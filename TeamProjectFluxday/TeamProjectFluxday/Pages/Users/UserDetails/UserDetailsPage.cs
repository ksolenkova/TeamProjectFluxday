using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class UserDetailsPage : BasePage<UserDetailsPageMap, UserDetailsPageValidator>
    {
        public UserDetailsPage(string url = "https://app.fluxday.io/users/FT1#pane3") : base(url)
        {
        }

        internal void DeleteNewUser()
        {
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
            Thread.Sleep(1000);
            SwitchToAlert().Accept();
            Thread.Sleep(2000);
        }
    }
}
