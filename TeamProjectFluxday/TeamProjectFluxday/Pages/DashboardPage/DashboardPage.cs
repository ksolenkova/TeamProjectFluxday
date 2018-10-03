using SeleniumWebDriver.Core;

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

<<<<<<< HEAD
        internal void ClickOnDepartmentsLink()
        {
            Map.DepartmentsLink.Click();
=======
        internal void UsersLinkClick()
        {
            Map.UsersLink.Click();
>>>>>>> f13b8557b7071109c28fe204b075c623ec628d20
        }
    }
}
