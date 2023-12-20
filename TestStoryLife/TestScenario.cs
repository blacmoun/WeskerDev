using NUnit.Framework;
using StoryLife;
using System;
using System.Collections.Generic;

namespace Undertale
{
    public class ScenarioTest
    {
        [Test]
        public void TestScenarioLoading()
        {
            List<Scenario> scenarios = Scenario.GetScenarios();

            Assert.That(scenarios.Count, Is.GreaterThan(0), "Aucun scénario n'a été chargé depuis la base de données.");

            foreach (Scenario scenario in scenarios)
            {
                Assert.That(scenario.ImagePlace, Is.Not.Null, "ImagePlace est null pour un scénario.");
                Assert.That(scenario.ChapName, Is.Not.Null, "ChapName est null pour un scénario.");
                Assert.That(scenario.Choice1Name, Is.Not.Null, "Choice1Name est null pour un scénario.");
                Assert.That(scenario.Choice2Name, Is.Not.Null, "Choice2Name est null pour un scénario.");
                Assert.That(scenario.Choice3Name, Is.Not.Null, "Choice3Name est null pour un scénario.");
            }
        }
    }
}