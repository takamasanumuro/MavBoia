namespace SimpleExample
{
    partial class FormConfigurações
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
            this.rjTextBoxLocalHostname = new CustomControls.RJControls.RJTextBox();
            this.labelConfigurações = new System.Windows.Forms.Label();
            this.labelLocalHostName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogDirectory = new System.Windows.Forms.Label();
            this.rjTextBoxLogDirectory = new CustomControls.RJControls.RJTextBox();
            this.buttonSeneca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rjTextBoxVPNInterval = new CustomControls.RJControls.RJTextBox();
            this.labelVPNRequisitionInterval = new System.Windows.Forms.Label();
            this.rjTextBoxVPNHostname = new CustomControls.RJControls.RJTextBox();
            this.labelVPNHostname = new System.Windows.Forms.Label();
            this.labelNetConnectionType = new System.Windows.Forms.Label();
            this.fancyComboBoxNetConnectionType = new CustomControls.FancyComboBox();
            this.comboBoxSerialPort = new CustomControls.FancyComboBox();
            this.comboBoxBaudRate = new CustomControls.FancyComboBox();
            this.SuspendLayout();
            // 
            // rjTextBoxLocalHostname
            // 
            this.rjTextBoxLocalHostname.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxLocalHostname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLocalHostname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxLocalHostname.BorderRadius = 0;
            this.rjTextBoxLocalHostname.BorderSize = 2;
            this.rjTextBoxLocalHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxLocalHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxLocalHostname.Location = new System.Drawing.Point(350, 314);
            this.rjTextBoxLocalHostname.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxLocalHostname.Multiline = false;
            this.rjTextBoxLocalHostname.Name = "rjTextBoxLocalHostname";
            this.rjTextBoxLocalHostname.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxLocalHostname.PasswordChar = false;
            this.rjTextBoxLocalHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLocalHostname.PlaceholderText = "";
            this.rjTextBoxLocalHostname.Size = new System.Drawing.Size(174, 45);
            this.rjTextBoxLocalHostname.TabIndex = 0;
            this.rjTextBoxLocalHostname.Texts = "boat-companion";
            this.rjTextBoxLocalHostname.UnderlinedStyle = false;
            // 
            // labelConfigurações
            // 
            this.labelConfigurações.AutoSize = true;
            this.labelConfigurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurações.ForeColor = System.Drawing.Color.Coral;
            this.labelConfigurações.Location = new System.Drawing.Point(36, 63);
            this.labelConfigurações.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfigurações.Name = "labelConfigurações";
            this.labelConfigurações.Size = new System.Drawing.Size(302, 48);
            this.labelConfigurações.TabIndex = 16;
            this.labelConfigurações.Text = "Configurações";
            // 
            // labelLocalHostName
            // 
            this.labelLocalHostName.AutoSize = true;
            this.labelLocalHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalHostName.ForeColor = System.Drawing.Color.Coral;
            this.labelLocalHostName.Location = new System.Drawing.Point(92, 314);
            this.labelLocalHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocalHostName.Name = "labelLocalHostName";
            this.labelLocalHostName.Size = new System.Drawing.Size(196, 25);
            this.labelLocalHostName.TabIndex = 17;
            this.labelLocalHostName.Text = "Nome de host local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(135, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Porta serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(112, 583);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Taxa de baud";
            // 
            // labelLogDirectory
            // 
            this.labelLogDirectory.AutoSize = true;
            this.labelLogDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogDirectory.ForeColor = System.Drawing.Color.Coral;
            this.labelLogDirectory.Location = new System.Drawing.Point(84, 654);
            this.labelLogDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogDirectory.Name = "labelLogDirectory";
            this.labelLogDirectory.Size = new System.Drawing.Size(208, 25);
            this.labelLogDirectory.TabIndex = 31;
            this.labelLogDirectory.Text = "Diretório para logger";
            // 
            // rjTextBoxLogDirectory
            // 
            this.rjTextBoxLogDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxLogDirectory.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLogDirectory.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxLogDirectory.BorderRadius = 0;
            this.rjTextBoxLogDirectory.BorderSize = 2;
            this.rjTextBoxLogDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxLogDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxLogDirectory.Location = new System.Drawing.Point(348, 652);
            this.rjTextBoxLogDirectory.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxLogDirectory.Multiline = false;
            this.rjTextBoxLogDirectory.Name = "rjTextBoxLogDirectory";
            this.rjTextBoxLogDirectory.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxLogDirectory.PasswordChar = false;
            this.rjTextBoxLogDirectory.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLogDirectory.PlaceholderText = "";
            this.rjTextBoxLogDirectory.Size = new System.Drawing.Size(174, 45);
            this.rjTextBoxLogDirectory.TabIndex = 30;
            this.rjTextBoxLogDirectory.Texts = "C://logs";
            this.rjTextBoxLogDirectory.UnderlinedStyle = false;
            this.rjTextBoxLogDirectory._TextChanged += new System.EventHandler(this.rjTextBoxLogDirectory__TextChanged);
            // 
            // buttonSeneca
            // 
            this.buttonSeneca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeneca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSeneca.FlatAppearance.BorderSize = 0;
            this.buttonSeneca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeneca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeneca.ForeColor = System.Drawing.Color.Coral;
            this.buttonSeneca.Location = new System.Drawing.Point(814, 189);
            this.buttonSeneca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeneca.Name = "buttonSeneca";
            this.buttonSeneca.Size = new System.Drawing.Size(304, 85);
            this.buttonSeneca.TabIndex = 32;
            this.buttonSeneca.Text = "Calculadora do T201";
            this.buttonSeneca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSeneca.UseVisualStyleBackColor = true;
            this.buttonSeneca.Click += new System.EventHandler(this.buttonSeneca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(806, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 48);
            this.label3.TabIndex = 33;
            this.label3.Text = "Acessórios";
            // 
            // rjTextBoxVPNInterval
            // 
            this.rjTextBoxVPNInterval.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxVPNInterval.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxVPNInterval.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxVPNInterval.BorderRadius = 0;
            this.rjTextBoxVPNInterval.BorderSize = 2;
            this.rjTextBoxVPNInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNInterval.Location = new System.Drawing.Point(350, 446);
            this.rjTextBoxVPNInterval.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxVPNInterval.Multiline = false;
            this.rjTextBoxVPNInterval.Name = "rjTextBoxVPNInterval";
            this.rjTextBoxVPNInterval.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxVPNInterval.PasswordChar = false;
            this.rjTextBoxVPNInterval.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNInterval.PlaceholderText = "";
            this.rjTextBoxVPNInterval.Size = new System.Drawing.Size(174, 45);
            this.rjTextBoxVPNInterval.TabIndex = 21;
            this.rjTextBoxVPNInterval.Texts = "2000";
            this.rjTextBoxVPNInterval.UnderlinedStyle = false;
            // 
            // labelVPNRequisitionInterval
            // 
            this.labelVPNRequisitionInterval.AutoSize = true;
            this.labelVPNRequisitionInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVPNRequisitionInterval.ForeColor = System.Drawing.Color.Coral;
            this.labelVPNRequisitionInterval.Location = new System.Drawing.Point(80, 446);
            this.labelVPNRequisitionInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVPNRequisitionInterval.Name = "labelVPNRequisitionInterval";
            this.labelVPNRequisitionInterval.Size = new System.Drawing.Size(230, 50);
            this.labelVPNRequisitionInterval.TabIndex = 20;
            this.labelVPNRequisitionInterval.Text = "Intervalo de requisição\r\n            VPN";
            // 
            // rjTextBoxVPNHostname
            // 
            this.rjTextBoxVPNHostname.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxVPNHostname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxVPNHostname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxVPNHostname.BorderRadius = 0;
            this.rjTextBoxVPNHostname.BorderSize = 2;
            this.rjTextBoxVPNHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNHostname.Location = new System.Drawing.Point(350, 374);
            this.rjTextBoxVPNHostname.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxVPNHostname.Multiline = false;
            this.rjTextBoxVPNHostname.Name = "rjTextBoxVPNHostname";
            this.rjTextBoxVPNHostname.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxVPNHostname.PasswordChar = false;
            this.rjTextBoxVPNHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNHostname.PlaceholderText = "";
            this.rjTextBoxVPNHostname.Size = new System.Drawing.Size(174, 45);
            this.rjTextBoxVPNHostname.TabIndex = 19;
            this.rjTextBoxVPNHostname.Texts = "boat32";
            this.rjTextBoxVPNHostname.UnderlinedStyle = false;
            // 
            // labelVPNHostname
            // 
            this.labelVPNHostname.AutoSize = true;
            this.labelVPNHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVPNHostname.ForeColor = System.Drawing.Color.Coral;
            this.labelVPNHostname.Location = new System.Drawing.Point(96, 374);
            this.labelVPNHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVPNHostname.Name = "labelVPNHostname";
            this.labelVPNHostname.Size = new System.Drawing.Size(195, 25);
            this.labelVPNHostname.TabIndex = 18;
            this.labelVPNHostname.Text = "Nome de host VPN";
            // 
            // labelNetConnectionType
            // 
            this.labelNetConnectionType.AutoSize = true;
            this.labelNetConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetConnectionType.ForeColor = System.Drawing.Color.Coral;
            this.labelNetConnectionType.Location = new System.Drawing.Point(80, 229);
            this.labelNetConnectionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetConnectionType.Name = "labelNetConnectionType";
            this.labelNetConnectionType.Size = new System.Drawing.Size(221, 25);
            this.labelNetConnectionType.TabIndex = 29;
            this.labelNetConnectionType.Text = "Tipo de conexão LAN";
            // 
            // fancyComboBoxNetConnectionType
            // 
            this.fancyComboBoxNetConnectionType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fancyComboBoxNetConnectionType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.fancyComboBoxNetConnectionType.BorderSize = 1;
            this.fancyComboBoxNetConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fancyComboBoxNetConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyComboBoxNetConnectionType.ForeColor = System.Drawing.Color.DimGray;
            this.fancyComboBoxNetConnectionType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.fancyComboBoxNetConnectionType.Items.AddRange(new object[] {
            "Local",
            "VPN"});
            this.fancyComboBoxNetConnectionType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.fancyComboBoxNetConnectionType.ListTextColor = System.Drawing.Color.DimGray;
            this.fancyComboBoxNetConnectionType.Location = new System.Drawing.Point(350, 229);
            this.fancyComboBoxNetConnectionType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fancyComboBoxNetConnectionType.MinimumSize = new System.Drawing.Size(45, 15);
            this.fancyComboBoxNetConnectionType.Name = "fancyComboBoxNetConnectionType";
            this.fancyComboBoxNetConnectionType.Padding = new System.Windows.Forms.Padding(2);
            this.fancyComboBoxNetConnectionType.Size = new System.Drawing.Size(174, 45);
            this.fancyComboBoxNetConnectionType.TabIndex = 28;
            this.fancyComboBoxNetConnectionType.Texts = "";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSerialPort.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.BorderSize = 1;
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialPort.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxSerialPort.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(350, 526);
            this.comboBoxSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSerialPort.MinimumSize = new System.Drawing.Size(45, 15);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxSerialPort.Size = new System.Drawing.Size(174, 48);
            this.comboBoxSerialPort.TabIndex = 22;
            this.comboBoxSerialPort.Texts = "";
            this.comboBoxSerialPort.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_OnSelectedIndexChanged);
            this.comboBoxSerialPort.Click += new System.EventHandler(this.comboBoxSerialPort_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxBaudRate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.BorderSize = 1;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            "915200"});
            this.comboBoxBaudRate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxBaudRate.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(350, 583);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBaudRate.MinimumSize = new System.Drawing.Size(45, 15);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxBaudRate.Size = new System.Drawing.Size(174, 48);
            this.comboBoxBaudRate.TabIndex = 23;
            this.comboBoxBaudRate.Texts = "";
            this.comboBoxBaudRate.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_OnSelectedIndexChanged);
            // 
            // FormConfigurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSeneca);
            this.Controls.Add(this.labelLogDirectory);
            this.Controls.Add(this.rjTextBoxLogDirectory);
            this.Controls.Add(this.labelNetConnectionType);
            this.Controls.Add(this.fancyComboBoxNetConnectionType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.rjTextBoxVPNInterval);
            this.Controls.Add(this.labelVPNRequisitionInterval);
            this.Controls.Add(this.rjTextBoxVPNHostname);
            this.Controls.Add(this.labelVPNHostname);
            this.Controls.Add(this.labelLocalHostName);
            this.Controls.Add(this.labelConfigurações);
            this.Controls.Add(this.rjTextBoxLocalHostname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConfigurações";
            this.Text = "FormConfigurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelConfigurações;
        public System.Windows.Forms.Label labelLocalHostName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        internal CustomControls.RJControls.RJTextBox rjTextBoxLocalHostname;
        internal CustomControls.FancyComboBox comboBoxSerialPort;
        internal CustomControls.FancyComboBox comboBoxBaudRate;
        public System.Windows.Forms.Label labelLogDirectory;
        internal CustomControls.RJControls.RJTextBox rjTextBoxLogDirectory;
        private System.Windows.Forms.Button buttonSeneca;
        private System.Windows.Forms.Label label3;
        internal CustomControls.RJControls.RJTextBox rjTextBoxVPNInterval;
        public System.Windows.Forms.Label labelVPNRequisitionInterval;
        internal CustomControls.RJControls.RJTextBox rjTextBoxVPNHostname;
        public System.Windows.Forms.Label labelVPNHostname;
        public System.Windows.Forms.Label labelNetConnectionType;
        internal CustomControls.FancyComboBox fancyComboBoxNetConnectionType;
    }
}