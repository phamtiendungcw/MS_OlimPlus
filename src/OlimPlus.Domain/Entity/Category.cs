using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = String.Empty;
        public int ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}