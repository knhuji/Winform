﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    public class InvoiceDetail
    {
        public int Invoice_ID { get; set; }
        public int Product_ID { get; set; }
        public int Combo_ID { get; set; }
        public int Amount { get; set; }
        public string Price { get; set; }
    }
}
