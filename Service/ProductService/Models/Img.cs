using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class Img
    {
        public Img()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string BlobUrl { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
