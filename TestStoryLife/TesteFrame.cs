namespace Undertale
{
    public class TestFrame
    {
        private Frame _expectedChoices;
        private Choice? _expectedFrame = null;

        [SetUp]
        public void Setup()
        {
            _expectedFrame = new Choice("n1");
            _expectedChoices = new Frame(null);
        }
    }
}