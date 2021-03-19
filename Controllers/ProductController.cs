using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_product;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_productController : ControllerBase
	{	
		private readonly ITbl_productService _nhanSuSerive;

		public Tbl_productController(ITbl_productService tbl_productService)
		{
			_nhanSuSerive = tbl_productService;
		}

		// GET: api/<Tbl_productController>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return Ok(await _nhanSuSerive.GetAll());
		}

		[HttpGet("GetFood")]
		public async Task<IActionResult> GetFood()
		{
			return Ok(await _nhanSuSerive.GetFood());
		}

		[HttpGet("GetDrink")]
		public async Task<IActionResult> GetDrink()
		{
			return Ok(await _nhanSuSerive.GetDrink());
		}

		// POST: api/Tbl_product/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_productRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_product/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_productRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_product/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_productRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}

		
	[HttpPost("SearchProduct")]
	public async Task<IActionResult> SearchProduct([FromBody]Tbl_productRequest request)
	{
		return Ok(await _nhanSuSerive.SearchProduct(request));
	}

}
}
