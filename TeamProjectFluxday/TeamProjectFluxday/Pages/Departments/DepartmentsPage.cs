using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPage : BasePage<DepartmentsPageMap, DepartmentsPageValidator>
    {
        public DepartmentsPage(string url = "https://app.fluxday.io/projects#pane2") : base(url)
        {
        }
        
        internal CreateDepartmentsPage PressCreateDepartmentLink()
        {
            Map.CreateDepartmentLink.Click();
            Thread.Sleep(2000);

            return new CreateDepartmentsPage();
        }

        internal void PressSettingsIcon()
        {
            Map.SettingsIcon.Click();
        }
        
        internal void DeleteNewlyCreatedDepartment()
        {
            Map.SettingsIcon.Click();
            Map.DeleteLink.Click();
            SwitchToAlert().Accept();
        }

        internal void ClickOnFinanceDepartment()
        {
            Map.FinanceLink.Click();
        }

        internal EditDepartmentsPage PressEdit()
        {
            Map.EditLink.Click();

            return new EditDepartmentsPage();
        }
    }
}
