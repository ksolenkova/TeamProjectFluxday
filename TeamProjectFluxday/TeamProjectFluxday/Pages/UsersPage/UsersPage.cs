using SeleniumWebDriver.Core;
using System;

namespace TeamProjectFluxday.Pages.UsersPage
{
    public class UsersPage : BasePage<UsersPageMap>
    {
        public UsersPage(string url = "https://app.fluxday.io/users#pane2") : base(url)
        {
        }

        internal void AddUserClick()
        {
            Map.AddUser.Click();
        }

        public string GenerateDateTimeString()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        internal void  FillInName()
        {
            var userNameField = Map.UserNameField;
            var userName = $"Test{GenerateDateTimeString()}";
            userNameField.SendKeys(userName);
        }

        internal void FillInNickName()
        {
            var nickNameField = Map.NickNameField;
            nickNameField.SendKeys($"Test{GenerateDateTimeString()}");
        }

        internal void FillInEmail()
        {
            var emailField = Map.EmailField;
            emailField.SendKeys($"Test{GenerateDateTimeString()}@fluxday.io");
        }

        internal void FillInEmployeeCode()
        {
            var employeeCodeField = Map.EmployeeCodeField;
            employeeCodeField.SendKeys($"test{GenerateDateTimeString()}");
        }

        internal void FillInPassword()
        {
            var passwordField = Map.PasswordField;
            passwordField.SendKeys("password");
        }

        internal void FillInConfirmPassword()
        {
            var confirmPasswordField = Map.ConfirmPasswordField;
            confirmPasswordField.SendKeys("password");
        }

        internal void SaveButtonClick()
        {
            var saveButton = Map.SaveButton;
            saveButton.Click();
        }

        internal void FillInAddUserForm()
        {
            FillInName();
            FillInNickName();
            FillInEmail();
            FillInEmployeeCode();
            FillInPassword();
            FillInConfirmPassword();
        }


    }
}
