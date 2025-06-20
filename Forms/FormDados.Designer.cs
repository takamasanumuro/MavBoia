namespace SimpleExample
{
    partial class FormDados
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
            this.lbl_estimative = new System.Windows.Forms.Label();
            this.lbl_temp_mppt_R = new System.Windows.Forms.Label();
            this.lbl_temp_mppt_L = new System.Windows.Forms.Label();
            this.lbl_temp_bat_R = new System.Windows.Forms.Label();
            this.lbl_temp_bat_L = new System.Windows.Forms.Label();
            this.lbl_pump = new System.Windows.Forms.Label();
            this.lbl_pv_curr = new System.Windows.Forms.Label();
            this.lbl_pv_voltage = new System.Windows.Forms.Label();
            this.lbl_temp_cont_R = new System.Windows.Forms.Label();
            this.lbl_temp_cont_L = new System.Windows.Forms.Label();
            this.lbl_rpm_R = new System.Windows.Forms.Label();
            this.lbl_rpm_L = new System.Windows.Forms.Label();
            this.lbl_bat_aux_volt = new System.Windows.Forms.Label();
            this.lbl_bat_volt = new System.Windows.Forms.Label();
            this.lbl_aux_bat_curr = new System.Windows.Forms.Label();
            this.lbl_mppt_curr = new System.Windows.Forms.Label();
            this.lbl_motor_curr_R = new System.Windows.Forms.Label();
            this.lbl_motor_curr_L = new System.Windows.Forms.Label();
            this.lbl_motor_volt_R = new System.Windows.Forms.Label();
            this.lbl_motor_volt_L = new System.Windows.Forms.Label();
            this.lbl_bat_curr = new System.Windows.Forms.Label();
            this.lbl_bms_temp_2 = new System.Windows.Forms.Label();
            this.lbl_bms_temp_1 = new System.Windows.Forms.Label();
            this.lbl_bms_soc = new System.Windows.Forms.Label();
            this.lbl_bms_curr = new System.Windows.Forms.Label();
            this.lbl_bms_voltage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlNotifications = new System.Windows.Forms.TabControl();
            this.tabPageMotor = new System.Windows.Forms.TabPage();
            this.tabPageBMS = new System.Windows.Forms.TabPage();
            this.flowLayoutBMS = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.panelNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControlNotifications.SuspendLayout();
            this.tabPageBMS.SuspendLayout();
            this.panelNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_estimative
            // 
            this.lbl_estimative.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estimative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_estimative.Location = new System.Drawing.Point(339, 504);
            this.lbl_estimative.Name = "lbl_estimative";
            this.lbl_estimative.Size = new System.Drawing.Size(330, 42);
            this.lbl_estimative.TabIndex = 26;
            this.lbl_estimative.Text = "Estimativa";
            // 
            // lbl_temp_mppt_R
            // 
            this.lbl_temp_mppt_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_mppt_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_mppt_R.Location = new System.Drawing.Point(339, 462);
            this.lbl_temp_mppt_R.Name = "lbl_temp_mppt_R";
            this.lbl_temp_mppt_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_mppt_R.TabIndex = 22;
            this.lbl_temp_mppt_R.Text = "Temp MPPT R";
            // 
            // lbl_temp_mppt_L
            // 
            this.lbl_temp_mppt_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_mppt_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_mppt_L.Location = new System.Drawing.Point(339, 420);
            this.lbl_temp_mppt_L.Name = "lbl_temp_mppt_L";
            this.lbl_temp_mppt_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_mppt_L.TabIndex = 21;
            this.lbl_temp_mppt_L.Text = "Temp MPPT L";
            // 
            // lbl_temp_bat_R
            // 
            this.lbl_temp_bat_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_bat_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_bat_R.Location = new System.Drawing.Point(339, 378);
            this.lbl_temp_bat_R.Name = "lbl_temp_bat_R";
            this.lbl_temp_bat_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_bat_R.TabIndex = 20;
            this.lbl_temp_bat_R.Text = "Temp Bateria R";
            // 
            // lbl_temp_bat_L
            // 
            this.lbl_temp_bat_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_bat_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_bat_L.Location = new System.Drawing.Point(339, 336);
            this.lbl_temp_bat_L.Name = "lbl_temp_bat_L";
            this.lbl_temp_bat_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_bat_L.TabIndex = 19;
            this.lbl_temp_bat_L.Text = "Temp Bateria L";
            // 
            // lbl_pump
            // 
            this.lbl_pump.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pump.Location = new System.Drawing.Point(339, 294);
            this.lbl_pump.Name = "lbl_pump";
            this.lbl_pump.Size = new System.Drawing.Size(330, 42);
            this.lbl_pump.TabIndex = 18;
            this.lbl_pump.Text = "Bombas";
            // 
            // lbl_pv_curr
            // 
            this.lbl_pv_curr.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pv_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pv_curr.Location = new System.Drawing.Point(339, 252);
            this.lbl_pv_curr.Name = "lbl_pv_curr";
            this.lbl_pv_curr.Size = new System.Drawing.Size(330, 42);
            this.lbl_pv_curr.TabIndex = 17;
            this.lbl_pv_curr.Text = "Corrente Painéis:";
            // 
            // lbl_pv_voltage
            // 
            this.lbl_pv_voltage.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pv_voltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pv_voltage.Location = new System.Drawing.Point(339, 210);
            this.lbl_pv_voltage.Name = "lbl_pv_voltage";
            this.lbl_pv_voltage.Size = new System.Drawing.Size(330, 42);
            this.lbl_pv_voltage.TabIndex = 16;
            this.lbl_pv_voltage.Text = "Tensão Painéis:";
            // 
            // lbl_temp_cont_R
            // 
            this.lbl_temp_cont_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_cont_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_cont_R.Location = new System.Drawing.Point(339, 168);
            this.lbl_temp_cont_R.Name = "lbl_temp_cont_R";
            this.lbl_temp_cont_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_cont_R.TabIndex = 15;
            this.lbl_temp_cont_R.Text = "Temp Controlador R";
            this.lbl_temp_cont_R.Click += new System.EventHandler(this.lbl_temp_cont_R_Click);
            // 
            // lbl_temp_cont_L
            // 
            this.lbl_temp_cont_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_cont_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp_cont_L.Location = new System.Drawing.Point(339, 126);
            this.lbl_temp_cont_L.Name = "lbl_temp_cont_L";
            this.lbl_temp_cont_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_temp_cont_L.TabIndex = 14;
            this.lbl_temp_cont_L.Text = "Temp Controlador L";
            this.lbl_temp_cont_L.Click += new System.EventHandler(this.lbl_temp_cont_L_Click);
            // 
            // lbl_rpm_R
            // 
            this.lbl_rpm_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpm_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_rpm_R.Location = new System.Drawing.Point(339, 84);
            this.lbl_rpm_R.Name = "lbl_rpm_R";
            this.lbl_rpm_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_rpm_R.TabIndex = 13;
            this.lbl_rpm_R.Text = "RPM R";
            this.lbl_rpm_R.Click += new System.EventHandler(this.lbl_rpm_R_Click);
            // 
            // lbl_rpm_L
            // 
            this.lbl_rpm_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpm_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_rpm_L.Location = new System.Drawing.Point(339, 42);
            this.lbl_rpm_L.Name = "lbl_rpm_L";
            this.lbl_rpm_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_rpm_L.TabIndex = 12;
            this.lbl_rpm_L.Text = "RPM L";
            // 
            // lbl_bat_aux_volt
            // 
            this.lbl_bat_aux_volt.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bat_aux_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bat_aux_volt.Location = new System.Drawing.Point(339, 0);
            this.lbl_bat_aux_volt.Name = "lbl_bat_aux_volt";
            this.lbl_bat_aux_volt.Size = new System.Drawing.Size(330, 42);
            this.lbl_bat_aux_volt.TabIndex = 10;
            this.lbl_bat_aux_volt.Text = "Bateria Aux. Tensão:";
            // 
            // lbl_bat_volt
            // 
            this.lbl_bat_volt.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bat_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bat_volt.Location = new System.Drawing.Point(3, 504);
            this.lbl_bat_volt.Name = "lbl_bat_volt";
            this.lbl_bat_volt.Size = new System.Drawing.Size(330, 42);
            this.lbl_bat_volt.TabIndex = 9;
            this.lbl_bat_volt.Text = "Bateria Tensão:";
            // 
            // lbl_aux_bat_curr
            // 
            this.lbl_aux_bat_curr.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aux_bat_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_aux_bat_curr.Location = new System.Drawing.Point(3, 462);
            this.lbl_aux_bat_curr.Name = "lbl_aux_bat_curr";
            this.lbl_aux_bat_curr.Size = new System.Drawing.Size(330, 42);
            this.lbl_aux_bat_curr.TabIndex = 8;
            this.lbl_aux_bat_curr.Text = "Bateria Aux. Corrente:";
            this.lbl_aux_bat_curr.Click += new System.EventHandler(this.lbl_aux_bat_curr_Click);
            // 
            // lbl_mppt_curr
            // 
            this.lbl_mppt_curr.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mppt_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mppt_curr.Location = new System.Drawing.Point(3, 420);
            this.lbl_mppt_curr.Name = "lbl_mppt_curr";
            this.lbl_mppt_curr.Size = new System.Drawing.Size(330, 42);
            this.lbl_mppt_curr.TabIndex = 7;
            this.lbl_mppt_curr.Text = "Corrente MPPT";
            this.lbl_mppt_curr.Click += new System.EventHandler(this.lbl_mppt_curr_Click);
            // 
            // lbl_motor_curr_R
            // 
            this.lbl_motor_curr_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor_curr_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_motor_curr_R.Location = new System.Drawing.Point(3, 378);
            this.lbl_motor_curr_R.Name = "lbl_motor_curr_R";
            this.lbl_motor_curr_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_motor_curr_R.TabIndex = 6;
            this.lbl_motor_curr_R.Text = "Corrente Motor R";
            this.lbl_motor_curr_R.Click += new System.EventHandler(this.lbl_motor_curr_R_Click);
            // 
            // lbl_motor_curr_L
            // 
            this.lbl_motor_curr_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor_curr_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_motor_curr_L.Location = new System.Drawing.Point(3, 336);
            this.lbl_motor_curr_L.Name = "lbl_motor_curr_L";
            this.lbl_motor_curr_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_motor_curr_L.TabIndex = 5;
            this.lbl_motor_curr_L.Text = "Corrente Motor L";
            this.lbl_motor_curr_L.Click += new System.EventHandler(this.lbl_motor_curr_L_Click);
            // 
            // lbl_motor_volt_R
            // 
            this.lbl_motor_volt_R.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor_volt_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_motor_volt_R.Location = new System.Drawing.Point(3, 294);
            this.lbl_motor_volt_R.Name = "lbl_motor_volt_R";
            this.lbl_motor_volt_R.Size = new System.Drawing.Size(330, 42);
            this.lbl_motor_volt_R.TabIndex = 24;
            this.lbl_motor_volt_R.Text = "Tensão Motor R";
            this.lbl_motor_volt_R.Click += new System.EventHandler(this.lbl_motor_volt_R_Click);
            // 
            // lbl_motor_volt_L
            // 
            this.lbl_motor_volt_L.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor_volt_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_motor_volt_L.Location = new System.Drawing.Point(3, 252);
            this.lbl_motor_volt_L.Name = "lbl_motor_volt_L";
            this.lbl_motor_volt_L.Size = new System.Drawing.Size(330, 42);
            this.lbl_motor_volt_L.TabIndex = 23;
            this.lbl_motor_volt_L.Text = "Tensão Motor L";
            this.lbl_motor_volt_L.Click += new System.EventHandler(this.lbl_motor_volt_L_Click);
            // 
            // lbl_bat_curr
            // 
            this.lbl_bat_curr.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bat_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bat_curr.Location = new System.Drawing.Point(3, 210);
            this.lbl_bat_curr.Name = "lbl_bat_curr";
            this.lbl_bat_curr.Size = new System.Drawing.Size(330, 42);
            this.lbl_bat_curr.TabIndex = 4;
            this.lbl_bat_curr.Text = "Bateria Corrente:";
            this.lbl_bat_curr.Click += new System.EventHandler(this.lbl_bat_curr_Click);
            // 
            // lbl_bms_temp_2
            // 
            this.lbl_bms_temp_2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bms_temp_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bms_temp_2.Location = new System.Drawing.Point(3, 168);
            this.lbl_bms_temp_2.Name = "lbl_bms_temp_2";
            this.lbl_bms_temp_2.Size = new System.Drawing.Size(330, 42);
            this.lbl_bms_temp_2.TabIndex = 3;
            this.lbl_bms_temp_2.Text = "BMS Temp2:";
            this.lbl_bms_temp_2.Click += new System.EventHandler(this.lbl_bms_temp_2_Click);
            // 
            // lbl_bms_temp_1
            // 
            this.lbl_bms_temp_1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bms_temp_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bms_temp_1.Location = new System.Drawing.Point(3, 126);
            this.lbl_bms_temp_1.Name = "lbl_bms_temp_1";
            this.lbl_bms_temp_1.Size = new System.Drawing.Size(330, 42);
            this.lbl_bms_temp_1.TabIndex = 2;
            this.lbl_bms_temp_1.Text = "BMS Temp1:";
            this.lbl_bms_temp_1.Click += new System.EventHandler(this.lbl_bms_temp_1_Click);
            // 
            // lbl_bms_soc
            // 
            this.lbl_bms_soc.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bms_soc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bms_soc.Location = new System.Drawing.Point(3, 84);
            this.lbl_bms_soc.Name = "lbl_bms_soc";
            this.lbl_bms_soc.Size = new System.Drawing.Size(330, 42);
            this.lbl_bms_soc.TabIndex = 1;
            this.lbl_bms_soc.Text = "BMS SOC: ";
            this.lbl_bms_soc.Click += new System.EventHandler(this.lbl_bms_soc_Click);
            // 
            // lbl_bms_curr
            // 
            this.lbl_bms_curr.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bms_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bms_curr.Location = new System.Drawing.Point(3, 42);
            this.lbl_bms_curr.Name = "lbl_bms_curr";
            this.lbl_bms_curr.Size = new System.Drawing.Size(330, 42);
            this.lbl_bms_curr.TabIndex = 0;
            this.lbl_bms_curr.Text = "BMS Corrente:";
            // 
            // lbl_bms_voltage
            // 
            this.lbl_bms_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bms_voltage.Location = new System.Drawing.Point(3, 0);
            this.lbl_bms_voltage.Name = "lbl_bms_voltage";
            this.lbl_bms_voltage.Size = new System.Drawing.Size(330, 42);
            this.lbl_bms_voltage.TabIndex = 25;
            this.lbl_bms_voltage.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_bms_voltage);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bms_curr);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bms_soc);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bms_temp_1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bms_temp_2);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bat_curr);
            this.flowLayoutPanel1.Controls.Add(this.lbl_motor_volt_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_motor_volt_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_motor_curr_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_motor_curr_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_mppt_curr);
            this.flowLayoutPanel1.Controls.Add(this.lbl_aux_bat_curr);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bat_volt);
            this.flowLayoutPanel1.Controls.Add(this.lbl_bat_aux_volt);
            this.flowLayoutPanel1.Controls.Add(this.lbl_rpm_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_rpm_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_cont_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_cont_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_pv_voltage);
            this.flowLayoutPanel1.Controls.Add(this.lbl_pv_curr);
            this.flowLayoutPanel1.Controls.Add(this.lbl_pump);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_bat_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_bat_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_mppt_L);
            this.flowLayoutPanel1.Controls.Add(this.lbl_temp_mppt_R);
            this.flowLayoutPanel1.Controls.Add(this.lbl_estimative);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 546);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tabControlNotifications
            // 
            this.tabControlNotifications.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlNotifications.Controls.Add(this.tabPageBMS);
            this.tabControlNotifications.Controls.Add(this.tabPageMotor);
            this.tabControlNotifications.Location = new System.Drawing.Point(28, 576);
            this.tabControlNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlNotifications.Multiline = true;
            this.tabControlNotifications.Name = "tabControlNotifications";
            this.tabControlNotifications.SelectedIndex = 0;
            this.tabControlNotifications.Size = new System.Drawing.Size(319, 576);
            this.tabControlNotifications.TabIndex = 1;
            // 
            // tabPageMotor
            // 
            this.tabPageMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMotor.Location = new System.Drawing.Point(4, 4);
            this.tabPageMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMotor.Name = "tabPageMotor";
            this.tabPageMotor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMotor.Size = new System.Drawing.Size(290, 568);
            this.tabPageMotor.TabIndex = 1;
            this.tabPageMotor.Text = "Motor";
            this.tabPageMotor.UseVisualStyleBackColor = true;
            // 
            // tabPageBMS
            // 
            this.tabPageBMS.Controls.Add(this.flowLayoutBMS);
            this.tabPageBMS.Location = new System.Drawing.Point(4, 4);
            this.tabPageBMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBMS.Name = "tabPageBMS";
            this.tabPageBMS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBMS.Size = new System.Drawing.Size(290, 568);
            this.tabPageBMS.TabIndex = 0;
            this.tabPageBMS.Text = "BMS";
            this.tabPageBMS.UseVisualStyleBackColor = true;
            // 
            // flowLayoutBMS
            // 
            this.flowLayoutBMS.AutoScroll = true;
            this.flowLayoutBMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBMS.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutBMS.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutBMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutBMS.Name = "flowLayoutBMS";
            this.flowLayoutBMS.Size = new System.Drawing.Size(284, 564);
            this.flowLayoutBMS.TabIndex = 0;
            this.flowLayoutBMS.WrapContents = false;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(327, 2);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(20, 570);
            this.btnNotifications.TabIndex = 2;
            this.btnNotifications.Text = "<";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelNotification
            // 
            this.panelNotification.Controls.Add(this.btnNotifications);
            this.panelNotification.Controls.Add(this.tabControlNotifications);
            this.panelNotification.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNotification.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelNotification.Location = new System.Drawing.Point(750, 15);
            this.panelNotification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(350, 546);
            this.panelNotification.TabIndex = 3;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panelNotification);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 576);
            this.Name = "FormDados";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.Text = "Dados";
            this.Load += new System.EventHandler(this.FormDados_Load);
            this.Resize += new System.EventHandler(this.FormDados_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControlNotifications.ResumeLayout(false);
            this.tabPageBMS.ResumeLayout(false);
            this.panelNotification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_estimative;
        private System.Windows.Forms.Label lbl_temp_mppt_R;
        private System.Windows.Forms.Label lbl_temp_mppt_L;
        private System.Windows.Forms.Label lbl_temp_bat_R;
        private System.Windows.Forms.Label lbl_temp_bat_L;
        private System.Windows.Forms.Label lbl_pump;
        private System.Windows.Forms.Label lbl_pv_curr;
        private System.Windows.Forms.Label lbl_pv_voltage;
        private System.Windows.Forms.Label lbl_temp_cont_R;
        private System.Windows.Forms.Label lbl_temp_cont_L;
        private System.Windows.Forms.Label lbl_rpm_R;
        private System.Windows.Forms.Label lbl_rpm_L;
        private System.Windows.Forms.Label lbl_bat_aux_volt;
        private System.Windows.Forms.Label lbl_bat_volt;
        private System.Windows.Forms.Label lbl_aux_bat_curr;
        private System.Windows.Forms.Label lbl_mppt_curr;
        private System.Windows.Forms.Label lbl_motor_curr_R;
        private System.Windows.Forms.Label lbl_motor_curr_L;
        private System.Windows.Forms.Label lbl_motor_volt_R;
        private System.Windows.Forms.Label lbl_motor_volt_L;
        private System.Windows.Forms.Label lbl_bat_curr;
        private System.Windows.Forms.Label lbl_bms_temp_2;
        private System.Windows.Forms.Label lbl_bms_temp_1;
        private System.Windows.Forms.Label lbl_bms_soc;
        private System.Windows.Forms.Label lbl_bms_curr;
        private System.Windows.Forms.Label lbl_bms_voltage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlNotifications;
        private System.Windows.Forms.TabPage tabPageBMS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBMS;
        private System.Windows.Forms.TabPage tabPageMotor;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.FlowLayoutPanel panelNotification;
    }
}