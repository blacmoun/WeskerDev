using MySql.Data.MySqlClient;

namespace StoryLife
{
    public class Scenario
    {
        private string _imagePlace;
        private string _chapName;
        private string _choice1Name;
        private string _choice2Name;
        private string _choice3Name;

        public Scenario(string imagePlace,string chapName,string choice1Name, string choice2Name, string choice3Name) 
        { 
            _imagePlace = imagePlace;
            _chapName = chapName;
            _choice1Name = choice1Name;
            _choice2Name = choice2Name;
            _choice3Name = choice3Name;
        }
        public string ImagePlace
        {
            get 
            { 
                return _imagePlace; 
            }
        }
        public string ChapName
        {
            get
            {
                return _chapName;
            }
        }
        public string Choice1Name
        {
            get
            {
                return _choice1Name;
            }
        }
        public string Choice2Name
        {
            get
            {
                return _choice2Name;
            }
        }
        public string Choice3Name
        {
            get 
            {
                return _choice3Name;
            }
        }

        public static string GetFirstPlayerName()
        {
            string connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            String query = "SELECT nickname FROM undertale.player ORDER BY player_id LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            string playerName = cmd.ExecuteScalar()?.ToString();
            return playerName;
        }

    }
}
