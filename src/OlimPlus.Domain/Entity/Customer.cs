using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string FullName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public List<User> Users { get; set; }
        public List<Address> Addresses { get; set; }
    }
}