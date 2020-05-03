using System;
using System.Data.SqlClient;
using Microsoft.ML;
using Microsoft.ML.Data;


namespace StockMarketPrediction
{
    class Program
    {
        public class MarketData
        {
            public DateTime Date { get; set; }
            public float Close { get; set; }
        }

        static void Main(String[] args) 
        {
            //Loading Data from Amazon RDS
            var mlcontext = new MLContext();
            var loader = mlcontext.Data.CreateDatabaseLoader<MarketData>();
            string connection = 
                "Data Source=mydb.cueaveoortkb.us-east-1.rds.amazonaws.com,1433;Initial Catalog=dow_jones;" +
                "User ID=root;" +
                "Password=Haresh115488";
            string sql_comand = "select [Date], [Close] from YearPrice";

            
            var source = new DatabaseSource(SqlClientFactory.Instance, connection, sql_comand );
            IDataView data_view = loader.Load(source);


        }
    }
}
