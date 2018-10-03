using Microsoft.VisualStudio.TestTools.UnitTesting;

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
