using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_item
{
    public class Tbl_itemDto
    {
        public int id { get; set; }
        public float discount { get; set; }
        public int quanlity { get; set; }

        public float? price { get; set; }
        public int idproduct { get; set; }
        public int idorder { get; set; }
    }
}
