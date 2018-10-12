using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages.Dashboard;
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
        [TestMethod]
        public void Test001AddAnEmployeeUser()
        {
            var usersPage = dashboardPage.NavigationPanel.NavigateToUsersPage();

            var addAnEmployeePage = usersPage.AddUserClick();
            addAnEmployeePage.FillInAddUserForm();
            addAnEmployeePage.SaveButtonClick();

            usersPage.Validate().NewEmployeeIsAdded();
            
            usersPage.DeleteNewUser();
        }
    }
}
