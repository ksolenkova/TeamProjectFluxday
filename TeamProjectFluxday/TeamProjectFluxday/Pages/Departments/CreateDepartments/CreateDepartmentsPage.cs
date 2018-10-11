using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data.Models;
using TeamProjectFluxday.Pages.Departments;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Pages
{
    public class CreateDepartmentsPage : BasePage<CreateDepartmentsPageMap, CreateDepartmentsValidator>
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
                departmentsPage = value;
            }
        }
        
        internal DepartmentsPage AddDepartment(Department newDepartment)
        {
            Map.TitleField.SendKeys("Administration");
            Map.CodeDepartment.SendKeys(StringHelper.AppendDateTimeString("ADM"));
            Map.Url.SendKeys("adm");
            Map.Description.SendKeys("Administration team");
            Map.SaveButton.Click();

            return DepartmentsPage;
        }
    }
}
