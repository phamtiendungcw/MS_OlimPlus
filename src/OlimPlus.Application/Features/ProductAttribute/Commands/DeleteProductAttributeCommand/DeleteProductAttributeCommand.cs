using MediatR;

namespace OlimPlus.Application.Features.ProductAttribute.Commands.DeleteProductAttributeCommand
{
    public class DeleteProductAttributeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}