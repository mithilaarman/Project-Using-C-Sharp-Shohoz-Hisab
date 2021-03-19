using Hello.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Application.MTbl_user
{
	public interface ITbl_userService
	{
		public Task<int> Create(Tbl_userRequest tbl_userRequest);

		public Task<int> Update(Tbl_userRequest tbl_userRequest);

		public Task<int> Delete(Tbl_userRequest tbl_userRequest);

		public Task<List<Tbl_userResponse>> GetAll();

		public Task<List<Tbl_userResponse>> SearchUser(Tbl_userRequest tbl_userRequest);
	}
}
