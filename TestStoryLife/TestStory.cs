namespace Undertale
{
    public class TestStory
    {
        private Story _expectedFrame;
        private Choice? _expectedChoices = null;

        [SetUp]
        public void Setup()
        {
            _expectedChoices = new Choice("n1");
            _expectedFrame = new Story(null);
        }
    }
}
