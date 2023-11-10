using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Address;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Address.Queries.GetAddressDetails
{
    public class GetAddressDetailsQueryHandler : IRequestHandler<GetAddressDetailsQuery, AddressDetailDto>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressDetailsQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<AddressDetailDto> Handle(GetAddressDetailsQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetByIdAsync(request.Id);

            if (address == null)
                throw new NotFoundException(nameof(Domain.Entity.Address), request.Id);

            var data = _mapper.Map<AddressDetailDto>(address);

            return data;
        }
    }
}