using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.DashboardMainPage
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
    }
}
