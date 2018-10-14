using OpenQA.Selenium;
using System.Collections.Generic;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DashboardPageMap : BasePageMap
    {
        public IReadOnlyCollection<IWebElement> TaskTitles
        {
            get
            {
                return GetElements(By.CssSelector(@"li.task-name"));
            }
        }
    }
}
