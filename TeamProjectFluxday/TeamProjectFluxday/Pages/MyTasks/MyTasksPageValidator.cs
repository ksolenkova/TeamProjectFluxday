using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
