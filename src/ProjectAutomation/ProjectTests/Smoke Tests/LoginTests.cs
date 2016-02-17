using NUnit.Framework;
using ProjectAutomation;
using ProjectTests.Utilities;

namespace ProjectTests.Smoke_Tests
{
    public class LoginTests : ProjectTest
    {
        [Test]
        public void User_Can_LogIn()
        {
            // Assert Sign In
            Assert.IsTrue(HomePage.IsAt, "Failed to sign in.");
        }
    }
}
