using Hello.Application.MTbl_order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
	public class Tbl_orderApiClient : ITbl_orderApiClient
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public Tbl_orderApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<string> Create(Tbl_orderRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_order/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}


		public async Task<string> Delete(Tbl_orderRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_order/Delete", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetAll()
		{		
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.GetAsync("api/Tbl_order");

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetOrderMax()
		{
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.GetAsync("api/Tbl_order/GetOrderMax");

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(Tbl_orderRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_order/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}
	}
}
