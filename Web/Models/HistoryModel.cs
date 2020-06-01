using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;

namespace Web.Models
{
    public class HistoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ProductImage { get; set; }

        public DateTime DateofPurchase {get; set; }

        public string Action {get; set; }
    }
}
