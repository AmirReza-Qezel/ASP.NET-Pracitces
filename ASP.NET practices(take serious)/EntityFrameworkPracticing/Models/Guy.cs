namespace EntityFrameworkPracticing.Models
{
    public class Guy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; } = false;
        public Guy( string name , string description)
        {
            Name = name;
            Description = description;
        }
    }
}
