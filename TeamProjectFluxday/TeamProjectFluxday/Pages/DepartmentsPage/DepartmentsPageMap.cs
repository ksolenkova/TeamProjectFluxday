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
                return GetElement(By.Id("project_name"));
            }
        }

        public IWebElement CodeDepartment
        {
            get
            {
                return GetElement(By.Id("project_code"));
            }
        }

        public IWebElement Url
        {
            get
            {
                return GetElement(By.Id("project_website"));
            }
        }

        public IWebElement Description
        {
            get
            {
                return GetElement(By.Id("project_description"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"new_project\"]/div[3]/div[2]/input"));
            }
        }

        public IWebElement NewlyCreatedDepartment
        {
            get
            {
                return GetElement(By.XPath("//*[@id=\"pane3\"]/div/div[1]/div[3]/div[1]"));
            }
        }

    }
}
