using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages.DashboardMainPage;
using SeleniumWebDriver.Pages.LoginPage;
using System.Threading;
using TeamProjectFluxday.Pages.MyTasksPage;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class MyTasksPageTests : BaseTest
    {
        [TestCategory("MyTasksPageTests")]
        [TestMethod]
        public void Test001CreateNewTask()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            var teamLeadUser = SeleniumWebDriver.Data.TestData.TeamLeadUser;
           
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();


            var myTasksPage = new MyTasksPage();
            myTasksPage.Navigate();

            myTasksPage.PressNewTaskButton();

            var newTask = SeleniumWebDriver.Data.TestData.NewTask;
            myTasksPage.TypeTitle(newTask.Title);
            myTasksPage.TypeDescription(newTask.Description);
            myTasksPage.PressCreateTaskButton();
            Thread.Sleep(3000);

            var dashboardPage = new DashboardPage();
            dashboardPage.Navigate();

            var actualResul = dashboardPage.ReadTaskTitleText();

            Assert.AreEqual(newTask.Title, actualResul);
        }
    }
}
