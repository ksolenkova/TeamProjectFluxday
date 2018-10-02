using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Pages.DashboardMainPage;
using TeamProjectFluxday.Pages.LoginPage;

namespace TeamProjectFluxday.Tests
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
        public void Test002LoginWithLeadUser()
        {
            var loginPage = new LoginPage(); ;
            loginPage.Navigate();

            var teamLeadUser = Data.TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser);
            var actualResul = dashboardPage.ReadAdminUserLinkText();

            Assert.AreEqual(teamLeadUser.Name, actualResul);
        }

    }
}
