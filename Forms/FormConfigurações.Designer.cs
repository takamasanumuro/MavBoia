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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogDirectory = new System.Windows.Forms.Label();
            this.rjTextBoxLogDirectory = new CustomControls.RJControls.RJTextBox();
            this.buttonSeneca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new CustomControls.FancyComboBox();
            this.comboBoxBaudRate = new CustomControls.FancyComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(184, 212);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(160, 270);
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
            this.labelLogDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelLogDirectory.Location = new System.Drawing.Point(97, 329);
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
            this.rjTextBoxLogDirectory.Location = new System.Drawing.Point(325, 329);
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
            this.buttonSeneca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
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
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(806, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 48);
            this.label3.TabIndex = 33;
            this.label3.Text = "Acessórios";
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
            this.comboBoxSerialPort.Location = new System.Drawing.Point(325, 212);
            this.comboBoxSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSerialPort.MinimumSize = new System.Drawing.Size(45, 15);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxSerialPort.Size = new System.Drawing.Size(174, 48);
            this.comboBoxSerialPort.TabIndex = 22;
            this.comboBoxSerialPort.Texts = "";
            this.comboBoxSerialPort.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_OnSelectedIndexChanged);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(325, 270);
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
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSeneca);
            this.Controls.Add(this.labelLogDirectory);
            this.Controls.Add(this.rjTextBoxLogDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConfigurações";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        internal CustomControls.FancyComboBox comboBoxSerialPort;
        internal CustomControls.FancyComboBox comboBoxBaudRate;
        public System.Windows.Forms.Label labelLogDirectory;
        internal CustomControls.RJControls.RJTextBox rjTextBoxLogDirectory;
        private System.Windows.Forms.Button buttonSeneca;
        private System.Windows.Forms.Label label3;
    }
}