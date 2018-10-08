using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages;

namespace TeamProjectFluxday.Pages
{
    public class CreateDepartmentsPage : BasePage<CreateDepartmentsPageMap>
    {
        private DepartmentsPage departmentsPage;

        public CreateDepartmentsPage(string url = @"https://app.fluxday.io/projects/new#pane3") : base(url)
        {
            DepartmentsPage = new DepartmentsPage();
        }

        public DepartmentsPage DepartmentsPage
        {
            get
            {
                return departmentsPage;
            }
            private set
            {
                {
                    departmentsPage = value;
                }
            }
        }
    }
}
