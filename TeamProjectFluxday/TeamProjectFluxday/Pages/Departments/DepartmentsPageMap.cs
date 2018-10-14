using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPageMap : BasePageMap
    {
        public IWebElement DepartmentsTitle
        {
            get
            {
                return GetElement(By.CssSelector("#pane2>.pane2-meta> .title"));
            }
        }

        public IWebElement CreateDepartmentLink
        {
            get
            {
                return GetElement(By.CssSelector("a[href=\"/projects/new\"]"));
            }
        }

        //public IWebElement NewlyCreatedDepartment
        //{
        //    get
        //    {
        //        return GetElement(By.CssSelector("div.title>.main-title"));
        //    }
        //}

        //public IWebElement SettingsIcon
        //{
        //    get
        //    {
        //        return GetElement(By.CssSelector("div.icon.settings-link"));
        //    }
        //}

        //public IWebElement DeleteLink
        //{
        //    get
        //    {
        //        return GetElement(By.CssSelector("#drop1 li:nth-child(2)>a"));
        //    }
        //}
    }
}
