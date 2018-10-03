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
            bool isDisplayed = BrowserWait.Until(driver => driver.FindElement(by).Displayed);
            bool isEnabled = BrowserWait.Until(driver => driver.FindElement(by).Enabled);

            if (isDisplayed && isEnabled)
            {
                return Browser.FindElement(by);
            }

            throw new ElementNotVisibleException($"Element with locator { by.ToString() } is not visible / clickable!");

        }

        public IReadOnlyCollection<IWebElement> GetElements(By by)
        {
            return Browser.FindElements(by);
        }
    }
}
