using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test001LoginPageValidation()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test002LoginWithAdminUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            var dashboardPage = loginPage.Login(adminUser);

            dashboardPage.Validate().UserNameLink(adminUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test003VerifyAdminUserCantLoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;

            var dashboardPage = loginPage.Login(adminUser.Email, "invalidPassword");

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test004LogOutAsAdminUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var adminUser = TestData.AdminUser;
            var dashboardPage = loginPage.Login(adminUser);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test005LoginWithLeadUser()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);
            dashboardPage.Validate().UserNameLink(teamLeadUser.Name);  
        }

        [TestCategory("LoginPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test006VerifyTeamLeadUserCantLoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser.Email, "invalidPassword");
            
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test007LoginWithEmployee1User()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);

            dashboardPage.Validate().UserNameLink(employeeUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test008LogOutAsEmployee1()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test009VerifyEmployee1IsNotAbleToLoginWithInvalidEmail()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employeeUser = TestData.Employee1;
            loginPage.Login("emploe@fluxday.io", employeeUser.Password);

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test010LoginWithEmployee2User()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employee2User = TestData.Employee2;
            var dashboardPage = loginPage.Login(employee2User);

            dashboardPage.Validate().UserNameLink(employee2User.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test011VerifyEmployee2CantLoginWithInvalidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employee2User = TestData.Employee2;

            var dashboardPage = loginPage.Login(employee2User.Email, "password1");
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test012LogOutAsEmployee2()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var employee2 = TestData.Employee2;
            var dashboardPage = loginPage.Login(employee2);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }
    }
}
