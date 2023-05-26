namespace SimpleExample
{
    partial class GroundStation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroundStation));
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxLogPacket = new System.Windows.Forms.ComboBox();
            this.buttonLogPacket = new System.Windows.Forms.Button();
            this.labelInstruData = new System.Windows.Forms.Label();
            this.labelInstruTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.mavlinkheartbeattBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControlData = new System.Windows.Forms.Label();
            this.labelControlTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.BackColor = System.Drawing.Color.White;
            this.comboBoxSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxSerialPort.IntegralHeight = false;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(12, 163);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(55, 21);
            this.comboBoxSerialPort.TabIndex = 0;
            this.comboBoxSerialPort.Click += new System.EventHandler(this.comboBoxSerialPort_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(77, 163);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(55, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Coral;
            this.buttonConnect.Location = new System.Drawing.Point(148, 163);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(85, 32);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxLogPacket
            // 
            this.comboBoxLogPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLogPacket.FormattingEnabled = true;
            this.comboBoxLogPacket.Items.AddRange(new object[] {
            "heartbeat"});
            this.comboBoxLogPacket.Location = new System.Drawing.Point(12, 203);
            this.comboBoxLogPacket.Name = "comboBoxLogPacket";
            this.comboBoxLogPacket.Size = new System.Drawing.Size(120, 21);
            this.comboBoxLogPacket.TabIndex = 5;
            // 
            // buttonLogPacket
            // 
            this.buttonLogPacket.FlatAppearance.BorderSize = 0;
            this.buttonLogPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogPacket.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogPacket.ForeColor = System.Drawing.Color.Coral;
            this.buttonLogPacket.Location = new System.Drawing.Point(148, 201);
            this.buttonLogPacket.Name = "buttonLogPacket";
            this.buttonLogPacket.Size = new System.Drawing.Size(85, 34);
            this.buttonLogPacket.TabIndex = 6;
            this.buttonLogPacket.Text = "Log Packet";
            this.buttonLogPacket.UseVisualStyleBackColor = true;
            this.buttonLogPacket.Click += new System.EventHandler(this.buttonLogPacket_Click);
            // 
            // labelInstruData
            // 
            this.labelInstruData.AutoSize = true;
            this.labelInstruData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruData.ForeColor = System.Drawing.Color.Coral;
            this.labelInstruData.Location = new System.Drawing.Point(286, 105);
            this.labelInstruData.Name = "labelInstruData";
            this.labelInstruData.Size = new System.Drawing.Size(79, 25);
            this.labelInstruData.TabIndex = 7;
            this.labelInstruData.Text = "Dados";
            this.labelInstruData.Click += new System.EventHandler(this.labelInt_Click);
            // 
            // labelInstruTitle
            // 
            this.labelInstruTitle.AutoSize = true;
            this.labelInstruTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelInstruTitle.Location = new System.Drawing.Point(285, 51);
            this.labelInstruTitle.Name = "labelInstruTitle";
            this.labelInstruTitle.Size = new System.Drawing.Size(223, 32);
            this.labelInstruTitle.TabIndex = 8;
            this.labelInstruTitle.Text = "Instrumentação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelNav);
            this.panel1.Controls.Add(this.comboBoxSerialPort);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxBaudRate);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.comboBoxLogPacket);
            this.panel1.Controls.Add(this.buttonLogPacket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 529);
            this.panel1.TabIndex = 9;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(3, 479);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 50);
            this.panelNav.TabIndex = 9;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Coral;
            this.buttonSettings.Image = global::SimpleExample.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(0, 474);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(255, 55);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.Leave += new System.EventHandler(this.buttonSettings_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 138);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackgroundImage = global::SimpleExample.Properties.Resources.Close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Location = new System.Drawing.Point(924, 24);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(47, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // mavlinkheartbeattBindingSource
            // 
            this.mavlinkheartbeattBindingSource.DataSource = typeof(Mavlink.mavlink_heartbeat_t);
            // 
            // labelControlData
            // 
            this.labelControlData.AutoSize = true;
            this.labelControlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlData.ForeColor = System.Drawing.Color.Coral;
            this.labelControlData.Location = new System.Drawing.Point(286, 356);
            this.labelControlData.Name = "labelControlData";
            this.labelControlData.Size = new System.Drawing.Size(79, 25);
            this.labelControlData.TabIndex = 11;
            this.labelControlData.Text = "Dados";
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.AutoSize = true;
            this.labelControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelControlTitle.Location = new System.Drawing.Point(285, 302);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(130, 32);
            this.labelControlTitle.TabIndex = 12;
            this.labelControlTitle.Text = "Controle";
            // 
            // GroundStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(983, 529);
            this.Controls.Add(this.labelControlData);
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInstruData);
            this.Controls.Add(this.labelInstruTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroundStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatStation";
            this.Load += new System.EventHandler(this.GroundStation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxLogPacket;
        private System.Windows.Forms.BindingSource mavlinkheartbeattBindingSource;
        private System.Windows.Forms.Button buttonLogPacket;
        private System.Windows.Forms.Label labelInstruData;
        private System.Windows.Forms.Label labelInstruTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelControlData;
        private System.Windows.Forms.Label labelControlTitle;
    }
}

