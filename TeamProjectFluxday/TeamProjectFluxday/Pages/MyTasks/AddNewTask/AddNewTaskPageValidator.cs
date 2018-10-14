using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class AddNewTaskPageValidator : BasePageValidator<AddNewTaskPageMap>
    {
        public void IsOnAddNewTaskPage()
        {
            var expectedResult = "Task";
            Thread.Sleep(1000);
            Assert.AreEqual(expectedResult, Map.AddNewTaskPageTitle.Text);
        }
    }
}
