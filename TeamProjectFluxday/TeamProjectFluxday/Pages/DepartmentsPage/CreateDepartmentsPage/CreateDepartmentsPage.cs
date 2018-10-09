using SeleniumWebDriver.Core;
using SeleniumWebDriver.Pages;

namespace TeamProjectFluxday.Pages
{
    public class CreateDepartmentsPage : BasePage<CreateDepartmentsPageMap, CreateDepartmentsValidator>
    {
        public CreateDepartmentsPage(string url = @"https://app.fluxday.io/projects/new#pane3") : base(url)
        {
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
    }
}
