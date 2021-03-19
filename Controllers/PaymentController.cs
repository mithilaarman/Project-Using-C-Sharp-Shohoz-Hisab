using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_payment;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_paymentController : ControllerBase
	{	
		private readonly ITbl_paymentService _nhanSuSerive;

		public Tbl_paymentController(ITbl_paymentService tbl_paymentService)
		{
			_nhanSuSerive = tbl_paymentService;
		}

		// GET: api/<Tbl_paymentController>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return Ok(await _nhanSuSerive.GetAll());
		}

		// POST: api/Tbl_payment/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_paymentRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_payment/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_paymentRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_payment/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_paymentRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}
		[HttpGet("GetPaymentMax")]
		public async Task<IActionResult> GetOrderMax()
		{
			return Ok(await _nhanSuSerive.GetPaymentMax());
		}


		[HttpGet("GetPaymentAll")]
		public async Task<IActionResult> GetPaymentAll()
		{
			return Ok(await _nhanSuSerive.GetPaymentAll());
		}

	}
}
