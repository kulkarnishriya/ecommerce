using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Web.Data;

namespace Web.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
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
            return View(productList);

        }

        public async Task<IActionResult> EditDelete(int id)
        {
            if(id != null)
            {
                 var productServiceClient = new ProductServiceClient();
            
            var product = await productServiceClient.GetProductById(id);
            
                if(product != null)
                {
                    return View(product);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductModel model)
        {
            if(ModelState.IsValid)
            {
                var productList = new List<ProductModel>();
                
                var productServiceClient = new ProductServiceClient();
                var prod = await productServiceClient.GetProductById(model.Id);
                if(prod !=null)
                {
                    var modelPost = prod;
                    modelPost.Name = model.Name;
                    modelPost.Price = model.Price;
                    modelPost.Description = model.Description;
                    modelPost.Category = model.Category;
                    modelPost.ProductImage = prod.ProductImage.Replace (Constants.blobUrl, "");
                    var response = await productServiceClient.UpdateProduct(modelPost);
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
            else 
            {
                return RedirectToAction("Error"); 
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            if(id != null)
            {
                var productServiceClient = new ProductServiceClient();
            
                var product = await productServiceClient.DeleteProducts(id);
            
                if(product != null)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Error");
        }
    }
}