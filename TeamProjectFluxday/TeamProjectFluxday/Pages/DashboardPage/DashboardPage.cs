using TeamProjectFluxday.Core;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Pages
{
    public class DashboardPage : BasePage<DashboardPageMap, DashboardPageValidator>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }
        
    }
}
