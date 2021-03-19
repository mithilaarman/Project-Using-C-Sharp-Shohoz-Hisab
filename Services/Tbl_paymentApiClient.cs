using Hello.Application.MTbl_payment;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hello.WebApp.Services
{
	public class Tbl_paymentApiClient : ITbl_paymentApiClient
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public Tbl_paymentApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<string> GetAll()
		{		
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.GetAsync("api/Tbl_payment");

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetPaymentMax()
		{
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:44358");
			var response = await client.GetAsync("api/Tbl_payment/GetPaymentMax");

			return await response.Content.ReadAsStringAsync();
		}
	}
}
