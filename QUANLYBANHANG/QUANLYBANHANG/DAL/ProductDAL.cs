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
    class ProductDAL
    {
        public DataTable GetAll()
        {
            string query = "select p.ID, p.Product_Name, c.Catalog_Name as catalog, p.Amount, p.Price, p.Image_Name, p.Detail " +
                "from Product p, Catalog c " +
                "where p.Catalog_ID=c.ID";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public List<String> GetProducts()
        {
            List<String> data = new List<String>();
            string query = "select ID from product";
            ConnectDB.DbConnection();
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    String ID = reader["ID"].ToString();
                    data.Add(ID);
                }
                reader.NextResult();
            }
            return data;
        }
        public Product GetProByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "select p.ID, p.Product_Name, c.Catalog_Name, p.Catalog_Id, p.Amount, p.Price, p.Image_Name, p.Detail " +
                "from Product p, Catalog c " +
                "where p.ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Product()
                        {
                            product_ID = Convert.ToInt32(dr["ID"].ToString()),
                            product_name = dr["Product_Name"].ToString(),
                            catalog_ID = Convert.ToInt32(dr["Catalog_ID"].ToString()),
                            price = dr["Price"].ToString(),
                            amount = Convert.ToInt32(dr["Amount"].ToString()),
                            product_detail = dr["Detail"].ToString(),
                            img = dr["Image_Name"].ToString(),
                        };
                    }
                }
                return null;
            }
        }
        public void DeletePro(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from product where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }
        public void UpdatePro(Product product)
        {
            ConnectDB.DbConnection();
            string query = "update product set Product_Name =@Product_Name,Catalog_ID =@Catalog_ID, Amount =@Amount, Price =@Price, Image_Name = @Image_Name, Detail = @Detail where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Product_Name", product.product_name);
            cmd.Parameters.AddWithValue("Catalog_ID", product.catalog_ID);
            cmd.Parameters.AddWithValue("Amount", product.amount);
            cmd.Parameters.AddWithValue("Price", product.price);
            cmd.Parameters.AddWithValue("Image_Name", product.img);
            cmd.Parameters.AddWithValue("Detail", product.product_detail);
            cmd.Parameters.AddWithValue("ID", product.product_ID);
            cmd.ExecuteNonQuery();
        }
        public void AddPro(Product product)
        {
            ConnectDB.DbConnection();
            string query = "insert into product(Product_Name,catalog_ID,Amount,Price,Image_Name,Detail) values (@Product_Name,@Catalog_ID,@Amount,@Price,@Image_Name,@Detail)";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = product.product_name;
            cmd.Parameters.Add("@Catalog_ID", SqlDbType.Int).Value = product.catalog_ID;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = product.amount;
            cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = product.price;
            cmd.Parameters.Add("@Image_Name", SqlDbType.NVarChar).Value = product.img;
            cmd.Parameters.Add("@Detail", SqlDbType.NVarChar).Value = product.product_detail;
            //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = product.product_ID;
            cmd.ExecuteNonQuery();
        }
        public DataTable LoadCatalog()
        {
            string data = "select ID, Catalog_Name from Catalog";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(data, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
