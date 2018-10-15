namespace TeamProjectFluxday.Data.Models
{
    public class Team
    {
        public Team(string name, string code, string department)
        {
            this.Name = name;
            this.Code = code;
            this.Department = department;
        }

        public Team(string name, string code, string department, string description, User teamLead)
        {
            this.Name = name;
            this.Code = code;
            this.Department = department;
            this.Description = description;
            this.TeamLead = new User(teamLead.Email, teamLead.Name, teamLead.Password);
        }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }

        public User TeamLead { get; set; }
    }
}

