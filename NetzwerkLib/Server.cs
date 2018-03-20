using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NetzwerkLib
{
    public class Server
    {
        Thread ListenThread;
        bool is_running = false;

        void Con(string str)
        {
            Console.WriteLine("[SERVER] " + str);
        }

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

        int MaxClients;

        // Socket: Listen
        Socket ListenSocket;

        PacketParser pParser = new PacketParser();

        // Dictionary mit allen verbundenen Sockets
        Dictionary<string,Socket> ConnectedSockets = new Dictionary<string, Socket>();
        public string[] ConnectedSocketsNames
        {
            get { return ConnectedSockets.Keys.ToArray<string>(); }
        }

        // IPEndpoint
        IPEndPoint localEndpoint;
        
        // Constructor
        public Server(IPEndPoint Endpoint)
        {
            localEndpoint = Endpoint;
            ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            pParser.SetAcceptedCommands(new List<Commands>() { Commands.SendMsg, Commands.SendPMsg, Commands.SetName, Commands.Disconnect});
            TimeOut = 15;
        }
        public void Start(int MaxClients, IPEndPoint Endpoint = null)
        {
            try
            {
                if (!(Endpoint == null))
                    localEndpoint = Endpoint;

                ListenSocket.Bind(localEndpoint);

                ListenSocket.Listen(MaxClients);
                this.MaxClients = MaxClients;

                ThreadStart start = new ThreadStart(AcceptSocket);

                ListenThread = new Thread(start);
                ListenThread.IsBackground = true;
                ListenThread.Start();
                is_running = true;
            }
            catch(Exception e)
            {
                if (e.GetHashCode() == 4094363) { 
                    Con("Start: Der Zugriff auf einen Socket war aufgrund der Zugriffsrechte des Sockets unzulässig (4094363)");
                }
                else if(e.GetHashCode() == 36849274)
                {
                    Con("Start: Der Zugriff auf einen Socket war aufgrund der Zugriffsrechte des Sockets unzulässig (36849274)");
                }
                else {
                    Con("Start: " + e);
                }
            }
        }
        public void Stop()
        {
            is_running = false;
            Socket[] Sockets = ConnectedSockets.Values.ToArray();
            ConnectedSockets.Clear();

            for (int i = 0; i < Sockets.Length; i++)
            {
                Sockets[i].Close();
                Sockets[i].Dispose();
            }
            Sockets = null;

            ListenSocket.Close();
            ListenSocket.Dispose();
            ListenSocket = null;
        }

        public void SendInfo( string str )
        {
            Con(str);

            Packet nP = new Packet();
            nP.SetCommand(Commands.SendMsg);
            nP.Setdata(str);

            SendToAll(nP);
        }

        public void AcceptSocket()
        {
            bool working = true;
            while (working)
            {
                while (ConnectedSockets.Count < MaxClients && working)
                {
                    try
                    {
                        Socket tempClientSocket = ListenSocket.Accept();

                        lock (this)
                        {
                            if (is_running)
                            {
                                Packet nP = new Packet();
                                nP.SetCommand(Commands.GetName);
                                nP.Setdata("");

                                nP.Send(tempClientSocket);

                                Packet ClientName = Packet.Receive(tempClientSocket, TimeOut);

                                string newClient = ASCIIEncoding.ASCII.GetString(ClientName.Data);
                                ConnectedSockets.Add(newClient, tempClientSocket);

                                SendInfo(newClient + " ist dem Chat beigetreten.");
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        Con("AcceptSocket(): " + e);
                        working = false;
                    }
                    Thread.Sleep(40);
                }
                Thread.Sleep(40);
            }
        }

        public void Send(string ClientName, Packet packet)
        {
            if (ConnectedSockets.ContainsKey(ClientName)) {
                packet.Send(ConnectedSockets[ClientName]);
            }
            else
                throw new Exception("Client nicht vorhanden");
        }
        public void SendToAll(Packet packet)
        {
            List<string> ClientNames = new List<string>(ConnectedSockets.Keys);
            foreach(string Client in ClientNames)
            {
                Send(Client, packet);
            }
        }
        public Packet Receive(string ClientName)
        {
            if (ConnectedSockets.ContainsKey(ClientName))
            {
                return Packet.Receive(ConnectedSockets[ClientName], TimeOut);
            }
            else
                throw new Exception("Client nicht vorhanden");
        }
        public Dictionary<string, Packet> ReceiveAll()
        {
            Dictionary<string, Packet> Packete = new Dictionary<string, Packet>();
            foreach(string SocketName in ConnectedSockets.Keys)
            {
                Packete.Add(SocketName, Receive(SocketName));
            }
            return Packete;
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
