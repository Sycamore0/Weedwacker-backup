using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketScenePointUnlockNotify: BasePacket
    {
        public PacketScenePointUnlockNotify(int sceneId, int pointId) : base(Enums.OpCode.ScenePointUnlockNotify)
        {
            ScenePointUnlockNotify p = new()
            {
                SceneId = (uint)sceneId,
            };
            p.PointList.Add((uint)pointId);
            Data = p.ToByteArray();
        }
    }
}
