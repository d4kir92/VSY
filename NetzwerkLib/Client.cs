using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NetzwerkLib
{
    public class Client
    {
        private int timeOut;
        public int TimeOut
        {
            get { return timeOut; }
            set
            {
                if (value > 0)
                {
                    timeOut = value;
                }
            }
        }
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        PacketParser pParser = new PacketParser();

        public Client()
        {
            pParser.SetAcceptedCommands(new List<Commands>() { Commands.SendMsg, Commands.SendPMsg, Commands.GetName, Commands.Disconnect });
            TimeOut = 15;
        }
        public void Reset()
        {
            sock.Close();
            sock.Dispose();

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(IPEndPoint Endpoint)
        {
            sock.Connect(Endpoint);
        }
        public void Disconnect(bool reuse)
        {
            sock.Disconnect(reuse);
        }

        public void Send(Packet packet)
        {
            packet.Send(sock);
        }
        public Packet Receive()
        {
            return Packet.Receive(sock, TimeOut);
        }

        public void ParsePacket(Packet packet)
        {
            pParser.ParsePacket(packet);
        }
        public void RegisterForCommand(Commands cmd, Action<byte[]> FuncPointer)
        {
            pParser.RegisterForCommand(cmd, FuncPointer);
        }
        public void UnRegisterForCommand(Commands cmd, Action<byte[]> FuncPointer)
        {
            pParser.UnRegisterForCommand(cmd, FuncPointer);
        }
    }
}
