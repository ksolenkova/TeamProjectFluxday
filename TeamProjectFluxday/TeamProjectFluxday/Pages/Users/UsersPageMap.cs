using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Users
{
   public class UsersPageMap : BasePageMap
    {
        public IWebElement AddUser
        {
            get
            {
                return GetElement(By.CssSelector("a[href=\"/users/new\"]"));
            }
        }

        public IWebElement UserNameField
        {
            get
            {
                return GetElement(By.CssSelector("#user_name"));
            }
        }

        public IWebElement NickNameField
        {
            get
            {
                return GetElement(By.CssSelector("#user_nickname"));
            }
        }

        public IWebElement EmailField
        {
            get
            {
                return GetElement(By.CssSelector("#user_email"));
            }
        }

        public IWebElement EmployeeCodeField
        {
            get
            {
                return GetElement(By.CssSelector("#user_employee_code"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return GetElement(By.CssSelector("#user_password"));
            }
        }

        public IWebElement ConfirmPasswordField
        {
            get
            {
                return GetElement(By.CssSelector("#user_password_confirmation"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }

        public IWebElement NewUser
        {
            get
            {
                return GetElement(By.LinkText("TestEmployee"));
            }
        }

        public IWebElement SettingsButton
        {
            get
            {
                return GetElement(By.CssSelector(".icon.settings-link"));
            }
        }
        
        public IWebElement DeleteOption
        {
            get
            {
                return GetElement(By.CssSelector("#drop1>li+li"));
            }
        }
    }
}
