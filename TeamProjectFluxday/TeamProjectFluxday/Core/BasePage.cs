using OpenQA.Selenium;
using System;
using TeamProjectFluxday.Parts;

namespace TeamProjectFluxday.Core

{
    public class BasePage<TM> where TM : BasePageMap, new()
    {
        public BasePage(string url)
        {
            Url = url;
        }

        public BasePage()
        {
            Url = null;
        }

        public string Url { get; set; }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public NavigationPanel NavigationPanel
        {
            get
            {
                return new NavigationPanel();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(Url);
        }

        public static IAlert SwitchToAlert()
        {
            return Driver.Browser.SwitchTo().Alert();
        }
    }

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public BasePage(string url) : base(url)
        {
        }

        public BasePage()
        {
        }

        public TV Validate()
        {
            return new TV();
        }
    }
}
