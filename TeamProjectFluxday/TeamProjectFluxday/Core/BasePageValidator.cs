using OpenQA.Selenium;
using TeamProjectFluxday.Parts;

namespace TeamProjectFluxday.Core
{
    public class BasePageValidator<TM> where TM : BasePageMap, new()
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        protected NavigationPanel NavigationPanel
        {
            get
            {
                return new NavigationPanel();
            }
        }

        //public bool ElementIsNotPresent(IWebElement element, By by)
        //{
        //    try
        //    {
        //        Driver.Browser.FindElement(by);
        //        return false;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return true;
        //    }
        //}
    }
}
