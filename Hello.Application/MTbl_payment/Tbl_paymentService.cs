using Hello.Application.MTbl_payment;
using Hello.Data;
using Hello.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocDotNet.Application.MTbl_payment
{
	public class Tbl_paymentService : ITbl_paymentService
	{
		private readonly HelloDbContext _context;

		public Tbl_paymentService(HelloDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(Tbl_paymentRequest tbl_paymentRequest)
		{
			int maxIdOrder = _context.tbl_orders.Max(u => u.id);
			var tbl_payment = new tbl_payment()
			{
				receive = tbl_paymentRequest.receive,
				refund = tbl_paymentRequest.refund,
				type = tbl_paymentRequest.type,
				idorder = maxIdOrder
			};
			_context.tbl_payments.Add(tbl_payment);

			return await _context.SaveChangesAsync();
		}

		public async Task<int> Delete(Tbl_paymentRequest tbl_paymentRequest)
		{
			var tbl_payment = new tbl_payment()
			{
				id = tbl_paymentRequest.id
			};
			_context.tbl_payments.Remove(tbl_payment);

			return await _context.SaveChangesAsync();
		}


		public async Task<int> Update(Tbl_paymentRequest tbl_paymentRequest)
		{
			int maxIdOrder = _context.tbl_orders.Max(u => u.id);
			var tbl_payment = new tbl_payment()
			{
				id = tbl_paymentRequest.id,
				receive = tbl_paymentRequest.receive,
				refund = tbl_paymentRequest.refund,
				type = tbl_paymentRequest.type,
				idorder = maxIdOrder
			};
			_context.tbl_payments.Update(tbl_payment);

			return await _context.SaveChangesAsync();
		}

		public async Task<List<Tbl_paymentResponse>> GetAll()
		{
			return await _context.tbl_payments
				.Select(x => new Tbl_paymentResponse()
				{
					id = x.id,
					receive = x.receive,
					refund = x.refund,
					type = x.type,
					idorder = x.idorder
				}).ToListAsync();
		}

		public async Task<Tbl_paymentResponse> GetPaymentMax()
		{
			int maxId = _context.tbl_payments.Max(u => u.id);
			var query = from or in _context.tbl_orders
						join pm in _context.tbl_payments on or.id equals pm.idorder
						join b in _context.tbl_bills on pm.id equals b.idpayment
						join us in _context.tbl_users on b.iduser equals us.id
						where pm.id == maxId
						select new { or, pm, b,us };
			return await query.Select(x => new Tbl_paymentResponse()
			{

				id = x.pm.id,
				receive = x.pm.receive,
				refund = x.pm.refund,
				type = x.pm.type,
				idorder = x.pm.idorder,
				create_at = x.b.create_at,
				name=x.us.name,
				fee=x.or.fee,
				total=x.or.total,
				discount=x.or.discount
			}).FirstOrDefaultAsync();
		}


		public async Task<List<Tbl_paymentResponse>> GetPaymentAll()
		{
			var query = from or in _context.tbl_orders
						join pm in _context.tbl_payments on or.id equals pm.idorder
						join b in _context.tbl_bills on pm.id equals b.idpayment
						join us in _context.tbl_users on b.iduser equals us.id
						orderby pm.id descending
						select new { or, pm, b, us };
			return await query.Select(x => new Tbl_paymentResponse()
			{

				id = x.pm.id,
				receive = x.pm.receive,
				refund = x.pm.refund,
				type = x.pm.type,
				idorder = x.pm.idorder,
				create_at = x.b.create_at,
				name = x.us.name,
				fee = x.or.fee,
				total = x.or.total,
				discount = x.or.discount
			}).ToListAsync();
		}

	}
}
