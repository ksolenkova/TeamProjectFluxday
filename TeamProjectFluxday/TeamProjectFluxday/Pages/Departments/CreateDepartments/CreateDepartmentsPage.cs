using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data.Models;

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
            Map.TitleField.SendKeys(newDepartment.Title);
            Map.CodeDepartment.SendKeys(newDepartment.Code);
            Map.Url.SendKeys(newDepartment.Url);
            Map.Description.SendKeys(newDepartment.Description);
            Map.SaveButton.Click();

            return new DepartmentsPage();
        }
    }
}
