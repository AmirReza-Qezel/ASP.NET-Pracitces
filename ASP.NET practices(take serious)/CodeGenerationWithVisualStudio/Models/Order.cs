namespace CodeGenerationWithVisualStudio.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
