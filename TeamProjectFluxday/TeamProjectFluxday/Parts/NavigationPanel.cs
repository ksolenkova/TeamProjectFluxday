using TeamProjectFluxday.Pages;
using System.Threading;

namespace TeamProjectFluxday.Parts
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

        internal void ClickOnDepartmentsLink()
        {
            Map.DepartmentsLink.Click();
            Thread.Sleep(2000);
        }

        internal void UsersLinkClick()
        {
            Map.UsersLink.Click();
        }

        internal LoginPage Logout()
        {
            Map.LogoutButton.Click();

            return new LoginPage();
        }
    }
}
