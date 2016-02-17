using NUnit.Framework;
using ProjectAutomation;
using ProjectAutomation.Pages;
using ProjectAutomation.Selenium;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ProjectTests.Smoke_Tests
{
    
    public class RegisterTests
    {
        // Driver initialization
        [TestFixtureSetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        // Register with Gmail
        [Test]
        public void User_Can_Register_With_Gmail()
        {
            RegisterPage.GoTo();
            RegisterPage.RegisterAs("charlie.brown.qa@gmail.com").WithPassword("qalozinka").RegisterGmail();
            Assert.IsTrue(HomePage.IsAt, "Failed to register with Gmail.");
        }
        
        // Register with Facebook
        [Test]
        public void User_Can_Register_With_Facebook()
        {
            RegisterPage.GoTo();
            RegisterPage.RegisterAs("brad.powers.qa@gmail.com").WithPassword("qalozinka").RegisterFacebook();
            Assert.IsTrue(HomePage.IsAt, "Failed to register with Facebook.");
        }

        // Register with Linkedin
        [Test]
        public void User_Can_Register_With_Linkedin()
        {
            RegisterPage.GoTo();
            RegisterPage.RegisterAs("qanindza@gmail.com").WithPassword("qalozinka").RegisterLinkedin();
            Assert.IsTrue(HomePage.IsAt, "Failed to register with LinkedIn.");
        }

        // Register with Twitter
        [Test]
        public void User_Can_Register_With_Twitter()
        {
            RegisterPage.GoTo();
            RegisterPage.RegisterAs("ferdinand.rio.qa@gmail.com").WithPassword("qalozinka").WithEmail("ferdinand.rio.qa@gmail.com").RegisterTwitter();
            Assert.IsTrue(HomePage.IsAt, "Failed to register with Twitter.");
        }

        // Close browser
        [TestFixtureTearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}



   