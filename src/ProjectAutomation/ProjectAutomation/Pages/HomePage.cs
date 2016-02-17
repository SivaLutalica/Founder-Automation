using OpenQA.Selenium;
using ProjectAutomation.Selenium;

namespace ProjectAutomation
{
    public class HomePage
    {
        public static bool IsAt
        {
            get
            {
                // ovo treba refaktorisati
                var profileNameText = Driver.Instance.FindElement(By.ClassName("UserWidget-username")).Text;
                var profileName = Driver.Instance.FindElement(By.ClassName("UserWidget-username"));
                if (profileName.Displayed) 
                    return profileName.Text == profileNameText;
                return false;

                /*var h4S = Driver.Instance.FindElements(By.TagName("h4"));
                if (h4S.Count > 0)
                    return h4S[1].Text == "TOOLS";
                return false;*/
            }
        }
    }
}
