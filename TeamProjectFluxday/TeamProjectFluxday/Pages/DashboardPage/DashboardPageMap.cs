using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages
{
    public class DashboardPageMap : BasePageMap
    {
        public IWebElement AdminUserLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.user-links.side-nav.sidebar-links >li:first-child >a"));
            }
        }


        public IWebElement DepartmentsLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.side-nav:nth-child(2) > li:nth-child(3) > a:nth-child(1)"));
            }
        }

        public IWebElement UsersLink
        {
            get
            {
                return GetElement(By.XPath(@"/html/body/div[2]/div[1]/ul[2]/li[5]/a"));
            }
        }
    }
}
