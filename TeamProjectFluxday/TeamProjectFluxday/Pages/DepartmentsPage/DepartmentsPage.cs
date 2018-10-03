using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.DepartmentsPage
{
    public class DepartmentsPage : BasePage<DepartmentsPageMap>
    {
        public DepartmentsPage(string url = "https://app.fluxday.io/projects#pane2") : base(url)
        {
        }

        internal void ClickOnCreateDepartmentsLink()
        {
            Map.CreateDepartmentLink.Click();
        }

        internal void WriteTitle()
        {
            Map.TitleField.SendKeys("Administration");
        }

        internal void WriteCode()
        {
            Map.CodeDepartment.SendKeys("ADM" + GenerateDateTimeString());
        }

        internal void WriteUrl()
        {
            Map.Url.SendKeys("adm");
        }

        internal void WriteDescription()
        {
            Map.Description.SendKeys("Administration team");
        }

        internal void ClickOnSave()
        {
            Map.SaveButton.Click();
        }

        internal bool NewDepartmentIsDisplayed()
        {
            return Map.NewlyCreatedDepartment.Displayed;
        }
    }
}
