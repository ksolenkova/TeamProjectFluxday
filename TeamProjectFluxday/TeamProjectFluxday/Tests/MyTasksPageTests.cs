using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
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
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test001CreateNewTask()
        {      
            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.NavigationPanel.PressNewTaskButton();

            var newTask = TestData.Task;
            myTasksPage.TypeTitle(newTask.Title);
            myTasksPage.TypeDescription(newTask.Description);
            myTasksPage.PressCreateTaskButton();

            myTasksPage.Validate().TaskExists();
            myTasksPage.DeleteNewTask();
        }
    }
}
