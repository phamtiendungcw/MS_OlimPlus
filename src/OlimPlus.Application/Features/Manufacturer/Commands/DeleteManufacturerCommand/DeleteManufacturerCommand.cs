using MediatR;

namespace OlimPlus.Application.Features.Manufacturer.Commands.DeleteManufacturerCommand
{
    public class DeleteManufacturerCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}