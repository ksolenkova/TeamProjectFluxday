using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Pages.Users;
using TeamProjectFluxday.Parts;

namespace TeamProjectFluxday.Tests
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

            var navigationPanel = new NavigationPanel();
            navigationPanel.UsersLinkClick();
            Thread.Sleep(1000);

            var usersPage = new UsersPage();
            usersPage.AddUserClick();

            usersPage.FillInAddUserForm();
            usersPage.SaveButtonClick();

            var expectedResult = "TestEmployee";
            Assert.AreEqual(expectedResult, usersPage.ReadNewUserName());
            usersPage.DeleteNewUser();
        }
    }
}
