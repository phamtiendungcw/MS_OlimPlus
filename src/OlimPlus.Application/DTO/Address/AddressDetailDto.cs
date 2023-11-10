using OlimPlus.Application.DTO.Customer;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.DTO.Address
{
    public class AddressDetailDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; } = String.Empty;
        public string Address2 { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Province { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public bool IsMain { get; set; }
        public CustomerDto? Customer { get; set; }
        public UserDto? User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}