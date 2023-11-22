namespace Undertale
{
    public class Game
    {
        private string _title;
        private DateOnly _date;

        public Game(string title,DateOnly date)
        {
            _title = title;
            _date = date;
        }
        
        public string Title
        {
            get 
            { 
                return _title;
            }
        }
        public DateOnly Date
        {
            get
            {
                return _date;
            }
        }

    }
}