using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Data
{
    public class HelloDbContext : DbContext
    {	
		public HelloDbContext(DbContextOptions<HelloDbContext> options) : base(options)
		{
		}

		public DbSet<tbl_product> tbl_products { get; set; }
		public DbSet<tbl_order> tbl_orders { get; set; }
		public DbSet<tbl_item> tbl_items { get; set; }
		public DbSet<tbl_payment> tbl_payments { get; set; }
		public DbSet<tbl_bill> tbl_bills { get; set; }
		public DbSet<tbl_user> tbl_users { get; set; }
	}
}
