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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelSecondaryFormLoader = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.buttonConnect = new CustomControls.RJControls.RJButton();
            this.labelTitleSelection = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHTTPConnect = new CustomControls.RJControls.RJButton();
            this.buttonRastreio = new System.Windows.Forms.Button();
            this.buttonGraficos = new System.Windows.Forms.Button();
            this.buttonDados = new System.Windows.Forms.Button();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.buttonConfigurações = new System.Windows.Forms.Button();
            this.pictureBoxArariboia = new System.Windows.Forms.PictureBox();
            this.mavlinkheartbeattBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLateral.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArariboia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLateral.Controls.Add(this.panelSecondaryFormLoader);
            this.panelLateral.Controls.Add(this.buttonRastreio);
            this.panelLateral.Controls.Add(this.buttonGraficos);
            this.panelLateral.Controls.Add(this.buttonDados);
            this.panelLateral.Controls.Add(this.buttonMapa);
            this.panelLateral.Controls.Add(this.panelNav);
            this.panelLateral.Controls.Add(this.buttonConfigurações);
            this.panelLateral.Controls.Add(this.panelTopLeft);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(228, 597);
            this.panelLateral.TabIndex = 9;
            this.panelLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown_Drag);
            this.panelLateral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove_Drag);
            // 
            // panelSecondaryFormLoader
            // 
            this.panelSecondaryFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecondaryFormLoader.Location = new System.Drawing.Point(0, 119);
            this.panelSecondaryFormLoader.Name = "panelSecondaryFormLoader";
            this.panelSecondaryFormLoader.Size = new System.Drawing.Size(228, 203);
            this.panelSecondaryFormLoader.TabIndex = 14;
            this.panelSecondaryFormLoader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelSecondaryFormLoader_MouseDoubleClick);
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
            this.panelTopLeft.Controls.Add(this.panelTopRight);
            this.panelTopLeft.Controls.Add(this.pictureBoxArariboia);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(228, 119);
            this.panelTopLeft.TabIndex = 7;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Location = new System.Drawing.Point(255, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(910, 113);
            this.panelTopRight.TabIndex = 17;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(228, 117);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(937, 480);
            this.panelFormLoader.TabIndex = 11;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConnect.BorderRadius = 10;
            this.buttonConnect.BorderSize = 0;
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Coral;
            this.buttonConnect.Location = new System.Drawing.Point(446, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(137, 31);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Ligar rádio";
            this.buttonConnect.TextColor = System.Drawing.Color.Coral;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelTitleSelection
            // 
            this.labelTitleSelection.AutoSize = true;
            this.labelTitleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSelection.ForeColor = System.Drawing.Color.Coral;
            this.labelTitleSelection.Location = new System.Drawing.Point(271, 73);
            this.labelTitleSelection.Name = "labelTitleSelection";
            this.labelTitleSelection.Size = new System.Drawing.Size(101, 32);
            this.labelTitleSelection.TabIndex = 15;
            this.labelTitleSelection.Text = "Dados";
            this.labelTitleSelection.Click += new System.EventHandler(this.labelTitleSelection_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // buttonHTTPConnect
            // 
            this.buttonHTTPConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonHTTPConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonHTTPConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonHTTPConnect.BorderRadius = 10;
            this.buttonHTTPConnect.BorderSize = 0;
            this.buttonHTTPConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHTTPConnect.FlatAppearance.BorderSize = 0;
            this.buttonHTTPConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHTTPConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHTTPConnect.ForeColor = System.Drawing.Color.Coral;
            this.buttonHTTPConnect.Location = new System.Drawing.Point(607, 6);
            this.buttonHTTPConnect.Name = "buttonHTTPConnect";
            this.buttonHTTPConnect.Size = new System.Drawing.Size(155, 31);
            this.buttonHTTPConnect.TabIndex = 18;
            this.buttonHTTPConnect.Text = "Ligar rede";
            this.buttonHTTPConnect.TextColor = System.Drawing.Color.Coral;
            this.buttonHTTPConnect.UseVisualStyleBackColor = false;
            this.buttonHTTPConnect.Click += new System.EventHandler(this.buttonHTTPConnect_Click);
            // 
            // buttonRastreio
            // 
            this.buttonRastreio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRastreio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRastreio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRastreio.FlatAppearance.BorderSize = 0;
            this.buttonRastreio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRastreio.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRastreio.ForeColor = System.Drawing.Color.Coral;
            this.buttonRastreio.Image = ((System.Drawing.Image)(resources.GetObject("buttonRastreio.Image")));
            this.buttonRastreio.Location = new System.Drawing.Point(0, 322);
            this.buttonRastreio.Name = "buttonRastreio";
            this.buttonRastreio.Size = new System.Drawing.Size(228, 55);
            this.buttonRastreio.TabIndex = 13;
            this.buttonRastreio.Text = "          Rastreio  ";
            this.buttonRastreio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRastreio.UseVisualStyleBackColor = true;
            this.buttonRastreio.Click += new System.EventHandler(this.buttonRastreio_Click);
            this.buttonRastreio.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonRastreio_DragDrop);
            // 
            // buttonGraficos
            // 
            this.buttonGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraficos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGraficos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonGraficos.FlatAppearance.BorderSize = 0;
            this.buttonGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraficos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraficos.ForeColor = System.Drawing.Color.Coral;
            this.buttonGraficos.Image = ((System.Drawing.Image)(resources.GetObject("buttonGraficos.Image")));
            this.buttonGraficos.Location = new System.Drawing.Point(0, 377);
            this.buttonGraficos.Name = "buttonGraficos";
            this.buttonGraficos.Size = new System.Drawing.Size(228, 55);
            this.buttonGraficos.TabIndex = 12;
            this.buttonGraficos.Text = "          Graficos  ";
            this.buttonGraficos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGraficos.UseVisualStyleBackColor = true;
            this.buttonGraficos.Click += new System.EventHandler(this.buttonGraficos_Click);
            this.buttonGraficos.Leave += new System.EventHandler(this.button_Leave);
            // 
            // buttonDados
            // 
            this.buttonDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDados.FlatAppearance.BorderSize = 0;
            this.buttonDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDados.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDados.ForeColor = System.Drawing.Color.Coral;
            this.buttonDados.Image = ((System.Drawing.Image)(resources.GetObject("buttonDados.Image")));
            this.buttonDados.Location = new System.Drawing.Point(0, 432);
            this.buttonDados.Name = "buttonDados";
            this.buttonDados.Size = new System.Drawing.Size(228, 55);
            this.buttonDados.TabIndex = 10;
            this.buttonDados.Text = "            Dados  ";
            this.buttonDados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDados.UseVisualStyleBackColor = true;
            this.buttonDados.Click += new System.EventHandler(this.buttonDados_Click);
            this.buttonDados.Leave += new System.EventHandler(this.button_Leave);
            // 
            // buttonMapa
            // 
            this.buttonMapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMapa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMapa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMapa.FlatAppearance.BorderSize = 0;
            this.buttonMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapa.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMapa.ForeColor = System.Drawing.Color.Coral;
            this.buttonMapa.Image = ((System.Drawing.Image)(resources.GetObject("buttonMapa.Image")));
            this.buttonMapa.Location = new System.Drawing.Point(0, 487);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(228, 55);
            this.buttonMapa.TabIndex = 11;
            this.buttonMapa.Text = "            Mapa  ";
            this.buttonMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            this.buttonMapa.Leave += new System.EventHandler(this.button_Leave);
            // 
            // buttonConfigurações
            // 
            this.buttonConfigurações.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfigurações.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfigurações.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConfigurações.FlatAppearance.BorderSize = 0;
            this.buttonConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigurações.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigurações.ForeColor = System.Drawing.Color.Coral;
            this.buttonConfigurações.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfigurações.Image")));
            this.buttonConfigurações.Location = new System.Drawing.Point(0, 542);
            this.buttonConfigurações.Name = "buttonConfigurações";
            this.buttonConfigurações.Size = new System.Drawing.Size(228, 55);
            this.buttonConfigurações.TabIndex = 8;
            this.buttonConfigurações.Text = "Configurações";
            this.buttonConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfigurações.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonConfigurações.UseVisualStyleBackColor = true;
            this.buttonConfigurações.Click += new System.EventHandler(this.buttonConfigurações_Click);
            this.buttonConfigurações.Leave += new System.EventHandler(this.button_Leave);
            // 
            // pictureBoxArariboia
            // 
            this.pictureBoxArariboia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxArariboia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArariboia.Image")));
            this.pictureBoxArariboia.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxArariboia.Name = "pictureBoxArariboia";
            this.pictureBoxArariboia.Size = new System.Drawing.Size(228, 119);
            this.pictureBoxArariboia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArariboia.TabIndex = 0;
            this.pictureBoxArariboia.TabStop = false;
            this.pictureBoxArariboia.DoubleClick += new System.EventHandler(this.pictureBoxArariboia_DoubleClick);
            this.pictureBoxArariboia.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxArariboia_MouseDoubleClick);
            this.pictureBoxArariboia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown_Drag);
            this.pictureBoxArariboia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove_Drag);
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
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonHTTPConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroundStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.GroundStation_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArariboia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkheartbeattBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.BindingSource mavlinkheartbeattBindingSource;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button buttonConfigurações;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDados;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Button buttonMapa;
        private System.Windows.Forms.Label labelTitleSelection;
        private System.Windows.Forms.Button buttonGraficos;
        private System.Windows.Forms.Button buttonRastreio;
        private CustomControls.RJControls.RJButton buttonHTTPConnect;
        private System.Windows.Forms.Panel panelSecondaryFormLoader;
        internal CustomControls.RJControls.RJButton buttonConnect;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.PictureBox pictureBoxArariboia;
    }
}

