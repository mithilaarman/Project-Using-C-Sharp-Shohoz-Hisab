using Hello.Application.MTbl_product;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_product
{
	public class Tbl_productService : ITbl_productService
	{
		private readonly HelloDbContext _context;

		public Tbl_productService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_productRequest tbl_productRequest)
		{
			var tbl_product = new tbl_product()
			{
				name = tbl_productRequest.name,
				price = tbl_productRequest.price,
				image = tbl_productRequest.image,
				category = tbl_productRequest.category
			};
			_context.tbl_products.Add(tbl_product);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_productRequest tbl_productRequest)
		{
			var tbl_product = new tbl_product()
			{
				id = tbl_productRequest.id
			};
			_context.tbl_products.Remove(tbl_product);

			return await _context.SaveChangesAsync();
		}


		public async Task<int> Update(Tbl_productRequest tbl_productRequest)
		{
			var tbl_product = new tbl_product()
			{
				id = tbl_productRequest.id,
				name = tbl_productRequest.name,
				price = tbl_productRequest.price,
				image = tbl_productRequest.image,
				category = tbl_productRequest.category
			};
			_context.tbl_products.Update(tbl_product);

			return await _context.SaveChangesAsync();
		}

		public async Task<List<Tbl_productResponse>> GetAll()
		{
			return await _context.tbl_products
				.Select(x => new Tbl_productResponse()
				{
					id = x.id,
					name = x.name,
					price = x.price,
					image = x.image,
					category = x.category
				}).ToListAsync();
		}

		public async Task<List<Tbl_productResponse>> GetFood()
		{
			var query = from pr in _context.tbl_products 
						where pr.category == 1
						select new { pr };
			return await query.Select(x => new Tbl_productResponse()
			{
				id = x.pr.id,
				name = x.pr.name,
				price = x.pr.price,
				image = x.pr.image,
				category=x.pr.category
			}).ToListAsync();
		}

		public async Task<List<Tbl_productResponse>> GetDrink()
		{
			var query = from pr in _context.tbl_products
						where pr.category == 2
						select new { pr };
			return await query.Select(x => new Tbl_productResponse()
			{
				id = x.pr.id,
				name = x.pr.name,
				price = x.pr.price,
				image = x.pr.image,
				category = x.pr.category
			}).ToListAsync();
		}

		public async Task<List<Tbl_productResponse>> SearchProduct(Tbl_productRequest tbl_productRequest)
		{
			var query = from pr in _context.tbl_products
						where EF.Functions.Like(pr.name, tbl_productRequest.name)
						select new { pr };
			return await query.Select(x => new Tbl_productResponse()
			{
				id = x.pr.id,
				name = x.pr.name,
				price = x.pr.price,
				image = x.pr.image,
				category = x.pr.category
			}).ToListAsync();
		}
	}
}
