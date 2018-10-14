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
