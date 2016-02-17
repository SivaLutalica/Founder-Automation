using NUnit.Framework;
using ProjectAutomation;
using ProjectAutomation.Navigation;
using ProjectTests.Utilities;

namespace ProjectTests.Smoke_Tests
{
    public class LogOutTests : ProjectTest
    {
        [Test]
        public void User_Can_LogOut()
        {
            // Sign Out
            SidebarNavigation.SignOut.Click();
            Assert.IsFalse(HomePage.IsAt, "Failed to sign out.");
        }
    }
}
