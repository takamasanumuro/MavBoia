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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroundStation));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonRastreio = new System.Windows.Forms.Button();
            this.buttonGraficos = new System.Windows.Forms.Button();
            this.buttonDados = new System.Windows.Forms.Button();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.buttonConfigurações = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelButtonConnect = new System.Windows.Forms.Panel();
            this.buttonConnectNetwork = new CustomControls.RJControls.RJButton();
            this.buttonConnectRadio = new CustomControls.RJControls.RJButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelButtonConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLateral.Controls.Add(this.panelButtons);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.pictureBoxLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(341, 844);
            this.panelLateral.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonRastreio);
            this.panelButtons.Controls.Add(this.buttonGraficos);
            this.panelButtons.Controls.Add(this.buttonDados);
            this.panelButtons.Controls.Add(this.buttonMapa);
            this.panelButtons.Controls.Add(this.buttonConfigurações);
            this.panelButtons.Location = new System.Drawing.Point(0, 320);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(341, 481);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonRastreio
            // 
            this.buttonRastreio.FlatAppearance.BorderSize = 0;
            this.buttonRastreio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRastreio.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRastreio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonRastreio.Image = global::MavBoia.Properties.Resources.camera;
            this.buttonRastreio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRastreio.Location = new System.Drawing.Point(0, 51);
            this.buttonRastreio.Name = "buttonRastreio";
            this.buttonRastreio.Size = new System.Drawing.Size(341, 86);
            this.buttonRastreio.TabIndex = 4;
            this.buttonRastreio.Text = "Rastreio";
            this.buttonRastreio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRastreio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRastreio.UseVisualStyleBackColor = true;
            this.buttonRastreio.Click += new System.EventHandler(this.buttonRastreio_Click);
            // 
            // buttonGraficos
            // 
            this.buttonGraficos.FlatAppearance.BorderSize = 0;
            this.buttonGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraficos.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraficos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonGraficos.Image = global::MavBoia.Properties.Resources.charts;
            this.buttonGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGraficos.Location = new System.Drawing.Point(0, 137);
            this.buttonGraficos.Name = "buttonGraficos";
            this.buttonGraficos.Size = new System.Drawing.Size(341, 86);
            this.buttonGraficos.TabIndex = 3;
            this.buttonGraficos.Text = "Gráficos";
            this.buttonGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGraficos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGraficos.UseVisualStyleBackColor = true;
            this.buttonGraficos.Click += new System.EventHandler(this.buttonGraficos_Click);
            // 
            // buttonDados
            // 
            this.buttonDados.FlatAppearance.BorderSize = 0;
            this.buttonDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDados.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonDados.Image = global::MavBoia.Properties.Resources.diagram;
            this.buttonDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDados.Location = new System.Drawing.Point(0, 223);
            this.buttonDados.Name = "buttonDados";
            this.buttonDados.Size = new System.Drawing.Size(341, 86);
            this.buttonDados.TabIndex = 2;
            this.buttonDados.Text = "Dados";
            this.buttonDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDados.UseVisualStyleBackColor = true;
            this.buttonDados.Click += new System.EventHandler(this.buttonDados_Click);
            // 
            // buttonMapa
            // 
            this.buttonMapa.FlatAppearance.BorderSize = 0;
            this.buttonMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapa.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonMapa.Image = global::MavBoia.Properties.Resources.mapicon;
            this.buttonMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMapa.Location = new System.Drawing.Point(0, 309);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(341, 86);
            this.buttonMapa.TabIndex = 1;
            this.buttonMapa.Text = "Mapa";
            this.buttonMapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            // 
            // buttonConfigurações
            // 
            this.buttonConfigurações.FlatAppearance.BorderSize = 0;
            this.buttonConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurações.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigurações.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonConfigurações.Image = global::MavBoia.Properties.Resources.settings;
            this.buttonConfigurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfigurações.Location = new System.Drawing.Point(0, 395);
            this.buttonConfigurações.Name = "buttonConfigurações";
            this.buttonConfigurações.Size = new System.Drawing.Size(341, 86);
            this.buttonConfigurações.TabIndex = 0;
            this.buttonConfigurações.Text = "Configurações";
            this.buttonConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfigurações.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonConfigurações.UseVisualStyleBackColor = true;
            this.buttonConfigurações.Click += new System.EventHandler(this.buttonConfigurações_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 801);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 43);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(341, 124);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelControls.Controls.Add(this.lblTitle);
            this.panelControls.Controls.Add(this.panelButtonConnect);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(341, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1237, 124);
            this.panelControls.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.lblTitle.Location = new System.Drawing.Point(410, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(827, 124);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MavBoia";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonConnect
            // 
            this.panelButtonConnect.AutoScroll = true;
            this.panelButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelButtonConnect.Controls.Add(this.buttonConnectNetwork);
            this.panelButtonConnect.Controls.Add(this.buttonConnectRadio);
            this.panelButtonConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonConnect.Location = new System.Drawing.Point(0, 0);
            this.panelButtonConnect.Name = "panelButtonConnect";
            this.panelButtonConnect.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtonConnect.Size = new System.Drawing.Size(410, 124);
            this.panelButtonConnect.TabIndex = 1;
            // 
            // buttonConnectNetwork
            // 
            this.buttonConnectNetwork.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonConnectNetwork.AutoSize = true;
            this.buttonConnectNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonConnectNetwork.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonConnectNetwork.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConnectNetwork.BorderRadius = 20;
            this.buttonConnectNetwork.BorderSize = 0;
            this.buttonConnectNetwork.FlatAppearance.BorderSize = 0;
            this.buttonConnectNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectNetwork.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonConnectNetwork.Location = new System.Drawing.Point(222, 33);
            this.buttonConnectNetwork.Name = "buttonConnectNetwork";
            this.buttonConnectNetwork.Size = new System.Drawing.Size(168, 55);
            this.buttonConnectNetwork.TabIndex = 1;
            this.buttonConnectNetwork.Text = "Conectar rede";
            this.buttonConnectNetwork.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonConnectNetwork.UseVisualStyleBackColor = false;
            this.buttonConnectNetwork.Click += new System.EventHandler(this.buttonConnectNetwork_Click);
            // 
            // buttonConnectRadio
            // 
            this.buttonConnectRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConnectRadio.AutoSize = true;
            this.buttonConnectRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonConnectRadio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonConnectRadio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConnectRadio.BorderRadius = 20;
            this.buttonConnectRadio.BorderSize = 0;
            this.buttonConnectRadio.FlatAppearance.BorderSize = 0;
            this.buttonConnectRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectRadio.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonConnectRadio.Location = new System.Drawing.Point(20, 33);
            this.buttonConnectRadio.Name = "buttonConnectRadio";
            this.buttonConnectRadio.Size = new System.Drawing.Size(168, 55);
            this.buttonConnectRadio.TabIndex = 0;
            this.buttonConnectRadio.Text = "Conectar rádio";
            this.buttonConnectRadio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonConnectRadio.UseVisualStyleBackColor = false;
            this.buttonConnectRadio.Click += new System.EventHandler(this.buttonConnectRadio_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(341, 124);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1237, 720);
            this.panelDesktop.TabIndex = 2;
            // 
            // GroundStation
            // 
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "GroundStation";
            this.Text = "MavBoia";
            this.Load += new System.EventHandler(this.GroundStation_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelButtonConnect.ResumeLayout(false);
            this.panelButtonConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelButtonConnect;
        private CustomControls.RJControls.RJButton buttonConnectRadio;
        private CustomControls.RJControls.RJButton buttonConnectNetwork;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfigurações;
        private System.Windows.Forms.Button buttonMapa;
        private System.Windows.Forms.Button buttonGraficos;
        private System.Windows.Forms.Button buttonDados;
        private System.Windows.Forms.Button buttonRastreio;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

