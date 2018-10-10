using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Parts
{
    public class NavigationPanelValidator : BasePageValidator<NavigationPanelMap>
    {
        public void UserNameLink(string expectedResult)
        {
            string actualResult = Map.UserLink.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
