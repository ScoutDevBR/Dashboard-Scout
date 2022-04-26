using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dashboard_Scout
{
    public partial class FrmProcessor : Form
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Informações do Processador", "% Tempo do Processador", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memoria", "MBytes disponíveis");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("Sistema", "Tempo de atividade do sistema");

        public FrmProcessor()
        {
            InitializeComponent();
        }

        private void FrmProcessor_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_txt1.Text = "CPU:" + "  " + (int)perfCPUCounter.NextValue() + "  " + "%";
            lbl_txt2.Text = "Available Memory:" + "  " + (int)perfMemCounter.NextValue() + "  " + "MB";
            lbl_txt3.Text = "System Up Time:" + "  " + (int)perfSystemCounter.NextValue() / 60 / 60 + "Hours";
        }
    }
}
