using TeamProjectFluxday.Data.Models;

namespace TeamProjectFluxday.Data.Models
{
    public class Team
    {
        public Team(string name, string code)
        {
            this.Name = name;
            this.Code = code;
        }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Department { get; set; }

        public User TeamLead { get; set; }
    }
}

