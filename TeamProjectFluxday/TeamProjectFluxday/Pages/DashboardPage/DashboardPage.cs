using SeleniumWebDriver.Core;
using TeamProjectFluxday.Pages;

namespace SeleniumWebDriver.Pages
{
    public class DashboardPage : BasePage<DashboardPageMap, DashboardPageValidator>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }
        
    }
}
