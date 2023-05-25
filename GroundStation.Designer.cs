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
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.but_armdisarm = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.but_mission = new System.Windows.Forms.Button();
            this.comboBoxLogPacket = new System.Windows.Forms.ComboBox();
            this.buttonLogPacket = new System.Windows.Forms.Button();
            this.mavlinkheartbeattBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelInt = new System.Windows.Forms.Label();
            this.labelIntName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(13, 13);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerialPort.TabIndex = 0;
            this.comboBoxSerialPort.Click += new System.EventHandler(this.comboBoxSerialPort_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(140, 12);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(268, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // but_armdisarm
            // 
            this.but_armdisarm.Location = new System.Drawing.Point(452, 12);
            this.but_armdisarm.Name = "but_armdisarm";
            this.but_armdisarm.Size = new System.Drawing.Size(75, 23);
            this.but_armdisarm.TabIndex = 3;
            this.but_armdisarm.Text = "Arm/Disarm";
            this.but_armdisarm.UseVisualStyleBackColor = true;
            this.but_armdisarm.Click += new System.EventHandler(this.but_armdisarm_Click);
            // 
            // but_mission
            // 
            this.but_mission.Location = new System.Drawing.Point(349, 12);
            this.but_mission.Name = "but_mission";
            this.but_mission.Size = new System.Drawing.Size(97, 23);
            this.but_mission.TabIndex = 4;
            this.but_mission.Text = "Send Mission";
            this.but_mission.UseVisualStyleBackColor = true;
            this.but_mission.Click += new System.EventHandler(this.but_mission_Click);
            // 
            // comboBoxLogPacket
            // 
            this.comboBoxLogPacket.FormattingEnabled = true;
            this.comboBoxLogPacket.Items.AddRange(new object[] {
            "heartbeat"});
            this.comboBoxLogPacket.Location = new System.Drawing.Point(13, 57);
            this.comboBoxLogPacket.Name = "comboBoxLogPacket";
            this.comboBoxLogPacket.Size = new System.Drawing.Size(248, 21);
            this.comboBoxLogPacket.TabIndex = 5;
            // 
            // buttonLogPacket
            // 
            this.buttonLogPacket.Location = new System.Drawing.Point(268, 57);
            this.buttonLogPacket.Name = "buttonLogPacket";
            this.buttonLogPacket.Size = new System.Drawing.Size(75, 23);
            this.buttonLogPacket.TabIndex = 6;
            this.buttonLogPacket.Text = "Log Packet";
            this.buttonLogPacket.UseVisualStyleBackColor = true;
            this.buttonLogPacket.Click += new System.EventHandler(this.buttonLogPacket_Click);
            // 
            // mavlinkheartbeattBindingSource
            // 
            this.mavlinkheartbeattBindingSource.DataSource = typeof(Mavlink.mavlink_heartbeat_t);
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(357, 85);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(79, 13);
            this.labelInt.TabIndex = 7;
            this.labelInt.Text = "Received int: []";
            // 
            // labelIntName
            // 
            this.labelIntName.AutoSize = true;
            this.labelIntName.Location = new System.Drawing.Point(357, 60);
            this.labelIntName.Name = "labelIntName";
            this.labelIntName.Size = new System.Drawing.Size(49, 13);
            this.labelIntName.TabIndex = 8;
            this.labelIntName.Text = "Param: []";
            // 
            // GroundStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 123);
            this.Controls.Add(this.labelIntName);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.buttonLogPacket);
            this.Controls.Add(this.comboBoxLogPacket);
            this.Controls.Add(this.but_mission);
            this.Controls.Add(this.but_armdisarm);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Name = "GroundStation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GroundStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button but_armdisarm;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button but_mission;
        private System.Windows.Forms.ComboBox comboBoxLogPacket;
        private System.Windows.Forms.BindingSource mavlinkheartbeattBindingSource;
        private System.Windows.Forms.Button buttonLogPacket;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelIntName;
    }
}

