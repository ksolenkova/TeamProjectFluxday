using OpenQA.Selenium;
using System.Collections.Generic;
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

        public IReadOnlyCollection<IWebElement> ListOfUsers
        {
            get
            {
                return GetElements(By.CssSelector(".user-name"));
            }
        }
    }
}
