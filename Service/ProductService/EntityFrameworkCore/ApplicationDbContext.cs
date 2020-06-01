using ProductService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Img> Img { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<WebsiteUser> WebsiteUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Cart>(eb=> {eb.HasNoKey();
            eb.ToTable("Cart");
            });
            builder.Entity<History>(eb=> {eb.HasNoKey();
            eb.ToTable("History");
            });;
            builder.Entity<Img>().ToTable("Img");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<WebsiteUser>().ToTable("WebsiteUser");
           
        }
    }
}
