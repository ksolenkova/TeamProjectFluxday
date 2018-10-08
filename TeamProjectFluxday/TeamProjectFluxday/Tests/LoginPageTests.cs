﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Data;
using SeleniumWebDriver.Pages.DashboardMainPage;
using SeleniumWebDriver.Pages.LoginPage;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test001LoginWithAdminUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = Data.TestData.AdminUser;

            loginPage.TypeEmail(adminUser.Email);
            loginPage.TypePassword(adminUser.Password);
            loginPage.PressLoginButton();

            var dashboardPage = new DashboardPage();
            var actualResult = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(adminUser.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test003LoginWithLeadUser()
        {
            var loginPage = new LoginPage(); ;
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser);
            var actualResul = dashboardPage.NavigationPanel.ReadUserLinkText();

            Assert.AreEqual(teamLeadUser.Name, actualResul);
        }
    }
}
