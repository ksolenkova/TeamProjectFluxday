using SeleniumWebDriver.Pages;
using SeleniumWebDriver.Pages.LoginPage;
using SeleniumWebDriver.Pages.UsersPage;

namespace SeleniumWebDriver.Parts
{
    public class NavigationPanel
    {
        public NavigationPanel()
        {
        }

        public NavigationPanelMap Map
        {
            get
            {
                return new NavigationPanelMap();
            }
        }

        internal string ReadUserLinkText()
        {
            return Map.UserLink.Text;
        }

        internal LoginPage Logout()
        {
            Map.LogoutButton.Click();

            return new LoginPage();
        }

        internal UsersPage NavigateToUsersPage()
        {
            Map.UsersLink.Click();

            return new UsersPage();
        }
    }
}
