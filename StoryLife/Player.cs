using MySql.Data.MySqlClient;

namespace Undertale
{
    public class Player
    {
        private string _nickname;

        public Player(string nickname)
        {
            _nickname = nickname;
        }

        public string Name
        {
            get
            {
                return _nickname;
            }
        }

        public static void SendNickname(string nickname)
        {
            string connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            String query = "INSERT INTO undertale.player (nickname) VALUES (" + nickname + ")";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
