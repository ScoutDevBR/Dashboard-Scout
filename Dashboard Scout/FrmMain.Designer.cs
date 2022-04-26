namespace Dashboard_Scout
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnPerformance = new System.Windows.Forms.Button();
            this.BtnDevices = new System.Windows.Forms.Button();
            this.BtnNetwork = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMyPlanner = new System.Windows.Forms.Button();
            this.BtnCommunication = new System.Windows.Forms.Button();
            this.BtnMusicPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 127);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ScoutBR_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard_Scout.Properties.Resources.Avatar_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnHome.Image = global::Dashboard_Scout.Properties.Resources.Novo_Projeto__13_;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHome.Location = new System.Drawing.Point(0, 127);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnHome.Size = new System.Drawing.Size(172, 46);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.Leave += new System.EventHandler(this.BtnHome_Leave);
            // 
            // BtnPerformance
            // 
            this.BtnPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPerformance.FlatAppearance.BorderSize = 0;
            this.BtnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPerformance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnPerformance.Image = global::Dashboard_Scout.Properties.Resources.Novo_Projeto__16_;
            this.BtnPerformance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPerformance.Location = new System.Drawing.Point(0, 173);
            this.BtnPerformance.Name = "BtnPerformance";
            this.BtnPerformance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPerformance.Size = new System.Drawing.Size(172, 46);
            this.BtnPerformance.TabIndex = 7;
            this.BtnPerformance.Text = "Performance";
            this.BtnPerformance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPerformance.UseVisualStyleBackColor = true;
            this.BtnPerformance.Click += new System.EventHandler(this.BtnPerformance_Click);
            this.BtnPerformance.Leave += new System.EventHandler(this.BtnPerformance_Leave);
            // 
            // BtnDevices
            // 
            this.BtnDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDevices.FlatAppearance.BorderSize = 0;
            this.BtnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnDevices.Image = global::Dashboard_Scout.Properties.Resources.devices;
            this.BtnDevices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDevices.Location = new System.Drawing.Point(0, 219);
            this.BtnDevices.Name = "BtnDevices";
            this.BtnDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDevices.Size = new System.Drawing.Size(172, 46);
            this.BtnDevices.TabIndex = 8;
            this.BtnDevices.Text = "Devices";
            this.BtnDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDevices.UseVisualStyleBackColor = true;
            this.BtnDevices.Click += new System.EventHandler(this.BtnDevices_Click);
            this.BtnDevices.Leave += new System.EventHandler(this.BtnDevices_Leave);
            // 
            // BtnNetwork
            // 
            this.BtnNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNetwork.FlatAppearance.BorderSize = 0;
            this.BtnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNetwork.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("BtnNetwork.Image")));
            this.BtnNetwork.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNetwork.Location = new System.Drawing.Point(0, 265);
            this.BtnNetwork.Name = "BtnNetwork";
            this.BtnNetwork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNetwork.Size = new System.Drawing.Size(172, 46);
            this.BtnNetwork.TabIndex = 9;
            this.BtnNetwork.Text = "Network ";
            this.BtnNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNetwork.UseVisualStyleBackColor = true;
            this.BtnNetwork.Click += new System.EventHandler(this.BtnNetwork_Click);
            this.BtnNetwork.Leave += new System.EventHandler(this.BtNetwork_Leave);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnSettings.Image = global::Dashboard_Scout.Properties.Resources.Novo_Projeto__17_;
            this.BtnSettings.Location = new System.Drawing.Point(0, 674);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSettings.Size = new System.Drawing.Size(172, 46);
            this.BtnSettings.TabIndex = 10;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.Leave += new System.EventHandler(this.BtnSettings_leave);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 169);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(163)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.BtnMyPlanner);
            this.panel1.Controls.Add(this.BtnCommunication);
            this.panel1.Controls.Add(this.BtnMusicPlayer);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnNetwork);
            this.panel1.Controls.Add(this.BtnDevices);
            this.panel1.Controls.Add(this.BtnPerformance);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnMyPlanner
            // 
            this.BtnMyPlanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMyPlanner.FlatAppearance.BorderSize = 0;
            this.BtnMyPlanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyPlanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMyPlanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnMyPlanner.Image = ((System.Drawing.Image)(resources.GetObject("BtnMyPlanner.Image")));
            this.BtnMyPlanner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMyPlanner.Location = new System.Drawing.Point(0, 403);
            this.BtnMyPlanner.Name = "BtnMyPlanner";
            this.BtnMyPlanner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMyPlanner.Size = new System.Drawing.Size(172, 46);
            this.BtnMyPlanner.TabIndex = 14;
            this.BtnMyPlanner.Text = "My Planner";
            this.BtnMyPlanner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMyPlanner.UseVisualStyleBackColor = true;
            this.BtnMyPlanner.Click += new System.EventHandler(this.BtnMyPlanner_Click);
            this.BtnMyPlanner.Leave += new System.EventHandler(this.BtnMyPlanner_Leave);
            // 
            // BtnCommunication
            // 
            this.BtnCommunication.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCommunication.FlatAppearance.BorderSize = 0;
            this.BtnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommunication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCommunication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnCommunication.Image = ((System.Drawing.Image)(resources.GetObject("BtnCommunication.Image")));
            this.BtnCommunication.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCommunication.Location = new System.Drawing.Point(0, 357);
            this.BtnCommunication.Name = "BtnCommunication";
            this.BtnCommunication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCommunication.Size = new System.Drawing.Size(172, 46);
            this.BtnCommunication.TabIndex = 13;
            this.BtnCommunication.Text = "Communication";
            this.BtnCommunication.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCommunication.UseVisualStyleBackColor = true;
            this.BtnCommunication.Click += new System.EventHandler(this.BtnCommunication_Click);
            this.BtnCommunication.Leave += new System.EventHandler(this.BtnCommunication_Leave);
            // 
            // BtnMusicPlayer
            // 
            this.BtnMusicPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMusicPlayer.FlatAppearance.BorderSize = 0;
            this.BtnMusicPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusicPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMusicPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.BtnMusicPlayer.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusicPlayer.Image")));
            this.BtnMusicPlayer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMusicPlayer.Location = new System.Drawing.Point(0, 311);
            this.BtnMusicPlayer.Name = "BtnMusicPlayer";
            this.BtnMusicPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMusicPlayer.Size = new System.Drawing.Size(172, 46);
            this.BtnMusicPlayer.TabIndex = 12;
            this.BtnMusicPlayer.Text = "Music Player";
            this.BtnMusicPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMusicPlayer.UseVisualStyleBackColor = true;
            this.BtnMusicPlayer.Click += new System.EventHandler(this.BtnMusicPlayer_Click);
            this.BtnMusicPlayer.Leave += new System.EventHandler(this.BtnMusicPlayer_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.lblTitle.Location = new System.Drawing.Point(189, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Principal Information";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(163)))), ((int)(((byte)(162)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(706, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search for Something..\r\n.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1027, 50);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(25, 25);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.White;
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(172, 127);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(908, 593);
            this.PnlFormLoader.TabIndex = 4;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnHome;
        private Button BtnPerformance;
        private Button BtnDevices;
        private Button BtnNetwork;
        private Button BtnSettings;
        private Panel PnlNav;
        private Panel panel1;
        private Label lblTitle;
        private TextBox textBox1;
        private Button BtnExit;
        private Panel PnlFormLoader;
        private Button BtnMyPlanner;
        private Button BtnCommunication;
        private Button BtnMusicPlayer;
    }
}