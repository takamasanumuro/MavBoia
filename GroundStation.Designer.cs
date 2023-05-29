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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.labelTitleSelection = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDados = new System.Windows.Forms.Button();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.buttonConfigurações = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mavlinkheartbeattBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLateral.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialPort.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxSerialPort.IntegralHeight = false;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(12, 163);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(55, 21);
            this.comboBoxSerialPort.TabIndex = 0;
            this.comboBoxSerialPort.DropDownClosed += new System.EventHandler(this.comboBox_RemoveBlueHighlight_DropdownClosed);
            this.comboBoxSerialPort.Click += new System.EventHandler(this.comboBoxSerialPort_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(87, 163);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(55, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.DropDownClosed += new System.EventHandler(this.comboBox_RemoveBlueHighlight_DropdownClosed);
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
            this.buttonConnect.Text = "Abrir";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxLogPacket
            // 
            this.comboBoxLogPacket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxLogPacket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLogPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLogPacket.ForeColor = System.Drawing.Color.Coral;
            this.comboBoxLogPacket.FormattingEnabled = true;
            this.comboBoxLogPacket.Items.AddRange(new object[] {
            "heartbeat"});
            this.comboBoxLogPacket.Location = new System.Drawing.Point(12, 203);
            this.comboBoxLogPacket.Name = "comboBoxLogPacket";
            this.comboBoxLogPacket.Size = new System.Drawing.Size(130, 21);
            this.comboBoxLogPacket.TabIndex = 5;
            this.comboBoxLogPacket.DropDownClosed += new System.EventHandler(this.comboBox_RemoveBlueHighlight_DropdownClosed);
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
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLateral.Controls.Add(this.buttonDados);
            this.panelLateral.Controls.Add(this.buttonMapa);
            this.panelLateral.Controls.Add(this.panelNav);
            this.panelLateral.Controls.Add(this.comboBoxSerialPort);
            this.panelLateral.Controls.Add(this.buttonConfigurações);
            this.panelLateral.Controls.Add(this.panelTopLeft);
            this.panelLateral.Controls.Add(this.comboBoxBaudRate);
            this.panelLateral.Controls.Add(this.buttonConnect);
            this.panelLateral.Controls.Add(this.comboBoxLogPacket);
            this.panelLateral.Controls.Add(this.buttonLogPacket);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(255, 597);
            this.panelLateral.TabIndex = 9;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(3, 479);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 50);
            this.panelNav.TabIndex = 9;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.pictureBox2);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(255, 119);
            this.panelTopLeft.TabIndex = 7;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(255, 117);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(910, 480);
            this.panelFormLoader.TabIndex = 11;
            // 
            // labelTitleSelection
            // 
            this.labelTitleSelection.AutoSize = true;
            this.labelTitleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSelection.ForeColor = System.Drawing.Color.Coral;
            this.labelTitleSelection.Location = new System.Drawing.Point(270, 68);
            this.labelTitleSelection.Name = "labelTitleSelection";
            this.labelTitleSelection.Size = new System.Drawing.Size(101, 32);
            this.labelTitleSelection.TabIndex = 15;
            this.labelTitleSelection.Text = "Dados";
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
            this.buttonExit.Location = new System.Drawing.Point(1106, 24);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(47, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDados
            // 
            this.buttonDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDados.FlatAppearance.BorderSize = 0;
            this.buttonDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDados.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDados.ForeColor = System.Drawing.Color.Coral;
            this.buttonDados.Image = global::SimpleExample.Properties.Resources.diagram;
            this.buttonDados.Location = new System.Drawing.Point(0, 432);
            this.buttonDados.Name = "buttonDados";
            this.buttonDados.Size = new System.Drawing.Size(255, 55);
            this.buttonDados.TabIndex = 10;
            this.buttonDados.Text = "            Dados  ";
            this.buttonDados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDados.UseVisualStyleBackColor = true;
            this.buttonDados.Click += new System.EventHandler(this.buttonDados_Click);
            this.buttonDados.Leave += new System.EventHandler(this.button_Leave);
            // 
            // buttonMapa
            // 
            this.buttonMapa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMapa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMapa.FlatAppearance.BorderSize = 0;
            this.buttonMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapa.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMapa.ForeColor = System.Drawing.Color.Coral;
            this.buttonMapa.Image = global::SimpleExample.Properties.Resources.mapicon;
            this.buttonMapa.Location = new System.Drawing.Point(0, 487);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(255, 55);
            this.buttonMapa.TabIndex = 11;
            this.buttonMapa.Text = "            Mapa  ";
            this.buttonMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            this.buttonMapa.Leave += new System.EventHandler(this.button_Leave);
            // 
            // buttonConfigurações
            // 
            this.buttonConfigurações.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfigurações.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConfigurações.FlatAppearance.BorderSize = 0;
            this.buttonConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurações.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigurações.ForeColor = System.Drawing.Color.Coral;
            this.buttonConfigurações.Image = global::SimpleExample.Properties.Resources.settings;
            this.buttonConfigurações.Location = new System.Drawing.Point(0, 542);
            this.buttonConfigurações.Name = "buttonConfigurações";
            this.buttonConfigurações.Size = new System.Drawing.Size(255, 55);
            this.buttonConfigurações.TabIndex = 8;
            this.buttonConfigurações.Text = "Configurações";
            this.buttonConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfigurações.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonConfigurações.UseVisualStyleBackColor = true;
            this.buttonConfigurações.Click += new System.EventHandler(this.buttonConfigurações_Click);
            this.buttonConfigurações.Leave += new System.EventHandler(this.button_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // mavlinkheartbeattBindingSource
            // 
            this.mavlinkheartbeattBindingSource.DataSource = typeof(Mavlink.mavlink_heartbeat_t);
            // 
            // GroundStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1165, 597);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.labelTitleSelection);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroundStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatStation";
            this.Load += new System.EventHandler(this.GroundStation_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonConfigurações;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDados;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label labelTitleSelection;
        private System.Windows.Forms.Button buttonMapa;
    }
}

