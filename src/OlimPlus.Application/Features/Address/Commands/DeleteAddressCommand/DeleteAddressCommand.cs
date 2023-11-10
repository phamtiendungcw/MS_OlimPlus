using MediatR;

namespace OlimPlus.Application.Features.Address.Commands.DeleteAddressCommand
{
    public class DeleteAddressCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}