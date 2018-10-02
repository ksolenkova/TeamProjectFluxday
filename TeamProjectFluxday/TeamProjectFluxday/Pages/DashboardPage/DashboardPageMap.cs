using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.DashboardMainPage
{
    public class DashboardPageMap : BasePageMap
    {
        public IWebElement AdminUserLink
        {
            get
            {
                return GetElement(By.XPath(@"/html/body/div[2]/div[1]/ul[3]/li[1]/a"));
            }
        }
    }
}
