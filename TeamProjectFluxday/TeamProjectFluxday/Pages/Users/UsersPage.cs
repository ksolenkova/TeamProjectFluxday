using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Pages
{
    public class UsersPage : BasePage<UsersPageMap, UsersPageValidator>
    {
        public UsersPage(string url = "https://app.fluxday.io/users#pane2") : base(url)
        {
        }

        internal AddAnEmployeePage AddUserClick()
        {
            Map.AddUser.Click();

            return new AddAnEmployeePage();
        }

        internal string ReadNewUserName()
        {
            return Map.NewUser.Text;
        }

        internal void DeleteNewUser()
        {
            Map.NewUser.Click();
            Thread.Sleep(1000);
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
            Thread.Sleep(1000);
            SwitchToAlert().Accept();
            Thread.Sleep(2000);
        }
    }
}
