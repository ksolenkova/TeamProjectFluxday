using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Data;
using SeleniumWebDriver.Pages.LoginPage;
using System.Threading;
using SeleniumWebDriver.Pages.UsersPage;

namespace SeleniumWebDriver.Tests
{
    [TestClass]
   public class UsersPageTests : BaseTest
    {
        [TestCategory("UsersPageTests")]
        [TestMethod]
        public void Test001AddUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            
            var dashboardPage = loginPage.Login(adminUser);

            dashboardPage.UsersLinkClick();
            Thread.Sleep(1000);

            var usersPage = new UsersPage();
            usersPage.AddUserClick();

            usersPage.FillInAddUserForm();
            usersPage.SaveButtonClick();

            var expectedResult = "TestEmployee";
            Assert.AreEqual(expectedResult, usersPage.ReadNewUserName());
        }
    }
}
