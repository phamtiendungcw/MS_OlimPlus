namespace OlimPlus.Domain.Entity.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
    }
}