﻿using MediatR;

namespace OlimPlus.Application.Features.Address.Commands.UpdateAddressCommand
{
    public class UpdateAddressCommand : IRequest<Unit>
    {
        public string Address1 { get; set; } = String.Empty;
        public string Address2 { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Province { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public bool IsMain { get; set; }
    }
}