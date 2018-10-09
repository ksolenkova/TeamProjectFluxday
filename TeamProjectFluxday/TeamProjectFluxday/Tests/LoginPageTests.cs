using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Data;
using SeleniumWebDriver.Data.Models;
using SeleniumWebDriver.Pages;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test001LoginPageValidation()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test002LoginWithAdminUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = Data.TestData.AdminUser;
            var dashboardPage = loginPage.Login(adminUser);
            
            var actualResult = dashboardPage.NavigationPanel.ReadUserLinkText();

            Assert.AreEqual(adminUser.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test003LoginWithLeadUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = Data.TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);
            
            var actualResult = dashboardPage.NavigationPanel.ReadUserLinkText();

            Assert.AreEqual(teamLeadUser.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test004LoginWithAUser()
        {
            var userList = TestData.UserList;

            foreach (User user in userList)
            {
                var loginPage = new LoginPage();
                loginPage.Navigate();
                loginPage.Validate().LoginForm();

                var dashboardPage = loginPage.Login(user);
                dashboardPage.Validate().UserNameLink(user.Name);

                loginPage = dashboardPage.NavigationPanel.Logout();
                loginPage.Validate().LoginForm();
            }
        }

    }
}
