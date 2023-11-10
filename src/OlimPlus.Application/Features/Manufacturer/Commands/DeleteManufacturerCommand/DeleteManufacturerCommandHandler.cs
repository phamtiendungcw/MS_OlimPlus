using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Manufacturer.Commands.DeleteManufacturerCommand
{
    public class DeleteManufacturerCommandHandler : IRequestHandler<DeleteManufacturerCommand, Unit>
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public DeleteManufacturerCommandHandler(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public async Task<Unit> Handle(DeleteManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturerToDelete = await _manufacturerRepository.GetByIdAsync(request.Id);

            if (manufacturerToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.Manufacturer), request.Id);

            await _manufacturerRepository.DeleteAsync(manufacturerToDelete);

            return Unit.Value;
        }
    }
}