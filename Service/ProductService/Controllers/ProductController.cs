using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Interface;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net;
using Services.ProductService.Operations;
using ProductService.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService IProductService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            IProductService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Products = new List<Product>();
            Products.AddRange(IProductService.GetAllProducts());
            return Ok(Products);
        }

        [HttpGet]
        [Route("/product/{id}")]
        public IActionResult Get(int id)
        {
            var Product = IProductService.GetProductById(id);
            return Ok(Product);
        }

        [HttpGet]
        [Route("SearchProduct/{name}")]
        public IEnumerable<Product> SearchProduct(string name=null)
        {
            return IProductService.SearchProduct(name);
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]Product product)
        {
            IProductService.InsertProduct(product);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("Edit")]
        public HttpResponseMessage Edit(Product product)
        {
            IProductService.UpdateProduct(product);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            IProductService.DeleteProducts(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("Checkout")]
        public HttpResponseMessage CheckOutProduct([FromBody]History product)
        {
            IProductService.CheckOutProduct(product);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("History")]
        public IActionResult GetProductHistory()
        {
            var History = new List<History>();
            History.AddRange(IProductService.GetProductHistory());
            return Ok(History);
        }

    }
}
