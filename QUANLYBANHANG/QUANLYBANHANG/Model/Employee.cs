using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class Employee
    {
        public int employee_ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Date birthday { get; set; }
        public string address { get; set; }
        public Date join_date { get; set; }
        public string is_new { get; set; }
        public int role_ID { get; set; }
    }
}
