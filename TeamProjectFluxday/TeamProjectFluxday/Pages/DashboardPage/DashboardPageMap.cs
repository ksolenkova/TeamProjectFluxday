using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.DashboardMainPage
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

        public IWebElement TeamUserLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.side-nav:nth-child(2) > li:nth-child(4) > a:nth-child(1)"));
            }
        }

        public IWebElement TaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='pane3']/div[2]/dl/dd[1]/a/li[1]"));
            }
        }
    }
}
