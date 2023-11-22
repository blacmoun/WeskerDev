namespace Undertale
{
    public class Frame
    {
        private List<Choice> _choices = new List<Choice>();

        public Frame(List<Choice> choice)
        {
            _choices = choice;
        }

        public List<Choice> Choices
        {
            get
            {
                return _choices;
            }
        }
    }
}
