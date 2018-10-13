namespace TeamProjectFluxday.Data.Models
{
    public class Department
    {
        public Department(string title, string code, string url, string description)
        {
            Title = title;
            Code = code;
            Url = url;
            Description = description;
        }

        public string Title { get; set; }

        public string Code { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }
    }
}
