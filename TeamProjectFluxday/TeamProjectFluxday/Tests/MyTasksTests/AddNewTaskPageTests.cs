using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void Test002NavigateToAddNewTaskPage()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();
            
            addNewTaskPage.Validate().IsOnAddNewTaskPage();
        }

        [TestCategory("AddNewTaskPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test002CreateNewTask()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();
            
            addNewTaskPage.CreateNewTask();

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.Validate().TaskExists();
            
            myTasksPage.DeleteNewTask();
            
            myTasksPage.Validate().IsTaskDeleted();
        }
    }
}
