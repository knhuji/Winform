using QUANLYBANHANG.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.Model;

namespace QUANLYBANHANG.BLL
{
    class ProductBLL
    {
        private static ProductDAL obj = new ProductDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public List<String> GetProducts()
        {
            return obj.GetProducts();
        }
        public Product GetProByID(String ID)
        {
            return obj.GetProByID(ID);
        }
        public static void DeletePro(String ID)
        {
            obj.DeletePro(ID);
        }
        public static void UpdatePro(Product product)
        {
            obj.UpdatePro(product);
        }
        public static void AddPro(Product product)
        {
            obj.AddPro(product);
        }
        public DataTable LoadCatalog()
        {
            return obj.LoadCatalog();
        }

    }
}
