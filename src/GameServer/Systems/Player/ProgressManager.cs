using MongoDB.Bson.Serialization.Attributes;
using System;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ProgressManager
    {

        [BsonElement("_id")]
        [BsonId] public int OwnerId { get; private set; }
        private Player Owner;
        public Dictionary<OpenStateType, int> OpenStates = new(); // SET ONLY THROUGH THE OPENSTATEMANAGER
        public HashSet<int> UnlockedForgingBlueprints = new();
        public HashSet<int> UnlockedCombines = new();
        //public Dictionary<long, ExpeditionInfo> ExpeditionInfo;
        public Dictionary<int, int> UnlockedRecipies = new();
        //public List<ActiveForgeData> activeForges;
        [BsonElement] public Dictionary<int, int> QuestGlobalVariables = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedSceneAreas = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedScenePoints = new();

        public ProgressManager(Player owner)
        {
            Owner = owner;
            OwnerId = owner.GameUid;
        }

        public async Task OnPlayerCreate()
        {
            await Owner.OpenStateManager.OnPlayerCreate();
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
        }

        public async Task<bool> unlockTransPointAsync(int sceneId, int pointId, bool isStatue)
        {
            //// todo
            //// Check whether the unlocked point exists and whether it is still locked.
            //ScenePointData scenePointData = new ScenePointData();

            //if (scenePointData == null || Owner.UnlockedScenePoints.GetValueOrDefault(sceneId)?.Contains(pointId)==true)
            //{
            //    return false;
            //}

            //// Add the point to the list of unlocked points for its scene.
            UnlockedScenePoints.GetValueOrDefault(sceneId)?.Add(pointId);

            //// Give primogems  and Adventure EXP for unlocking.
            //await Owner.Inventory.AddItemByIdAsync(201, 5, ActionReason.UnlockPointReward);
            //await Owner.Inventory.AddItemByIdAsync(102, isStatue ? 50 : 10, ActionReason.UnlockPointReward);


            //// Fire quest trigger for trans point unlock.
            //Owner.QuestManager.TriggerEvent(QuestTrigger.QUEST_CONTENT_UNLOCK_TRANS_POINT, sceneId, pointId);

            // Send packet.
            await Owner.SendPacketAsync(new PacketScenePointUnlockNotify(sceneId, pointId));
            return true;
        }

    }
}
