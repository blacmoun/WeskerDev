using MySql.Data.MySqlClient;

namespace Undertale
{
    internal static class Program
    {
        static List<string> customers = new List<string>();

        static void Main(string[] args)
        {
            customers = ExecuteQuerySelect();

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Undertale());
        }

        static private List<string> ExecuteQuerySelect()
        {
            List<string> queryResults = new List<string>();

            //TODO Improvement - use an external file to store sensitive data
            string connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";

            //prepare the connection
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            //prepare the query
            //TODO Improvement - Using @parameter and value to build the query
            //TODO Improvement - https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlparametercollection.addwithvalue?view=dotnet-plat-ext-7.0
            string query = "SELECT * FROM player, game;";

            //set and execute the query 
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            //retrieve values
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //TODO Improvement - how to extract multiple fields ?
                //TODO Improvement - how deal with numeric values ?
                queryResults.Add(reader.GetString(0) + " - " + reader.GetString(1));
            }
            return queryResults;
        }
    }
}