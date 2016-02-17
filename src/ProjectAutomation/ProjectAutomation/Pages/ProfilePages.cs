using OpenQA.Selenium;
using ProjectAutomation.Navigation;
using ProjectAutomation.Selenium;

namespace ProjectAutomation
{
    public class ProfilePages
    {
        public static void GoTo()
        {
            SidebarNavigation.MyProfile.GoTo();
        }

        public static ProfileChangesCommand SetNewName(string userProfileName)
        {
            var cmd = new ProfileChangesCommand();
            cmd.SetNewName(userProfileName);
            return cmd;
        }

        public static ProfileChangesCommand SetNewProfilePicture(string userProfilePicture)
        {
            var cmd = new ProfileChangesCommand();
            cmd.SetNewProfilePicture(userProfilePicture);
            return cmd;
        }

        public static ProfileChangesCommand SetNewProfileTitle(string userProfileTitle)
        {
            var cmd = new ProfileChangesCommand();
            cmd.SetNewTitle(userProfileTitle);
            return cmd;
        }

        public static ProfileChangesCommand SetNewAbout(string userProfileAbout)
        {
            var cmd = new ProfileChangesCommand();
            cmd.SetNewAbout(userProfileAbout);
            return cmd;
        }

        public static ProfileChangesCommand SetNewAboutPicture(string userProfileAboutPicture)
        {
            var cmd = new ProfileChangesCommand();
            cmd.SetNewAboutPucture(userProfileAboutPicture);
            return cmd;
        }

        // Assert changed profile name
        public static bool NameIsChanged()
        {
            var checkProfileName = Driver.Instance.FindElement(By.LinkText("John Doe"));
            if (checkProfileName.Displayed) 
                return checkProfileName.Text == "John Doe";
            return false;
        }
        // Assert change profile title
        public static bool TitleIsChanged
        {
            get
            {
                var checkProfileTitle = Driver.Instance.FindElements(By.ClassName("u-link-assimilate"));
                if (checkProfileTitle.Count > 0)
                    return checkProfileTitle[1].Text == "Quality Assurance @ Founder.org";
                return false;
            }
        }

        /*// Assert changed profile picture
        public static bool ProfilePictureIsChanged()
        {
            var checkProfilePicture = Driver.Instance.FindElement(By.ClassName("avatar-person-enormous"));
            if (checkProfilePicture.Displayed)
                return checkProfilePicture.Text == "John Doe";
            return false;
        }*/

        // Assert change profile about
        public static bool ProfileAboutIsChanged
        {
            get
            {
                var checkProfileAbout = Driver.Instance.FindElements(By.ClassName("u-textEmbeded"));
                if (checkProfileAbout.Count > 0 )
                    return checkProfileAbout[0].Text != "This section is empty";
                return false;
            }
        }

        // About section - Remove Picture
        public static void RemoveAboutPicture()
        {
            /*var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.CssSelector("input.u-linkify-action")));*/

            var removePictureButton = Driver.Instance.FindElement(By.CssSelector("input.u-linkify-action"));
            removePictureButton.Click();
        }
    }

    public class ProfileChangesCommand
    {
        public string UserProfileName;
        public string UserProfileTitle;
        public string UserProfilePicture;
        public string UserProfileAbout;
        public string UserProfileAboutPicture;

        // public ProfileChangesCommand() { }

        public ProfileChangesCommand SetNewName(string userProfileName)
        {
            UserProfileName = userProfileName;
            return this;
        }

        public ProfileChangesCommand SetNewTitle(string userProfileTitle)
        {
            UserProfileTitle = userProfileTitle;
            return this;
        }

        public ProfileChangesCommand SetNewProfilePicture(string userProfilePicture)
        {
            UserProfilePicture = userProfilePicture;
            return this;
        }


        public ProfileChangesCommand SetNewAbout(string userProfileAbout)
        {
            UserProfileAbout = userProfileAbout;
            return this;
        }

        public ProfileChangesCommand SetNewAboutPucture(string userProfileAboutPicture)
        {
            UserProfileAboutPicture = userProfileAboutPicture;
            return this;
        }
      
        public void ChangeNameTitle()
        {
            /*var profileContextMenu = Driver.Instance.FindElement(By.CssSelector("a.js-contextMenu-action-menu"));
            profileContextMenu.Click();

            var profileChangeNameAndTitle = Driver.Instance.FindElement(By.LinkText("Change Name and Title"));
            profileChangeNameAndTitle.Click();*/

            MenuSelector.ContextSelect("a.js-contextMenu-action-menu", "Change Name and Title");

            var inputName = Driver.Instance.FindElement(By.Id("FullName"));
            inputName.Clear();
            inputName.SendKeys(UserProfileName);

            var inputTitle = Driver.Instance.FindElement(By.Id("Title"));
            inputTitle.Clear();
            inputTitle.SendKeys(UserProfileTitle);

            var confirmChanges = Driver.Instance.FindElement(By.ClassName("button-primary"));
            confirmChanges.Click();
        }

        public void ChangeProfilePicture()
        {
            var profileContextMenu = Driver.Instance.FindElement(By.CssSelector("a.js-contextMenu-action-menu"));
            profileContextMenu.Click();

            var profileChangeProfilePicture = Driver.Instance.FindElement(By.LinkText("Change Profile Picture"));
            profileChangeProfilePicture.Click();

            var profilePicture = Driver.Instance.FindElement(By.Name("qqfile"));
            profilePicture.SendKeys(UserProfilePicture);

            var confirmChanges = Driver.Instance.FindElement(By.ClassName("button-primary"));
            confirmChanges.Click();
        }

        public void ChangeProfileAbout()
        {
            var sectionEditButton = Driver.Instance.FindElement(By.LinkText("Edit"));
            sectionEditButton.Click();

            var inputAbout = Driver.Instance.FindElement(By.Id("About"));
            inputAbout.Clear();
            inputAbout.SendKeys(UserProfileAbout);

            var confirmChanges = Driver.Instance.FindElement(By.ClassName("button-primary"));
            confirmChanges.Click();
        }

        public void AddAboutPicture()
        {
            /*var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.LinkText("Add Picture")));*/

            var addPictureButton = Driver.Instance.FindElement(By.LinkText("Add Picture"));
            addPictureButton.Click();

            var profileAboutPicture = Driver.Instance.FindElement(By.Name("qqfile"));
            profileAboutPicture.SendKeys(UserProfileAboutPicture);

            var confirmChanges = Driver.Instance.FindElement(By.ClassName("button-primary"));
            confirmChanges.Click();
        }
    }
}
