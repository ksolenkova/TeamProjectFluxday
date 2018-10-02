using OpenQA.Selenium;
using TeamProjectFluxday.Core;
using System.Collections.Generic;

namespace TeamProjectFluxday.Pages.TeamPage
{
    public class TeamPageMap : BasePageMap
    {
        public IWebElement AddTeamButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"team - members\"]/a"));
            }
        }
        public IWebElement CancelButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"edit_team_11\"]/div[3]/div[2]/a/span"));
            }
        }
        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"edit_team_11\"]/div[3]/div[2]/input"));
            }
        }
        public IWebElement TeamsPane
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"pane2\"]/div[2]"));
            }
        }
        public IReadOnlyCollection<IWebElement> Teams
        {
            get
            {
                return GetElements(By.XPath("//*[@id=\"pane2\"]/div[2]"));
            }
        }
    }
}
