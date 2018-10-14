﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Tests
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
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test000LoginWithLeadUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);
            dashboardPage.Validate().UserNameLink(teamLeadUser.Name);  
        }

        [TestCategory("LoginPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test001LoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser.Email, "invalidPassword");
            
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test004LoginWithEmployee1User()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = Data.TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);

            dashboardPage.Validate().UserNameLink(employeeUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test005LogOutAsEmployee1()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = Data.TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test006VerifyEmployee1IsNotAbleToLoginWithInvalidEmail()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = Data.TestData.Employee1;
            loginPage.Login("emploe@fluxday.io", employeeUser.Password);

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test010LoginWithEmployee2User()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employee2User = TestData.Employee2;
            var dashboardPage = loginPage.Login(employee2User);

            var actualResult = dashboardPage.NavigationPanel.ReadUserLinkText();

            Assert.AreEqual(employee2User.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test012VerifyEmployee2CantLoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employee2User = TestData.Employee2;

            var dashboardPage = loginPage.Login(employee2User.Email, "password1");
            loginPage.Validate().LoginForm();
        }
    }
}
