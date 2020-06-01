using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;

namespace Web.Models
{
    public class History
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime DateofPurchase { get; set; }
        public string Action { get; set; }

        public ProductModel Product { get; set; }
        public WebsiteUser User { get; set; }
        
    }
}