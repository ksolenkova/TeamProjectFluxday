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

        [TestCategory("MyTasksPageTests")]
        [TestMethod]
        public void Test001CreateNewTask()
        {
            dashboardPage = LoginProvider.Login(TestData.TeamLeadUser);

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.NavigationPanel.PressNewTaskButton();

            var newTask = TestData.NewTask;
            myTasksPage.TypeTitle(newTask.Title);
            myTasksPage.TypeDescription(newTask.Description);
            myTasksPage.PressCreateTaskButton();

            var myTasksPageValidation = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            myTasksPageValidation.Validate().TaskExists(newTask.Title);
        }
    }
}
