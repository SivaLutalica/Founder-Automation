using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectAutomation.Navigation;
using ProjectAutomation.Selenium;

namespace ProjectAutomation.Pages
{
    public class RegisterPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "/account/login");
        }

        public static RegisterCommand RegisterAs(string userName)
        {
            return new RegisterCommand(userName);
        }

    }

    public class RegisterCommand
    {
        private readonly string _userName;
        private string _password;
        private string _email;

        public RegisterCommand(string userName)
        {
            _userName = userName;
        }

        public RegisterCommand WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public RegisterCommand WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public void RegisterGmail()
        {

            MenuSelector.NetworkSelect("Google");

            var loginInput = Driver.Instance.FindElement(By.Id("Email"));
            loginInput.SendKeys(_userName);

            var loginNextButton = Driver.Instance.FindElement(By.Id("next"));
            loginNextButton.Click();

            var passwordInput = Driver.Instance.FindElement(By.Id("Passwd"));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Id("signIn"));
            loginButton.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.ClassName("button-primary")));

            var registerButton = Driver.Instance.FindElement(By.ClassName("button-primary"));
            registerButton.Click();

        }
                 
        public void RegisterFacebook()
        {
            MenuSelector.NetworkSelect("Facebook");

            var loginInput = Driver.Instance.FindElement(By.Id("email"));
            loginInput.SendKeys(_userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("pass"));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Id("loginbutton"));
            loginButton.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.ClassName("button-primary")));

            var registerButton = Driver.Instance.FindElement(By.ClassName("button-primary"));
            registerButton.Click();
        }

        public void RegisterLinkedin()
        {
            MenuSelector.NetworkSelect("LinkedIn");

            var loginInput = Driver.Instance.FindElement(By.Name("session_key"));
            loginInput.SendKeys(_userName);

            var passwordInput = Driver.Instance.FindElement(By.Name("session_password"));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Name("authorize"));
            loginButton.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.ClassName("button-primary")));

            var registerButton = Driver.Instance.FindElement(By.ClassName("button-primary"));
            registerButton.Click();
        }

        public void RegisterTwitter()
        {
            MenuSelector.NetworkSelect("Twitter");

            var loginInput = Driver.Instance.FindElement(By.Id("username_or_email"));
            loginInput.SendKeys(_userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Id("allow"));
            loginButton.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.ClassName("button-primary")));

            var typeEmail = Driver.Instance.FindElement(By.Id("Email"));
            typeEmail.SendKeys(_email);

            var registerButton = Driver.Instance.FindElement(By.ClassName("button-primary"));
            registerButton.Click();
        }
    }
}
