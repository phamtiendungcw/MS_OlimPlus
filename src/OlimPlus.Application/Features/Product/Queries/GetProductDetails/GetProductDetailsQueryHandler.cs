using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Product;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Product.Queries.GetProductDetails
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, ProductDetailDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDetailDto> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            // Verify that record exists
            if (product == null)
                throw new NotFoundException(nameof(Domain.Entity.Product), request.Id);

            var data = _mapper.Map<ProductDetailDto>(product);

            return data;
        }
    }
}