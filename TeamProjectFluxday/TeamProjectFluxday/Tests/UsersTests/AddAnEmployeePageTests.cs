using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class AddAnEmployeePageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("AddAnEmployeePageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test001NavigateToAddAnEmployeePage()
        {
            var usersPage = dashboardPage.NavigationPanel.NavigateToUsersPage();

            var addAnEmployeePage = usersPage.AddUserClick();

            addAnEmployeePage.Validate().IsOnAddAnEmployeePage();
        }

        [TestCategory("AddAnEmployeePageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test002AddAnEmployeeUser()
        {
            var usersPage = dashboardPage.NavigationPanel.NavigateToUsersPage();

            var addAnEmployeePage = usersPage.AddUserClick();
            addAnEmployeePage.FillInAddUserForm();
            addAnEmployeePage.SaveButtonClick();

            usersPage.Validate().NewEmployeeIsAdded();

            var userDetailsPage = usersPage.NewUserClick();
            userDetailsPage.DeleteNewUser();

            usersPage.Validate().NewEmployeeIsNotInTheList();
        }

        [TestCategory("AddAnEmployeePageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test003CancelAddingAnEmployeeUser()
        {
            var usersPage = dashboardPage.NavigationPanel.NavigateToUsersPage();

            var addAnEmployeePage = usersPage.AddUserClick();
            addAnEmployeePage.FillInAddUserForm();
            addAnEmployeePage.CancelButtonClick();

            addAnEmployeePage.Validate().IsNotOnAddAnEmployeePage();
        }
    }
}
