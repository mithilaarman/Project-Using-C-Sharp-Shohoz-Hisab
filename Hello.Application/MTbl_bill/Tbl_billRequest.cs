using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_bill
{
    public class Tbl_billRequest
    {
        public int id { get; set; }
        public DateTime create_at { get; set; }
        public int iduser { get; set; }
        public int idpayment { get; set; }
        public int idorder { get; set; }
    }
}
