using OpenQA.Selenium;
using ProjectAutomation.Navigation;
using ProjectAutomation.Selenium;

namespace ProjectAutomation.Pages
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "/account/login");
            /*// wait for element: Google
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "Google");*/
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

    }

    public class LoginCommand
    {
        private readonly string _userName;
        private string _password;

        public LoginCommand(string userName)
        {
            _userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public void Login()
        {

            /*var loginNetwork = Driver.Instance.FindElement(By.Id("Google"));
            loginNetwork.Click();*/
            MenuSelector.NetworkSelect("Google");

            var loginInput = Driver.Instance.FindElement(By.Id("Email"));
            loginInput.SendKeys(_userName);

            var loginNextButton = Driver.Instance.FindElement(By.Id("next"));
            loginNextButton.Click();

            var passwordInput = Driver.Instance.FindElement(By.Id("Passwd"));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Id("signIn"));
            loginButton.Click();
            
        }
    }
}
