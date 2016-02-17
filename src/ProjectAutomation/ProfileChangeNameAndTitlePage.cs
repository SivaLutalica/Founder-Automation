using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectAutomation
{
    public class ProfileChangeNameAndTitlePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "/people");
        }

        public static void ChangeNameAndTitle()
        {
            var profileContextMenu = Driver.Instance.FindElement(By.ClassName("fontIcon ficon-dot"));
            profileContextMenu.Click();

            var profileChangeNameAndTitleMenu = Driver.Instance.FindElement(By.LinkText("Change Name and Title"));
            profileChangeNameAndTitleMenu.Click();
        }
    }
}