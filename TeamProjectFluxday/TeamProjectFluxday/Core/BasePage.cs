using System;
using TeamProjectFluxday.Core;

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

        public string GenerateDateTimeString()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public BasePage(string url) : base(url)
        {
        }

        public TV Validate()
        {
            return new TV();
        }
    }
}
