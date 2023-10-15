using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using Entity = OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Product.Commands.CreateProductCommand
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var productToCreate = _mapper.Map<Entity.Product>(request);

            await _productRepository.CreateAsync(productToCreate);

            return productToCreate.Id;
        }
    }
}