using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class AddNewTaskPageValidator : BasePageValidator<AddNewTaskPageMap>
    {
        public void IsOnAddNewTaskPage()
        {
            var expectedResult = "Task";
            Assert.AreEqual(expectedResult, Map.AddNewTaskPageTitle.Text);
        }
    }
}
