using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class Customer
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public string address { get; set; }
        public DateTime joinDate { get; set; }
        public int isNew { get; set; }
    }
}
