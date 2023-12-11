using MySql.Data.MySqlClient;

namespace Undertale
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Undertale());
         
        }
        
    }
}