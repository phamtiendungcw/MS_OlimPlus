using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class OrderV1 : BaseEntity
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public UserV1 User { get; set; }
        public AddressV1 Address { get; set; }

        public ICollection<PaymentV1> Payments { get; set; }
        public ICollection<OrderItemV1> OrderItems { get; set; }
    }
}