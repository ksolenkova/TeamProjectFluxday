using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Data;
using SeleniumWebDriver.Pages;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
    public class DepartmentsPageTests : BaseTest
    {
        [TestCategory("DepartmentsPageTests")]
        [TestMethod]
        public void Test001CreateDepartmentAsAnAdmin()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            var logInAsAdmin = loginPage.Login(adminUser);

            var dashboardPage = new DashboardPage();
            dashboardPage.ClickOnDepartmentsLink();

            var departmentsPage = new DepartmentsPage();
            departmentsPage.ClickOnCreateDepartmentsLink();

            departmentsPage.WriteTitle();
            departmentsPage.WriteCode();
            departmentsPage.WriteUrl();
            departmentsPage.WriteDescription();
            departmentsPage.ClickOnSave();

            var departmentIsDisplayed = departmentsPage.NewDepartmentIsDisplayed();

            Assert.IsTrue(departmentIsDisplayed);

            departmentsPage.DeleteCreatedDepartment();
        }
    }
}
