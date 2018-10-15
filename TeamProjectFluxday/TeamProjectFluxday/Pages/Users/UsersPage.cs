using System.Threading;
using TeamProjectFluxday.Core;

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

        internal UserDetailsPage NewUserClick()
        {
            Map.NewUser.Click();
            Thread.Sleep(1000);
            return new UserDetailsPage();
        }
    }
}
