using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Parts
{
    public class NavigationPanelMap : BasePageMap
    {
        public IWebElement MyTasksLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.side-nav:nth-child(2) > li:nth-child(2) > a:nth-child(1)"));
            }
        }

        public IWebElement DepartmentsLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.side-nav:nth-child(2) > li:nth-child(3) > a:nth-child(1)"));
            }
        }

        public IWebElement TeamUserLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.side-nav:nth-child(2) > li:nth-child(4) > a:nth-child(1)"));
            }
        }

        public IWebElement UsersLink
        {
            get
            {
                return GetElement(By.XPath(@"/html/body/div[2]/div[1]/ul[2]/li[5]/a"));
            }
        }

        public IWebElement UserLink
        {
            get
            {
                return GetElement(By.CssSelector("ul.user-links.side-nav.sidebar-links >li:first-child >a"));
            }
        }

        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.CssSelector(".user-links > li:nth-child(2) > a:nth-child(1)"));
            }
        }
    }
}
