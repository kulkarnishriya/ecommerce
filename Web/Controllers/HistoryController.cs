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
    public class HistoryController : Controller
    {
        // #region Fields

        #region Methods

        // GET: /History/
        public async Task<IActionResult> Index()
        {
             //var historyItems = new List<HistoryModel>();

            // if (Session.GetString(_cartItesmSessionKey) != null)
            //     cartItems = JsonConvert.DeserializeObject<List<CartItemModel>>(Session.GetString(_cartItesmSessionKey));
            // historyItems.Add(new HistoryModel(){
            //     Id = 1,
            //     Name = "Laptop",
            //     Price = 25000,
            //     Quantity = 1,
            //     ProductImage = "/Images/asus gtx 1070 strix.png",
            //     Action = "Buy",
            //     DateofPurchase = new DateTime(2020,1,24,0,0,0)
            // });
            // return View(historyItems);
            var historyList = new List<HistoryModel>();
            
            var productServiceClient = new ProductServiceClient();
            
            IAsyncEnumerator<HistoryModel> products = productServiceClient.GetHistory();
            while (await products.MoveNextAsync())
            {
                historyList.Add(products.Current);
            }
            await products.DisposeAsync();

            return View(historyList);
            
        }

       
        #endregion
    }
}
