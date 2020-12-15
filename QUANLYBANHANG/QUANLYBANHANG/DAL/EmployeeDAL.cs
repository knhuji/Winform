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
    class EmployeeDAL
    {
        public DataTable GetAll()
        {
            string query = "select e.id, e.username, e.password, e.address,e.gender, r.role_name as role, e.firstName + ' ' + e.lastName as name " +
                "from employee e, role r where e.role_ID=r.ID";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Employee GetEmpByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "Select * from employee where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Employee()
                        {
                            employee_ID = Convert.ToInt32(dr["ID"].ToString()),
                            username = dr["username"].ToString(),
                            password = dr["password"].ToString(),
                            firstName = dr["firstName"].ToString(),
                            lastName = dr["lastName"].ToString(),
                            gender = dr["gender"].ToString(),
                            address = dr["address"].ToString(),
                            role_ID = Convert.ToInt32(dr["Role_ID"].ToString())
                        };
                    }
                }
                return null;
            }
        }
        public void UpdateEmp(Employee employee)
        {
            ConnectDB.DbConnection();
            string query = "update employee set firstName =@firstName, lastName =@lastName, @username = username, @password = password, gender =@gender, role_ID = @role_ID, address = @address where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("firstName", employee.firstName);
            cmd.Parameters.AddWithValue("lastName", employee.lastName);
            cmd.Parameters.AddWithValue("gender", employee.gender);
            cmd.Parameters.AddWithValue("address", employee.address);
            cmd.Parameters.AddWithValue("role_ID", employee.role_ID);
            cmd.Parameters.AddWithValue("username", employee.username);
            cmd.Parameters.AddWithValue("password", employee.password);
            cmd.Parameters.AddWithValue("ID", employee.employee_ID);
            cmd.ExecuteNonQuery();
        }
        public void AddEmp(Employee employee)
        {
            ConnectDB.DbConnection();
            string query = "insert into employee(username, password,firstName,lastName,gender,address, role_ID) " +
                "values (@username,@password,@firstName,@lastName,@gender,@address, @role_ID)";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = employee.username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = employee.password;
            cmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = employee.firstName;
            cmd.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employee.lastName;
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = employee.gender;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = employee.address;
            cmd.Parameters.Add("@role_ID", SqlDbType.NVarChar).Value = employee.role_ID;
            cmd.ExecuteNonQuery();
        }
        public void DeleteEmp(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from employee where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }

        public DataTable LoadRole()
        {
            string data = "select ID, Role_Name from Role";
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
