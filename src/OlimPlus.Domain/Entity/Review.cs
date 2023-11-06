using OlimPlus.Domain.Entity.Common;

namespace OlimPlus.Domain.Entity
{
    public class Review : BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}