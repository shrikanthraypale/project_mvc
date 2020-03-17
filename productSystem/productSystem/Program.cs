using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDataLayer rdl = new ProductDataLayer();
            Product pt = Set();

              
            rdl.InsertProductDetail(pt);
           // rdl.UpdateDetail(2,"books");
             /* Product srt = rdl.ShowAllProduct();
             //rdl.DeleteProductDetail();
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",srt.ProductId, srt.ProductName, srt.Category, srt.Price);
            rdl.InsertProductDetail(pt);
            List<Product> locallistr = rdl.ShowAllProduct();
            foreach (Product pts in locallistr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    pts.ProductId, pts.ProductName, pts.Category, pts.Price);
            }*/
            Console.Read();
        }
        public static int Set()
        {
            Console.WriteLine("Enter the Id");
            int ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name");
            char ProductName = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Product Category");
            int Category =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price");
            int Price = Convert.ToInt32(Console.ReadLine());

            Product pts = new Product();
            pts.ProductId = ProductId;
            pts.ProductName=ProductName;
            pts.Category = Category;
            pts.Price = Price;
            
           
        }
    }
}
