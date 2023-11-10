using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Manufacturer;

namespace OlimPlus.Application.Features.Manufacturer.Queries.GetAllManufacturers
{
    public class GetAllManufacturersQueryHandler : IRequestHandler<GetAllManufacturersQuery, List<ManufacturerDto>>
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public GetAllManufacturersQueryHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }

        public async Task<List<ManufacturerDto>> Handle(GetAllManufacturersQuery request,
            CancellationToken cancellationToken)
        {
            var manufacturers = await _manufacturerRepository.GetAllAsync();
            var data = _mapper.Map<List<ManufacturerDto>>(manufacturers);

            return data;
        }
    }
}