using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class EchoShellEntity : ScriptGadgetEntity
    {
        protected EchoShellEntity(Scene? scene, uint gadgetId, uint blockId, uint groupId, uint configId) : base(scene, gadgetId, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            EchoShellInfo shellInfo = new()
            {
                //ShellId =
            };

            info.Gadget.ShellInfo = shellInfo;

            return info;
        }
    }
}
