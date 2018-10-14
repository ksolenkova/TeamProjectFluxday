using OpenQA.Selenium;
using System.Collections.Generic;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
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
                return GetElement(By.XPath("//*[@id=\"pane2\"]/div[1]/div"));
            }
        }

        public IWebElement TeamName(string teamName)
        {
            return GetElement(By.LinkText(teamName));
        }
    }
}
