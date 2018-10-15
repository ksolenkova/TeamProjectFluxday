using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class LoginPageTests : BaseTest
    {
        LoginPage loginPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            loginPage = new LoginPage();
            loginPage.Navigate();
        }

        [TestCategory("LoginPageTests")]
        [TestMethod]
        public void Test001NavigateToLoginPage()
        {
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test002LoginWithAdminUser()
        {
            var adminUser = TestData.AdminUser;
            var dashboardPage = loginPage.Login(adminUser);

            dashboardPage.Validate().UserNameLink(adminUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test003VerifyAdminUserCantLoginWithInvalidPassword()
        {
            var adminUser = TestData.AdminUser;

            var dashboardPage = loginPage.Login(adminUser.Email, "invalidPassword");

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Dobrin Ganev")]
        [TestMethod]
        public void Test004LogOutAsAdminUser()
        {
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
            var teamLeadUser = TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);
            dashboardPage.Validate().UserNameLink(teamLeadUser.Name);  
        }

        [TestCategory("LoginPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test006VerifyTeamLeadUserCantLoginWithInvalidPassword()
        {
            var teamLeadUser = TestData.TeamLeadUser;

            var dashboardPage = loginPage.Login(teamLeadUser.Email, "invalidPassword");
            
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test007LogOutAsTeamLead()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = TestData.TeamLeadUser;
            var dashboardPage = loginPage.Login(teamLeadUser);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test008LoginWithEmployee1User()
        {
            var employeeUser = TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);

            dashboardPage.Validate().UserNameLink(employeeUser.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test009LogOutAsEmployee1()
        {
            var employeeUser = TestData.Employee1;
            var dashboardPage = loginPage.Login(employeeUser);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Kristina Solenkova")]
        [TestMethod]
        public void Test0010VerifyEmployee1IsNotAbleToLoginWithInvalidEmail()
        {
            var employeeUser = TestData.Employee1;
            loginPage.Login("emploe@fluxday.io", employeeUser.Password);

            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test011LoginWithEmployee2User()
        {
            var employee2User = TestData.Employee2;
            var dashboardPage = loginPage.Login(employee2User);

            dashboardPage.Validate().UserNameLink(employee2User.Name);
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test012VerifyEmployee2CantLoginWithInvalidPassword()
        {
            var employee2User = TestData.Employee2;

            var dashboardPage = loginPage.Login(employee2User.Email, "password1");
            loginPage.Validate().LoginForm();
        }

        [TestCategory("LoginPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test013LogOutAsEmployee2()
        {
            var employee2 = TestData.Employee2;
            var dashboardPage = loginPage.Login(employee2);
            dashboardPage.NavigationPanel.Logout();

            loginPage.Validate().LoginForm();
        }
    }
}
