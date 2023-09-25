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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1= new Form1();
            frm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Caculator cal = new Caculator();
            cal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arcticle07 art07 = new Arcticle07();
                art07.ShowDialog();
        }
    }
}
