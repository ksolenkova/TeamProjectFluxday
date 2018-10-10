using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Departments
{
    public class DepartmentsPageValidator : BasePageValidator<DepartmentsPageMap>
    {
        public void IsOnDepartmentsPage()
        {
            Assert.IsTrue(Map.DepartmentsTitle.Displayed, "Departments page is not displayed");
        }
    }
}
