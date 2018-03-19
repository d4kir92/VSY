namespace ClientForm
{
    partial class ClientF
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
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_write = new System.Windows.Forms.RichTextBox();
            this.tb_ip = new System.Windows.Forms.RichTextBox();
            this.tb_port = new System.Windows.Forms.RichTextBox();
            this.tb_name = new System.Windows.Forms.RichTextBox();
            this.tb_chat = new System.Windows.Forms.RichTextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(390, 25);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(120, 23);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "ACTION";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(497, 526);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "SENDEN";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_write
            // 
            this.tb_write.Location = new System.Drawing.Point(12, 526);
            this.tb_write.Multiline = false;
            this.tb_write.Name = "tb_write";
            this.tb_write.Size = new System.Drawing.Size(479, 23);
            this.tb_write.TabIndex = 2;
            this.tb_write.Text = "";
            this.tb_write.TextChanged += new System.EventHandler(this.tb_write_TextChanged);
            this.tb_write.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_write_KeyDown);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(12, 25);
            this.tb_ip.Multiline = false;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(120, 23);
            this.tb_ip.TabIndex = 3;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(138, 25);
            this.tb_port.Multiline = false;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(120, 23);
            this.tb_port.TabIndex = 4;
            this.tb_port.Text = "1234";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(264, 25);
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(120, 23);
            this.tb_name.TabIndex = 5;
            this.tb_name.Text = "Unbenannt";
            // 
            // tb_chat
            // 
            this.tb_chat.BackColor = System.Drawing.Color.Gray;
            this.tb_chat.Location = new System.Drawing.Point(12, 67);
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.Size = new System.Drawing.Size(560, 453);
            this.tb_chat.TabIndex = 6;
            this.tb_chat.Text = "";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 51);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(50, 13);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "STATUS";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(12, 9);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(17, 13);
            this.label_ip.TabIndex = 8;
            this.label_ip.Text = "IP";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(138, 9);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(37, 13);
            this.label_port.TabIndex = 9;
            this.label_port.Text = "PORT";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(264, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            // 
            // ClientF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.tb_chat);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.tb_write);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_action);
            this.Name = "ClientF";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox tb_write;
        private System.Windows.Forms.RichTextBox tb_ip;
        private System.Windows.Forms.RichTextBox tb_port;
        private System.Windows.Forms.RichTextBox tb_name;
        private System.Windows.Forms.RichTextBox tb_chat;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_name;
    }
}

