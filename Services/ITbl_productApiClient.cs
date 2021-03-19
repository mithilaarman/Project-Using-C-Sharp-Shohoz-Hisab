using Hello.Application.MTbl_product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
    public interface ITbl_productApiClient
    {
        public Task<string> GetAll();

        public Task<string> Create(Tbl_productRequest request);
        public Task<string> Delete(Tbl_productRequest request);
        public Task<string> Update(Tbl_productRequest request);
    }
}
