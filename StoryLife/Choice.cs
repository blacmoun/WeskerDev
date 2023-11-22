namespace Undertale
{
    public class Choice
    {
        private string _description;

        public Choice(string description)
        {
            _description = description;
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }
    }
}
