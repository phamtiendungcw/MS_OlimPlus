using MediatR;

namespace OlimPlus.Application.Features.Product.Commands.UpdateProductCommand
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
    }
}