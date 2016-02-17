using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectAutomation
{
    public class LogOutPage
    {
        public static void LogOut()
        {
            var signOutLink = Driver.Instance.FindElement(By.LinkText("Sign Out"));
            signOutLink.Click();
        }
    }
}
