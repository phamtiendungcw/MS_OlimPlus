using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.ProductAttribute.Commands.DeleteProductAttributeCommand
{
    public class DeleteProductAttributeCommandHandler : IRequestHandler<DeleteProductAttributeCommand, Unit>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;

        public DeleteProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository)
        {
            _productAttributeRepository = productAttributeRepository;
        }

        public async Task<Unit> Handle(DeleteProductAttributeCommand request, CancellationToken cancellationToken)
        {
            var productAttributeToDelete = await _productAttributeRepository.GetByIdAsync(request.Id);
            if (productAttributeToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.ProductAttribute), request.Id);
            await _productAttributeRepository.DeleteAsync(productAttributeToDelete);

            return Unit.Value;
        }
    }
}