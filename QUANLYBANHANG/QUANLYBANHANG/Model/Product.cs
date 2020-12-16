using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.Model;

namespace QUANLYBANHANG.Model
{
    public class Product
    {
        public int product_ID { get; set; }
        public string product_name { get; set; }
        public int catalog_ID { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string product_detail { get; set; }
        public string img { get; set; }
        public List<Catalog> Catalog_Name { get; set; }
    }
}
