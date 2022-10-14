﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class WeaponTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        [BsonElement] private int NextWeaponId = 1; // Is it possible to collect this many items? O.o
        public new Dictionary<int, WeaponItem> Items = new(); // Mongodb unique (for the player) id
        public Dictionary<int, MaterialItem> UpgradeMaterials = new(); // id

        public WeaponTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (WeaponItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
                if (item.EquippedAvatar != 0) await inventory.EquipWeapon(owner.Avatars.Avatars[item.EquippedAvatar].Guid, item.Guid);
            }
            foreach (MaterialItem item in UpgradeMaterials.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
            }
        }

        internal override async Task<GameItem> AddItemAsync(int itemId, int count = 1)
        {

            if (GameData.ItemDataMap[itemId].itemType == ItemType.ITEM_MATERIAL)
            {
                if (UpgradeMaterials.TryGetValue(itemId, out MaterialItem material))
                {
                    if (material.ItemData.stackLimit >= material.Count + count)
                    {
                        material.Count += count;

                        // Update Database
                        var filter1 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                        var update1 = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_WEAPON}.UpgradeMaterials.{itemId}.Count", material.Count);
                        var result1 = await DatabaseManager.UpdateInventoryAsync(filter1, update1);

                        //TODO update codex
                        return material;
                    }
                    else return null;
                }
                else
                {
                    var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                    UpgradeMaterials.Add(itemId, newMaterial);

                    // Update Database
                    var filter2 = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update2 = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_WEAPON}.UpgradeMaterials.{itemId}", newMaterial);
                    var result2 = await DatabaseManager.UpdateInventoryAsync(filter2, update2);

                    //TODO update codex
                    return newMaterial;
                }
            }
                
            if (Items.Count == InventoryLimit)
            {
                return null;
            }

            var weapon = new WeaponItem(Owner.GetNextGameGuid(), itemId, NextWeaponId++);
            Items.Add(weapon.UniqueId, weapon);

            // Update Database
            var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_WEAPON}.Items.{weapon.UniqueId}", weapon);
            var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

            //TODO update codex
            return weapon;
        }


        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as WeaponItem).UniqueId, out WeaponItem weapon))
            {
                if (weapon.EquippedAvatar != 0)
                {
                    await Owner.Avatars.Avatars[weapon.EquippedAvatar].UnequipWeapon();
                }

                // Update Database
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_WEAPON}.Items.{weapon.UniqueId}");
                var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                Items.Remove(weapon.UniqueId);
                return true;
            }
            else if(UpgradeMaterials.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_WEAPON}.UpgradeMaterials.{material.ItemId}.Count", material.Count);
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_WEAPON}.UpgradeMaterials.{material.ItemId}.Count");
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    UpgradeMaterials.Remove(material.ItemId);
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
    }
}
