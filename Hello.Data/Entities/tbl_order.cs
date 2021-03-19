using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Data.Entities
{
    [Table("tbl_order")]
    public class tbl_order
    {
        [Key]
        public int id { get; set; }
        public float fee { get; set; }
        public float? discount { get; set; }
        public float total { get; set; }
    }
}
