using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class Storage
    {
        public int product_ID { get; set; }
        public int amount { get; set; }
        public Date import_date { get; set; }
        public Date export_date { get; set; }
    }
}
