using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Dashboard
{
    public class DashboardPage : BasePage<DashboardPageMap, DashboardPageValidator>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }

    }
}
