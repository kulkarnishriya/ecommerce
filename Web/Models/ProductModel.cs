using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web.Models
{
    public class ProductModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public string Description { get; set; }

        public string ProductImage { get; set; }

        public decimal Rating { get; set; }

        public int ReviewCount { get; set; }

        public DateTime DateAdded { get; set; }

        public string Category { get; set; }

        public string Manufacturers { get; set; }

        public string AddedBy {get; set;}

        public IFormFile Image {get; set;}
    }
}