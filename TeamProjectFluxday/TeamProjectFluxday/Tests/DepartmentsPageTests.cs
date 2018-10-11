using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Pages.Dashboard;
using TeamProjectFluxday.Pages.Departments;
using TeamProjectFluxday.Pages.Login;
using TeamProjectFluxday.Parts;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class DepartmentsPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.Employee);
        }

        [TestCategory("DepartmentsPageTests")]
        [TestMethod]
        public void Test001DepartmentsPageValidation()
        {
            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            departmentsPage.Validate().IsOnDepartmentsPage();
        }
    }
}
