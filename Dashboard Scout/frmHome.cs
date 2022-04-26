using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Scout
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour1.Text = DateTime.Now.ToLongTimeString();
            Date1.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Hour1_Click(object sender, EventArgs e)
        {

        }
    }
}
