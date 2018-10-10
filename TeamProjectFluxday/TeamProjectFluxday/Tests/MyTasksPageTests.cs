using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages.Login;
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

            var teamLeadUser = TestData.TeamLeadUser;
           
            loginPage.TypeEmail(teamLeadUser.Email);
            loginPage.TypePassword(teamLeadUser.Password);
            loginPage.PressLoginButton();

            var myTasksPage = new MyTasksPage();
            myTasksPage.Navigate();
            
            myTasksPage.NavigationPanel.PressNewTaskButton();

            var newTask = TestData.NewTask;
            myTasksPage.TypeTitle(newTask.Title);
            myTasksPage.TypeDescription(newTask.Description);
            myTasksPage.PressCreateTaskButton();

            var myTasksPage2 = new MyTasksPage();
            myTasksPage.Navigate();

            var actualResul = myTasksPage2.ReadTaskTitleText();

            Assert.AreEqual(newTask.Title, actualResul);
        }
    }
}
