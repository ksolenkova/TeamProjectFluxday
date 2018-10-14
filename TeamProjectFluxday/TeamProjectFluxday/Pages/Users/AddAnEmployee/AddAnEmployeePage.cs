using System;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Pages
{
    public class AddAnEmployeePage : BasePage<AddAnEmployeePageMap,AddAnEmployeePageValidator>
    {
        public AddAnEmployeePage(string url = "https://app.fluxday.io/users/new#pane3") : base(url)
        {
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

        internal void CancelButtonClick()
        {
            Map.CancelButton.Click();
        }
    }
}
