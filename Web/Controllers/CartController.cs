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
using Web.Data;
using System.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Session;


namespace Web.Controllers
{
    //[Authorize]
    public class CartController : Controller
    {
       
         private readonly string _cartItesmSessionKey = "CartItems";
         private readonly string _cartItemsCountSessionKey = "CartItemsCount";

        #region Methods

        // GET: /Cart/
        public IActionResult Index()
        {
             var cartItems = new List<CartItemModel>();

            // cartItems.Add(new CartItemModel(){
            //     Id = 1,
            //     Name = "Laptop",
            //     Price = 25000,
            //     OldPrice = 3000,
            //     Quantity = 1,
            //     MaxCartQuantity = 5,
            //     ProductImage = "/Images/asus gtx 1070 strix.png"
            // });
             if (HttpContext.Session.GetString(_cartItesmSessionKey) != null)
                cartItems = JsonConvert.DeserializeObject<List<CartItemModel>>(HttpContext.Session.GetString(_cartItesmSessionKey));
            return View(cartItems);
        }

        [Route("/Cart/Remove/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            if(id == null)
                return RedirectToAction("Index");
            // check if product exist
             var productServiceClient = new ProductServiceClient();
             var selectedItem = await productServiceClient.GetProductById(id);
             var cartItems = new List<CartItemModel>();
            if (HttpContext.Session.GetString(_cartItesmSessionKey) != null)
                cartItems = JsonConvert.DeserializeObject<List<CartItemModel>>(HttpContext.Session.GetString(_cartItesmSessionKey));
            
            if (cartItems.Exists(x => x.Id == selectedItem.Id))
                cartItems.RemoveAll(x=> x.Id == selectedItem.Id);

            //Remove from session
            HttpContext.Session.Remove(_cartItesmSessionKey);
            HttpContext.Session.Remove(_cartItemsCountSessionKey);

            HttpContext.Session.SetString(_cartItesmSessionKey, JsonConvert.SerializeObject(cartItems));
            HttpContext.Session.SetInt32(_cartItemsCountSessionKey, cartItems.Count());
            return RedirectToAction("Index");
        }

        //POST: /Cart/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(int id)
        {
            if(id == null)
                return RedirectToAction("Index");

            // check if product exist
             var productServiceClient = new ProductServiceClient();
             var selectedItem = await productServiceClient.GetProductById(id);
            
            if(selectedItem == null)
                return RedirectToAction("Index");

            // check if there are already cart instance
            var cartItems = new List<CartItemModel>();
            if (HttpContext.Session.GetString(_cartItesmSessionKey) != null)
                cartItems = JsonConvert.DeserializeObject<List<CartItemModel>>(HttpContext.Session.GetString(_cartItesmSessionKey));

            // check if the item are already in the cart
            // if the item is already in the cart,
            // increase the quantity by 1
            if (cartItems.Exists(x => x.Id == selectedItem.Id))
                cartItems.Find(x => x.Id == selectedItem.Id).Quantity++;
            else
            {
                var item = new CartItemModel
                {
                    Id = selectedItem.Id,
                    Name = selectedItem.Name,
                    Price = selectedItem.Price,
                    ProductImage = selectedItem.ProductImage,
                    Quantity = 1
                };

                cartItems.Add(item);
            }

            // add to session
            HttpContext.Session.SetString(_cartItesmSessionKey, JsonConvert.SerializeObject(cartItems));
            HttpContext.Session.SetInt32(_cartItemsCountSessionKey, cartItems.Count());

            return RedirectToAction("Index");
        }

        //GET: /Cart/Checkout
        public async Task<IActionResult> Checkout(CartItemModel cartItem)
        {
            if(ModelState.IsValid)
            {
                var paymentServiceClient = new PaymentFunctionClient();
                var productServiceClient = new ProductServiceClient();
                var cartItems = new List<CartItemModel>();
                var products = new List<ProductModel>();
            if (HttpContext.Session.GetString(_cartItesmSessionKey) != null)
                cartItems = JsonConvert.DeserializeObject<List<CartItemModel>>(HttpContext.Session.GetString(_cartItesmSessionKey));

                var response = await paymentServiceClient.PayForProduct(cartItems);
                if(response !=null)
                {
                    cartItems.Clear();
                    HttpContext.Session.Remove(_cartItesmSessionKey);
                    HttpContext.Session.Remove(_cartItemsCountSessionKey);
                    ViewBag.Message = response;
                    products = JsonConvert.DeserializeObject<List<ProductModel>>(response);
                    var res = await productServiceClient.InsertHistory(products,"Buy");
                    
                    return View("PaymentSuccess");
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

        public async Task<IActionResult> PaymentSuccess(string message)
        {
            ViewBag.Message = message;
            return View();
        }


        #endregion
    }
}
