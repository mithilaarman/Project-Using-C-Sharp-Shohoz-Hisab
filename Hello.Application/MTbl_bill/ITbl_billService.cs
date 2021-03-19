using Hello.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_bill
{
	public interface ITbl_billService
	{
		public Task<int> Create(Tbl_billRequest tbl_billRequest);

		public Task<int> Update(Tbl_billRequest tbl_billRequest);

		public Task<int> Delete(Tbl_billRequest tbl_billRequest);

		public Task<List<Tbl_billResponse>> GetAll();


	}
}
