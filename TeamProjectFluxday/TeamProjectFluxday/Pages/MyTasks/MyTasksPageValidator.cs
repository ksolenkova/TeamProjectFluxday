using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages
{
    public class MyTasksPageValidator : BasePageValidator<MyTasksPageMap>
    {
        public void TaskExists()
        {
            var expectedResult = TestData.Task.Title;
            Assert.AreEqual(expectedResult, Map.TaskTitle.Text);
        }

        public void IsOnMyTasksPage()
        {
            var expectedResult = "My tasks";
            Assert.AreEqual(expectedResult, Map.MyTasksPageTitle.Text);
        }

        public void IsTaskDeleted()
        {
                try
                {
                var dashboardpagecheck = new DashboardPage();
                dashboardpagecheck.Navigate();
                Thread.Sleep(1000);
                var tasks = dashboardpagecheck.ReadTaskItems();

                Assert.Fail();
                }
                catch (WebDriverTimeoutException)
                {
                    
                }
        }
    }
}
