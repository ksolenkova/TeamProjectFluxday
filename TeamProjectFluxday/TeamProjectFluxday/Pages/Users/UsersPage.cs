using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Pages
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

        internal void FillInName()
        {
            Map.UserNameField.SendKeys("TestEmployee");
        }

        internal void FillInNickName()
        {
            Map.NickNameField.SendKeys(StringHelper.AppendDateTimeString("Test"));
        }

        internal void FillInEmail()
        {
            Map.EmailField.SendKeys($"Test{StringHelper.GenerateDateTimeString()}@fluxday.io");
        }

        internal void FillInEmployeeCode()
        {
            Map.EmployeeCodeField.SendKeys(StringHelper.AppendDateTimeString("test"));
        }

        internal void FillInPassword()
        {
            Map.PasswordField.SendKeys("password");
        }

        internal void FillInConfirmPassword()
        {
            Map.ConfirmPasswordField.SendKeys("password");
        }

        internal void SaveButtonClick()
        {
            Map.SaveButton.Click();
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

        internal string ReadNewUserName()
        {
            return Map.NewUser.Text;
        }

        internal void DeleteNewUser()
        {
            Map.NewUser.Click();
            Thread.Sleep(1000);
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
            Thread.Sleep(1000);
            SwitchToAlert().Accept();
            Thread.Sleep(2000);
        }
    }
}
