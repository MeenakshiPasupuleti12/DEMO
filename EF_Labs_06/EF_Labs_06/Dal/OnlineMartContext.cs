using EF_Labs_06.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Labs_06.Dal
{
    internal class OnlineMartContext:DbContext
    {
        public OnlineMartContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
