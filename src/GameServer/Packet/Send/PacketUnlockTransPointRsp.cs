using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketUnlockTransPointRsp:BasePacket
    {
        public PacketUnlockTransPointRsp(Retcode retcode):base(Enums.OpCode.UnlockTransPointRsp)
        {
            UnlockTransPointRsp ret = new UnlockTransPointRsp() 
            { 
                Retcode = (int)retcode,
            };
            Data = ret.ToByteArray();
        }
    }
}
