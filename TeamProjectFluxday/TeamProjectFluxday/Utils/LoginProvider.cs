using TeamProjectFluxday.Data.Models;
using TeamProjectFluxday.Pages.Dashboard;
using TeamProjectFluxday.Pages.Login;

namespace TeamProjectFluxday.Utils
{
    public static class LoginProvider
    {
        public static DashboardPage Login(User user)
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            return loginPage.Login(user);
        }
    }
}
