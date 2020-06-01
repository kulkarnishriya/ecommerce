using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Web.Models;
using System.Net.Http;
using Web.Data;
using System.Net.Http.Headers;

namespace Web.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var productList = new List<ProductModel>();
            
            var productServiceClient = new ProductServiceClient();
            
            IAsyncEnumerator<ProductModel> products = productServiceClient.GetAllProducts();
            while (await products.MoveNextAsync())
            {
                productList.Add(products.Current);
            }
            await products.DisposeAsync();
            if(productList !=null)
            {
                productList = productList.OrderByDescending(x=> x.DateAdded).Take(3).ToList();
            }

            return View(productList);

            // var productEntities = new List<ProductModel>();
            // productEntities.Add(new ProductModel(){
            //     Id = 1,
            //     Name = "Laptop",
            //     Price = 25000,
            //     OldPrice = 3000,
            //     Description = "Laptop",
            //     ProductImage = "/Images/asus gtx 1070 strix.png",
            //     Rating = 5,
            //     ReviewCount = 2,
            //     Category = "Hardware",
            //     Manufacturers = "Azus"
            // });
            // productEntities.Add(new ProductModel(){
            //     Id = 2,
            //     Name = "Mobile",
            //     Price = 10000,
            //     OldPrice = 10000,
            //     Description = "Mobile",
            //     ProductImage = "/Images/asus gtx 1070 strix.png",
            //     Rating = 5,
            //     ReviewCount = 4,
            //     Category = "Mobile",
            //     Manufacturers = "Azus"
            // });
        }

        public IActionResult ProductAdd()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductModel model)
        {
            try
            {
                if(ModelState.IsValid)
            {
                var productServiceClient = new ProductServiceClient();
                var blobServiceClient = new BlobServiceClient();
                
                var blobResponse = await blobServiceClient.UploadToBlob(model.Image);
                model.ProductImage = model.Image.FileName;
                var response = await productServiceClient.InsertProduct(model);
                 if(response !=null)
                    {
                        return RedirectToAction("Index");
                    }
                    else 
                    {
                        return RedirectToAction("Error"); 
                    }
            }
            else 
                {
                   return RedirectToAction("Error");  
                }
                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }
        
        public async Task<IActionResult> AllProducts()
        {
            var productList = new List<ProductModel>();
            
            var productServiceClient = new ProductServiceClient();
            
            IAsyncEnumerator<ProductModel> products = productServiceClient.GetAllProducts();
            while (await products.MoveNextAsync())
            {
                productList.Add(products.Current);
            }
            await products.DisposeAsync();

            return View(productList);
        }

        public async Task<IActionResult> ProductSearch(string name)
        {
            if(name != string.Empty && name != null)
            {
                var productServiceClient = new ProductServiceClient();
                IAsyncEnumerator<ProductModel> products = productServiceClient.SearchProduct(name);
                
                var productList = new List<ProductModel>();

                while (await products.MoveNextAsync())
                {
                    productList.Add(products.Current);
                }
                await products.DisposeAsync();

                ViewData["ProductSearchName"] = name;

                return View(productList);
            }

            return RedirectToAction("Index");
        }

        // GET: /Home/Product ?? /Product/{id}
        public async Task<IActionResult> Product(int id)
        {
            if(id != null)
            {
                // var productEntity = new ProductModel(){
                // Id = 1,
                // Name = "Laptop",
                // Price = 25000,
                // OldPrice = 3000,
                // Description = "Laptop",
                // ProductImage = "/Images/asus gtx 1070 strix.png",
                // Rating = 5,
                // ReviewCount = 2,
                // Category = "Hardware",
                // Manufacturers = "Azus"

            var productServiceClient = new ProductServiceClient();
            
            var product = await productServiceClient.GetProductById(id);
            
                if(product != null)
                {
                    return View(product);
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
