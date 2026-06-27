namespace CodeGenerationWithVisualStudio.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
