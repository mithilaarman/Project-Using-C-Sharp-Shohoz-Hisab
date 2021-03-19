using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Data.Entities
{
    [Table("tbl_payment")]
    public class tbl_payment
    {
        [Key]
        public int id { get; set; }
        public float receive { get; set; }
        public float refund { get; set; }
        public int type { get; set; }
        public int idorder { get; set; }
    }
}
