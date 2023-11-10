using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Address.Commands.UpdateAddressCommand
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public UpdateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToUpdate = _mapper.Map<Domain.Entity.Address>(request);
            await _addressRepository.UpdateAsync(addressToUpdate);

            return Unit.Value;
        }
    }
}