using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Data.Entities
{
    [Table("tbl_item")]
    public class tbl_item
    {
        [Key]
        public int id { get; set; }
        public float discount { get; set; }
        public int quanlity { get; set; }

        public float? price { get; set; }
        public int idproduct { get; set; }
        public int idorder { get; set; }
    }
}
