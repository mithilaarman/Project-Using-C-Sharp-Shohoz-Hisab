using Hello.Application.MTbl_bill;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_bill
{
	public class Tbl_billService : ITbl_billService
	{
		private readonly HelloDbContext _context;

		public Tbl_billService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_billRequest tbl_billRequest)
		{
			int maxIdOrder = _context.tbl_orders.Max(u => u.id);
			int maxIdPayment = _context.tbl_payments.Max(u => u.id);
			var tbl_bill = new tbl_bill()
			{
				create_at = DateTime.Now,
				iduser = tbl_billRequest.iduser,
				idpayment = maxIdPayment,
				idorder = maxIdOrder,
			};
			_context.tbl_bills.Add(tbl_bill);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_billRequest tbl_billRequest)
		{
			var tbl_bill = new tbl_bill()
			{
				id = tbl_billRequest.id
			};
			_context.tbl_bills.Remove(tbl_bill);

			return await _context.SaveChangesAsync();
		}


		public async Task<int> Update(Tbl_billRequest tbl_billRequest)
		{
			var tbl_bill = new tbl_bill()
			{
				id = tbl_billRequest.id,
				create_at = tbl_billRequest.create_at,
				iduser = tbl_billRequest.iduser,
				idpayment = tbl_billRequest.idpayment,
				idorder = tbl_billRequest.idorder,
			};
			_context.tbl_bills.Update(tbl_bill);

			return await _context.SaveChangesAsync();
		}

		public async Task<List<Tbl_billResponse>> GetAll()
		{
			return await _context.tbl_bills
				.Select(x => new Tbl_billResponse()
				{
					id = x.id,
					create_at = x.create_at,
					iduser = x.iduser,
					idpayment = x.idpayment,
					idorder = x.idorder,

				}).ToListAsync();
		}

	}
}
