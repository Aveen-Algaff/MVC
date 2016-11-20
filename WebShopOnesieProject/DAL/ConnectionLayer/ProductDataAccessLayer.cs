using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;

namespace WebShopOnesie
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ImagePath { get; set; }
    }
    public class ProductDataAccessLayer
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> listProducts = new List<Product>();
            string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Product product = new Product();
                    product.ProductID = Convert.ToInt32(rdr["ProductID"]);
                    product.ProductName = rdr["ProductName"].ToString();
                    product.ProductDescription = rdr["ProductDescription"].ToString();
                    product.ImagePath = rdr["ImagePath"].ToString();
                    product.ProductPrice = Convert.ToDouble(rdr["ProductPrice"]);

                    listProducts.Add(product);
                }
            }
            return listProducts;
        }
    }
}
