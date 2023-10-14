using OlimPlus.Domain.Entity.Common;
using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Discription { get; set; }
        public Blob Picture { get; set; }
    }
}