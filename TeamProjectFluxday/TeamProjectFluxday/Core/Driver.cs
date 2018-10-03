using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriver.Core
{
    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait browserWait;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("WebDriver is not Started!");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 5)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    Browser = new ChromeDriver();
                    break;
                case BrowserTypes.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                default:
                    break;
            }

            Browser.Manage().Window.Maximize();
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
