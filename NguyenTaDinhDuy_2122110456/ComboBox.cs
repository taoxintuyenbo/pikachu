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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Ban da chon khoa thu: " + index.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Ban la sinh vien khoa: "+ item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}
