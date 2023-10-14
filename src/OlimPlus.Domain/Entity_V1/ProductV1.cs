using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class ProductV1 : BaseEntity
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

        public CategoryV1 Category { get; set; }
        public BrandV1 BrandV1 { get; set; }

        public ICollection<ProductImageV1> ProductImages { get; set; }
        public IReadOnlyList<CartItemV1> CartItems { get; set; }
        public IReadOnlyList<OrderV1> Orders { get; set; }
    }
}