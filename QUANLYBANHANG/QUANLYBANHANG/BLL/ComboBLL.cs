using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.Model;
using QUANLYBANHANG.DAL;


namespace QUANLYBANHANG.BLL
{
    class ComboBLL
    {
        private static ComboDAL obj = new ComboDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public Combo GetComboByID(String ID)
        {
            return obj.GetComboByID(ID);
        }
        public static void DeleteCombo(String ID)
        {
            obj.DeleteCombo(ID);
        }
        public static void UpdateCombo(Combo combo)
        {
            obj.UpdateCombo(combo);
        }
    }
}
