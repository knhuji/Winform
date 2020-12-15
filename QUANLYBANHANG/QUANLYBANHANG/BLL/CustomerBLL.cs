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
    class CustomerBLL
    {
        private static CustomerDAL obj = new CustomerDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public Customer GetCusByID(String ID)
        {
            return obj.GetCusByID(ID);
        }
        public static void UpdateCus(Customer customer)
        {
            obj.UpdateCus(customer);
        }
        public static void DeleteCus(String ID)
        {
            obj.DeleteCus(ID);
        }
        public static void AddCus(Customer customer)
        {
            obj.AddCus(customer);
        }
    }
}
