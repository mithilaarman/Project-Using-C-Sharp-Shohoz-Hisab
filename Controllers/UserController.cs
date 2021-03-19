using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Application.MTbl_user;
using Hello.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Tbl_userController : ControllerBase
	{	
		private readonly ITbl_userService _nhanSuSerive;

		public Tbl_userController(ITbl_userService tbl_userService)
		{
			_nhanSuSerive = tbl_userService;
		}

		// GET: api/<Tbl_userController>
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return Ok(await _nhanSuSerive.GetAll());
		}

		// POST: api/Tbl_user/Create
		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody]Tbl_userRequest request)
		{
			return Ok(await _nhanSuSerive.Create(request));
		}

		// POST: api/Tbl_user/Update
		[HttpPost("Update")]
		public async Task<IActionResult> Update([FromBody]Tbl_userRequest request)
		{
			return Ok(await _nhanSuSerive.Update(request));
		}

		// POST: api/Tbl_user/Delete
		[HttpPost("Delete")]
		public async Task<IActionResult> Delete([FromBody]Tbl_userRequest request)
		{
			return Ok(await _nhanSuSerive.Delete(request));
		}

		[HttpPost("SearchUser")]
		public async Task<IActionResult> SearchProduct([FromBody]Tbl_userRequest request)
		{
			return Ok(await _nhanSuSerive.SearchUser(request));
		}

	}
}
