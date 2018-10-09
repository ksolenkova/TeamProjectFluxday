using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.Pages;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.LoginPage
{
    public class LoginPageValidator : BasePageValidator<LoginPageMap>
    {
        public void LoginForm()
        {
            Assert.IsTrue(Map.EmailInput.Displayed, "Email input is not displayed!");
            Assert.IsTrue(Map.PasswordInput.Displayed, "Password input is not displayed!");
            Assert.IsTrue(Map.LoginButton.Displayed, "Loggin button is not displayed!");
        }
    }
}
