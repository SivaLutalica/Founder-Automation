using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ProjectAutomation.Selenium
{

    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return "https://loc.founder.org"; }
        }

        public static string BaseFilePath
        {
            get { return "C:\\_selenium_content\\"; }
        }

        public static void Initialize()
        {

            Instance = new FirefoxDriver();
            
            // TurnOnWait();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            // Instance.Manage().Window.Size = new Size(1024, 768); // for specific browser size
            Instance.Manage().Window.Maximize(); // full screen
        }

        public static void Close()
        {
            Instance.Close();
        }

        // Turn Off Wait ?!
        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }
    }
}