namespace OlimPlus.Domain.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}