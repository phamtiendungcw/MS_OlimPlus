using OlimPlus.Domain.Entity.Common;
using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class CategoryV1 : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Blob ImagePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public IReadOnlyList<ProductV1> Products { get; set; }
    }
}