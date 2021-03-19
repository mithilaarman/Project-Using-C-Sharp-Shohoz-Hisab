using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hello.Application.MTbl_product
{
    public class Tbl_productRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int category { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string username { get; set; }

        [NotMapped]
        public string password { get; set; }
    }
}
