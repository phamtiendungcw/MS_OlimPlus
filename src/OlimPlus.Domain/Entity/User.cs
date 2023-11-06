using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? DisplayName { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DOB { get; set; }
        public Blob Image { get; set; }
        public string PhotoPath { get; set; }
        public bool IsManager { get; set; }
        public Customer Customer { get; set; }
        public List<Address> Addresses { get; set; }
    }
}