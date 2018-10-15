using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Parts
{
    public class NavigationPanelMap : BasePageMap
    {
        public IWebElement UserLink
        {
            get
            {
                return GetElement(By.CssSelector(".user-links > li:nth-child(1) > a:nth-child(1)"));
            }
        }

        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.CssSelector(".user-links > li:nth-child(2) > a:nth-child(1)"));
            }
        }

        public IWebElement UsersLink
        {
            get
            {
                return GetElement(By.LinkText("Users"));
            }
        }
    }
}
