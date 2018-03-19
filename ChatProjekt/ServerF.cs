using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using NetzwerkLib;

namespace ChatProjekt
{
    public partial class ServerF : Form
    {
        Server server;
        bool running = false;

        void con(string str)
        {
            Console.WriteLine("[SERVER] " + str);
        }

        public ServerF()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            label_status.Text = "Bereit";
            btn_action.Text = "Starten";
        }

        private void GetMsg(byte[] Data)
        {
            tb_chat.AppendText(Environment.NewLine + ASCIIEncoding.ASCII.GetString(Data));

            Packet p = new Packet();
            p.SetCommand(Commands.SendMsg);
            p.Setdata(Data);
            server.SendToAll(p);
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                running = !running;

                IPAddress ip = IPAddress.Parse(tb_ip.Text);
                int port = Int32.Parse(tb_port.Text);

                IPEndPoint ipe = new IPEndPoint(ip, port);
                server = new Server(ipe);
                server.RegisterForCommand(Commands.SendMsg, new Action<byte[]>(GetMsg));
                server.Start(5);

                timer.Enabled = true;
                label_status.Text = "Server ist am laufen.";
                btn_action.Text = "Stoppen";
            }
            else
            {
                running = !running;

                label_status.Text = "Am stoppen";
                btn_action.Text = "...";

                server.Stop();

                label_status.Text = "Bereit";
                btn_action.Text = "Starten";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Dictionary<string, Packet> Packets = server.ReceiveAll();

            foreach (string Client in server.ConnectedSocketsNames)
            {
                server.ParsePacket(Packets[Client]);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string text = tb_write.Text;

            Packet p = new Packet();
            p.SetCommand(Commands.SendMsg);
            p.Setdata("SERVER" + ": " + text);

            server.SendToAll(p);

            tb_chat.AppendText(Environment.NewLine + "SERVER: " + text);
            tb_write.Text = "";
        }

        private void btn_send_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ServerF_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tb_write_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send_Click(this, null);
            }
        }
    }
}
