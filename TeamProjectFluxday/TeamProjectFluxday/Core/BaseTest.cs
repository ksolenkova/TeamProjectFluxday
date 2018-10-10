using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamProjectFluxday.Core
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
