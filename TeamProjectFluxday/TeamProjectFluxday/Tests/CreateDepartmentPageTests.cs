using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Data.Models;
using TeamProjectFluxday.Pages.Dashboard;
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

        [TestCategory("CreateDepartmentsPageTests")]
        [TestMethod]
        public void Test001CreateDepartmentAsAnAdmin()
        {
            Department newDepartment = new Department("Administration",
                                                      StringHelper.PrependDateTimeString("ADM"),
                                                      "adm",
                                                      "Administration team");
            
            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            var createDepartmentPage = departmentsPage.PressCreateDepartmentLink();
            createDepartmentPage.AddDepartment(newDepartment);

            //createDepartmentPage.DepartmentsPage.Validate().DepartmentExists(newDepartment.Title);
            //DeleteNewlyCreatedDepartment();
        }
    }
}
