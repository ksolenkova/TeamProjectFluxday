using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class EditTeamPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("EditTeamPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test001EditSupportTeamName()
        {
            var defaultSupportName = TestData.Support.Name;
            var newSupportName = "Support Edited";

            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            var supportDetailsPage = teamPage.SelectTeam(defaultSupportName);
            //supportDetailsPage.Navigate();
            //var editSupportPage = supportDetailsPage.NavigateToTeamDetailsPage(defaultSupportName);
            //supportDetailsPage.Validate();
        }
    }
}
