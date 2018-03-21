using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;

using System.Diagnostics;

namespace NetzwerkLib
{
    public class Packet
    {
        void Con(string str)
        {
            Console.WriteLine("[PACKET] " + str);
        }

        uint size;
        public uint Size
        {
            get { return 4 + (uint)data.Length; }
        }

        uint Commando;

        public Commands Command {
            get { return (Commands)Commando; }
        }

        byte[] data;
        public byte[] Data
        {
            get { return data; }
        }

        public void SetCommand(Commands cmd)
        {
            Commando = (uint)cmd;
        }

        public byte[] Getdata()
        {
            return data;
        }

        public void Setdata(string ToSet)
        {
            data = ASCIIEncoding.ASCII.GetBytes(ToSet);
        }
        public void Setdata(byte[] ToSet)
        {
            data = ToSet;
        }

        public void Send(Socket socket)
        {
            byte[] sizeArray = BitConverter.GetBytes(Size);
            byte[] commandArray = BitConverter.GetBytes(Commando);

            byte[] ToSend = new byte[sizeArray.Length + commandArray.Length + data.Length];

            sizeArray.CopyTo(ToSend, 0);
            commandArray.CopyTo(ToSend, sizeArray.Length);
            data.CopyTo(ToSend, sizeArray.Length + commandArray.Length);

            socket.Send(ToSend);
        }

        public static Packet Receive(Socket socket, int Timeout)
        {
            byte[] sizeBuffer = new byte[4];
            int recBytes = 0;

            try
            {
                socket.ReceiveTimeout = Timeout;
                while ((recBytes += socket.Receive(sizeBuffer, recBytes, sizeBuffer.Length - recBytes, SocketFlags.None)) != 4)
                {

                }

                Packet newPacket = new Packet();
                uint newSize = BitConverter.ToUInt32(sizeBuffer, 0);
                byte[] buffer = new byte[newSize];
                recBytes = 0;

                while ((recBytes += socket.Receive(buffer, recBytes, buffer.Length - recBytes, SocketFlags.None)) < newSize)
                {

                }

                newPacket.Commando = BitConverter.ToUInt32(buffer, 0);

                byte[] tempbuffer = new byte[buffer.Length - 4];
                for (int i = 4; i < buffer.Length; i++)
                {
                    tempbuffer[i - 4] = buffer[i];
                }
                newPacket.data = tempbuffer;

                newPacket.Con("Receive() "+ASCIIEncoding.ASCII.GetString(newPacket.data));

                return newPacket;
            }
            catch(Exception e)
            {
                Packet p = new Packet();
                p.Con("Receive() " + "[Keine Daten]");
                p.SetCommand(Commands.None);
                return p;
            }
        }
    }
}
