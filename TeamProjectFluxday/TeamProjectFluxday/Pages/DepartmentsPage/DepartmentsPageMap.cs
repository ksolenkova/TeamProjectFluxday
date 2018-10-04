using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace SeleniumWebDriver.Pages.DepartmentsPage
{
    public class DepartmentsPageMap : BasePageMap
    {
        public IWebElement CreateDepartmentLink
        {
            get
            {
                return GetElement(By.CssSelector("a[href=\"/projects/new\"]"));
            }
        }

        public IWebElement TitleField
        {
            get
            {
                return GetElement(By.CssSelector("#project_name"));
            }
        }

        public IWebElement CodeDepartment
        {
            get
            {
                return GetElement(By.CssSelector("#project_code"));
            }
        }

        public IWebElement Url
        {
            get
            {
                return GetElement(By.CssSelector("#project_website"));
            }
        }

        public IWebElement Description
        {
            get
            {
                return GetElement(By.CssSelector("#project_description"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.CssSelector(".button.alert.right"));
            }
        }

        public IWebElement NewlyCreatedDepartment
        {
            get
            {
                return GetElement(By.CssSelector("div.title>.main-title"));
            }
        }

        public IWebElement SettingsIcon
        {
            get
            {
                return GetElement(By.CssSelector("div.icon.settings-link"));
            }
        }

        public IWebElement DeleteLink
        {
            get
            {
                return GetElement(By.CssSelector("#drop1 li:nth-child(2)>a"));
            }
        }
    }
}
