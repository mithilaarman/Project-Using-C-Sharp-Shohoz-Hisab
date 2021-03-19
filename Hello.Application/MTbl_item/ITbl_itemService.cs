using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_item
{
	public interface ITbl_itemService
	{
		public Task<int> Create(Tbl_itemRequest tbl_itemRequest);

		public Task<int> Update(Tbl_itemRequest tbl_itemRequest);

		public Task<int> Delete(Tbl_itemRequest tbl_itemRequest);

		public Task<int> UpdateQuanlity(Tbl_itemRequest tbl_itemRequest);

		public Task<int> UpdateDiscount(Tbl_itemRequest tbl_itemRequest);

		public Task<List<Tbl_itemResponse>> GetAll();

	}
}
