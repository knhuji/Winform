using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.BLL;
using System.Windows.Forms;
using QUANLYBANHANG.Model;
using QUANLYBANHANG.GUI;

namespace QUANLYBANHANG
{
    public partial class Form1 : Form
    {
        private static CustomerBLL cus = new CustomerBLL();
        private static ProductBLL pro = new ProductBLL();
        private static ComboBLL cbo = new ComboBLL();
        private static CatalogBLL ca = new CatalogBLL();
        private static EmployeeBLL emp = new EmployeeBLL();
        private static InvoiceBLL invoice = new InvoiceBLL();
        public Form1()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            tblCustomer.DataSource = cus.GetAll();
            tblProduct.DataSource = pro.GetAll();
            tblCombo.DataSource = cbo.GetAll();
            tblCatalog.DataSource = ca.GetAll();
            tblStaff.DataSource = emp.GetAll();
            btnEditCus.Visible = false;
            btnDeleteCus.Visible = false;
            btnEditPro.Visible = false;
            btnDeletePro.Visible = false;
            btnEditCatalog.Visible = false;
            btnEditCombo.Visible = false;
            btnDeleteCombo.Visible = false;
            btnChoosePro.Visible = false;
            btnURLCombo.Visible = false;
            btnChoose.Visible = false;
            btnEditStaff.Visible = false;
            btnDeleteStaff.Visible = false;
            tblInvoice.DataSource = invoice.GetAll();
           // DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = pro.GetAll();
            dt1 = dt.DefaultView.ToTable(true, "Product_Name", "Price", "Amount", "ID");
            tblgetPro.DataSource = dt1;
            labelerror.Visible = false;

        }
        /*-------------Customer-------------*/
        private void btnEditCus_Click(object sender, EventArgs e)
        {
            String[] name = tbNameCus.Text.Split(' ');
            Customer customer = new Customer();
            for (int i = 0; i < name.Length - 1; i++)
            {
                if (i != name.Length - 2)
                {
                    name[i] = name[i] + ' ';
                }
                customer.firstName += name[i];
            }
            customer.lastName = name[name.Length - 1];
            customer.ID = Convert.ToInt32(tbIDCus.Text);
            customer.gender = tbGenderCus.Text;
            customer.address = tbAdressCus.Text;
            customer.birthDate = Convert.ToDateTime(tbBirthCus.Text);
            Console.WriteLine(customer.firstName);
            CustomerBLL.UpdateCus(customer);
            tblCustomer.DataSource = cus.GetAll();
        }

        private void tblCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblCustomer.Rows[e.RowIndex];
            Customer customer = cus.GetCusByID(row.Cells["id_cus"].Value.ToString());
            tbNameCus.Text = customer.firstName + ' ' + customer.lastName;
            tbIDCus.Text = customer.ID.ToString();
            tbUsernameCus.Text = customer.username.ToString();
            tbBirthCus.Text = customer.birthDate.ToString();
            tbGenderCus.Text = customer.gender.ToString();
            tbAdressCus.Text = customer.address.ToString();
            tbJoinDateCus.Text = customer.joinDate.ToString();
            tbPhoneCus.Text = customer.phoneNumber.ToString();
            tbPassCus.Text = customer.password.ToString();
            tbPassCus.UseSystemPasswordChar = true;
            btnEditCus.Visible = true;
            btnDeleteCus.Visible = true;
        }
        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            CustomerBLL.DeleteCus(tbIDCus.Text);
            tblCustomer.DataSource = cus.GetAll();
        }
        private void btnAddCus_Click(object sender, EventArgs e)
        {
            FormAddCus fcus = new FormAddCus();
            fcus.Show();
        }
        private void btnResetCus_Click(object sender, EventArgs e)
        {
            tblCustomer.DataSource = cus.GetAll();
        }
        /*-------------End Customer-------------*/
        /*-------------Product-------------*/
        private void tblProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = tblProduct.Rows[e.RowIndex];
            Product product = pro.GetProByID(row.Cells["id_pro"].Value.ToString());
            tbNamePro.Text = product.product_name;
            tbIDPro.Text = product.product_ID.ToString();
            cbCatalog.DataSource = pro.LoadCatalog();
            cbCatalog.DisplayMember = pro.LoadCatalog().Columns["Catalog_Name"].ToString();
            cbCatalog.ValueMember = pro.LoadCatalog().Columns["ID"].ToString();
            cbCatalog.SelectedValue = product.catalog_ID;
            tbPricePro.Text = product.price.ToString();
            tbAmountPro.Text = product.amount.ToString();
            tbDetailPro.Text = product.product_detail.ToString();
            tbURL.Text = product.img.ToString();
            imgPro.ImageLocation = product.img.ToString();
            btnEditPro.Visible = true;
            btnDeletePro.Visible = true;
            btnChoose.Visible = true;
        }
        private void btnEditPro_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.product_ID = Convert.ToInt32(tbIDPro.Text);
            product.product_name = tbNamePro.Text;
            product.catalog_ID = Convert.ToInt32(cbCatalog.SelectedValue);
            product.price = tbPricePro.Text;
            product.amount = Convert.ToInt32(tbAmountPro.Text);
            product.img = tbURL.Text;
            product.product_detail = tbDetailPro.Text;
            ProductBLL.UpdatePro(product);
            tblProduct.DataSource = pro.GetAll();
        }
        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            ProductBLL.DeletePro(tbIDPro.Text);
            tblProduct.DataSource = pro.GetAll();
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            FormAddPro fpro = new FormAddPro();
            fpro.Show();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.jpg";
            //fbd.ShowNewFolderButton = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                tbURL.Text = open.FileName;
            }
        }
        private void btnResetPro_Click(object sender, EventArgs e)
        {
            tblProduct.DataSource = pro.GetAll();
        }
        /*-------------End Product-------------*/

        /*-------------Catalog-------------*/
        private void tblCatalog_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblCatalog.Rows[e.RowIndex];
            Catalog catalog = ca.GetCatalogByID(row.Cells["id_catalog"].Value.ToString());
            tbNameCatalog.Text = catalog.catalog_name;
            tbIDCatalog.Text = catalog.catalog_ID.ToString();
            btnEditCatalog.Visible = true;
        }
        private void btnEditCatalog_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.catalog_ID = Convert.ToInt32(tbIDCatalog.Text);
            catalog.catalog_name = tbNameCatalog.Text;
            CatalogBLL.UpdateCatalog(catalog);
            tblCatalog.DataSource = ca.GetAll();
        }
        private void btnAddCatalog_Click(object sender, EventArgs e)
        {
            FormAddCatalog fca = new FormAddCatalog();
            fca.Show();
        }
        private void btnResetCatalog_Click(object sender, EventArgs e)
        {
            tblCatalog.DataSource = ca.GetAll();
        }
        /*-------------End Catalog-------------*/
        /*-------------Combo-------------*/
        private void tblCombo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblCombo.Rows[e.RowIndex];
            Combo combo = cbo.GetComboByID(row.Cells["id_combo"].Value.ToString());
            tbNameCombo.Text = combo.combo_name.ToString();
            tbIDCombo.Text = combo.combo_ID.ToString();
            tbPriceCombo.Text = combo.total_money.ToString();
            tbStartDayCombo.Text = combo.start_date.ToString();
            tbEndDayCombo.Text = combo.end_date.ToString();
            tbDiscountCombo.Text = combo.discount_money.ToString();
            tbListPro.Text = combo.product_list.ToString();
            tbURLCombo.Text = combo.image_combo.ToString();
            imgCombo.ImageLocation = combo.image_combo.ToString();
            btnEditCombo.Visible = true;
            btnDeleteCombo.Visible = true;
            btnChoosePro.Visible = true;
            btnURLCombo.Visible = true;
        }
        private void btnDeleteCombo_Click(object sender, EventArgs e)
        {
            ComboBLL.DeleteCombo(tbIDCombo.Text);
            tblCombo.DataSource = pro.GetAll();
        }

        /*-------------End Combo-------------*/
        /*-------------Employee-------------*/
        private void tblStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblStaff.Rows[e.RowIndex];
            Employee employee = emp.GetEmpByID(row.Cells["ID"].Value.ToString());
            tbNameStaff.Text = employee.firstName + ' ' + employee.lastName;
            tbIDStaff.Text = employee.employee_ID.ToString();
            tbUsernameStaff.Text = employee.username.ToString();
            tbGenderStaff.Text = employee.gender.ToString();
            tbAddressStaff.Text = employee.address.ToString();
            cbRole.DataSource = emp.LoadRole();
            cbRole.DisplayMember = emp.LoadRole().Columns["Role_Name"].ToString();
            cbRole.ValueMember = emp.LoadRole().Columns["ID"].ToString();
            cbRole.SelectedValue = employee.role_ID;
            tbPassStaff.Text = employee.password.ToString();
            tbPassStaff.UseSystemPasswordChar = true;
            btnEditStaff.Visible = true;
            btnDeleteStaff.Visible = true;
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            String[] name = tbNameStaff.Text.Split(' ');
            Employee employee = new Employee();
            for (int i = 0; i < name.Length - 1; i++)
            {
                if (i != name.Length - 2)
                {
                    name[i] = name[i] + ' ';
                }
                employee.firstName += name[i];
            }
            employee.lastName = name[name.Length - 1];
            employee.employee_ID = Convert.ToInt32(tbIDStaff.Text);
            employee.gender = tbGenderStaff.Text;
            employee.address = tbAddressStaff.Text;
            employee.username = tbUsernameStaff.Text;
            employee.password = tbPassStaff.Text;
            employee.role_ID = Convert.ToInt32(cbRole.SelectedValue);
            EmployeeBLL.UpdateEmp(employee); ;
            Console.WriteLine(employee.firstName);
            tblStaff.DataSource = emp.GetAll();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            FormAddEmp femp = new FormAddEmp();
            femp.Show();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            EmployeeBLL.DeleteEmp(tbIDStaff.Text);
            tblStaff.DataSource = emp.GetAll();
        }

        private void btnResetStaff_Click(object sender, EventArgs e)
        {
            tblStaff.DataSource = emp.GetAll();
        }
        /*-------------End Employee-------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void tblProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }
        
        private void tblCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tbPricePro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void tblProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void imgPro_Click(object sender, EventArgs e)
        {          

        }

        private void tbIDCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStartDayCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tblCombo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void tblgetPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tblgetPro.Rows[e.RowIndex];
            Product product = pro.GetProByID(row.Cells["id_product"].Value.ToString());
            tbgetidpro.Text = product.product_ID.ToString();
            tbgetsl.Text = "1";

        }

        private void btnaddcart_Click(object sender, EventArgs e)
        {
            string id = tbgetidpro.Text;
            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
            else
            {
                Product product = pro.GetProByID(id);
                string thanhtien = (Convert.ToInt32(product.price) * Convert.ToInt32(tbgetsl.Text)).ToString();
                tbldetailnivoice.Rows.Add(id, product.product_name, product.price, tbgetsl.Text, thanhtien, 1);
                int a = tbldetailnivoice.Rows.Count;
                double tongtien = 0;
                for (int i = 0; i < a - 1; i++)
                {
                    tongtien = tongtien + double.Parse(tbldetailnivoice.Rows[i].Cells["thanhtien"].Value.ToString());
                }

                tbtamtinh.Text = tongtien.ToString();
                tbtotalbill.Text = (Convert.ToInt32(tbtamtinh.Text) + Convert.ToInt32(tbfeeship.Text)).ToString();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Customer customer = cus.GetCusByID("1");
                tbidcustomer.Text = "1";
                tbname_cus.Text = customer.firstName + " " + customer.lastName;
                tbphone_cus.Text = customer.phoneNumber;
            }
            if (checkBox1.Checked == false)
            {
                tbidcustomer.Text = "";
                tbname_cus.Text = " ";
                tbphone_cus.Text = "";
            }
        }

        private void checkship_CheckedChanged(object sender, EventArgs e)
        {
            if (checkship.Checked == true)
            {
                tbfeeship.Text = "30000";
                tbtotalbill.Text = (Convert.ToInt32(tbtamtinh.Text) + 30000).ToString();
            }
            if (checkship.Checked == false)
            {
                tbfeeship.Text = " ";
                tbtotalbill.Text = tbtamtinh.Text;
            }
        }

        private void btnfindphone_cus_Click(object sender, EventArgs e)
        {
            string phonenumber = tbphonenumer_cus.Text;
            Customer customer = cus.GetCusByPhone(phonenumber);
            if (customer != null)
            {
                labelerror.Visible = false;
                tbidcustomer.Text = customer.ID.ToString();
                tbname_cus.Text = customer.firstName + " " + customer.lastName;
                tbphone_cus.Text = phonenumber;
                tbaddress_cus.Text = customer.address;
            }
            else
            {
                labelerror.Visible = true;
                tbidcustomer.Text = "";
                tbname_cus.Text = " ";
                tbphone_cus.Text = "";
            }
        }

        private void tbphonenumer_cus_TextChanged(object sender, EventArgs e)
        {
            if (tbphonenumer_cus.Text == "")
            {
                labelerror.Visible = false;
            }
        }

        private void tbncheckout_Click(object sender, EventArgs e)
        {
            int a = tbldetailnivoice.Rows.Count;
            if (a <= 1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
            else
            {
                //.ToString("yyyy-MM-dd")

                //DateTime time = DateTime.Now;
                //string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                Invoice inv = new Invoice();
                inv.Customer_ID = Convert.ToInt32(tbidcustomer.Text);
                inv.Invoice_Name = tbname_cus.Text;
                inv.totalMoney = tbtotalbill.Text;
                inv.createdDate = Convert.ToString(DateTime.Now.Date);
                inv.shipDate = Convert.ToString(DateTime.Now.Date);
                inv.customerAddress = tbaddress_cus.Text;

                try
                {
                    int ab = InvoiceBLL.AddInvoice(inv);

                    for (int i = 0; i <= a - 1; i++)
                    {
                        InvoiceDetail invoicedetail = new InvoiceDetail();
                        string valuestatus = Convert.ToString(tbldetailnivoice.Rows[i].Cells["status"].Value);
                        if (valuestatus == "1")
                        {
                            invoicedetail.Invoice_ID = ab;
                            invoicedetail.Product_ID = Convert.ToInt32(tbldetailnivoice.Rows[i].Cells["ID_Pronivoice"].Value.ToString());
                            invoicedetail.Price = tbldetailnivoice.Rows[i].Cells["thanhtien"].Value.ToString();
                            invoicedetail.Amount = Convert.ToInt32(tbldetailnivoice.Rows[i].Cells["soluongsp"].Value.ToString());
                            InvoiceBLL.AddInvoiceDetail(invoicedetail);
                        }
                    }
                    tbldetailnivoice.Rows.Clear();
                    tbidcustomer.Text = "";
                    tbname_cus.Text = " ";
                    tbphone_cus.Text = "";
                    tbfeeship.Text = " ";
                    tbtotalbill.Text = "";
                    tbtamtinh.Text = "";
                    checkship.Checked = false;
                    checkBox1.Checked = false;
                    MessageBox.Show(ab.ToString());

                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra thông tin!");
                }
            }
        }
    }
}
