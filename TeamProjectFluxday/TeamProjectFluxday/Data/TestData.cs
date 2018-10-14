using System.Collections.Generic;
using TeamProjectFluxday.Data.Models;

namespace TeamProjectFluxday.Data
{
    public static class TestData
    {
        private static List<User> usersList = new List<User>()
        {
            AdminUser,
            TeamLeadUser
        };

        private static Dictionary<string, string> teamIndexes = new Dictionary<string, string>()
        {
            { "DevOps", "11"},
            { "Fedena Development", "1"},
            { "Support", "4"},
            { "Testing", "2"},
            { "UI/UX Design", "10"},
            { "Uzity Development", "3"}
        };

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

        public static List<User> UserList
        {
            get
            {
                return usersList;

            }
        }

        public static Dictionary<string, string> TeamIndexes
        {
            get
            {
                return teamIndexes;

            }
        }

        public static Team DevOps
        {
            get
            {
                return new Team("DevOps", "devops", "Engineering");
            }
        }

        public static Team UzityDevelopment
        {
            get
            {
                return new Team("Uzity Development", "uzitydev", "Engineering");
            }
        }

        public static Team Support
        {
            get
            {
                return new Team("Support", "sup", "Engineering");
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
