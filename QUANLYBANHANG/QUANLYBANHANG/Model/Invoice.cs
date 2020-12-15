using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class Invoice
    {
        public int invoice_ID { get; set; }
        public string invoice_name { get; set; }
        public int customer_ID { get; set; }
        public int shipper_ID { get; set; }
        public string total_money { get; set; }
        public Date created_date { get; set; }
        public string customer_address { get; set; }
        public Date ship_date { get; set; }
    }
}
