using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_order;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly ITbl_orderApiClient _nhanSuApiClient;

        public OrderController(ITbl_orderApiClient sinhVienApiClient)
        {
            _nhanSuApiClient = sinhVienApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _nhanSuApiClient.GetOrderMax();

            var model = JsonConvert.DeserializeObject<Tbl_orderResponse>(response.ToString());

            return View(model);
        }


    }
}