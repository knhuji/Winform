using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class InvoiceDetail
    {
        public int invoice_ID { get; set; }
        public int product_ID { get; set; }
        public int combo_ID { get; set; }
        public int amount { get; set; }
        public string price { get; set; }
    }
}
