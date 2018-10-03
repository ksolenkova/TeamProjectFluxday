using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SeleniumWebDriver.Core
{
    public class BasePageMap
    {
        protected IWebDriver Browser;
        protected WebDriverWait BrowserWait;

        public BasePageMap()
        {
            Browser = Driver.Browser;
            BrowserWait = Driver.BrowserWait;
        }

        public IWebElement GetElement(By by)
        {
            BrowserWait.Until(ExpectedConditions.ElementExists(by));
            return Browser.FindElement(by);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By by)
        {
            return Browser.FindElements(by);
        }
    }
}
