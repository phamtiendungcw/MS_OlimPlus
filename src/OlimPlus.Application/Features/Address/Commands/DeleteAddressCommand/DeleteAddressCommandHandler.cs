using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Address.Commands.DeleteAddressCommand
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;

        public DeleteAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToDelete = await _addressRepository.GetByIdAsync(request.Id);

            if (addressToDelete == null)
                throw new NotFoundException(nameof(Domain.Entity.Address), request.Id);

            await _addressRepository.DeleteAsync(addressToDelete);

            return Unit.Value;
        }
    }
}