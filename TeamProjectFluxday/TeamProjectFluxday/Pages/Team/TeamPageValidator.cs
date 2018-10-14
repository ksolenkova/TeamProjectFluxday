using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages
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
            Assert.AreEqual(TestData.DefaultTeamsList.Count, Map.ListOfTeams.Count);
        }

        internal void TeamExists(string teamName)
        {
            Assert.IsTrue(Map.TeamName(teamName).Displayed, $"Team with name { teamName } cannot be found");
        }
    }
}
