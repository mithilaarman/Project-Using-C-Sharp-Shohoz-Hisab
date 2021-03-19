using Hello.Application.MTbl_item;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_item
{
	public class Tbl_itemService : ITbl_itemService
	{
		private readonly HelloDbContext _context;

		public Tbl_itemService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_itemRequest tbl_itemRequest)
		{
			int maxId = _context.tbl_orders.Max(u => u.id);
			var tbl_item = new tbl_item()
			{
				idproduct = tbl_itemRequest.idproduct,
				discount = tbl_itemRequest.discount,
				quanlity = tbl_itemRequest.quanlity,
				price = tbl_itemRequest.price,
				idorder = maxId
			};
			_context.tbl_items.Add(tbl_item);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_itemRequest tbl_itemRequest)
		{
			var tbl_item = new tbl_item()
			{
				id = tbl_itemRequest.id
			};
			_context.tbl_items.Remove(tbl_item);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> UpdateQuanlity(Tbl_itemRequest tbl_itemRequest)
		{
			var tbl_item = new tbl_item()
			{
				id = tbl_itemRequest.id,
				idproduct = tbl_itemRequest.idproduct,
				discount = tbl_itemRequest.discount,
				quanlity = tbl_itemRequest.quanlity,
				price = tbl_itemRequest.price,
				idorder = tbl_itemRequest.quanlity,
			};
			_context.tbl_items.Update(tbl_item);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> UpdateDiscount(Tbl_itemRequest tbl_itemRequest)
		{
			var tbl_item = new tbl_item()
			{
				id = tbl_itemRequest.id,
				idproduct = tbl_itemRequest.idproduct,
				discount = tbl_itemRequest.discount,
				quanlity = tbl_itemRequest.quanlity,
				price = tbl_itemRequest.price,
				idorder = tbl_itemRequest.quanlity,
			};
			_context.tbl_items.Update(tbl_item);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Update(Tbl_itemRequest tbl_itemRequest)
		{
			var tbl_item = new tbl_item()
			{
				id = tbl_itemRequest.id,
				idproduct = tbl_itemRequest.idproduct,
				discount = tbl_itemRequest.discount,
				quanlity = tbl_itemRequest.quanlity,
				price = tbl_itemRequest.price,
				idorder = tbl_itemRequest.idorder
			};
			_context.tbl_items.Update(tbl_item);

			return await _context.SaveChangesAsync();
		}
		public async Task<List<Tbl_itemResponse>> GetAll()
		{
			return await _context.tbl_items
				.Select(x => new Tbl_itemResponse()
				{
					id = x.id,
					idproduct = x.idproduct,
					discount = x.discount,
					quanlity = x.quanlity,
					price = x.price,
					idorder = x.idorder
				}).ToListAsync();
		}
	}
}
