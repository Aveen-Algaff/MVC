using System;
using System.Collections.Generic;
using System.Data;
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

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void SetComnd(string stmt)
        {
            con.ConnectionString = "Data Source=(local);Initial Catalog = OrderSystem;Integrated Security = True";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = stmt;
            //con.Close();
        }
        private void DisConnect()
        {
            con.Close();
        }
        public int RunInsDelUpd(string stmt)
        {
            //code

            SetComnd(stmt);
            int rows = cmd.ExecuteNonQuery();
            DisConnect();
            return rows;
        }
        public DataTable RunQuery(string select)
        {
            //code
            SetComnd(select);
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            DisConnect();
            return tbl;
        }
        public bool logIn(string user, string pass)
        {
            string sql = ("select * from tblCustomer where FirstName='"+ user +"'and Password='" + pass+"'");
            DataTable tbl= RunQuery(sql);
            if (tbl.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public bool register(string FName, string LName, string Password, string Confirm, string city, string Street, int ZipCod, string Address, string Email)
        //{
        //    string sql = "Insert in to tblRegister values('" + FName + "','" + Password + "','" + Confirm + "','" + Address + "','" + Email + "','" + LName + "','" + city + "','" + Street + "','" + ZipCod + "')";

        //}

    }
}