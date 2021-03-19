using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_product;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class OrderManageController : Controller
    {
        private readonly ITbl_productApiClient _nhanSuApiClient;

        public OrderManageController(ITbl_productApiClient sinhVienApiClient)
        {
            _nhanSuApiClient = sinhVienApiClient;
        }

        [HttpGet]
        public IActionResult Index()
        {       
            return View();
        }


    }
}