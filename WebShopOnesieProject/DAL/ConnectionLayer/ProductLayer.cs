using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.ConnectionLayer
{
    public class ProductLayer
    {
        private string _connectionString; 
        public ProductLayer()
        {
            _connectionString = "Data Source=(local);Initial Catalog = OrderSystem;Integrated Security = True";

        }

        private SqlConnection _sqlConnection = null;
        public void OpenConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }
        public void CloseConnection()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            OpenConnection(_connectionString);

            string sql = "select CategoryName from tblCategory";
            SqlCommand myCommand = new SqlCommand(sql, _sqlConnection);

            using (SqlDataReader myDataReader = myCommand.ExecuteReader())
            {               
                while (myDataReader.Read())
                {
                    categories.Add(myDataReader["CategoryName"].ToString());
                }
            }

            CloseConnection();

            return categories;
        }
        public List<string> GetProducts()
        {
            List<string> products = new List<string>();
            OpenConnection(_connectionString);

            string sql = "select ProductName from tblProduct";
            SqlCommand myCommand = new SqlCommand(sql, _sqlConnection);

            using (SqlDataReader myDataReader = myCommand.ExecuteReader())
            {
                while (myDataReader.Read())
                {
                    products.Add(myDataReader["ProductName"].ToString());
                }
            }

            CloseConnection();

            return products;
        }
    }
}