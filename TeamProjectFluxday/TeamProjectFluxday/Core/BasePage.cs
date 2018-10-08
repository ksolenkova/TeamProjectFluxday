using SeleniumWebDriver.Parts;
using System;

namespace SeleniumWebDriver.Core

{
    public class BasePage<TM> where TM : BasePageMap, new()
    {
        public BasePage(string url)
        {
            Url = url;
        }

        public string Url { get; set; }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(Url);
        }

        public NavigationPanel NavigationPanel
        {
            get
            {
                return new NavigationPanel();
            }
        }

        public string GenerateDateTimeString()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
