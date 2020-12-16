using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QUANLYBANHANG.Model;


namespace QUANLYBANHANG.DAL
{
    class ComboDAL
    {
        public DataTable GetAll()
        {
            string query = "select ID, Combo_Name, totalMoney, discountMoney, startDate, endDate from combo";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Combo GetComboByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "Select * from combo where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        //string[] array = dr["Product_List"].ToString().Split(',');
                        return new Combo()
                        {
                            combo_ID = Convert.ToInt32(dr["ID"].ToString()),
                            combo_name = dr["Combo_Name"].ToString(),
                            product_list = dr["Product_List"].ToString(),
                            total_money = dr["totalMoney"].ToString(),
                            discount_money = dr["discountMoney"].ToString(),
                            start_date = Convert.ToDateTime(dr["startDate"].ToString()),
                            end_date = Convert.ToDateTime(dr["endDate"].ToString()),
                            image_combo = dr["Image_Combo"].ToString(),
                        };
                    }
                }   
                return null;
            }
        }
        public void UpdateCombo(Combo combo)
        {
            ConnectDB.DbConnection();
            string query = "update combo set Combo_Name =@Combo_Name,Product_List =@Product_List, startDate =@startDate, endDate =@endDate, totalMoney = @totalMoney, discountMoney = @discountMoney, Image_Combo=@Image_Combo where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Combo_Name", combo.combo_name);
            cmd.Parameters.AddWithValue("Product_List", combo.product_list);
            cmd.Parameters.AddWithValue("startDate", combo.start_date);
            cmd.Parameters.AddWithValue("endDate", combo.end_date);
            cmd.Parameters.AddWithValue("totalMoney", combo.total_money);
            cmd.Parameters.AddWithValue("discountMoney", combo.discount_money);
            cmd.Parameters.AddWithValue("Image_Combo", combo.image_combo);
            cmd.Parameters.AddWithValue("ID", combo.combo_ID);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCombo(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from combo where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }
    }
}
