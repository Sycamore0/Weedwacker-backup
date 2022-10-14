﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    [BsonKnownTypes(typeof(BattlePassTab), typeof(FoodTab),
    typeof(GadgetTab)  , typeof(PreciousTab),
    typeof(PromoteTab), typeof(QuestTab))]
    internal class MaterialsTab : InventoryTab
    {
        [BsonIgnore] public new const int InventoryLimit = 9999;
        public new Dictionary<int, MaterialItem> Items = new(); // ItemId

        public MaterialsTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;
            foreach (MaterialItem item in Items.Values)
            {
                item.Guid = Owner.GetNextGameGuid();
            }
        }

        internal override async Task<GameItem?> AddItemAsync(int itemId, int count = 1)
        {
            if (Items.TryGetValue(itemId, out MaterialItem material))
            {
                if (material.ItemData.stackLimit >= material.Count + count)
                {
                    material.Count += count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_MATERIAL}.MaterialsTab.Items.{itemId}.Count", material.Count);
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return material;
                }
                else return null;
            }
            else
            {
                var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                Items.Add(itemId, newMaterial);

                // Update Database
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_MATERIAL}.MaterialsTab.Items.{itemId}", newMaterial);
                var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                //TODO update codex
                return newMaterial;
            }
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue((item as MaterialItem).ItemId, out MaterialItem material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"SubInventories.{ItemType.ITEM_MATERIAL}.MaterialsTab.Items.{material.ItemId}.Count", material.Count);
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"SubInventories.{ItemType.ITEM_MATERIAL}.MaterialsTab.Items.{material.ItemId}");
                    var result = await DatabaseManager.UpdateInventoryAsync(filter, update);

                    Items.Remove(material.ItemId);
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
