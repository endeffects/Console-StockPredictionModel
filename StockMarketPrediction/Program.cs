using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace StockMarketPrediction
{
    /*
        CODE IS BROKEN 
        DO NOT RUN
    */

    class Program
    {
        static List<String> db_query(String query, String column)
        {
            List<String> list = new List<String>();
            SqlConnection connection = new SqlConnection("Data Source = mydb.cueaveoortkb.us-east-1.rds.amazonaws.com, 1433; Initial Catalog = dow_jones; User ID = root; Password = Haresh115488");
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[column]));
                }
            }

            return list;
        }
        static void Main(string[] args)
        {
                List<String> date = db_query("select [Date] from YearPrice", "Date");
                List<String> close = db_query("select [Close]  from YearPrice", "Close");

        }
    }
}