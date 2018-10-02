using OpenQA.Selenium;
using System.Collections.Generic;

namespace  TeamProjectFluxday.Core
{
    public class BasePageMap
    {
        protected IWebDriver Browser;

        public BasePageMap()
        {
            Browser = Driver.Browser;
        }

        public IWebElement GetElement(By by)
        {
            return Browser.FindElement(by);
        }

        public IReadOnlyCollection<IWebElement> GetElements(By by)
        {
            return Browser.FindElements(by);
        }
    }
}
