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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxBaudRate = new CustomControls.FancyComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSerialPort = new CustomControls.FancyComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTextBoxInfluxToken = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxInfluxAdress = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rjTextBoxApolloTracker = new CustomControls.RJControls.RJTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 148);
            this.label1.TabIndex = 24;
            this.label1.Text = "Porta serial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 148);
            this.label2.TabIndex = 25;
            this.label2.Text = "Taxa de baud";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogDirectory
            // 
            this.labelLogDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLogDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelLogDirectory.Location = new System.Drawing.Point(30, 0);
            this.labelLogDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogDirectory.Name = "labelLogDirectory";
            this.labelLogDirectory.Size = new System.Drawing.Size(168, 148);
            this.labelLogDirectory.TabIndex = 31;
            this.labelLogDirectory.Text = "Diretório para logger";
            this.labelLogDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rjTextBoxLogDirectory.Location = new System.Drawing.Point(218, 52);
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
            this.buttonSeneca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonSeneca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeneca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSeneca.FlatAppearance.BorderSize = 0;
            this.buttonSeneca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeneca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonSeneca.Location = new System.Drawing.Point(141, 180);
            this.buttonSeneca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeneca.Name = "buttonSeneca";
            this.buttonSeneca.Size = new System.Drawing.Size(193, 77);
            this.buttonSeneca.TabIndex = 32;
            this.buttonSeneca.Text = "Calculadora do T201";
            this.buttonSeneca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSeneca.UseVisualStyleBackColor = false;
            this.buttonSeneca.Click += new System.EventHandler(this.buttonSeneca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(114, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 48);
            this.label3.TabIndex = 33;
            this.label3.Text = "Acessórios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.97114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.02886F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1237, 720);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(723, 714);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxBaudRate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 157);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(717, 148);
            this.panel2.TabIndex = 36;
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(218, 52);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBaudRate.MinimumSize = new System.Drawing.Size(45, 15);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxBaudRate.Size = new System.Drawing.Size(174, 48);
            this.comboBoxBaudRate.TabIndex = 23;
            this.comboBoxBaudRate.Texts = "";
            this.comboBoxBaudRate.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_OnSelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxSerialPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(717, 148);
            this.panel1.TabIndex = 35;
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
            this.comboBoxSerialPort.Location = new System.Drawing.Point(218, 52);
            this.comboBoxSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSerialPort.MinimumSize = new System.Drawing.Size(45, 15);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxSerialPort.Size = new System.Drawing.Size(174, 48);
            this.comboBoxSerialPort.TabIndex = 22;
            this.comboBoxSerialPort.Texts = "";
            this.comboBoxSerialPort.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_OnSelectedIndexChanged);
            this.comboBoxSerialPort.DropDown += new System.EventHandler(this.comboBoxSerialPort_DropDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelLogDirectory);
            this.panel3.Controls.Add(this.rjTextBoxLogDirectory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 311);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(717, 148);
            this.panel3.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rjTextBoxInfluxToken);
            this.panel5.Controls.Add(this.rjTextBoxInfluxAdress);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 465);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(717, 225);
            this.panel5.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label6.Location = new System.Drawing.Point(213, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 39);
            this.label6.TabIndex = 35;
            this.label6.Text = "Endereço";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label5.Location = new System.Drawing.Point(213, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 39);
            this.label5.TabIndex = 34;
            this.label5.Text = "Token";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBoxInfluxToken
            // 
            this.rjTextBoxInfluxToken.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxInfluxToken.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxInfluxToken.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxInfluxToken.BorderRadius = 0;
            this.rjTextBoxInfluxToken.BorderSize = 2;
            this.rjTextBoxInfluxToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxInfluxToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxInfluxToken.Location = new System.Drawing.Point(218, 160);
            this.rjTextBoxInfluxToken.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxInfluxToken.Multiline = false;
            this.rjTextBoxInfluxToken.Name = "rjTextBoxInfluxToken";
            this.rjTextBoxInfluxToken.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxInfluxToken.PasswordChar = false;
            this.rjTextBoxInfluxToken.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxInfluxToken.PlaceholderText = "";
            this.rjTextBoxInfluxToken.Size = new System.Drawing.Size(252, 45);
            this.rjTextBoxInfluxToken.TabIndex = 33;
            this.rjTextBoxInfluxToken.Texts = "";
            this.rjTextBoxInfluxToken.UnderlinedStyle = false;
            this.rjTextBoxInfluxToken.Leave += new System.EventHandler(this.rjTextBoxInfluxToken_Leave);
            // 
            // rjTextBoxInfluxAdress
            // 
            this.rjTextBoxInfluxAdress.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxInfluxAdress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxInfluxAdress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxInfluxAdress.BorderRadius = 0;
            this.rjTextBoxInfluxAdress.BorderSize = 2;
            this.rjTextBoxInfluxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxInfluxAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxInfluxAdress.Location = new System.Drawing.Point(218, 64);
            this.rjTextBoxInfluxAdress.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxInfluxAdress.Multiline = false;
            this.rjTextBoxInfluxAdress.Name = "rjTextBoxInfluxAdress";
            this.rjTextBoxInfluxAdress.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxInfluxAdress.PasswordChar = false;
            this.rjTextBoxInfluxAdress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxInfluxAdress.PlaceholderText = "";
            this.rjTextBoxInfluxAdress.Size = new System.Drawing.Size(252, 45);
            this.rjTextBoxInfluxAdress.TabIndex = 32;
            this.rjTextBoxInfluxAdress.Texts = "http://localhost:8086";
            this.rjTextBoxInfluxAdress.UnderlinedStyle = false;
            this.rjTextBoxInfluxAdress.Leave += new System.EventHandler(this.rjTextBoxInfluxAdress_Leave);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 225);
            this.label4.TabIndex = 32;
            this.label4.Text = "InfluxDB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(732, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 714);
            this.panel4.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSeneca);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rjTextBoxApolloTracker);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(502, 714);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(502, 56);
            this.label7.TabIndex = 34;
            this.label7.Text = "ApolloTracker";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.label8.Location = new System.Drawing.Point(0, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 297);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nome da competição";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBoxApolloTracker
            // 
            this.rjTextBoxApolloTracker.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxApolloTracker.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxApolloTracker.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxApolloTracker.BorderRadius = 0;
            this.rjTextBoxApolloTracker.BorderSize = 2;
            this.rjTextBoxApolloTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxApolloTracker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxApolloTracker.Location = new System.Drawing.Point(208, 182);
            this.rjTextBoxApolloTracker.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBoxApolloTracker.Multiline = false;
            this.rjTextBoxApolloTracker.Name = "rjTextBoxApolloTracker";
            this.rjTextBoxApolloTracker.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.rjTextBoxApolloTracker.PasswordChar = false;
            this.rjTextBoxApolloTracker.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxApolloTracker.PlaceholderText = "";
            this.rjTextBoxApolloTracker.Size = new System.Drawing.Size(252, 45);
            this.rjTextBoxApolloTracker.TabIndex = 36;
            this.rjTextBoxApolloTracker.Texts = "desafio-sol-e-mar";
            this.rjTextBoxApolloTracker.UnderlinedStyle = false;
            this.rjTextBoxApolloTracker._TextChanged += new System.EventHandler(this.rjTextBoxApolloTracker__TextChanged);
            // 
            // FormConfigurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1237, 720);
            this.Name = "FormConfigurações";
            this.Text = "Configurações";
            this.Resize += new System.EventHandler(this.FormConfigurações_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        internal CustomControls.RJControls.RJTextBox rjTextBoxInfluxAdress;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        internal CustomControls.RJControls.RJTextBox rjTextBoxInfluxToken;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal CustomControls.RJControls.RJTextBox rjTextBoxApolloTracker;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}