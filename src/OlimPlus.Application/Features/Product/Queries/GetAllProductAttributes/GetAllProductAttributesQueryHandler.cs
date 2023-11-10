using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.Product.Queries.GetAllProductAttributes
{
    public class
        GetAllProductAttributesQueryHandler : IRequestHandler<GetAllProductAttributesQuery, List<ProductAttributeDto>>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IMapper _mapper;

        public GetAllProductAttributesQueryHandler(IProductAttributeRepository productAttributeRepository,
            IMapper mapper)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductAttributeDto>> Handle(GetAllProductAttributesQuery request,
            CancellationToken cancellationToken)
        {
            var productAttributes = await _productAttributeRepository.GetAllAsync();
            var data = _mapper.Map<List<ProductAttributeDto>>(productAttributes);

            return data;
        }
    }
}