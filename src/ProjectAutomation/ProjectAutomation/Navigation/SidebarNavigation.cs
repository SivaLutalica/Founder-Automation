using OpenQA.Selenium;
using ProjectAutomation.Selenium;

namespace ProjectAutomation.Navigation
{
    public class SidebarNavigation
    {
        public class MenuAction
        {
            // SidebarNavigation.MenuAction.Open();
            public static void Open()
            {
                MenuSelector.Select("PageNavigation-pin", "");
            }
            // SidebarNavigation.MenuAction.Close();
            public static void Close()
            {
                MenuSelector.Select("UserWidget-closen", "");
            }
        }

        public class MyProfile
        {
            // SidebarNavigation.MyProfile.GoTo();
            public static void GoTo()
            {
                MenuSelector.Select("PageNavigation", "My Profile");
            }
        }

        public class Classes
        {
            // SidebarNavigation.Classes.GoTo();
            public static void GoTo()
            {
                MenuSelector.Select("PageNavigation", "Classes");
            }
        }

        public class WhatsNew
        {
            // SidebarNavigation.WhatsNew.GoTo();
            public static void GoTo()
            {
                MenuSelector.Select("PageNavigation", "What's New");
            }
        }

        public class SignOut
        {
            // SidebarNavigation.SignOut.Click();
            public static void Click()
            {
                MenuSelector.Select("PageNavigation", "Sign Out");
                // Ovog se treba rijesiti. Mora postojati 'if' za sign out, ili da za sada bude samo sign out obican, bez vise browsera. Razmisliti
                var signOutThisDevice = Driver.Instance.FindElement(By.ClassName("button-primary"));
                signOutThisDevice.Click();
            }
        }
    }

    public class MenuSelector
    {
        public static void Select(string topLevelMenuClass, string toplelvelMenuLinkText)
        {
            Driver.Instance.FindElement(By.ClassName(topLevelMenuClass)).Click();
            Driver.Instance.FindElement(By.LinkText(toplelvelMenuLinkText)).Click();
        }

        public static void ContextSelect(string contextMenuClass, string contextMenuLinkText)
        {
            Driver.Instance.FindElement(By.CssSelector(contextMenuClass)).Click();
            Driver.Instance.FindElement(By.LinkText(contextMenuLinkText)).Click();
        }

        public static void NetworkSelect(string networkId)
        {
            Driver.Instance.FindElement(By.Id(networkId)).Click();
        }
    }
}