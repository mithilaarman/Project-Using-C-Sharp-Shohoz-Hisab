using Hello.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_payment
{
	public interface ITbl_paymentService
	{
		public Task<int> Create(Tbl_paymentRequest tbl_paymentRequest);

		public Task<int> Update(Tbl_paymentRequest tbl_paymentRequest);

		public Task<int> Delete(Tbl_paymentRequest tbl_paymentRequest);

		public Task<List<Tbl_paymentResponse>> GetAll();
		public Task<Tbl_paymentResponse> GetPaymentMax();

		public Task<List<Tbl_paymentResponse>> GetPaymentAll();

	}
}
