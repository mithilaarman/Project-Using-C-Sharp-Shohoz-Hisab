using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_payment
{
    public class Tbl_paymentRequest
    {
        public int id { get; set; }
        public float receive { get; set; }
        public float refund { get; set; }
        public int type { get; set; }
        public int idorder { get; set; }
    }
}
