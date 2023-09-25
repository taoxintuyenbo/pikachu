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
    public partial class Arcticle07 : Form
    {
        public Arcticle07()
        {
            InitializeComponent();
        }
        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char .IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbYear_Validating(object sender, CancelEventArgs e) {
            int year = int.Parse(tbYear.Text);
            if(year>2000)
                e.Cancel = true;
                }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
