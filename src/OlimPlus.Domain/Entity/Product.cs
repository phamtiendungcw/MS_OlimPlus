using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string SKU { get; set; }
        public string Slug { get; set; }
        public int InStock { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public IReadOnlyList<CartItem> CartItems { get; set; }
        public IReadOnlyList<Order> Orders { get; set; }
    }
}