using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_product;
using Hello.WebApp.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ITbl_productApiClient _nhanSuApiClient;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(ITbl_productApiClient sinhVienApiClient, IWebHostEnvironment hostEnvironment)
        {
            _nhanSuApiClient = sinhVienApiClient;
            this._hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {       
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tbl_productRequest request)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(request.ImageFile.FileName);
            string extension = Path.GetExtension(request.ImageFile.FileName);
            request.image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/image/", fileName);
            request.image = fileName;
            
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await request.ImageFile.CopyToAsync(fileStream);
                request.ImageFile = null;
                await _nhanSuApiClient.Create(request);
            }
                
            return RedirectToAction("index");
        }


        [HttpPost]
        public async Task<IActionResult> Update(Tbl_productRequest request)
        {   
            if(request.ImageFile == null)
            {
                request.ImageFile = null;
                await _nhanSuApiClient.Update(request);

            }
            else
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(request.ImageFile.FileName);
                string extension = Path.GetExtension(request.ImageFile.FileName);
                request.image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/image/", fileName);
                request.image = fileName;

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await request.ImageFile.CopyToAsync(fileStream);
                    request.ImageFile = null;
                    await _nhanSuApiClient.Update(request);
                }
            }
            

            return RedirectToAction("index");
        }


    }
}