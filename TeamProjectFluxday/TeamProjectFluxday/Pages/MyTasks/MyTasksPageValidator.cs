﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Thread.Sleep(1000);
            Assert.AreEqual(expectedResult, Map.TaskTitle.Text);
        }

        public void IsOnMyTasksPage()
        {
            var expectedResult = "My tasks";
            Thread.Sleep(1000);
            Assert.AreEqual(expectedResult, Map.MyTasksPageTitle.Text);
        }

        public void IsTaskDeleted()
        {
            try
            {
                var dashboardPageCheck = new DashboardPage();
                dashboardPageCheck.Navigate();
                Thread.Sleep(1000);
                var tasks = dashboardPageCheck.ReadTaskItems();

                Assert.Fail();
            }
            catch (WebDriverTimeoutException)
            {

            }
        }

        public void EditedTaskExists()
        {
            var expectedResult = "Edited Title";
            Assert.AreEqual(expectedResult, Map.TaskTitle.Text);
        }
    }
}
