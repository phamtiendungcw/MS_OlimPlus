using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } = String.Empty;
        public string PhoneNumber { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}