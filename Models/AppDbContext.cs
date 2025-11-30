using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderManagement.Models
{
    using System.Data.Entity;
    using OrderManagement.Models;
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MyConnectionString")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID)
                .WillCascadeOnDelete(true);


           
            modelBuilder.Entity<Log>()
                .HasOptional(l => l.Order)
                .WithMany()
                .HasForeignKey(l => l.OrderID)
                .WillCascadeOnDelete(false);  

           
            modelBuilder.Entity<Log>()
                .HasOptional(l => l.Customer)
                .WithMany()
                .HasForeignKey(l => l.CustomerID)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }



    }
}
