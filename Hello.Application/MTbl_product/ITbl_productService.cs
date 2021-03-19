using Hello.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_product
{
	public interface ITbl_productService
	{
		public Task<int> Create(Tbl_productRequest tbl_productRequest);

		public Task<int> Update(Tbl_productRequest tbl_productRequest);

		public Task<int> Delete(Tbl_productRequest tbl_productRequest);

		public Task<List<Tbl_productResponse>> GetAll();

		public Task<List<Tbl_productResponse>> GetFood();

		public Task<List<Tbl_productResponse>> GetDrink();

		public Task<List<Tbl_productResponse>> SearchProduct(Tbl_productRequest tbl_productRequest);

	}
}
