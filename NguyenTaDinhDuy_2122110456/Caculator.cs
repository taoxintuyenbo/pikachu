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
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xVal = double.Parse(xValue.Text);
            double yVal = double.Parse(yValue.Text);
            double kq = xVal + yVal;
            caValue.Text = kq.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double xVal = double.Parse(xValue.Text);
            double yVal = double.Parse(yValue.Text);
            double kq=xVal*yVal;
            caValue.Text = kq.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
