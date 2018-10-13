using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.MyTasks
{
    public class MyTasksPageValidator : BasePageValidator<MyTasksPageMap>
    {
        public void TaskExists(string taskTitle)
        {
            Assert.IsTrue(Map.TaskTitle(taskTitle).Displayed, $"Task with name { taskTitle } cannot be found!");
        }
    }
}
