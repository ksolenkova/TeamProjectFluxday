﻿using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages
{
    public class TeamPage : BasePage<TeamPageMap, TeamPageValidator>
    {
        public TeamPage(string url = "https://app.fluxday.io/teams#pane2") : base(url)
        {
        }

        public TeamDetailsPage SelectTeam(string teamName)
        {
            string teamIndex = TestData.TeamIndexes[teamName];
            return new TeamDetailsPage($"https://app.fluxday.io/teams/{teamIndex}#pane3");
        }
    }
}
