using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTaDinhDuy_2122110456
{
    public partial class Timer : Form
    {
        int second=0;
        public Timer()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            lbDisplay.Text = second.ToString();
        }
    }
}
