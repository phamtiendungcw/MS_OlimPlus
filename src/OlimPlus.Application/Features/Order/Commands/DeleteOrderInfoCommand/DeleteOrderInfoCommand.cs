using MediatR;

namespace OlimPlus.Application.Features.Order.Commands.DeleteOrderInfoCommand
{
    public class DeleteOrderInfoCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}