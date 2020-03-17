using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace productSystem
{
    class ProductDataLayer
    {
        private string constring = " ";

        public ProductDataLayer()
        {
            constring = @"DataSource=(loacldb)\BLT188\SQLEXPRESS;Initial Catlog=Shrikantdb;Intergrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWwrite;MultiSubNetFailover=False";

        }
        public void InsertProductDetail(Product pt)
        {
            
            string insertquery = string.Format("insert into Product(ProductId,ProductName,Category,Price)" + "values('{0}','{1}',{2},'{3}');", pt.ProductId,pt.ProductName, pt.Category, pt.Price);
            using (SqlConnection con = new SqlConnection(constring))
            {
                int i = 0;
                con.Open();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand(insertquery, con);
                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (i > 0)
                    Console.WriteLine("ProductDetail is Inserted");
            }
           

        }
    }
    /*public void DeleteProductDetail(int ProductId)
    {
        int i = 0;
        string delquery = "delete Product where ProductId=" + ProductId;
        using(SqlConnection con = new SqlConnection())
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(delquery, con);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            if (i > 0)
            {
                Console.WriteLine("ProductDetail is Delete");

            }
        }
    }*/
   /* public void UpdateDetail(int ProductId, string Category)
    {
        string updatequery = "Update ProductDetail set Category" + "'" + Category + "'" + "where ProductId = "+ ProductId;
            int i = 0;
        using (SqlConnection con = new SqlConnection(constring))
        
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(Updatequery, con);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            if (i > 0)
            {
                Console.WriteLine("ProductDetail is Update");


            }
        }
    }*/


       /* public  List<Product>ShowAllProduct()
        {
            var reslist = new List<Product>();
            String selectquery = "select * from Product";
            using (SqlConnection con = new SqlConnection(constring)) 
            {
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand(selectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    reslist.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dr[0]),
                        ProductName = dr[1].ToString(),
                        Category = dr[2].ToString(),
                        Price = Convert.ToInt32(dr[3])
                    });
                }
            }*/
    

}
