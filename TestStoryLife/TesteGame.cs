namespace Undertale
{
    public class TestGame
    {
        private Game _expectedGame;
        private string _expectedtitle;
        private DateOnly _expecteddate;

        [SetUp]
        public void Setup()
        {
            _expectedtitle = "Undetale";
            _expecteddate = new DateOnly();
            _expectedGame = new Game(_expectedtitle, _expecteddate);
        }

        [Test]
        public void AllProperties_JustAfterInstantiation_GetValues()
        {
            Assert.That(_expectedtitle, Is.EqualTo(_expectedGame.Title));
            Assert.That(_expecteddate, Is.EqualTo(_expectedGame.Date));
        }
    }
}