using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class PaymentV1 : BaseEntity
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }

        public UserV1 User { get; set; }
        public OrderV1 Order { get; set; }
    }
}