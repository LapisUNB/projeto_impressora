namespace Braille_APP
{
    partial class Tradução_Braille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtTradu = new System.Windows.Forms.TextBox();
            this.gpbConnection = new System.Windows.Forms.GroupBox();
            this.cbbHandshake = new System.Windows.Forms.ComboBox();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblHandShake = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.cbbDataSize = new System.Windows.Forms.ComboBox();
            this.cbbComPorts = new System.Windows.Forms.ComboBox();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(641, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTradu
            // 
            this.txtTradu.AcceptsReturn = true;
            this.txtTradu.AcceptsTab = true;
            this.txtTradu.AllowDrop = true;
            this.txtTradu.Enabled = true;
            this.txtTradu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTradu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTradu.Location = new System.Drawing.Point(14, 19);
            this.txtTradu.Multiline = true;
            this.txtTradu.Name = "txtTradu";
            this.txtTradu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTradu.Size = new System.Drawing.Size(751, 206);
            this.txtTradu.TabIndex = 0;
            // 
            // gpbConnection
            // 
            this.gpbConnection.Controls.Add(this.cbbHandshake);
            this.gpbConnection.Controls.Add(this.cbbMode);
            this.gpbConnection.Controls.Add(this.btnDisconnect);
            this.gpbConnection.Controls.Add(this.lblMode);
            this.gpbConnection.Controls.Add(this.btnConnect);
            this.gpbConnection.Controls.Add(this.lblHandShake);
            this.gpbConnection.Controls.Add(this.cbbBaudRate);
            this.gpbConnection.Controls.Add(this.cbbParity);
            this.gpbConnection.Controls.Add(this.lblBaudRate);
            this.gpbConnection.Controls.Add(this.lblParity);
            this.gpbConnection.Controls.Add(this.lblCom);
            this.gpbConnection.Controls.Add(this.cbbDataSize);
            this.gpbConnection.Controls.Add(this.cbbComPorts);
            this.gpbConnection.Controls.Add(this.lblDataSize);
            this.gpbConnection.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gpbConnection.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gpbConnection.Location = new System.Drawing.Point(12, 12);
            this.gpbConnection.Name = "gpbConnection";
            this.gpbConnection.Padding = new System.Windows.Forms.Padding(12);
            this.gpbConnection.Size = new System.Drawing.Size(777, 92);
            this.gpbConnection.TabIndex = 4;
            this.gpbConnection.TabStop = false;
            this.gpbConnection.Text = "Conexão";
            // 
            // cbbHandshake
            // 
            this.cbbHandshake.BackColor = System.Drawing.SystemColors.Info;
            this.cbbHandshake.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbbHandshake.FormattingEnabled = true;
            this.cbbHandshake.Location = new System.Drawing.Point(337, 26);
            this.cbbHandshake.Name = "cbbHandshake";
            this.cbbHandshake.Size = new System.Drawing.Size(72, 21);
            this.cbbHandshake.TabIndex = 24;
            // 
            // cbbMode
            // 
            this.cbbMode.BackColor = System.Drawing.SystemColors.Info;
            this.cbbMode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Location = new System.Drawing.Point(337, 55);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(72, 21);
            this.cbbMode.TabIndex = 23;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDisconnect.Location = new System.Drawing.Point(643, 53);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(122, 31);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMode.Location = new System.Drawing.Point(266, 58);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(40, 13);
            this.lblMode.TabIndex = 22;
            this.lblMode.Text = "Mode:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnConnect.Location = new System.Drawing.Point(643, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 32);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Location = new System.Drawing.Point(266, 29);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(68, 13);
            this.lblHandShake.TabIndex = 21;
            this.lblHandShake.Text = "Handshake:";
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.BackColor = System.Drawing.SystemColors.Info;
            this.cbbBaudRate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(49, 55);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(72, 21);
            this.cbbBaudRate.TabIndex = 6;
            // 
            // cbbParity
            // 
            this.cbbParity.BackColor = System.Drawing.SystemColors.Info;
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Location = new System.Drawing.Point(188, 59);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(72, 21);
            this.cbbParity.TabIndex = 20;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(11, 58);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(37, 13);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud:";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(129, 58);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(38, 13);
            this.lblParity.TabIndex = 19;
            this.lblParity.Text = "Parity:";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(11, 29);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(36, 13);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "COM:";
            // 
            // cbbDataSize
            // 
            this.cbbDataSize.BackColor = System.Drawing.SystemColors.Info;
            this.cbbDataSize.FormattingEnabled = true;
            this.cbbDataSize.Location = new System.Drawing.Point(188, 26);
            this.cbbDataSize.Name = "cbbDataSize";
            this.cbbDataSize.Size = new System.Drawing.Size(72, 21);
            this.cbbDataSize.TabIndex = 18;
            // 
            // cbbComPorts
            // 
            this.cbbComPorts.BackColor = System.Drawing.SystemColors.Info;
            this.cbbComPorts.FormattingEnabled = true;
            this.cbbComPorts.Location = new System.Drawing.Point(49, 26);
            this.cbbComPorts.Name = "cbbComPorts";
            this.cbbComPorts.Size = new System.Drawing.Size(72, 21);
            this.cbbComPorts.TabIndex = 0;
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(129, 29);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(57, 13);
            this.lblDataSize.TabIndex = 17;
            this.lblDataSize.Text = "Data Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTradu);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tradução";
            // 
            // Tradução_Braille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbConnection);
            this.Name = "Tradução_Braille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tradução Braille";
            this.Load += new System.EventHandler(this.Tradução_Braille_Load);
            this.gpbConnection.ResumeLayout(false);
            this.gpbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTradu;
        private System.Windows.Forms.GroupBox gpbConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ComboBox cbbComPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbHandshake;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblHandShake;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbbDataSize;
        private System.Windows.Forms.Label lblDataSize;
    }
}