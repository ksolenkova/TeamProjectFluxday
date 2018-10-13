using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Team.EditTeam
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
    }
}
