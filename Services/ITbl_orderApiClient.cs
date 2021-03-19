using Hello.Application.MTbl_order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
    public interface ITbl_orderApiClient
    {
        public Task<string> GetAll();

        public Task<string> Create(Tbl_orderRequest request);
        public Task<string> Delete(Tbl_orderRequest request);
        public Task<string> Update(Tbl_orderRequest request);

        public Task<string> GetOrderMax();
    }
}
