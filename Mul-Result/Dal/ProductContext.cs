using Mul_Result.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mul_Result.Dal
{
    public class ProductContext:DbContext
    {
        public ProductContext():base()
        {

        }
        protected  override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
        public DbSet<Product> Products { get; set; }
        public object Product { get; internal set; }
    }
}