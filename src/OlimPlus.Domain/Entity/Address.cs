using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Address : BaseEntity
    {
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; } = String.Empty;
        public string Address2 { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Province { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public bool IsMain { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }
    }
}