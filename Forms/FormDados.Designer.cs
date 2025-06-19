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
            this.tabControlNotifications = new System.Windows.Forms.TabControl();
            this.tabPageBMS = new System.Windows.Forms.TabPage();
            this.tabPageMotor = new System.Windows.Forms.TabPage();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.panelNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutBMS = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlNotifications.SuspendLayout();
            this.tabPageBMS.SuspendLayout();
            this.panelNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNotifications
            // 
            this.tabControlNotifications.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNotifications.Controls.Add(this.tabPageBMS);
            this.tabControlNotifications.Controls.Add(this.tabPageMotor);
            this.tabControlNotifications.Location = new System.Drawing.Point(31, 3);
            this.tabControlNotifications.Multiline = true;
            this.tabControlNotifications.Name = "tabControlNotifications";
            this.tabControlNotifications.SelectedIndex = 0;
            this.tabControlNotifications.Size = new System.Drawing.Size(359, 720);
            this.tabControlNotifications.TabIndex = 1;
            // 
            // tabPageBMS
            // 
            this.tabPageBMS.Controls.Add(this.flowLayoutBMS);
            this.tabPageBMS.Location = new System.Drawing.Point(4, 4);
            this.tabPageBMS.Name = "tabPageBMS";
            this.tabPageBMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBMS.Size = new System.Drawing.Size(327, 712);
            this.tabPageBMS.TabIndex = 0;
            this.tabPageBMS.Text = "BMS";
            this.tabPageBMS.UseVisualStyleBackColor = true;
            // 
            // tabPageMotor
            // 
            this.tabPageMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMotor.Location = new System.Drawing.Point(4, 4);
            this.tabPageMotor.Name = "tabPageMotor";
            this.tabPageMotor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMotor.Size = new System.Drawing.Size(327, 712);
            this.tabPageMotor.TabIndex = 1;
            this.tabPageMotor.Text = "Motor";
            this.tabPageMotor.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(3, 3);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(22, 713);
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
            this.panelNotification.Location = new System.Drawing.Point(843, 0);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(394, 720);
            this.panelNotification.TabIndex = 3;
            // 
            // flowLayoutBMS
            // 
            this.flowLayoutBMS.AutoScroll = true;
            this.flowLayoutBMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBMS.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutBMS.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutBMS.Name = "flowLayoutBMS";
            this.flowLayoutBMS.Size = new System.Drawing.Size(321, 706);
            this.flowLayoutBMS.TabIndex = 0;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1237, 720);
            this.Name = "FormDados";
            this.Text = "Dados";
            this.Load += new System.EventHandler(this.FormDados_Load);
            this.Resize += new System.EventHandler(this.FormDados_Resize);
            this.tabControlNotifications.ResumeLayout(false);
            this.tabPageBMS.ResumeLayout(false);
            this.panelNotification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlNotifications;
        private System.Windows.Forms.TabPage tabPageBMS;
        private System.Windows.Forms.TabPage tabPageMotor;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.FlowLayoutPanel panelNotification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBMS;
    }
}