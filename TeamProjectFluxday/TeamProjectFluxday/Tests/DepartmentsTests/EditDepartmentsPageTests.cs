using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class EditDepartmentsPageTests : BaseTest
    {
        [TestCategory("EditDepartmentsPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test001EditFinanceDepartmentAsAdmin()
        {
            var dashboardPage = LoginProvider.Login(TestData.AdminUser);

            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();
            departmentsPage.ClickOnFinanceDepartment();
            departmentsPage.PressSettingsIcon();

            var editDepartmentsPage = departmentsPage.PressEdit();
            editDepartmentsPage.EditTitle("Finance Department");

            departmentsPage.Validate().TitleIsChanged();
        }

        [TestCategory("EditDepartmentsPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test002VerifyOnlyAdminCanEditDepartments()
        {
            var dashboardPage = LoginProvider.Login(TestData.TeamLeadUser);

            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();

            departmentsPage.ClickOnFinanceDepartment();

            departmentsPage.Validate().SettingsIconIsNotPresent();
        }

        [TestCategory("EditDepartmentsPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test003VerifyCancelAndSaveButtonsAreEnabled()
        {
            var dashboardPage = LoginProvider.Login(TestData.AdminUser);

            var departmentsPage = dashboardPage.NavigationPanel.NavigateToDepartmentsPage();
            departmentsPage.ClickOnFinanceDepartment();
            departmentsPage.PressSettingsIcon();

            var editDepartmentsPage = departmentsPage.PressEdit();
            editDepartmentsPage.Validate().CancelAndSaveButtonsAreEnabled();
        }
    }
}
