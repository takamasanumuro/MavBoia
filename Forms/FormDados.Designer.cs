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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelInstrumentation = new System.Windows.Forms.Label();
            this.tableLayoutPanelInstrumentation = new System.Windows.Forms.TableLayoutPanel();
            this.labelIrradiance = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelMpptCurrent = new System.Windows.Forms.Label();
            this.labelMotorCurrentRight = new System.Windows.Forms.Label();
            this.labelMotorCurrentLeft = new System.Windows.Forms.Label();
            this.labelBatteryVoltage = new System.Windows.Forms.Label();
            this.tableLayoutPanelTemp = new System.Windows.Forms.TableLayoutPanel();
            this.labelMpptTemp = new System.Windows.Forms.Label();
            this.labelBatteryRightTemp = new System.Windows.Forms.Label();
            this.labelBatteryLeftTemp = new System.Windows.Forms.Label();
            this.tableLayoutPanelRpm = new System.Windows.Forms.TableLayoutPanel();
            this.labelRpmRight = new System.Windows.Forms.Label();
            this.labelRpmLeft = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelInstrumentation.SuspendLayout();
            this.tableLayoutPanelTemp.SuspendLayout();
            this.tableLayoutPanelRpm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(130, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 520);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.29717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.90793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70374F));
            this.tableLayoutPanel1.Controls.Add(this.labelRPM, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTemperature, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInstrumentation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelInstrumentation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelTemp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelRpm, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.61539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRPM.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelRPM.Location = new System.Drawing.Point(737, 0);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(237, 53);
            this.labelRPM.TabIndex = 2;
            this.labelRPM.Text = "RPM";
            this.labelRPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTemperature.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelTemperature.Location = new System.Drawing.Point(416, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(315, 53);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "Temperatura";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInstrumentation
            // 
            this.labelInstrumentation.AutoSize = true;
            this.labelInstrumentation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInstrumentation.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelInstrumentation.Location = new System.Drawing.Point(3, 0);
            this.labelInstrumentation.Name = "labelInstrumentation";
            this.labelInstrumentation.Size = new System.Drawing.Size(407, 53);
            this.labelInstrumentation.TabIndex = 0;
            this.labelInstrumentation.Text = "Instrumentação";
            this.labelInstrumentation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelInstrumentation
            // 
            this.tableLayoutPanelInstrumentation.ColumnCount = 1;
            this.tableLayoutPanelInstrumentation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelIrradiance, 0, 5);
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelVelocity, 0, 4);
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelMpptCurrent, 0, 3);
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelMotorCurrentRight, 0, 2);
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelMotorCurrentLeft, 0, 1);
            this.tableLayoutPanelInstrumentation.Controls.Add(this.labelBatteryVoltage, 0, 0);
            this.tableLayoutPanelInstrumentation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInstrumentation.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanelInstrumentation.Name = "tableLayoutPanelInstrumentation";
            this.tableLayoutPanelInstrumentation.RowCount = 6;
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelInstrumentation.Size = new System.Drawing.Size(407, 461);
            this.tableLayoutPanelInstrumentation.TabIndex = 6;
            // 
            // labelIrradiance
            // 
            this.labelIrradiance.AutoSize = true;
            this.labelIrradiance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIrradiance.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIrradiance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelIrradiance.Location = new System.Drawing.Point(3, 380);
            this.labelIrradiance.Name = "labelIrradiance";
            this.labelIrradiance.Size = new System.Drawing.Size(401, 81);
            this.labelIrradiance.TabIndex = 5;
            this.labelIrradiance.Text = "Aguardando...";
            this.labelIrradiance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVelocity.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelVelocity.Location = new System.Drawing.Point(3, 304);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(401, 76);
            this.labelVelocity.TabIndex = 4;
            this.labelVelocity.Text = "Aguardando...";
            this.labelVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMpptCurrent
            // 
            this.labelMpptCurrent.AutoSize = true;
            this.labelMpptCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMpptCurrent.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMpptCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelMpptCurrent.Location = new System.Drawing.Point(3, 228);
            this.labelMpptCurrent.Name = "labelMpptCurrent";
            this.labelMpptCurrent.Size = new System.Drawing.Size(401, 76);
            this.labelMpptCurrent.TabIndex = 3;
            this.labelMpptCurrent.Text = "Aguardando...";
            this.labelMpptCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMotorCurrentRight
            // 
            this.labelMotorCurrentRight.AutoSize = true;
            this.labelMotorCurrentRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMotorCurrentRight.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorCurrentRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelMotorCurrentRight.Location = new System.Drawing.Point(3, 152);
            this.labelMotorCurrentRight.Name = "labelMotorCurrentRight";
            this.labelMotorCurrentRight.Size = new System.Drawing.Size(401, 76);
            this.labelMotorCurrentRight.TabIndex = 2;
            this.labelMotorCurrentRight.Text = "Aguardando...";
            this.labelMotorCurrentRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMotorCurrentLeft
            // 
            this.labelMotorCurrentLeft.AutoSize = true;
            this.labelMotorCurrentLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMotorCurrentLeft.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorCurrentLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelMotorCurrentLeft.Location = new System.Drawing.Point(3, 76);
            this.labelMotorCurrentLeft.Name = "labelMotorCurrentLeft";
            this.labelMotorCurrentLeft.Size = new System.Drawing.Size(401, 76);
            this.labelMotorCurrentLeft.TabIndex = 1;
            this.labelMotorCurrentLeft.Text = "Aguardando...";
            this.labelMotorCurrentLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBatteryVoltage
            // 
            this.labelBatteryVoltage.AutoSize = true;
            this.labelBatteryVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatteryVoltage.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelBatteryVoltage.Location = new System.Drawing.Point(3, 0);
            this.labelBatteryVoltage.Name = "labelBatteryVoltage";
            this.labelBatteryVoltage.Size = new System.Drawing.Size(401, 76);
            this.labelBatteryVoltage.TabIndex = 0;
            this.labelBatteryVoltage.Text = "Aguardando...";
            this.labelBatteryVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelTemp
            // 
            this.tableLayoutPanelTemp.ColumnCount = 1;
            this.tableLayoutPanelTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTemp.Controls.Add(this.labelMpptTemp, 0, 2);
            this.tableLayoutPanelTemp.Controls.Add(this.labelBatteryRightTemp, 0, 1);
            this.tableLayoutPanelTemp.Controls.Add(this.labelBatteryLeftTemp, 0, 0);
            this.tableLayoutPanelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTemp.Location = new System.Drawing.Point(416, 56);
            this.tableLayoutPanelTemp.Name = "tableLayoutPanelTemp";
            this.tableLayoutPanelTemp.RowCount = 3;
            this.tableLayoutPanelTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTemp.Size = new System.Drawing.Size(315, 461);
            this.tableLayoutPanelTemp.TabIndex = 7;
            // 
            // labelMpptTemp
            // 
            this.labelMpptTemp.AutoSize = true;
            this.labelMpptTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMpptTemp.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMpptTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelMpptTemp.Location = new System.Drawing.Point(3, 306);
            this.labelMpptTemp.Name = "labelMpptTemp";
            this.labelMpptTemp.Size = new System.Drawing.Size(309, 155);
            this.labelMpptTemp.TabIndex = 3;
            this.labelMpptTemp.Text = "Aguardando...";
            this.labelMpptTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBatteryRightTemp
            // 
            this.labelBatteryRightTemp.AutoSize = true;
            this.labelBatteryRightTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatteryRightTemp.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryRightTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelBatteryRightTemp.Location = new System.Drawing.Point(3, 153);
            this.labelBatteryRightTemp.Name = "labelBatteryRightTemp";
            this.labelBatteryRightTemp.Size = new System.Drawing.Size(309, 153);
            this.labelBatteryRightTemp.TabIndex = 2;
            this.labelBatteryRightTemp.Text = "Aguardando...";
            this.labelBatteryRightTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBatteryLeftTemp
            // 
            this.labelBatteryLeftTemp.AutoSize = true;
            this.labelBatteryLeftTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatteryLeftTemp.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryLeftTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelBatteryLeftTemp.Location = new System.Drawing.Point(3, 0);
            this.labelBatteryLeftTemp.Name = "labelBatteryLeftTemp";
            this.labelBatteryLeftTemp.Size = new System.Drawing.Size(309, 153);
            this.labelBatteryLeftTemp.TabIndex = 1;
            this.labelBatteryLeftTemp.Text = "Aguardando...";
            this.labelBatteryLeftTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelRpm
            // 
            this.tableLayoutPanelRpm.ColumnCount = 1;
            this.tableLayoutPanelRpm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRpm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRpm.Controls.Add(this.labelRpmRight, 0, 1);
            this.tableLayoutPanelRpm.Controls.Add(this.labelRpmLeft, 0, 0);
            this.tableLayoutPanelRpm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRpm.Location = new System.Drawing.Point(737, 56);
            this.tableLayoutPanelRpm.Name = "tableLayoutPanelRpm";
            this.tableLayoutPanelRpm.RowCount = 2;
            this.tableLayoutPanelRpm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRpm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRpm.Size = new System.Drawing.Size(237, 461);
            this.tableLayoutPanelRpm.TabIndex = 8;
            // 
            // labelRpmRight
            // 
            this.labelRpmRight.AutoSize = true;
            this.labelRpmRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRpmRight.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRpmRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelRpmRight.Location = new System.Drawing.Point(3, 230);
            this.labelRpmRight.Name = "labelRpmRight";
            this.labelRpmRight.Size = new System.Drawing.Size(231, 231);
            this.labelRpmRight.TabIndex = 3;
            this.labelRpmRight.Text = "Aguardando...";
            this.labelRpmRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRpmLeft
            // 
            this.labelRpmLeft.AutoSize = true;
            this.labelRpmLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRpmLeft.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRpmLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelRpmLeft.Location = new System.Drawing.Point(3, 0);
            this.labelRpmLeft.Name = "labelRpmLeft";
            this.labelRpmLeft.Size = new System.Drawing.Size(231, 230);
            this.labelRpmLeft.TabIndex = 2;
            this.labelRpmLeft.Text = "Aguardando...";
            this.labelRpmLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1237, 720);
            this.Name = "FormDados";
            this.Padding = new System.Windows.Forms.Padding(130, 100, 130, 100);
            this.Text = "Dados";
            this.Resize += new System.EventHandler(this.FormDados_Resize);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelInstrumentation.ResumeLayout(false);
            this.tableLayoutPanelInstrumentation.PerformLayout();
            this.tableLayoutPanelTemp.ResumeLayout(false);
            this.tableLayoutPanelTemp.PerformLayout();
            this.tableLayoutPanelRpm.ResumeLayout(false);
            this.tableLayoutPanelRpm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInstrumentation;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInstrumentation;
        private System.Windows.Forms.Label labelBatteryVoltage;
        private System.Windows.Forms.Label labelIrradiance;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelMpptCurrent;
        private System.Windows.Forms.Label labelMotorCurrentRight;
        private System.Windows.Forms.Label labelMotorCurrentLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTemp;
        private System.Windows.Forms.Label labelMpptTemp;
        private System.Windows.Forms.Label labelBatteryRightTemp;
        private System.Windows.Forms.Label labelBatteryLeftTemp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRpm;
        private System.Windows.Forms.Label labelRpmRight;
        private System.Windows.Forms.Label labelRpmLeft;
    }
}