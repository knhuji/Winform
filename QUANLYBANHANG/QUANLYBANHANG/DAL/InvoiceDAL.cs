using QUANLYBANHANG.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAL
{
    public class InvoiceDAL
    {
        public DataTable GetAll()
        {
            string query = "select Invoice.ID , Invoice.Invoice_Name," +
                " Invoice.totalMoney , Invoice.createdDate ," +
                " Invoice.customerAddress  " +
                "  from Invoice  ";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAllDetail(string ID)
        {
            string query = "select Invoice_ID , Product_ID," +
                " Combo_ID , Amount ," +
                " Price  " +
                "  from InvoiceDetail where  Invoice_ID=@ID";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            command.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Invoice GetInvoiceByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "Select * from Invoice where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Invoice()
                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
                            Invoice_Name = dr["Invoice_Name"].ToString(),
                            totalMoney = Convert.ToInt32(dr["totalMoney"].ToString()),
                            createdDate = dr["createdDate"].ToString(),
                            shipDate = dr["shipDate"].ToString(),
                            customerAddress = dr["customerAddress"].ToString()
                        };
                    }
                }
                return null;
            }
        }
        public InvoiceDetail GetInvoiceDetailByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "Select * from InvoiceDetail where Invoice_ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new InvoiceDetail()
                        {
                            Invoice_ID = Convert.ToInt32(dr["Invoice_ID"].ToString()),
                            Product_ID = Convert.ToInt32(dr["Product_ID"].ToString()),
                            Combo_ID = Convert.ToInt32(dr["Combo_ID"].ToString()),
                            Amount = Convert.ToInt32(dr["Amount"].ToString()),
                            Price = Convert.ToInt32(dr["Price"].ToString())
                        };
                    }
                }
                return null;
            }
        }
        public void UpdateInvoice(Invoice invoice)
        {
            ConnectDB.DbConnection();
            string query = "update Invoice set Invoice_Name =@Invoice_Name, totalMoney =@totalMoney, createdDate =@createdDate, customerAddress =@customerAddress, shipDate = @shipDate, Shipper_ID = @Shipper_ID, ID_Customer = @ID_Customer  where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Invoice_Name", invoice.Invoice_Name);
            cmd.Parameters.AddWithValue("totalMoney", invoice.totalMoney);
            cmd.Parameters.AddWithValue("createdDate", invoice.createdDate);
            cmd.Parameters.AddWithValue("customerAddress", invoice.customerAddress);
            cmd.Parameters.AddWithValue("shipDate", invoice.shipDate);
            cmd.Parameters.AddWithValue("Shipper_ID", invoice.Shipper_ID);
            cmd.Parameters.AddWithValue("ID", invoice.ID);
            cmd.ExecuteNonQuery();
        }
        public int AddInvoice(Invoice invoice)
        {
            ConnectDB.DbConnection();
            string query = "insert into Invoice (Invoice_Name, Customer_ID, totalMoney, createdDate, customerAddress, Shipper_ID, shipDate) OUTPUT INSERTED.ID values ( @Invoice_Name, @Customer_ID, @totalMoney, @createdDate, @customerAddress, @shipDate, @Shipper_ID)";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Invoice_Name", invoice.Invoice_Name);
            cmd.Parameters.AddWithValue("totalMoney", invoice.totalMoney);
            cmd.Parameters.AddWithValue("createdDate", DateTime.Now.Date.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("customerAddress", invoice.customerAddress);
            cmd.Parameters.AddWithValue("shipDate", DateTime.Now.Date.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("Shipper_ID", 1);
            cmd.Parameters.AddWithValue("Customer_ID", invoice.Customer_ID);
            cmd.Parameters.AddWithValue("ID", invoice.ID);
            Int32 newId = (Int32)cmd.ExecuteScalar();
            // int a=Convert.ToInt32(cmd.Parameters["@ID"].Value.ToString());
            return newId;
        }

        public void AddDetailInvoice(InvoiceDetail invoiceDetail)
        {
            ConnectDB.DbConnection();
            string query = "insert into InvoiceDetail (Invoice_ID, Product_ID, Combo_ID, Amount, Price ) values (@Invoice_ID, @Product_ID, @Combo_ID, @Amount, @Price )";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("Product_ID", invoiceDetail.Product_ID);
            cmd.Parameters.AddWithValue("Combo_ID", invoiceDetail.Combo_ID);
            cmd.Parameters.AddWithValue("Amount", invoiceDetail.Amount);
            cmd.Parameters.AddWithValue("Price", invoiceDetail.Price);
            cmd.Parameters.AddWithValue("Invoice_ID", invoiceDetail.Invoice_ID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteInvoice(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from Invoice where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }

    }
}
