namespace Undertale
{
    public class TestPlayer
    {
        private Player _expectedPlayer;
        private string _expectedname;

        [SetUp]
        public void Setup()
        {
            _expectedname = "Undetale";
            _expectedPlayer = new Player(_expectedname);
        }

        [Test]
        public void AllProperties_JustAfterInstantiation_GetValues()
        {
            Assert.That(_expectedname, Is.EqualTo(_expectedPlayer.Name));
        }
    }
}