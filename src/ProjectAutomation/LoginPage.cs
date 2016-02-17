using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ProjectAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "/account/login");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {

            var loginGoogle = Driver.Instance.FindElement(By.Id("Google"));
            loginGoogle.Click();

            var loginInput = Driver.Instance.FindElement(By.Id("Email"));
            loginInput.SendKeys(userName);

            var loginNextButton = Driver.Instance.FindElement(By.Id("next"));
            loginNextButton.Click();

            var passwordInput = Driver.Instance.FindElement(By.Id("Passwd"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("signIn"));
            loginButton.Click();
            
        }
    }
}
