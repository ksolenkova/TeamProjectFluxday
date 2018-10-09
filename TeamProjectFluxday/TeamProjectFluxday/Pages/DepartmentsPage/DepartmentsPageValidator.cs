using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Pages;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPageValidator : BasePageValidator<DepartmentsPageMap>
    {
        public void IsOnDepartmentsPage()
        {
            Assert.IsTrue(Map.DepartmentsTitle.Displayed, "Departments page is not displayed");
        }
    }
}
