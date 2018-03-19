using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;

using NetzwerkLib;

namespace Console_Client
{
    class Program
    {
        void con(string str)
        {
            Console.WriteLine("[CLIENT] " + str);
        }

        static void Main(string[] args)
        {
            Client newClient = new Client();

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            newClient.Connect(ipe);

            Packet antwort = newClient.Receive();
            if(antwort.Command == Commands.GetName)
            {
                Console.WriteLine("[CLIENT] " + "Anfrage auf Name");
                string name = "Arno";

                Packet nP = new Packet();
                nP.SetCommand(Commands.SetName);
                nP.Setdata(name);

                newClient.Send(nP);
            }
            
            Console.Read();
        }
    }
}
