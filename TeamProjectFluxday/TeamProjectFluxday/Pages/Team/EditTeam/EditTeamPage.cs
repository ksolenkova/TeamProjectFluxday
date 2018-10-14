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

        
    }
}
