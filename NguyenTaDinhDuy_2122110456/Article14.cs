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
    public partial class Article14 : Form
    {
        public Article14()
        {
            InitializeComponent();
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true;
            }
            else
            {
                tbDiscount.Enabled=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if(rbMale.Checked == true)
            {
                msg += "Ong ";
            }
            if (rbMale.Checked == true)
            {
                msg += "Ba ";
            }
            if (ckDiscount.Checked == true)
                disc = 5;
            tbResult.Text = msg+ tbName.Text + " duoc giam "+ disc.ToString()+"%"+ "\r\n";  
        }
    }
}
