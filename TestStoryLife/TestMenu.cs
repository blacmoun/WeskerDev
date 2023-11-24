namespace Undertale
{
    public class TestMenu
    {
        private Menu _expectedMenu;
        private string _expecteddescription;

        [SetUp]
        public void Setup()
        {
            _expecteddescription = "Grand espace bleu";
            _expectedMenu = new Menu(_expecteddescription);
        }

        [Test]
        public void AllProperties_JustAfterInstantiation_GetValues()
        {
            Assert.That(_expecteddescription, Is.EqualTo(_expectedMenu.Description));
        }
    }
}