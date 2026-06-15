namespace EntityFrameworkPracticing.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsRemoved { get; set; } = false;
        public Passport(string code)
        {
            Code = code;    
        }
    }
}
