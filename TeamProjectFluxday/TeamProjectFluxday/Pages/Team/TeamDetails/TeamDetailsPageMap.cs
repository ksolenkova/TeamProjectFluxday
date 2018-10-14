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

        public IWebElement DevOpsTitle
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
    }
}
