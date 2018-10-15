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
        public void Test001MyTasksPageValidation()
        {
            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.Validate().IsOnMyTasksPage();
        }

        [TestCategory("MyTasksPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test002EditTask()
        {
            //var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();

            //addNewTaskPage.CreateNewTask();

            TaskProvider.CreateTask(dashboardPage);

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.EditTask();

            myTasksPage.Validate().EditedTaskExists();

            myTasksPage.DeleteNewTask();
           
            myTasksPage.Validate().IsTaskDeleted();
        }

        [TestCategory("MyTasksPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test003CompletedButtonValidate()
        {
            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.CompletedButton();

            myTasksPage.Validate().IsCompletedTasksExist();
        }

        [TestCategory("MyTasksPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test004AddSubtask()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();

            addNewTaskPage.CreateNewTask();

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.AddSubtask();

            myTasksPage.Validate().SubtaskExists();

            myTasksPage.DeleteTasks();

            myTasksPage.Validate().IsTaskDeleted();
        }

        [TestCategory("MyTasksPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test005DeleteTask()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();

            addNewTaskPage.CreateNewTask();

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.DeleteNewTask();

            myTasksPage.Validate().IsTaskDeleted();
        }
    }
}
