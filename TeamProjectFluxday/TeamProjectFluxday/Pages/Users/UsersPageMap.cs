using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
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
