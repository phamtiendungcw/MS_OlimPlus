namespace OlimPlus.Domain.Entity
{
    public class CustomerV1
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<AddressV1> Addresses { get; set; }
    }
}