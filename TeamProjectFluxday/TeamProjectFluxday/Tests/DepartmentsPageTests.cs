using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
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
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("DepartmentsPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test001DepartmentsPageValidation()
        {
            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            departmentsPage.Validate().IsOnDepartmentsPage();
        }

        [TestCategory("DepartmentsPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test002VerifyDefaultDepartmentsCount()
        {
            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            departmentsPage.Validate().DefaultDepartmentsCount();
        }
    }
}
