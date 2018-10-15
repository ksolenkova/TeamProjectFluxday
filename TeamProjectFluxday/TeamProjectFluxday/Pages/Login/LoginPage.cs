using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data.Models;

namespace TeamProjectFluxday.Pages
{
    public class LoginPage : BasePage<LoginPageMap, LoginPageValidator>
    {
        public LoginPage(string url = "https://app.fluxday.io/users/sign_in") : base(url)
        {
        }

        internal void TypeEmail(string email)
        {
            var emailInput = Map.EmailInput;
            emailInput.Click();
            emailInput.Clear();
            emailInput.SendKeys(email);
        }

        internal void TypePassword(string password)
        {
            var passwordInput = Map.PasswordInput;
            passwordInput.Click();
            passwordInput.Clear();
            passwordInput.SendKeys(password);
        }

        internal void PressLoginButton()
        {
            Map.LoginButton.Click();
        }

        internal DashboardPage Login(string email, string password)
        {
            TypeEmail(email);
            TypePassword(password);
            PressLoginButton();

            return new DashboardPage();
        }

        internal DashboardPage Login(User user)
        {
            TypeEmail(user.Email);
            TypePassword(user.Password);
            PressLoginButton();

            return new DashboardPage();
        }
    }
}
