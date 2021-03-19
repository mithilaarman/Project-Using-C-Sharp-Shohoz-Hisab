using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_bill;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_billController : ControllerBase
	{	
		private readonly ITbl_billService _nhanSuSerive;

		public Tbl_billController(ITbl_billService tbl_billService)
		{
			_nhanSuSerive = tbl_billService;
		}

		// GET: api/<Tbl_billController>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return Ok(await _nhanSuSerive.GetAll());
		}

		// POST: api/Tbl_bill/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_billRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_bill/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_billRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_bill/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_billRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}

	}
}
