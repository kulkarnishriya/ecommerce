using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class Cart
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual WebsiteUser User { get; set; }
    }
}
