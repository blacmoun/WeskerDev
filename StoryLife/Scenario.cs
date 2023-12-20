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

        public static List<Scenario> GetScenarios()
        {
            string connString = "server=localhost;user=admin;database=undertale;port=3306;password=admin;";
            List<Scenario> scenarios = new List<Scenario>();

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT id, imagePlace, chapName, choice1Name, choice2Name, choice3Name FROM undertale.scenario";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string? imagePlace = reader.IsDBNull(reader.GetOrdinal("imagePlace")) ? null : reader.GetString("imagePlace");
                        string? chapName = reader.IsDBNull(reader.GetOrdinal("chapName")) ? null : reader.GetString("chapName");
                        string? choice1Name = reader.IsDBNull(reader.GetOrdinal("choice1Name")) ? null : reader.GetString("choice1Name");
                        string? choice2Name = reader.IsDBNull(reader.GetOrdinal("choice2Name")) ? null : reader.GetString("choice2Name");
                        string? choice3Name = reader.IsDBNull(reader.GetOrdinal("choice3Name")) ? null : reader.GetString("choice3Name");

                        Scenario scenario = new Scenario(imagePlace, chapName, choice1Name, choice2Name, choice3Name);
                        scenarios.Add(scenario);
                    }
                }
            }
            return scenarios;
        }
    }
}
