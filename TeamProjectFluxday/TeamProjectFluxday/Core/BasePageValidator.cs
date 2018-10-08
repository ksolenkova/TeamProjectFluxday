using SeleniumWebDriver.Core;

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
    }
}
