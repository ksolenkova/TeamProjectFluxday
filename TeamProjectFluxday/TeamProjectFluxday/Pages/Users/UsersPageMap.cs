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
                return GetElement(By.CssSelector(".pane2-meta>.title"));
            }
        }

        public IWebElement AddUser
        {
            get
            {
                return GetElement(By.CssSelector("a[href=\"/users/new\"]"));
            }
        }

        public IWebElement TeamLeadUser
        {
            get
            {
                return GetElement(By.LinkText("Team Lead"));
            }
        }

        public IWebElement NewUser
        {
            get
            {
                return Browser.FindElement(By.PartialLinkText("TestEmployee"));
            }
        }

        public IReadOnlyCollection<IWebElement> ListOfUsers
        {
            get
            {
                return GetElements(By.CssSelector(".user-name"));
            }
        }

        public bool NewEmployeeNotVisible
        {
            get
            {
                return ElementIsNotPresent(By.LinkText("TestEmployee"));
            }
        }
    }
}
