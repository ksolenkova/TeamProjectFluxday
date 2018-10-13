using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class UserDetailsPageMap : BasePageMap
    {
        public IWebElement SettingsButton
        {
            get
            {
                return GetElement(By.CssSelector(".icon.settings-link"));
            }
        }

        public IWebElement DeleteOption
        {
            get
            {
                return GetElement(By.CssSelector("#drop1>li+li"));
            }
        }
    }
}
