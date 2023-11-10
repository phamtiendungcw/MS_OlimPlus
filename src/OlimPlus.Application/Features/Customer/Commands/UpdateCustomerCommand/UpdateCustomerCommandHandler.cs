using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Customer.Commands.UpdateCustomerCommand
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerToUpdate = _mapper.Map<Domain.Entity.Customer>(request);
            await _customerRepository.UpdateAsync(customerToUpdate);

            return Unit.Value;
        }
    }
}