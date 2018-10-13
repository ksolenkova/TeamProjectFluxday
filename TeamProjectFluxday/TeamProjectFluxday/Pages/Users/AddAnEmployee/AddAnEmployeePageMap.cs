using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class AddAnEmployeePageMap : BasePageMap
    {
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
    }
}
