using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod]
        public void Test003VerifyTeamLeadCantLoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser.Email, "password1");
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
