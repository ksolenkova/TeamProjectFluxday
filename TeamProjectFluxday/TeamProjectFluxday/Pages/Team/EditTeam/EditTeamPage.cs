using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class EditTeamPage : BasePage<EditTeamPageMap, EditTeamPageValidator>
    {
        public EditTeamPage(string url) : base(url)
        {
        }
        internal void PressSaveButton()
        {
            Map.SaveButton.Click();
        }

        internal void PressCancelButton()
        {
            Map.CancelButton.Click();
        }

        internal void ChangeTeamName(string newName)
        {
            var nameInput = Map.TeamNameField;
            nameInput.Click();
            nameInput.Clear();
            nameInput.SendKeys(newName);
        }
    }
}
