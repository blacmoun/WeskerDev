using MySql.Data.MySqlClient;

namespace Undertale
{
    internal static class Program
    {
        static List<string> customers = new List<string>();

        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Undertale());
        }
    }
}