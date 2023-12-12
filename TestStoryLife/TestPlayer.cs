using NUnit.Framework;
using MySql.Data.MySqlClient;

namespace Undertale
{
    [TestFixture]
    public class PlayerTests
    {
        private string connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";

        [Test]
        public void SendNickname_AddsToDatabase_Success()
        {
            // Arrange
            string nicknameToAdd = "TestNickname";
            Player.SendNickname(nicknameToAdd);

            // Act
            bool isNicknameAdded = CheckIfNicknameExistsInDatabase(nicknameToAdd);

            // Assert
            Assert.That(isNicknameAdded, Is.True, $"Nickname '{nicknameToAdd}' was not added to the database.");
        }

        private bool CheckIfNicknameExistsInDatabase(string nickname)
        {
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM undertale.player WHERE nickname = @nickname";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nickname", nickname);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
