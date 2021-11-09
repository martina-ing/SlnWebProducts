using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebProducts.Models;

namespace WebProducts.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("KeyProductDB") { }
        public DbSet<Product> Products { get; set; }


    }
}