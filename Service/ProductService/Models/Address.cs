using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class Address
    {
        public Address()
        {
            WebsiteUser = new HashSet<WebsiteUser>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<WebsiteUser> WebsiteUser { get; set; }
    }
}
