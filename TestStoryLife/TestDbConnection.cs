using System;
using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Data;

namespace DBConnector
{
    [TestFixture]
    public class DBConnectorTests
    {
        private string _connString;

        [SetUp]
        public void Setup()
        {
            _connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";
        }

        [Test]
        public void TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connString))
                {
                    connection.Open();
                    Assert.That(connection.State, Is.EqualTo(ConnectionState.Open));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Erreur lors de la connexion à la base de données : {ex.Message}");
            }
        }
    }
}
