using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Data.Entities
{
    [Table("tbl_bill")]
    public class tbl_bill
    {
        [Key]
        public int id { get; set; }
        public DateTime create_at { get; set; }
        public int iduser { get; set; }
        public int idpayment { get; set; }
        public int idorder { get; set; }
    }
}
