using System.Reflection.Metadata;

namespace OlimPlus.Domain.Entity
{
    public class UserV1
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenIdentityCard { get; set; }
        public DateOnly DOB { get; set; }
        public Blob Image { get; set; }
        public string Status { get; set; }

        public ICollection<AddressV1> Addresses { get; set; }
    }
}