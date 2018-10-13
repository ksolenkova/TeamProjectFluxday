using TeamProjectFluxday.Data.Models;
using TeamProjectFluxday.Pages;

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
