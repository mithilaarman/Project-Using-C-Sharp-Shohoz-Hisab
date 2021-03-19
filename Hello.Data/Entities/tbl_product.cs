using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Data.Entities
{
    [Table("tbl_product")]
    public class tbl_product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int category { get; set; }
    }
}
