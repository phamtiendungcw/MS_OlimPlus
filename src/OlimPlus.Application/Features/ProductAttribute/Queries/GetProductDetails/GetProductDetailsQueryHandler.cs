using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Product;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.ProductAttribute.Queries.GetProductDetails
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, ProductAttributeDetailDto>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IMapper _mapper;

        public GetProductDetailsQueryHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
        }

        public async Task<ProductAttributeDetailDto> Handle(GetProductDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var productAttribute = await _productAttributeRepository.GetByIdAsync(request.Id);

            if (productAttribute is null)
                throw new NotFoundException(nameof(Domain.Entity.ProductAttribute), request.Id);

            var data = _mapper.Map<ProductAttributeDetailDto>(productAttribute);

            return data;
        }
    }
}