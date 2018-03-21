namespace ChatProjekt
{
    partial class ServerF
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_action = new System.Windows.Forms.Button();
            this.tb_chat = new System.Windows.Forms.RichTextBox();
            this.label_sv_status = new System.Windows.Forms.Label();
            this.tb_write = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_db_database = new System.Windows.Forms.TextBox();
            this.label_db_status = new System.Windows.Forms.Label();
            this.tb_db_userid = new System.Windows.Forms.TextBox();
            this.tb_db_host = new System.Windows.Forms.TextBox();
            this.tb_db_password = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_sv_range = new System.Windows.Forms.NumericUpDown();
            this.nud_sv_port = new System.Windows.Forms.NumericUpDown();
            this.nud_sv_max_clients = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sv_ip = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_max_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.Color.Red;
            this.btn_action.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_action.Location = new System.Drawing.Point(6, 58);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(286, 33);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "ACTION";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // tb_chat
            // 
            this.tb_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_chat.BackColor = System.Drawing.Color.LightGray;
            this.tb_chat.Location = new System.Drawing.Point(12, 132);
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.ReadOnly = true;
            this.tb_chat.Size = new System.Drawing.Size(560, 388);
            this.tb_chat.TabIndex = 2;
            this.tb_chat.Text = "";
            // 
            // label_sv_status
            // 
            this.label_sv_status.AutoSize = true;
            this.label_sv_status.Location = new System.Drawing.Point(6, 94);
            this.label_sv_status.Name = "label_sv_status";
            this.label_sv_status.Size = new System.Drawing.Size(67, 13);
            this.label_sv_status.TabIndex = 3;
            this.label_sv_status.Text = "STATUS SV";
            // 
            // tb_write
            // 
            this.tb_write.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_write.Location = new System.Drawing.Point(13, 526);
            this.tb_write.Multiline = false;
            this.tb_write.Name = "tb_write";
            this.tb_write.Size = new System.Drawing.Size(478, 23);
            this.tb_write.TabIndex = 4;
            this.tb_write.Text = "";
            this.tb_write.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_write_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Location = new System.Drawing.Point(497, 526);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "SENDEN";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_send_KeyDown);
            // 
            // timer
            // 
            this.timer.Interval = 4000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(6, 16);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(17, 13);
            this.label_ip.TabIndex = 7;
            this.label_ip.Text = "IP";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(114, 16);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(26, 13);
            this.label_port.TabIndex = 8;
            this.label_port.Text = "Port";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datenbank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Benutzername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Passwort";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.tb_db_database);
            this.groupBox1.Controls.Add(this.label_db_status);
            this.groupBox1.Controls.Add(this.tb_db_userid);
            this.groupBox1.Controls.Add(this.tb_db_host);
            this.groupBox1.Controls.Add(this.tb_db_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(298, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MYSQL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Port";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // tb_db_database
            // 
            this.tb_db_database.Location = new System.Drawing.Point(143, 33);
            this.tb_db_database.Name = "tb_db_database";
            this.tb_db_database.Size = new System.Drawing.Size(109, 20);
            this.tb_db_database.TabIndex = 25;
            this.tb_db_database.Text = "vsy_servers";
            // 
            // label_db_status
            // 
            this.label_db_status.AutoSize = true;
            this.label_db_status.Location = new System.Drawing.Point(6, 94);
            this.label_db_status.Name = "label_db_status";
            this.label_db_status.Size = new System.Drawing.Size(68, 13);
            this.label_db_status.TabIndex = 24;
            this.label_db_status.Text = "STATUS DB";
            // 
            // tb_db_userid
            // 
            this.tb_db_userid.Location = new System.Drawing.Point(6, 71);
            this.tb_db_userid.Name = "tb_db_userid";
            this.tb_db_userid.Size = new System.Drawing.Size(123, 20);
            this.tb_db_userid.TabIndex = 22;
            this.tb_db_userid.Text = "root";
            // 
            // tb_db_host
            // 
            this.tb_db_host.Location = new System.Drawing.Point(6, 32);
            this.tb_db_host.Name = "tb_db_host";
            this.tb_db_host.Size = new System.Drawing.Size(75, 20);
            this.tb_db_host.TabIndex = 20;
            this.tb_db_host.Text = "localhost";
            // 
            // tb_db_password
            // 
            this.tb_db_password.Location = new System.Drawing.Point(135, 71);
            this.tb_db_password.Name = "tb_db_password";
            this.tb_db_password.PasswordChar = '*';
            this.tb_db_password.Size = new System.Drawing.Size(117, 20);
            this.tb_db_password.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nud_sv_range);
            this.groupBox2.Controls.Add(this.nud_sv_port);
            this.groupBox2.Controls.Add(this.nud_sv_max_clients);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_sv_ip);
            this.groupBox2.Controls.Add(this.label_sv_status);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label_ip);
            this.groupBox2.Controls.Add(this.label_port);
            this.groupBox2.Controls.Add(this.btn_action);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 114);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Range";
            // 
            // nud_sv_range
            // 
            this.nud_sv_range.Location = new System.Drawing.Point(174, 32);
            this.nud_sv_range.Name = "nud_sv_range";
            this.nud_sv_range.Size = new System.Drawing.Size(48, 20);
            this.nud_sv_range.TabIndex = 24;
            this.nud_sv_range.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_sv_port
            // 
            this.nud_sv_port.Location = new System.Drawing.Point(117, 32);
            this.nud_sv_port.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_sv_port.Name = "nud_sv_port";
            this.nud_sv_port.Size = new System.Drawing.Size(51, 20);
            this.nud_sv_port.TabIndex = 23;
            this.nud_sv_port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nud_sv_max_clients
            // 
            this.nud_sv_max_clients.Location = new System.Drawing.Point(228, 32);
            this.nud_sv_max_clients.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_sv_max_clients.Name = "nud_sv_max_clients";
            this.nud_sv_max_clients.Size = new System.Drawing.Size(64, 20);
            this.nud_sv_max_clients.TabIndex = 22;
            this.nud_sv_max_clients.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max Clients";
            // 
            // tb_sv_ip
            // 
            this.tb_sv_ip.Location = new System.Drawing.Point(6, 32);
            this.tb_sv_ip.Name = "tb_sv_ip";
            this.tb_sv_ip.Size = new System.Drawing.Size(104, 20);
            this.tb_sv_ip.TabIndex = 20;
            this.tb_sv_ip.Text = "127.0.0.1";
            // 
            // ServerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_write);
            this.Controls.Add(this.tb_chat);
            this.Name = "ServerF";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ServerF_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sv_max_clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Label label_sv_status;
        private System.Windows.Forms.RichTextBox tb_write;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_db_password;
        private System.Windows.Forms.TextBox tb_db_userid;
        private System.Windows.Forms.TextBox tb_db_host;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sv_ip;
        private System.Windows.Forms.NumericUpDown nud_sv_port;
        private System.Windows.Forms.NumericUpDown nud_sv_max_clients;
        private System.Windows.Forms.Label label_db_status;
        private System.Windows.Forms.TextBox tb_db_database;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_sv_range;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.RichTextBox tb_chat;
    }
}

