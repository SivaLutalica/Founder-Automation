using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectAutomation;
using ProjectAutomation.Navigation;
using ProjectAutomation.Pages;
using ProjectAutomation.Selenium;
using ProjectTests.Utilities;

namespace ProjectTests.Smoke_Tests
{
    public class ProfileTests : ProjectTest
    {
        public void Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("ian.rewalls.qa@gmail.com").WithPassword("qalozinka").Login();
            // Wait to login
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElements(By.LinkText("My Profile")));
        }

        [Test]
        public void Can_Change_Name_And_Title()
        {
            Login();
            SidebarNavigation.MyProfile.GoTo();
            ProfilePages.SetNewName("John Doe").SetNewTitle("Quality Assurance @ Founder.org").ChangeNameTitle();

            Assert.IsTrue(ProfilePages.NameIsChanged(), "Profile name is not changed");
            Assert.IsTrue(ProfilePages.TitleIsChanged, "Profile title is not changed");
        }

        [Test]
        public void Can_Change_Profile_Picture()
        {
            SidebarNavigation.MenuAction.Open();
            SidebarNavigation.MyProfile.GoTo();
            ProfilePages.SetNewProfilePicture(Driver.BaseFilePath + "Profile.png").ChangeProfilePicture();
            // Assertovati Profile Picture
            // Assert.IsTrue(ProfilePages.ProfilePictureIsChanged(), "Profile picture is not changed");
        }

        [Test]
        public void Can_Edit_User_About_Section()
        {
            SidebarNavigation.MyProfile.GoTo();
            ProfilePages.SetNewAbout("Lorem Ipsum Dolor User Profile About Section Edit Test").ChangeProfileAbout();
            Assert.IsTrue(ProfilePages.ProfileAboutIsChanged, "Profile about section is not changed");
        }

        [Test]
        public void Can_Add_Remove_Picture_In_About_Section()
        {
            SidebarNavigation.MyProfile.GoTo();
            ProfilePages.SetNewAboutPicture(Driver.BaseFilePath + "WhoIsLoremIpsum.gif").AddAboutPicture();
            // assert slike
            ProfilePages.RemoveAboutPicture();
            // assert da nema slike
        }

        /*[Test]
        public void Can_Add_Remove_Video_In_About_Section()
        {
            ProfilePages.GoTo();
            // ProfilePages.SetNewAboutVideo("").AddAboutVideo();
            // assert videa
            // ProfilePages.RemoveAboutVideo();
            // assert da nema videa
        }*/
    }
}
