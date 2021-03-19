using Hello.Application.MTbl_payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
    public interface ITbl_paymentApiClient
    {
        public Task<string> GetAll();
        public Task<string> GetPaymentMax();
    }
}
