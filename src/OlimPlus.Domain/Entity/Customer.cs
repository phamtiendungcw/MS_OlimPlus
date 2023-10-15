using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Customer : BaseEntity
    {
        public ICollection<Address> Addresses { get; set; }
    }
}