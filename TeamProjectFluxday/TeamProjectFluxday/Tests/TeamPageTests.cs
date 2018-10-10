using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Pages.Login;
using TeamProjectFluxday.Pages.Team;

namespace TeamProjectFluxday.Tests
{
    public class TeamPageTests
    {
        [TestClass]
        public class LoginPageTests : BaseTest
        {
            [TestCategory("TeamPageTests")]
            [TestMethod]
            public void Test001AddMembersToTeam()
            {
                var loginPage = new LoginPage();
                loginPage.Navigate();

                var adminUser = Data.TestData.TeamLeadUser;

                var dashboardPage = loginPage.Login(adminUser);
                var teamPage = new TeamPage();
                teamPage.Navigate();

                var team = Data.TestData.DevOps;
            }
        }
    }
}
