namespace TeamProjectFluxday.Data.Models
{
    public class Task
    {
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}

