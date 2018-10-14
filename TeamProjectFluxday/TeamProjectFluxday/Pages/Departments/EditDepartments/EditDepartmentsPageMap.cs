using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class EditDepartmentsPageMap : BasePageMap
    {
        public IWebElement TitleField
        {
            get
            {
                return GetElement(By.CssSelector("#project_name"));
            }
        }

        public IWebElement Save
        {
            get
            {
                return GetElement(By.CssSelector(".button.alert.right"));
            }
        }

        public IWebElement Cancel
        {
            get
            {
                return GetElement(By.CssSelector(".btn.cancel-btn"));
            }
        }
    }
}
