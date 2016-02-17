using OpenQA.Selenium;
using ProjectAutomation.Selenium;

namespace ProjectAutomation.Pages
{
    public class LogOutPage
    {
        public static void LogOut()
        {
            var signOutLink = Driver.Instance.FindElement(By.LinkText("Sign Out"));
            signOutLink.Click();

            var signOutThisDevice = Driver.Instance.FindElement(By.ClassName("button-primary"));
            signOutThisDevice.Click();
        }
    }
}
