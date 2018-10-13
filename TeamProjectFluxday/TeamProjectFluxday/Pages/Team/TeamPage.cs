using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class TeamPage : BasePage<TeamPageMap, TeamPageValidator>
    {
        public TeamPage(string url = "https://app.fluxday.io/teams#pane2") : base(url)
        {
        }

        public EditTeamPage NavigateToEditTeamPage()
        {
            return new EditTeamPage();
        }
    }
}
