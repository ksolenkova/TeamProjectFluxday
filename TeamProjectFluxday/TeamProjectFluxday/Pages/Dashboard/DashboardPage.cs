using OpenQA.Selenium;
using System.Collections.Generic;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DashboardPage : BasePage<DashboardPageMap, DashboardPageValidator>
    {
        public DashboardPage(string url = "https://app.fluxday.io/") : base(url)
        {
        }

        internal IReadOnlyCollection<IWebElement> ReadTaskItems()
        {
            return Map.TaskTitles;
        }
    }
}
