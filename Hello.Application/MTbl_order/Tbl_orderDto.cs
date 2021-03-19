using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_order
{
    public class Tbl_orderDto
    {
        public int id { get; set; }

        public int iditem { get; set; }
        public int idproduct { get; set; }
        public int idorder { get; set; }
        public float discount { get; set; }
        public int quanlity { get; set; }
        public float? priceItem { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int category { get; set; }

        public float fee { get; set; }
        public float total { get; set; }
    }
}
