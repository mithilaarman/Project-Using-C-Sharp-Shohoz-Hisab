using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_order
{
    public class Tbl_orderRequest
    {
        public int id { get; set; }
        public float fee { get; set; }
        public float discount { get; set; }
        public float total { get; set; }
    }
}
