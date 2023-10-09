using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace NguyenTaDinhDuy_2122110456
//{
//    public partial class DataGrid2 : Form
//    {
//        List<Employee> lst = new List<Employee>();
//        private void DataGrid2_Load(object senser,EventArgs e)
//        {
//            lst = GetData();
//            foreach (Employee em in lst)
//            {
//                dgvEmployee.Rows.Add(em.Id,em.Name,em.Age);

//            }
//        }
//        public DataGrid2()
//        {
//            InitializeComponent();
//        }

//        private void btNew_Click(object sender, EventArgs e)
//        {
//            Employee em = new Employee();
//            em.Id = tbId.Text;
//            em.Name=tbName.Text;
//            em.Age=tbAge.Text;
//            em.Gender=ckGender.Checked;
//            lst.Add(em);
//            dgvEmployee.Rows.Add(tbId.Text,tbName.Text,tbAge.Text,ckGender.Checked);

//        }

//        private void btDelete_Click(object sender, EventArgs e)
//        {
//            int idx = dgvEmployee.CurrentCell.RowIndex;
//            lst.RemoveAt(idx);
//            dgvEmployee.Rows.RemoveAt(idx);
//        }

//        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int idx = e.RowIndex;
//            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
//            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
//            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
//            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
//        }
//    }
//    public List<Employee> GetData()
//    {
//        List<Employee> lst = new List<Employee>();
//        Employee em = new Employee();
//        em.Id = "44444";
//        em.Name = "Tran Tien";
//        em.Age = "20";
//        lst.Add(em);

//        em = new Employee();
//        em.Id = "33234";
//        em.Name = "Nguyen Cuong";
//        em.Age = "25";
//        lst.Add(em);

//        em = new Employee();
//        em.Id = "25532";
//        em.Name = "Nguyen Hao";
//        em.Age = "23";
//        lst.Add(em);

//        return lst;

//    }
//}
namespace NguyenTaDinhDuy_2122110456
{
    public partial class DataGrid2 : Form
    {
        List<Employee> lst = new List<Employee>();

        private void DataGrid2_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        public DataGrid2()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = Convert.ToInt32(tbAge.Text); // Assuming Age is an integer
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "44444";
            em.Name = "Tran Tien";
            em.Age = 20; // Assuming Age is an integer
            lst.Add(em);

            em = new Employee();
            em.Id = "33234";
            em.Name = "Nguyen Cuong";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "25532";
            em.Name = "Nguyen Hao";
            em.Age = 23;
            lst.Add(em);

            return lst;
        }
    }

    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}
