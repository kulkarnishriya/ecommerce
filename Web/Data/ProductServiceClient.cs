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
    public class ProductServiceClient
    {
        private static readonly HttpClient _client = new HttpClient();

        public async IAsyncEnumerator<ProductModel> GetAllProducts()
         {             
            var products = new List<ProductModel>();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
             using(var client = new HttpClient(clientHandler))  
            {  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method 
                HttpResponseMessage response = await client.GetAsync(Constants.apiUrl);  
                if (response.IsSuccessStatusCode)  
                {  
                    var productArray = await response.Content.ReadAsAsync<ProductModel[]>(); 
                    products = productArray.ToList();
                }  
            }
            if(products !=null) 
            {
                foreach (var prod in products)
                {
                    prod.ProductImage = Constants.blobUrl + prod.ProductImage;
                    yield return prod;
                }
            }
            
         }

        /// <summary>
        /// Get product usind id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product entity</returns>
        public async Task<ProductModel> GetProductById(int id)
        {
            var product = new ProductModel();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
             using(var client = new HttpClient(clientHandler))  
            {  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  - Need to ewmove hardcoding of Urls.
                HttpResponseMessage response = await client.GetAsync(Constants.apiUrl+ id);  
                if (response.IsSuccessStatusCode)  
                {  
                    product = await response.Content.ReadAsAsync<ProductModel>(); 
                    product.ProductImage = Constants.blobUrl + product.ProductImage;
                }  
            }
            return product;

        }

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        public async Task<string> InsertProduct(ProductModel product)
        {
            string response = null;
            product.AddedBy = "Admin";
            product.Image = null;
            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var url = Constants.apiUrl;
            using (var client = new HttpClient(clientHandler))
            {
                var res = await client.PostAsync(url, data);
                response = res.Content.ReadAsStringAsync().Result;
            }

            return response;
        }

        // <summary>
        // Update product
        // </summary>
        // <param name="product">Product entity</param>
        public async Task<string> UpdateProduct(ProductModel product)
        {
            string response = null;
            product.AddedBy = "Admin";
            product.Image = null;
            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var url = Constants.apiUrl;
            using (var client = new HttpClient(clientHandler))
            {
                var res = await client.PostAsync(url+"Edit", data);
                response = res.Content.ReadAsStringAsync().Result;
            }

            return response;
        }

        /// <summary>
        /// Delete products
        /// </summary>
        /// <param name="ids">Ids of product to delete</param>
        public async Task<string> DeleteProducts(int id)
        {
            string response = null;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var url = Constants.apiUrl;
            using (var client = new HttpClient(clientHandler))
            {
                var res = await client.GetAsync(Constants.apiUrl + "Delete/" + id);
                response = res.Content.ReadAsStringAsync().Result;
            }

            return response;
        }

        /// <summary>
        /// Search products
        /// </summary>
        /// <param name="nameFilter">Name filter</param>
        public async IAsyncEnumerator<ProductModel> SearchProduct(
            string nameFilter = null)
        {
            var products = new List<ProductModel>();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
             using(var client = new HttpClient(clientHandler))  
            {  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  - Need to ewmove hardcoding of Urls.
                HttpResponseMessage response = await client.GetAsync(Constants.apiUrl + "SearchProduct/"+ nameFilter);
                if (response.IsSuccessStatusCode)  
                {  
                    var productArray = await response.Content.ReadAsAsync<ProductModel[]>(); 
                    //List<ProductModel> myList = JsonConvert.DeserializeObject<List<ProductModel>>(JsonList); 
                    products = productArray.ToList();
                }  
            }
            if(products !=null) 
            {
                foreach (var prod in products)
                {
                    prod.ProductImage = Constants.blobUrl + prod.ProductImage;
                    yield return prod;
                }
            }
        }

        public async IAsyncEnumerator<HistoryModel> GetHistory()
         {             
            var history = new List<HistoryModel>();
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
             using(var client = new HttpClient(clientHandler))  
            {  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method 
                HttpResponseMessage response = await client.GetAsync(Constants.apiUrl+"History");  
                if (response.IsSuccessStatusCode)  
                {  
                    var historyArray = await response.Content.ReadAsAsync<HistoryModel[]>(); 
                    history = historyArray.ToList();
                }  
            }
            if(history !=null) 
            {
                foreach (var hist in history)
                {
                    yield return hist;
                }
            }
            
         }

         /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        public async Task<string> InsertHistory(IList<ProductModel> products, string action)
        {
            string response = null;
            List<History> hist = new List<History>();
            foreach (var h in products)
            {
                var historyitem = new History();
                historyitem.UserId = 1;
                historyitem.ProductId = h.Id;
                historyitem.Quantity = 1;
                historyitem.Price = Convert.ToInt32(h.Price);
                historyitem.DateofPurchase = DateTime.Now;
                historyitem.Action = action;
                historyitem.Product = h;
                historyitem.User = new WebsiteUser(){
                    Id = 1,
                    Name = "Shriya",
                    EmailId = "Shriyu20",
                    AddressId = null,
                    Address = null
                };
                hist.Add(historyitem);
            }
            var json = JsonConvert.SerializeObject(hist);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var url = Constants.apiUrl;
            using (var client = new HttpClient(clientHandler))
            {
                var res = await client.PostAsync(url+"Checkout", data);
                response = res.Content.ReadAsStringAsync().Result;
            }

            return response;
        }

        
    }
}