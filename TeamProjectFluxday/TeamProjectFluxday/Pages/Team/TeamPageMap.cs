using OpenQA.Selenium;
using System.Collections.Generic;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Team
{
    public class TeamPageMap : BasePageMap
    {

        public IReadOnlyCollection<IWebElement> ListOfTeams
        {
            get
            {
                return GetElements(By.CssSelector(".team-name"));
            }
        }

        public IWebElement TeamPageTitle
        {
            get
            {
                return GetElement(By.CssSelector("div.title"));
            }
        }

        public IReadOnlyCollection<IWebElement> AddTaskButtonsList
        {
            get
            {
                return GetElements(By.CssSelector(".btn"));
            }
        }

        public IWebElement TeamName(string teamName)
        {
            return GetElement(By.LinkText(teamName));
        }
    }
}
