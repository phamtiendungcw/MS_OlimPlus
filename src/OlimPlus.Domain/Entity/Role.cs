using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Privileges { get; set; }
    }
}
