using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Team
{
    public class TeamPageValidator : BasePageValidator<TeamPageMap>
    {
        public void TeamPageTitle()
        {
            var expectedResult = "Teams";
            Thread.Sleep(500);
            Assert.AreEqual(expectedResult, Map.TeamPageTitle.Text);
        }

        public void DefaultTeamsCount()
        {
            Assert.AreEqual(6, Map.ListOfTeams.Count);
        }

        internal void TeamExists(string teamName)
        {
            Assert.IsTrue(Map.TeamName(teamName).Displayed, $"Team with name { teamName } cannot be found");
        }
    }
}
