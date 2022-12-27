using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.GameServer.Enums;
using Google.Protobuf;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWeaponPromoteRsp : BasePacket
    {
        public PacketWeaponPromoteRsp(WeaponItem item, int oldPromoteLevel) : base(OpCode.WeaponPromoteRsp)
        {
            WeaponPromoteRsp proto = new()
            {
                TargetWeaponGuid = item.Guid,
                OldPromoteLevel = (uint)oldPromoteLevel,
                CurPromoteLevel = (uint)item.PromoteLevel
            };
            Data = proto.ToByteArray();
        }

    }

}
