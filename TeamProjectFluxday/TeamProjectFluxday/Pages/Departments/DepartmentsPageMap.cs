using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.Departments
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
                return GetElement(By.LinkText("Create department"));
            }
        }
    }
}
