using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.MyTasks
{
    public class MyTasksPageValidator : BasePageValidator<MyTasksPageMap>
    {
        public void TaskExists()
        {
            var expectedResult = "Test Title";
            Assert.AreEqual(expectedResult, Map.TaskTitle.Text);
        }
    }
}
