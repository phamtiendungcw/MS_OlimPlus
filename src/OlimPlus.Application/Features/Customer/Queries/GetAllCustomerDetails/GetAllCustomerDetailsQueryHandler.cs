using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Customer;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Customer.Queries.GetAllCustomerDetails
{
    public class GetAllCustomerDetailsQueryHandler : IRequestHandler<GetAllCustomerDetailsQuery, CustomerDetailDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetAllCustomerDetailsQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDetailDto> Handle(GetAllCustomerDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);

            if (customer == null)
                throw new NotFoundException(nameof(Domain.Entity.Customer), request.Id);

            var data = _mapper.Map<CustomerDetailDto>(customer);

            return data;
        }
    }
}