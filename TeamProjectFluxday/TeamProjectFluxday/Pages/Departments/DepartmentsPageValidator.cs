using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data.Models;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPageValidator : BasePageValidator<DepartmentsPageMap>
    {
        public void IsOnDepartmentsPage()
        {
            Assert.IsTrue(Map.DepartmentsTitle.Displayed, "Departments page is not displayed");
        }

        internal void NewDepartmentExists()
        {
            Assert.IsTrue(Map.MainTitleOfDepartment.Displayed, "Newly created department is not displayed!");
        }

        internal void NewDepartmentIsDeleted()
        {
            var expectedResult = "Administration";
            Assert.AreNotSame(expectedResult, Map.MainTitleOfDepartment.Text);
        }

        internal void DefaultDepartmentsCount()
        {
            Assert.AreEqual(4, Map.ListOfDepartments.Count);
        }
    }
}
