using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class CartItem : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Column { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
