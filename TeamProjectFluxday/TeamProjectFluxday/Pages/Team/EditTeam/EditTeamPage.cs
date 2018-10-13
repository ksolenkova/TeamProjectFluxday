using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Team.EditTeam
{
    public class EditTeamPage : BasePage<EditTeamPageMap, EditTeamPageValidator>
    {
        internal void PressSaveButton()
        {
            Map.SaveButton.Click();
        }

        internal void PressCancelButton()
        {
            Map.CancelButton.Click();
        }
    }
}
