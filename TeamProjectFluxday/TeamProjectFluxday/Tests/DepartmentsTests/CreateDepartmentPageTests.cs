using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Data.Models;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class CreateDepartmentPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("CreateDepartmentsPageTestsAsAdmin")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test001NavigateToCreateDepartmentsPage()
        {
            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            var createDepartmentPage = departmentsPage.PressCreateDepartmentLink();

            createDepartmentPage.Validate().CreateDepartmentForm();
        }

        [TestCategory("CreateDepartmentsPageTestsAsAdmin")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test002CreateDepartmentAsAnAdmin()
        {
            Department newDepartment = new Department("Administration",
                                       StringHelper.AppendDateTimeString("ADM"),
                                       "adm",
                                       "Administration team");

            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            var createDepartmentPage = departmentsPage.PressCreateDepartmentLink();
            createDepartmentPage.AddDepartment(newDepartment);

            createDepartmentPage.DepartmentsPage.Validate().NewDepartmentExists();

            departmentsPage.DeleteNewlyCreatedDepartment();
            departmentsPage.Validate().NewDepartmentIsDeleted();
        }
    }
}
