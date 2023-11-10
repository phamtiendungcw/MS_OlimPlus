using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Product.Commands.UpdateProductAttributeCommand
{
    public class UpdateProductAttributeCommandHandler : IRequestHandler<UpdateProductAttributeCommand, Unit>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly IMapper _mapper;

        public UpdateProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository,
            IMapper mapper)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            var productAttributeToUpdate = _mapper.Map<Domain.Entity.ProductAttribute>(request);
            await _productAttributeRepository.UpdateAsync(productAttributeToUpdate);

            return Unit.Value;
        }
    }
}