using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Manufacturer;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Manufacturer.Queries.GetManufacturerDetails
{
    public class
        GetManufacturerDetailsQueryHandler : IRequestHandler<GetManufacturerDetailsQuery, ManufacturerDetailDto>
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public GetManufacturerDetailsQueryHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }

        public async Task<ManufacturerDetailDto> Handle(GetManufacturerDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var manufacturer = await _manufacturerRepository.GetByIdAsync(request.Id);

            if (manufacturer == null)
                throw new NotFoundException(nameof(Domain.Entity.Manufacturer), request.Id);

            var data = _mapper.Map<ManufacturerDetailDto>(manufacturer);

            return data;
        }
    }
}