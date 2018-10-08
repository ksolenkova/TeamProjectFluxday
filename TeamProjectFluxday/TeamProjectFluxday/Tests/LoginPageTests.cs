using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
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
            var logInAsAdmin = loginPage.Login(adminUser);

            var dashboardPage = new DashboardPage();
            var actualResult = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(adminUser.Name, actualResult);
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test002LoginWithLeadUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = Data.TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser);
            var actualResul = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(teamLeadUser.Name, actualResul);
        }

    }
}
