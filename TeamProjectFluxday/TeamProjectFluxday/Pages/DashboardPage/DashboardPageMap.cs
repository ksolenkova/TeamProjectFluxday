using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.DashboardMainPage
{
    public class DashboardPageElementMap : BasePageMap
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
