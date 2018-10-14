using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Utils;
using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class TeamPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("TeamPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test001NavigateToTeamPage()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            teamPage.Validate().TeamPageTitle();
        }

        [TestCategory("TeamPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test002VerifyDefaultTeamsCount()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            teamPage.Validate().DefaultTeamsCount();
        }

        [TestCategory("TeamPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test003VerifyDevOpsIsPresentInTeamsList()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            teamPage.Validate().TeamExists(TestData.DevOps.Name);
        }

    }
}
