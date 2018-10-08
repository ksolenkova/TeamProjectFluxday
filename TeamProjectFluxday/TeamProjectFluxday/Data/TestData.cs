using SeleniumWebDriver.Data.Models;
using TeamProjectFluxday.Data.Models;

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

        public static Task NewTask
        {
            get
            {
                return new Task("Test Title", "Test Description");
            }
        }
    }
}
