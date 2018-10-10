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

        internal CreateDepartmentsPage ClickOnCreateDepartmentsLink()
        {
            Map.CreateDepartmentLink.Click();

            return new CreateDepartmentsPage();
        }

        //internal bool NewDepartmentIsDisplayed()
        //{
        //    return Map.NewlyCreatedDepartment.Displayed;
        //}

        //internal void ClickOnSettingsIcon()
        //{
        //    Map.SettingsIcon.Click();
        //}

        //internal void ClickOnDelete()
        //{
        //    Map.DeleteLink.Click();
        //}

        //internal void DeleteCreatedDepartment()
        //{
        //    ClickOnSettingsIcon();
        //    ClickOnDelete();
        //    Driver.AcceptAlert();
        //}
    }
}
