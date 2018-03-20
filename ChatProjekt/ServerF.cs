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
using System.Threading;

namespace ChatProjekt
{
    public partial class ServerF : Form
    {
        Datenbank db;
        Server server;
        bool running = false;

        void Con(string str)
        {
            Console.WriteLine("[SERVER-FORM] " + str);
        }

        public ServerF()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            label_sv_status.Text = "Bereit";
            label_db_status.Text = "Bereit";
            btn_action.Text = "Starten";
        }

        private void GetMsg(byte[] Data)
        {
            string msg = ASCIIEncoding.ASCII.GetString(Data) + Environment.NewLine;
            Con(msg);
            tb_chat.AppendText(msg);

            Packet p = new Packet();
            p.SetCommand(Commands.SendMsg);
            p.Setdata(Data);
            server.SendToAll(p);
        }

        public bool is_reachable(IPAddress ip, int port)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint ipe = new IPEndPoint(ip, port);
                sock.Connect(ipe);
                sock.Dispose();
                sock.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                running = !running;

                // Verbindung zur Datenbank
                db = new Datenbank();

                string host = tb_db_host.Text;
                string datenbank = tb_db_database.Text;
                string userid = tb_db_userid.Text;
                string password = tb_db_password.Text;

                db.DB_Connect(host, datenbank, userid, password);

                // Gucken ob Server vorhanden sind
                db.DB_CREATE_DATABASE("test");
                
                // Server informationen
                IPAddress ip = IPAddress.Parse(tb_sv_ip.Text);
                int port = (int)nud_sv_port.Value;
                int mc = (int)nud_sv_max_clients.Value;

                //db.DB_CREATE_TABLE("vsy_servers", "uid int not null auto_increment primary key, IP TEXT, PORT INT");
                //db.DB_INSERT_INTO("vsy_servers", "IP, PORT", "'127.0.0.1', '1234'");
                /*Dictionary<int, string> servers = db.DB_Select("vsy_servers", "*", "");
                foreach(KeyValuePair<int, string> server in servers)
                {
                    Con(server.Value);
                }*/

                int range = (int)nud_sv_range.Value;
                int new_port = port;
                bool found = false;
                for (int new_p = port; new_p < port+range; new_p++)
                {
                    //Con("i: " + i + " Port: " + new_p);
                    DataTable result = db.DB_Select("vsy_servers", "*", "PORT = '" + new_p + "'");

                    if (result != null){
                        foreach (DataRow row in result.Rows)
                        {
                            for (int i = 0; i < row.ItemArray.Length; i++)
                            {
                                Con(row.ItemArray[i].ToString());   
                            }
                        }
                        Con("Server in Datenbank gefunden!");

                        if (is_reachable(ip, new_p))
                        {
                            Con("Server ist erreichbar.");
                        }
                        else
                        {
                            Con("Server ist nicht erreichbar.");
                            db.DB_DELETE_FROM("vsy_servers", "PORT = '"+new_p+"'");
                            if (!found)
                            {
                                found = true;
                                port = new_p;
                            }
                        }
                    }
                    else
                    {
                        if (!found)
                        {
                            found = true;
                            port = new_p;
                        }
                    }
                }
                nud_sv_port.Text = port.ToString();
                db.DB_INSERT_INTO("vsy_servers", "IP, PORT", "'" + ip + "', '" + port + "'");

                Con("Server wird gestartet(IP: "+ip+" Port: "+port+" MaxClients: "+mc+").");

                IPEndPoint ipe = new IPEndPoint(ip, port);
                server = new Server(ipe);
                server.RegisterForCommand(Commands.SendMsg, new Action<byte[]>(GetMsg));
                server.Start(mc);

                Con("Server wurde gestartet.");

                timer.Enabled = true;
                label_sv_status.Text = "Server ist am laufen.";
                btn_action.Text = "Stoppen";
            }
            else
            {
                running = !running;

                Con("Server wird gestoppt.");

                label_sv_status.Text = "Am stoppen";
                btn_action.Text = "...";

                server.Stop();
                Con("Server wurde gestoppt.");

                label_sv_status.Text = "Bereit";
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

            tb_chat.AppendText("SERVER: " + text + Environment.NewLine);
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

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
