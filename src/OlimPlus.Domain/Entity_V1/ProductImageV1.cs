using OlimPlus.Domain.Entity.Common;
using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class ProductImageV1 : BaseEntity
    {
        public Blob Image { get; set; }
        public int ProductId { get; set; }

        public ProductV1 Product { get; set; }
    }
}
