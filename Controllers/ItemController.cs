using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_item;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_itemController : ControllerBase
	{	
		private readonly ITbl_itemService _nhanSuSerive;

		public Tbl_itemController(ITbl_itemService tbl_itemService)
		{
			_nhanSuSerive = tbl_itemService;
		}

		// GET: api/<Tbl_itemController>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return Ok(await _nhanSuSerive.GetAll());
		}

		

		// POST: api/Tbl_item/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_itemRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_item/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_itemRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}
		[HttpPost("UpdateQuanlity")]
		public async Task<IActionResult> UpdateQuanlity([FromBody]Tbl_itemRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		[HttpPost("UpdateDiscount")]
		public async Task<IActionResult> UpdateDiscount([FromBody]Tbl_itemRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_item/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_itemRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}



	}
}
