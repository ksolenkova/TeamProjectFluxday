using OpenQA.Selenium;
using System.Collections.Generic;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPageMap : BasePageMap
    {
        public IWebElement DepartmentsTitle
        {
            get
            {
                return GetElement(By.CssSelector("#pane2>.pane2-meta>.title"));
            }
        }

        public IWebElement CreateDepartmentLink
        {
            get
            {
                return GetElement(By.LinkText("Create department"));
            }
        }

        public IWebElement MainTitleOfDepartment
        {
            get
            {
                return GetElement(By.CssSelector("div .title > .main-title"));
            }
        }

        public IWebElement SettingsIcon
        {
            get
            {
                return GetElement(By.CssSelector("div.icon.settings-link"));
            }
        }

        public IWebElement EditLink
        {
            get
            {
                return GetElement(By.CssSelector("#drop1>li:first-child >a"));
            }
        }

        public IWebElement DeleteLink
        {
            get
            {
                return GetElement(By.CssSelector("#drop1 li:nth-child(2)>a"));
            }
        }

        public IReadOnlyCollection<IWebElement> ListOfDepartments
        {
            get
            {
                return GetElements(By.CssSelector(".cols > .title"));
            }
        }

        public IWebElement FinanceLink
        {
            get
            {
                return GetElement(By.CssSelector("a[href='/projects/3']>div>div:nth-child(2)>.title"));
            }
        }

        public bool SettingsNotVisible
        {
            get
            {
                return ElementIsNotPresent(By.CssSelector("div.icon.settings-link"));
            }
        }
    }
}
