using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class EditTeamPageMap : BasePageMap
    {
        public IWebElement CancelButton
        {
            get
            {
                return GetElement(By.CssSelector(".translation_missing"));
            }
        }
        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }

        public IWebElement TeamNameField
        {
            get
            {
                return GetElement(By.CssSelector("#team_name"));
            }
        }
    }
}
