using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class CartItemV1 : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Column { get; set; }

        public ProductV1 Product { get; set; }
        public UserV1 User { get; set; }
    }
}
