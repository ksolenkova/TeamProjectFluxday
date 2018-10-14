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
        public void Test004EditTask()
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();

            addNewTaskPage.CreateNewTask();

            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();

            myTasksPage.EditTask();

            myTasksPage.Validate().EditedTaskExists();

            myTasksPage.DeleteNewTask();
           
            myTasksPage.Validate().IsTaskDeleted();
        }

        [TestCategory("MyTasksPageTests")]
        [Owner("Yusuf Machan")]
        [TestMethod]
        public void Test006CompletedButtonValidation()
        {
            var myTasksPage = dashboardPage.NavigationPanel.NavigateToMyTasksPage();
            
            myTasksPage.CompletedButton();

            myTasksPage.Validate().IsCompletedTasksExist();
        }
    }
}
