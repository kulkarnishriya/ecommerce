using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class History
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime DateofPurchase { get; set; }
        public string Action { get; set; }

        public virtual Product Product { get; set; }
        public virtual WebsiteUser User { get; set; }
    }
}
