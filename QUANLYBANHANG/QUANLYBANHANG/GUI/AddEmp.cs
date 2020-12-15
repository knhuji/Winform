using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.BLL;
using QUANLYBANHANG.Model;


namespace QUANLYBANHANG.GUI
{
    public partial class FormAddEmp : Form
    {
        private static EmployeeBLL emp = new EmployeeBLL();
        public FormAddEmp()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            cbRole.DataSource = emp.LoadRole();
            cbRole.DisplayMember = emp.LoadRole().Columns["Role_Name"].ToString();
            cbRole.ValueMember = emp.LoadRole().Columns["ID"].ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.firstName = tbFirstName.Text;
            employee.lastName = tbLastName.Text;
            employee.gender = cbGende.Text;
            employee.address = tbAddress.Text;
            employee.username = tbUsername.Text;
            employee.password = tbPassword.Text;
            employee.role_ID = Convert.ToInt32(cbRole.SelectedValue);
            EmployeeBLL.AddEmp(employee);
            this.Close();
        }
    }
}
