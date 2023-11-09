using OlimPlus.Domain.Entity.Common;
using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class User : BaseEntity
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string DisplayName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public DateOnly? DOB { get; set; }
        public Blob Image { get; set; }
        public string? PhotoPath { get; set; } = String.Empty;
        public bool IsManager { get; set; }
        public Customer Customer { get; set; }
        public List<Address> Addresses { get; set; }
    }
}