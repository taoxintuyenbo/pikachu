using System;
using System.Collections;
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
    public partial class DataGrid : Form
    {
        //ArrayList lstEm

        public DataGrid()
        {
            InitializeComponent();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
