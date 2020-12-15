using QUANLYBANHANG.DAL;
using QUANLYBANHANG.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BLL
{
    class CatalogBLL
    {
        private static CatalogDAL obj = new CatalogDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public Catalog GetCatalogByID(String ID)
        {
            return obj.GetCatalogByID(ID);
        }
        //public static void DeleteCatalog(String ID)
        //{
        //    obj.DeleteCatalog(ID);
        //}
        public static void UpdateCatalog(Catalog catalog)
        {
            obj.UpdateCatalog(catalog);
        }
        public static void AddCatalog(Catalog catalog)
        {
            obj.AddCatalog(catalog);
        }
    }
}
