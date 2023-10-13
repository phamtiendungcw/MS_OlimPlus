using OlimPlus.Domain.Entity.Common;
using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class ProductImage : BaseEntity
    {
        public Blob Image { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
