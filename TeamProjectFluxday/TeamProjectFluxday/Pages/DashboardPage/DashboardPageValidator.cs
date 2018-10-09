using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Pages;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DashboardPageValidator : BasePageValidator<DashboardPageMap>
    {
        public void UserNameLink(string expectedResult)
        {
            string actualResult = NavigationPanel.Map.UserLink.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
