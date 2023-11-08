using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class ProductAttribute : BaseEntity
    {
        public int ProductId { get; set; }
        public string AttributeName { get; set; } = String.Empty;
        public string AttributeValue { get; set; } = String.Empty;
        public Product Product { get; set; }
    }
}