using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class AddAnEmployeePageValidator : BasePageValidator<AddAnEmployeePageMap>
    {
        internal void IsOnAddAnEmployeePage()
        {
            var expectedResult = "Add an employee";
            Assert.AreEqual(expectedResult, Map.AddAnEmployeeTitle.Text);
        }

        internal void IsNotOnAddAnEmployeePage()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Map.AddAnEmployeeTitleNotVisible, "Still on Add add an employee page!");
        }
    }
}
