using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Product.Commands.DeleteProductCommand
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            // Retrieve domain entity object
            var productToDelete = await _productRepository.GetByIdAsync(request.Id);

            // Verify that record exists
            if (productToDelete == null)
                throw new NotFoundException(nameof(Domain.Entity.Product), request.Id);

            // Remove from database
            await _productRepository.DeleteAsync(productToDelete);

            // Return record id
            return Unit.Value;
        }
    }
}