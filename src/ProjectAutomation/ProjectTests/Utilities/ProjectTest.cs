using NUnit.Framework;
using ProjectAutomation.Selenium;

namespace ProjectTests.Utilities
{
    [TestFixture]
    public class ProjectTest
    {
        // Driver initialization
        [TestFixtureSetUp]
        public void Init()
        {
            Driver.Initialize();
        }


        // Close browser
        [TestFixtureTearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
