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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Arctical08 art08 = new Arctical08();    
        //        art08.ShowDialog();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            Article10 art10 = new Article10();
            art10.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Article11 art11 = new Article11();      
            art11.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ComboBox combo = new ComboBox();
            combo.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Article14 art14 = new Article14();
            art14.ShowDialog();
        }
    }
}
