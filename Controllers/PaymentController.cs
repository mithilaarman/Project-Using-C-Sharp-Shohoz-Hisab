using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_payment;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ITbl_paymentApiClient _nhanSuApiClient;

        public PaymentController(ITbl_paymentApiClient sinhVienApiClient)
        {
            _nhanSuApiClient = sinhVienApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _nhanSuApiClient.GetPaymentMax();

            var model = JsonConvert.DeserializeObject<Tbl_paymentResponse>(response.ToString());

            return View(model);
        }


    }
}