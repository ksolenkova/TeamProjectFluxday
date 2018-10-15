using System;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages
{
    public class TeamDetailsPage : BasePage<TeamDetailsPageMap, TeamDetailsPageValidator>
    {
        public TeamDetailsPage(string url) : base(url)
        {
        }

        public TeamDetailsPage()
        {
        }

        internal void ClickOnSettingsIcon()
        {
            Map.SettingsIcon.Click();
        }

        internal void ClickOnEditOption()
        {
            Map.EditOption.Click();
        }

        internal EditTeamPage NavigateToTeamDetailsPage(string teamName)
        {
            ClickOnSettingsIcon();
            ClickOnEditOption();
            string teamIndex = TestData.TeamIndexes[teamName];
            return new EditTeamPage($"https://app.fluxday.io/teams/{teamIndex}/edit#pane3");
        }
    }
}
