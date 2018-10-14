using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class AddNewTaskPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.TeamLeadUser);
        }


        [TestCategory("AddNewTaskPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test002NewTaskButtonValidation()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();
            Thread.Sleep(1000);
            addNewTaskPage.Validate().IsOnAddNewTaskPage();
        }

        [TestCategory("AddNewTaskPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test003CreateNewTask()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();
            
            addNewTaskPage.CreateNewTask();

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.Validate().TaskExists();
            Thread.Sleep(1000);
            myTasksPage.DeleteNewTask();
            Thread.Sleep(1000);
            myTasksPage.Validate().IsTaskDeleted();
        }
    }
}
