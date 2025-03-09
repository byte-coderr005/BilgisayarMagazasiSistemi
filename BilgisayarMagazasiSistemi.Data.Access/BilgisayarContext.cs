using BilgisayarMagazasiSistemi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarMagazasiSistemi.Data.Access
{
    public class BilgisayarContext : DbContext
    {
        public BilgisayarContext(DbContextOptions<BilgisayarContext> options) : base(options)
        { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Ali",

                    Email = "ali054343@gmail.com",
                },
                new Customer
                {
                    Id = 2,
                    Name = "Burak",
                    Email = "gglglgl@hotmail.com"
                },
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Asus",
                        Price = 5000,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Msi",
                        Price = 6000,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Lenovo",
                        Price = 4000,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Hp",
                        Price = 4500,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Dell",
                        Price = 7000,
                        Stock = 100
                    }));
        }
    }          
}
