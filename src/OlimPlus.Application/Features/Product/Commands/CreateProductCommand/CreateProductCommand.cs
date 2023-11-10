using MediatR;

namespace OlimPlus.Application.Features.Product.Commands.CreateProductCommand
{
    public class CreateProductCommand : IRequest<int>
    {
        public string ProductName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
    }
}