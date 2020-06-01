using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class WebsiteUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
