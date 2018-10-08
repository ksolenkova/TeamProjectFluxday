using SeleniumWebDriver.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
