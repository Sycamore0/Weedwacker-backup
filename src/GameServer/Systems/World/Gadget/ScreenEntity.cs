using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ScreenEntity : ScriptGadgetEntity
    {
        protected ScreenEntity(Scene? scene, uint gadgetId, uint blockId, uint groupId, uint configId) : base(scene, gadgetId, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            ScreenInfo screen = new()
            {
                //LiveId =,
                //ProjectorEntityId =,
            };

            info.Gadget.ScreenInfo = screen;

            return info;
        }
    }
}
