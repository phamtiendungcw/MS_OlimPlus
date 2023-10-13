using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public int AddressId { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}