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

namespace QUANLYBANHANG
{
    public partial class FormAddCus : Form
    {
        private static CustomerBLL cus = new CustomerBLL();
        public FormAddCus()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.firstName = tbFirstName.Text;
            customer.lastName = tbLastName.Text;
            customer.gender = cbGende.Text;
            customer.phoneNumber = tbPhone.Text;
            customer.address = tbAddress.Text;
            customer.username = tbUsername.Text;
            customer.password = tbPassword.Text;
            CustomerBLL.AddCus(customer);
            this.Close();
        }
    }
}
