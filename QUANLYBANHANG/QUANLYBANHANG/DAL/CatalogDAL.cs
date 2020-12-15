using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYBANHANG.Model;

namespace QUANLYBANHANG.DAL
{
    class CatalogDAL
    {
        public DataTable GetAll()
        {
            string query = "select * from catalog";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Catalog GetCatalogByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "select ID, Catalog_Name from catalog where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Catalog()
                        {
                            catalog_ID = Convert.ToInt32(dr["ID"].ToString()),
                            catalog_name = dr["Catalog_Name"].ToString(),
                        };
                    }
                }
                return null;
            }
        }
        //public void DeleteCatalog(string ID)
        //{
        //    ConnectDB.DbConnection();
        //    string query = "delete from catalog where ID = @ID";
        //    SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
        //    cmd.Parameters.AddWithValue("@ID", ID);
        //    cmd.ExecuteNonQuery();
        //}
        public void UpdateCatalog(Catalog catalog)
        {
            ConnectDB.DbConnection();
            string query = "update catalog set Catalog_Name =@Catalog_Name where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Catalog_Name", catalog.catalog_name);
            cmd.Parameters.AddWithValue("ID", catalog.catalog_ID);
            cmd.ExecuteNonQuery();
        }
        public void AddCatalog(Catalog catalog)
        {
            ConnectDB.DbConnection();
            string query = "insert into catalog(Catalog_Name) values (@Catalog_Name)";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.Add("@Catalog_Name", SqlDbType.NVarChar).Value = catalog.catalog_name;
            cmd.ExecuteNonQuery();
        }
    }
}
