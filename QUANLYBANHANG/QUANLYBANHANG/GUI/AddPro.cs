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

namespace QUANLYBANHANG.GUI
{
    public partial class FormAddPro : Form
    {
        private static ProductBLL productbll = new ProductBLL();
        public FormAddPro()
        {
            InitializeComponent();
            cbCatalog.DataSource = productbll.LoadCatalog();
            cbCatalog.DisplayMember = productbll.LoadCatalog().Columns["Catalog_Name"].ToString();
            cbCatalog.ValueMember = productbll.LoadCatalog().Columns["ID"].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.product_name = tbName.Text;
            product.catalog_ID = Convert.ToInt32(cbCatalog.SelectedValue);
            product.price = Convert.ToInt32(tbPrice.Text);
            product.amount = Convert.ToInt32(tbAmount.Text);
            product.img = tbURL.Text;
            product.product_detail = tbDetail.Text;
            ProductBLL.AddPro(product);
            this.Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.jpg";
            //fbd.ShowNewFolderButton = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                tbURL.Text = open.FileName;
            }
        }

        private void cbCatalog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
