using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System.Net.Http;
using Web.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace Web.Data
{
    public class PaymentFunctionClient
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<string> PayForProduct(List<CartItemModel> products)
        {
            string response = null;
            var json = JsonConvert.SerializeObject(products);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var url = Constants.functionUrl;
            using (var client = new HttpClient(clientHandler))
            {
                var res = await client.PostAsync(url, data);
                response = res.Content.ReadAsStringAsync().Result;
            }

            return response;
        }

        
    }
}