using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TeamProjectFluxday.Core
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
            return BrowserWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        public bool ElementIsNotPresent(By by)
        {
            try
            {
                GetElement(by);
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return true;
            }
        }
    }
}
