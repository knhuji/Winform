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
    class EmployeeBLL
    {
        private static EmployeeDAL obj = new EmployeeDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public Employee GetEmpByID(String ID)
        {
            return obj.GetEmpByID(ID);
        }
        public DataTable LoadRole()
        {
            return obj.LoadRole();
        }
        public static void UpdateEmp(Employee employee)
        {
            obj.UpdateEmp(employee);
        }
        public static void AddEmp(Employee employee)
        {
            obj.AddEmp(employee);
        }
        public static void DeleteEmp(String ID)
        {
            obj.DeleteEmp(ID);
        }
    }
}
