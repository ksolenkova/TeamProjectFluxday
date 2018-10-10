using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class CreateDepartmentsPageMap : BasePageMap
    {
        public IWebElement AddDepartmentTitle
        {
            get
            {
                return GetElement(By.CssSelector(""));
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
    }
}
