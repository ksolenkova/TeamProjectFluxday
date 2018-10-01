using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Core
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TestTeardown()
        {
            Driver.StopBrowser();
        }
    }
}
