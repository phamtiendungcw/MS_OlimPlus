using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using Entity = OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Product.Commands.UpdateProductCommand
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            // Validate data

            // Convert to domain entity object
            var productToUpdate = _mapper.Map<Entity.Product>(request);

            // Add to database
            await _productRepository.UpdateAsync(productToUpdate);

            return Unit.Value;
        }
    }
}