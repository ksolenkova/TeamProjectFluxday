using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data.Models;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace TeamProjectFluxday.Pages
{
    class TeamPage : BasePage<TeamPageMap>
    {
        public TeamPage(string url = "https://app.fluxday.io/teams#pane2") : base(url)
        {
        }

        internal IReadOnlyCollection<IWebElement> GetTeams()
        {
            var teamsList = Map.Teams;

            return teamsList;
        }

        internal void ChooseTeam(string password)
        {
        }

        internal void AddMembers(User member)
        {
        }
        internal void PressSaveButton()
        {
            Map.SaveButton.Click();
        }

        internal void PressLoginButton()
        {
            Map.CancelButton.Click();
        }
    }
}
