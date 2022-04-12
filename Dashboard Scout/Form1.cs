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
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundReactRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(41, 73, 42);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(41, 73, 42);


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            BtnAnalytics.BackColor = Color.FromArgb(41, 73, 42);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalender_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCalender.Height;
            PnlNav.Top = BtnCalender.Top;
            BtnCalender.BackColor = Color.FromArgb(41, 73, 42);
        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnContactUs.Height;
            PnlNav.Top = BtnContactUs.Top;
            BtnContactUs.BackColor = Color.FromArgb(41, 73, 42);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(41, 73, 42);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 54, 25);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 54, 25);
        }

        private void BtnCalender_Leave(object sender, EventArgs e)
        {
            BtnCalender.BackColor = Color.FromArgb(24, 54, 25);
        }

        private void BtnContactUs_Leave(object sender, EventArgs e)
        {
            BtnContactUs.BackColor = Color.FromArgb(24, 54, 25);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 54, 25);
        }
    }
}