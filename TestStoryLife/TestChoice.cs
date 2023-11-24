namespace Undertale
{
    public class TestChoice
    {
        private Choice _expectedChoice;
        private string _expecteddescription;

        [SetUp]
        public void Setup()
        {
            _expecteddescription = "Description of ...";
            _expectedChoice = new Choice(_expecteddescription);
        }

        [Test]
        public void AllProperties_JustAfterInstantiation_GetValues()
        {
            Assert.That(_expecteddescription, Is.EqualTo(_expectedChoice.Description));
        }
    }
}