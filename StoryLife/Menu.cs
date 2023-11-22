namespace Undertale
{
    public class Menu
    {
        private string _description;

        public Menu(string description)
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