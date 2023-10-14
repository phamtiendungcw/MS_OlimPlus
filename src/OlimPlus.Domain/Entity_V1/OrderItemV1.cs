using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class OrderItemV1 : BaseEntity
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public ProductV1 Product { get; set; }
        public OrderV1 Order { get; set; }
    }
}
