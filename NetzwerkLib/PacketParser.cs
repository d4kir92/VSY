using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetzwerkLib
{
    public class PacketParser
    {
        List<Commands> AcceptedCommands = new List<Commands>();
        Dictionary<Commands, List<Action<byte[]>>> RegisteredCommands = new Dictionary<Commands, List<Action<byte[]>>>();

        public void ParsePacket(Packet packet)
        {
            for (int i = 0; i < AcceptedCommands.Count; i++)
            {
                if (packet.Command == AcceptedCommands[i])
                {
                    if (RegisteredCommands.ContainsKey(packet.Command))
                    {
                        for (int y = 0; y < RegisteredCommands[packet.Command].Count; y++)
                        {
                            RegisteredCommands[packet.Command][y](packet.Data);
                        }
                    }
                }
            }
        }

        public void SetAcceptedCommands(List<Commands> List)
        {
            AcceptedCommands = List;
        }

        public void RegisterForCommand(Commands cmd, Action<byte[]> FuncPointer)
        {
            if (!RegisteredCommands.ContainsKey(cmd))
                RegisteredCommands.Add(cmd, new List<Action<byte[]>>());
            RegisteredCommands[cmd].Add(FuncPointer);
        }

        public void UnRegisterForCommand(Commands cmd, Action<byte[]> FuncPointer)
        {
            if (RegisteredCommands.ContainsKey(cmd))
                RegisteredCommands[cmd].Remove(FuncPointer);
        }
    }
}
