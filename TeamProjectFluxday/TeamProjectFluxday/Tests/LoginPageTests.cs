using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
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

            var teamLeadUser = Data.TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);

            dashboardPage.Validate().UserNameLink(teamLeadUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test004LoginWithEmployeeUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = Data.TestData.Employee;
            var dashboardPage = loginPage.Login(employeeUser);

            dashboardPage.Validate().UserNameLink(employeeUser.Name);
        }
    }
}
