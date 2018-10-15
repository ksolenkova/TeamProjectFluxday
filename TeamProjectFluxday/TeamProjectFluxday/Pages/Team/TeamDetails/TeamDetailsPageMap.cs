using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class TeamDetailsPageMap : BasePageMap
    {
        public IWebElement AddMembersButton
        {
            get
            {
                return GetElement(By.CssSelector(".dashed_link"));
            }
        }

        public IWebElement TeamTitle
        {
            get
            {
                return GetElement(By.CssSelector(".main-title"));
            }
        }

        public IWebElement UzityTeamMembersCount
        {
            get
            {
                return GetElement(By.CssSelector(".active a .fig"));
            }
        }

        public IWebElement SettingsIcon
        {
            get
            {
                return GetElement(By.CssSelector("div.icon"));
            }
        }

        public IWebElement EditOption
        {
            get
            {
                return GetElement(By.CssSelector("#drop1 > li:nth-child(1) > a:nth-child(1)"));
            }
        }
    }
}
