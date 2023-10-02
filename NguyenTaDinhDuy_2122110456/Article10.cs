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
    public partial class Article10 : Form
    {
        decimal workingMemory  = 0;

        string opr = "";
  
        public Article10()
        {
            InitializeComponent();
        }
       

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text = (workingMemory+secondValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (workingMemory * secondValue).ToString();
  
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }
        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void dc_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += dc.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}
