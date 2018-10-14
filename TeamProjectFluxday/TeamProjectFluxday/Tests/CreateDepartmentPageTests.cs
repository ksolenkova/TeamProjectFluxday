using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Parts;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class CreateDepartmentPageTests : BaseTest
    {
        [TestCategory("CreateDepartmentsPageTests")]
        [TestMethod]
        public void Test001CreateDepartmentAsAnAdmin()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            var logInAsAdmin = loginPage.Login(adminUser);

            var navigationPanel = new NavigationPanel();
            navigationPanel.ClickOnDepartmentsLink();

            var departmentsPage = new DepartmentsPage();
            departmentsPage.ClickOnCreateDepartmentsLink();

            var createDepartmentsPage = departmentsPage.NavigateToCreateDepartmentPage();
            createDepartmentsPage.WriteTitle();
            createDepartmentsPage.WriteCode();
            createDepartmentsPage.WriteUrl();
            createDepartmentsPage.WriteDescription();
            createDepartmentsPage.ClickOnSave();

            //var departmentIsDisplayed = departmentsPage.NewDepartmentIsDisplayed();

            //Assert.IsTrue(departmentIsDisplayed);

            //departmentsPage.DeleteCreatedDepartment();
        }
    }
}
