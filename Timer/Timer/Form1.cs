using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            //int sayac = 0;
            //while (true)
            //{
            //    sayac++;
            //    label1.Text = sayac.ToString();
            //    Application.DoEvents();
            //    Thread.Sleep(1000);
            //}
            timer1.Start();
            timer1.Enabled = true;
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
        }
    }
}
