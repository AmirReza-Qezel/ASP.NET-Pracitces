namespace EntityFrameworkPracticing.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsRemoved { get; set; } = false;
        public int GuyId { get; set; }
        public Guy Guy { get; set; }
    }
}
