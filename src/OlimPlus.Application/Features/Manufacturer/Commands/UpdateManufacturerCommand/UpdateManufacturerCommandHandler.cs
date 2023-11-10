using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Manufacturer.Commands.UpdateManufacturerCommand
{
    public class UpdateManufacturerCommandHandler : IRequestHandler<UpdateManufacturerCommand, Unit>
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public UpdateManufacturerCommandHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturerToUpdate = _mapper.Map<Domain.Entity.Manufacturer>(request);
            await _manufacturerRepository.UpdateAsync(manufacturerToUpdate);

            return Unit.Value;
        }
    }
}