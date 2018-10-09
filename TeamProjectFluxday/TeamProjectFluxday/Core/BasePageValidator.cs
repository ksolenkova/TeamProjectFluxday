using SeleniumWebDriver.Core;
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
    }
}
