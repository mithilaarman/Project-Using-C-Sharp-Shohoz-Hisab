using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_payment
{
    public class Tbl_paymentDto
    {
        public int id { get; set; }
        public float receive { get; set; }
        public float refund { get; set; }
        public int type { get; set; }
        public int idorder { get; set; }
        public DateTime create_at { get; set; }

        public string name { get; set; }
        public float fee { get; set; }

        public float total { get; set; }
        public float? discount { get; set; }
    }
}
