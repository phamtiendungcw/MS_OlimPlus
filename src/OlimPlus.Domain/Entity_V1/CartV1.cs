using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Cartv1 : BaseEntity
    {
        public int Id { get; set; }

        public IReadOnlyList<CartItemV1> CartItems { get; set; }
    }
}