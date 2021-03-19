using Hello.Application.MTbl_product;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
	public class Tbl_productApiClient : ITbl_productApiClient
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public Tbl_productApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<string> Create(Tbl_productRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_product/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}


		public async Task<string> Delete(Tbl_productRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_product/Delete", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetAll()
		{		
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.GetAsync("api/Tbl_product");

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(Tbl_productRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.PostAsync("api/Tbl_product/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}
	}
}
