using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Data;
using SeleniumWebDriver.Pages;
using TeamProjectFluxday.Parts;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class DepartmentsPageTests : BaseTest
    {
        [TestCategory("DepartmentsPageTests")]
        [TestMethod]
        public void Test001DepartmentsPageValidation()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            var logInAsAdmin = loginPage.Login(adminUser);

            var navigationPanel = new NavigationPanel();
            navigationPanel.ClickOnDepartmentsLink();

            var departmentsPage = new DepartmentsPage();

            departmentsPage.Validate().IsOnDepartmentsPage();
        }
    }
}
