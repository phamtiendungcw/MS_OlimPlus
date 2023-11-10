using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Product.Commands.CreateProductAttributeCommand
{
    public class CreateProductAttributeCommandHandler : IRequestHandler<CreateProductAttributeCommand, int>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IMapper _mapper;

        public CreateProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository,
            IMapper mapper)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            var productAttributeToCreate = _mapper.Map<Domain.Entity.ProductAttribute>(request);
            await _productAttributeRepository.CreateAsync(productAttributeToCreate);

            return productAttributeToCreate.Id;
        }
    }
}