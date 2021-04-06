using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp35
{


    class Store
    {
        public int StoreID { get; set; }

        public Product StoreProduct { get; set; }

        public string location { get; set; }

        public List<Product> Products { get; set; }

    }

    class Product
    {
        public int ProductID { get; set; }

        public Order OrderID { get; set; }

        public string Description { get; set; }

        public List<Order> Orders { get; set; }


    }

    class Order
    {
        public int OrderID { get; set; }

        public Product ProductID { get; set; }

        public string Information { get; set; }

        public List<Product> Products { get; set; }

    }

    class ProductContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            using (ProductContext context = new ProductContext())
            {
                context.Database.EnsureCreated();
#orders
    var result =
    db.Orders
      .Where(Product => Product.ProductID == id)
      .SelectMany(Information => Order.OrdersID)
      .ToList();

#the maximum  
    int maxOrder;
    var result1 = 
    db.Orders
        .Where(Product => Product.ProductID == id)
        .maxOrder= Information.Max
        .ToList();

            }
        }
    }
}
