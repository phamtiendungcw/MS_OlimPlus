using MediatR;

namespace OlimPlus.Application.Features.Category.Commands.CreateCategoryCommand
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string CategoryName { get; set; }
    }
}