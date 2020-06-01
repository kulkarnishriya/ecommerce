using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AddedBy { get; set; }
        public int? ImageId { get; set; }
        public DateTime DateAdded { get; set; }
        public String ProductImage {get; set;}
        
        public virtual Img Image { get; set; }
    }
}
