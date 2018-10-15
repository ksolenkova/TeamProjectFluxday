using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class TeamDetailsPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("TeamDetailsPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test001NavigateToDevOpsTeamDetailsPage()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            var devOpsTeamDetailsPage = teamPage.SelectTeam(TestData.DevOps.Name);
            devOpsTeamDetailsPage.Navigate();
            devOpsTeamDetailsPage.Validate().DevOpsTitle();
        }

        [TestCategory("TeamDetailsPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test002VerifyUzityDevelopmentTeamDefaultMembersCount()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            var uzityTeamDetailsPage = teamPage.SelectTeam(TestData.UzityDevelopment.Name);
            uzityTeamDetailsPage.Navigate();
            uzityTeamDetailsPage.Validate().UzityTeamMembersCount();
        }

        [TestCategory("TeamDetailsPageTests")]
        [Owner("Angel Botev")]
        [TestMethod]
        public void Test003VerifyAddMembersButtonIsEnabledAndDisplayedInSupportTeamDetailsPage()
        {
            var teamPage = dashboardPage.NavigationPanel.NavigateToTeamPage();
            var supportTeamDetailsPage = teamPage.SelectTeam(TestData.Support.Name);
            supportTeamDetailsPage.Navigate();
            supportTeamDetailsPage.Validate().SupportTeamAddMembersButton();
        }
    }
}
