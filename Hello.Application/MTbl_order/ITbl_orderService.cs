using Hello.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_order
{
	public interface ITbl_orderService
	{
		public Task<int> Create(Tbl_orderRequest tbl_orderRequest);

		public Task<int> Update(Tbl_orderRequest tbl_orderRequest);

		public Task<int> Delete(Tbl_orderRequest tbl_orderRequest);


		public Task<List<Tbl_orderResponse>> GetOrder();

		public Task<tbl_order> GetOrderMax();


		public Task<List<Tbl_orderResponse>> GetOrderByIdOrder(int id);

	}
}
