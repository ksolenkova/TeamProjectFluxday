using SeleniumWebDriver.Data.Models;
using System.Collections.Generic;

namespace SeleniumWebDriver.Data
{
    public static class TestData
    {
        public static User AdminUser
        {
            get
            {
                return new User("admin@fluxday.io", "password", "Admin User");
            }
        }

        public static User TeamLeadUser
        {
            get
            {
                return new User("lead@fluxday.io", "password", "Team Lead");
            }
        }
        public static Team DevOps
        {
            get
            {
                return new Team("DevOps", "01");
            }
        }
    }
}
