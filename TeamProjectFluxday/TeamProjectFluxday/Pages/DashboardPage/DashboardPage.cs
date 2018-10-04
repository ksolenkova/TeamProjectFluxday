using SeleniumWebDriver.Core;
using System.Threading;

namespace SeleniumWebDriver.Pages.DashboardMainPage
{
    public class DashboardPage : BasePage<DashboardPageMap>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }

        internal string ReadAdminUserLinkText()
        {
            return Map.AdminUserLink.Text;
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
    }
}
