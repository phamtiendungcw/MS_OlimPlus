using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class RoleV1 : BaseEntity
    {
        public string Name { get; set; }
        public string Privileges { get; set; }
    }
}
