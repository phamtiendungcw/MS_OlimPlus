using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Manufacturer.Commands.CreateManufacturerCommand
{
    public class CreateManufacturerCommandHandler : IRequestHandler<CreateManufacturerCommand, int>
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public CreateManufacturerCommandHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturerToCreate = _mapper.Map<Domain.Entity.Manufacturer>(request);
            await _manufacturerRepository.CreateAsync(manufacturerToCreate);

            return manufacturerToCreate.Id;
        }
    }
}