using System.Collections.Generic;
using TeamProjectFluxday.Data.Models;

namespace TeamProjectFluxday.Data
{
    public static class TestData
    {
        private static List<User> defaultUsersList = new List<User>()
        {
            AdminUser,
            TeamLeadUser,
            Employee1,
            Employee2
        };

        private static List<string> defaultTeamsList = new List<string>()
        {
            "DevOps",
            "Fedena Development",
            "Support",
            "Testing",
            "UI/UX Design",
            "Uzity Development",
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

        public static List<User> DefaultUsersList
        {
            get
            {
                return defaultUsersList;

            }
        }

        public static Dictionary<string, string> TeamIndexes
        {
            get
            {
                return teamIndexes;

            }
        }

        public static List<string> DefaultTeamsList
        {
            get
            {
                return defaultTeamsList;

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

        public static Task Task
        {
            get
            {
                return new Task("Test Title", "Test Description");
            }
        }

        public static User Employee1
        {
            get
            {
                return new User("emp1@fluxday.io", "password", "Employee 1");
            }
        }

        public static Task Subtask
        {
            get
            {
                return new Task("Subtask Test Title", "Subtask Test Description");
            }
        }
        public static User Employee2
        {
            get
            {
                return new User("emp2@fluxday.io", "password", "Employee 2");
            }
        }
    }
}
