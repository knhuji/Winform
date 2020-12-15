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
    public partial class FormAddCatalog : Form
    {
        private static CatalogBLL ca = new CatalogBLL();
        public FormAddCatalog()
        {
            InitializeComponent();
        }

        private void btnAddCatalog_Click(object sender, EventArgs e)
        {   
            Catalog catalog= new Catalog();
            catalog.catalog_name = tbName.Text;
            CatalogBLL.AddCatalog(catalog);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
