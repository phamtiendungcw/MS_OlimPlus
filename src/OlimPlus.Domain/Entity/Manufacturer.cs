using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Manufacturer : BaseEntity
    {
        public string ManufacturerName { get; set; }
        public List<Product> Products { get; set; }
    }
}
