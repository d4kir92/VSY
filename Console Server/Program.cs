using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;

using NetzwerkLib;

namespace Console_Server
{
    class Program
    {
        void con(string str)
        {
            Console.WriteLine("[SERVER] " + str);
        }

        static void Main(string[] args)
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            Server server = new Server(ipe);

            server.Start(5);
            server.AcceptSocket();

            Packet p = new Packet();
            p.SetCommand(Commands.SendMsg);
            p.Setdata("Willkommen im Chat!");

            server.Send("Unbenannt", p);

            Console.Read();
        }

        public static void ActionBytesArray(byte[] Data)
        {
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(Data));
        }
    }
}
