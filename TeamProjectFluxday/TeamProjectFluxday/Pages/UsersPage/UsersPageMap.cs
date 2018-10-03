using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.UsersPage
{
   public class UsersPageMap : BasePageMap
    {
        public IWebElement AddUser
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"pane2\"]/div[2]/a"));
            }
        }

        public IWebElement UserNameField
        {
            get
            {
                return GetElement(By.Id("user_name"));
            }
        }

        public IWebElement NickNameField
        {
            get
            {
                return GetElement(By.Id("user_nickname"));
            }
        }

        public IWebElement EmailField
        {
            get
            {
                return GetElement(By.Id("user_email"));
            }
        }

        public IWebElement EmployeeCodeField
        {
            get
            {
                return GetElement(By.Id("user_employee_code"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return GetElement(By.Id("user_password"));
            }
        }

        public IWebElement ConfirmPasswordField
        {
            get
            {
                return GetElement(By.Id("user_password_confirmation"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"new_user\"]/div[3]/div[2]/input"));
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
                return GetElement(By.XPath("//*[@id=\"pane3\"]/div/div[1]/div[2]/a/div"));
            }
        }
        
        public IWebElement DeleteOption
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"drop1\"]/li[2]/a"));
            }
        }


    }
}
