using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages.Dashboard;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class MyTasksPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.TeamLeadUser);
        }

        [TestCategory("MyTasksPageTests")]
        [TestMethod]
        public void Test001CreateNewTask()
        {      
            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.NavigationPanel.PressNewTaskButton();

            var newTask = TestData.NewTask;
            myTasksPage.TypeTitle(newTask.Title);
            myTasksPage.TypeDescription(newTask.Description);
            myTasksPage.PressCreateTaskButton();

            myTasksPage.Validate().TaskExists();
        }
    }
}
