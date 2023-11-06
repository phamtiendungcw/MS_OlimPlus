namespace OlimPlus.Domain.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public bool IsMain { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }
    }
}