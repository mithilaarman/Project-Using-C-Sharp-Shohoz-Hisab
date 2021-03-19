using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Data
{
	class HelloDbContextFactory : IDesignTimeDbContextFactory<HelloDbContext>
	{
		public HelloDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<HelloDbContext>();
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-35F3HM7\SQLEXPRESS;Database=OrderSystemDB;Trusted_Connection=True;");

			return new HelloDbContext(optionsBuilder.Options);
		}
	}
}
