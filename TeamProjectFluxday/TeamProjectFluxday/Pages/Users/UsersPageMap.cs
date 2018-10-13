using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class UsersPageMap : BasePageMap
    {
        public IWebElement UsersTitle
        {
            get
            {
                return GetElement(By.CssSelector("div.title"));
            }
        }

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
    }
}
