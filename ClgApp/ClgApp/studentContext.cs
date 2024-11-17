using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClgApp
{
    internal class studentContext:DbContext
        
    {
       public studentContext():base()
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("student");
        }
        public DbSet<Student> Students { get;set; }
    }
}
