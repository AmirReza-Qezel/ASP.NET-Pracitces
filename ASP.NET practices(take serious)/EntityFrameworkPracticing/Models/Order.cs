namespace EntityFrameworkPracticing.Models
{
    public class Order
    {

        public int Id { get; set; }
        public string Product { get; set; }

        public int CustomerId { get; set; }      // foreign key
        public Customer Customer { get; set; }
    }
}
