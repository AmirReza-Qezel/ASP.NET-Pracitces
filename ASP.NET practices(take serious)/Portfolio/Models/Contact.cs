namespace Portfolio.Models
{
    public class Contact
    {
        public Contact(string email,string phonenumber,string github)
        { 
            Email = email;
            PhoneNumber = phonenumber;
            Github = github;
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Github { get; set; }
    }
}
