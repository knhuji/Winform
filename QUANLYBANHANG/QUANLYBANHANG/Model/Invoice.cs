using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    public class Invoice
    {
        public int ID { get; set; }
        public string Invoice_Name { get; set; }
        public int Customer_ID { get; set; }
        public int Shipper_ID { get; set; }
        public int totalMoney { get; set; }
        public string createdDate { get; set; }
        public string customerAddress { get; set; }
        public string shipDate { get; set; }
    }
}
