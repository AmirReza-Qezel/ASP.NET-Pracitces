namespace EntityFrameworkPracticing.Models
{
    public class Guy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public bool IsRemoved { get; set; } = false;
        public virtual Passport Passport { get; set; }
    }
}
