using System;
using System.Data.SqlClient;
namespace StockMarketPrediction
{
    /*
        CODE IS BROKEN 
        DO NOT RUN
    */

    class Program
    {
        static void db_query(String query)
        {
            
            SqlConnection connection = new SqlConnection("Data Source = mydb.cueaveoortkb.us - east - 1.rds.amazonaws.com, 1433; Initial Catalog = dow_jones; User ID = root; Password = ***********");
            connection.Open();
            
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            Console.WriteLine(reader);
        }
        static void Main(string[] args)
        {
            db_query("select * from YearPrice");

        }
    }
}