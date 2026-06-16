namespace EntityFrameworkPracticing.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsRemoved { get; set; } = false;
        public List<Order> Orders { get; set; }

    }
}
