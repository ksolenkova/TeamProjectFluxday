using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Departments
{
    public class DepartmentsPage : BasePage<DepartmentsPageMap, DepartmentsPageValidator>
    {
        public DepartmentsPage(string url = "https://app.fluxday.io/projects#pane2") : base(url)
        {
        }

        public CreateDepartmentsPage NavigateToCreateDepartmentPage()
        {
            return new CreateDepartmentsPage();
        }

        internal CreateDepartmentsPage PressCreateDepartmentLink()
        {
            Map.CreateDepartmentLink.Click();
            Thread.Sleep(2000);

            return new CreateDepartmentsPage();
        }
    }
}
