using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class RogueLikeGadgetEntity : ScriptGadgetEntity
    {
        protected RogueLikeGadgetEntity(Scene? scene, uint gadgetId, uint blockId, uint groupId, uint configId) : base(scene, gadgetId, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            RoguelikeGadgetInfo roguelike = new()
            {
                //CellConfigId =,
                //CellId =,
                //CellState =,
                //CellType =
            };

            info.Gadget.RoguelikeGadgetInfo = roguelike;

            return info;
        }
    }
}
