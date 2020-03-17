using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var product = context.Products;
            product.Add(new Product
            {
                Name = "Coffee drink",
                Price = 40
            });
            context.SaveChanges();
        }
    }
    public class ProductDBContext:DbContext
    {
        public ProductDBContext():base("ProductDBContext")
        {
         
        }
        public DbSet<Product> Products { get; set; }
    }
    public class Product
    {
        public int ProductID { get; set; }   //PoCo class
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
