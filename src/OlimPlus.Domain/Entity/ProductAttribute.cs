using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class ProductAttribute : BaseEntity
    {
        public int ProductId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public Product Product { get; set; }
    }
}
