using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}
