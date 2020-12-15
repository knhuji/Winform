using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    public class Combo
    {
        public int combo_ID { get; set; }
        public string combo_name { get; set; }
        public string product_list { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string total_money { get; set; }
        public string discount { get; set; }
        public string discount_money { get; set; }
        public string image_combo { get; set; }
    }
}
