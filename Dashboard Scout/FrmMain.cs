using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard_Scout
{
    public partial class FrmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundReactRgn
 (
 int nLeftRect,
 int nToptRect,
 int nRightRect,
 int nBottomRect,
 int nWidthEllipse,
 int nHeightEliipse
 );


        public FrmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundReactRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnHome.Height;
            PnlNav.Top = BtnHome.Top;
            PnlNav.Left = BtnHome.Left;
            BtnHome.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Principal Information";
            this.PnlFormLoader.Controls.Clear();
            frmHome FrmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)	//Home
        {
            PnlNav.Height = BtnHome.Height;
            PnlNav.Top = BtnHome.Top;
            PnlNav.Left = BtnHome.Left;
            BtnHome.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Principal Information";
            this.PnlFormLoader.Controls.Clear();
            frmHome FrmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }

        private void BtnHome_Leave(object sender, EventArgs e)
        {
            BtnHome.BackColor = Color.FromArgb(0, 54, 46);
        }


        private void BtnPerformance_Click(object sender, EventArgs e)	//Performance
        {
            PnlNav.Height = BtnPerformance.Height;
            PnlNav.Top = BtnPerformance.Top;
            PnlNav.Left = BtnPerformance.Left;
            BtnPerformance.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Performance";
            this.PnlFormLoader.Controls.Clear();
            FrmPerformance FrmHome_Vrb = new FrmPerformance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtnPerformance_Leave(object sender, EventArgs e)
        {
            BtnPerformance.BackColor = Color.FromArgb(0, 54, 46);
        }

        private void BtnDevices_Click(object sender, EventArgs e)	//Devices
        {
            PnlNav.Height = BtnDevices.Height;
            PnlNav.Top = BtnDevices.Top;
            PnlNav.Left = BtnDevices.Left;
            BtnDevices.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Devices";
            this.PnlFormLoader.Controls.Clear();
            FrmDevices FrmHome_Vrb = new FrmDevices() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtnDevices_Leave(object sender, EventArgs e)
        {
            BtnDevices.BackColor = Color.FromArgb(0, 54, 46);
        }

        private void BtnNetwork_Click(object sender, EventArgs e)	//Network
        {
            PnlNav.Height = BtnNetwork.Height;
            PnlNav.Top = BtnNetwork.Top;
            PnlNav.Left = BtnNetwork.Left;
            BtnNetwork.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Network connect";
            this.PnlFormLoader.Controls.Clear();
            FrmNetwork FrmHome_Vrb = new FrmNetwork() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtNetwork_Leave(object sender, EventArgs e)
        {
            BtnNetwork.BackColor = Color.FromArgb(0, 54, 46);
        }


        private void BtnMusicPlayer_Click(object sender, EventArgs e)	//Music Player
        {
            PnlNav.Height = BtnMusicPlayer.Height;
            PnlNav.Top = BtnMusicPlayer.Top;
            PnlNav.Left = BtnMusicPlayer.Left;
            BtnMusicPlayer.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Music Player";
            this.PnlFormLoader.Controls.Clear();
            FrmMusicPlayer FrmHome_Vrb = new FrmMusicPlayer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtnMusicPlayer_Leave(object sender, EventArgs e)
        {
            BtnMusicPlayer.BackColor = Color.FromArgb(0, 54, 46);
        }


        private void BtnCommunication_Click(object sender, EventArgs e)	//Communication
        {
            PnlNav.Height = BtnCommunication.Height;
            PnlNav.Top = BtnCommunication.Top;
            PnlNav.Left = BtnCommunication.Left;
            BtnCommunication.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Communication";
            this.PnlFormLoader.Controls.Clear();
            FrmCommunication FrmHome_Vrb = new FrmCommunication() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtnCommunication_Leave(object sender, EventArgs e)
        {
            BtnCommunication.BackColor = Color.FromArgb(0, 54, 46);
        }

        private void BtnMyPlanner_Click(object sender, EventArgs e)	//My Planner
        {
            PnlNav.Height = BtnMyPlanner.Height;
            PnlNav.Top = BtnMyPlanner.Top;
            PnlNav.Left = BtnMyPlanner.Left;
            BtnMyPlanner.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "My Planner";
            this.PnlFormLoader.Controls.Clear();
            FrmMyPlanner FrmHome_Vrb = new FrmMyPlanner() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
        private void BtnMyPlanner_Leave(object sender, EventArgs e)
        {
            BtnMyPlanner.BackColor = Color.FromArgb(0, 54, 46);
        }


        private void BtnSettings_Click(object sender, EventArgs e)	//Settings
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            PnlNav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(50, 100, 100);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            FrmSettings FrmHome_Vrb = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }
            private void BtnSettings_leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(0, 54, 46);
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}