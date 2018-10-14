using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class TeamDetailsPage : BasePage<TeamDetailsPageMap, TeamDetailsPageValidator>
    {
        public TeamDetailsPage(string url) : base(url)
        {
        }

        internal void ClickOnSettingsIcon()
        {
            Map.SettingsIcon.Click();
        }
    }
}
