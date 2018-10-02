using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
                return GetElement(By.XPath("/html/body/div[2]/div[1]/ul[2]/li[3]/a"));
            }
        }
    }
}
