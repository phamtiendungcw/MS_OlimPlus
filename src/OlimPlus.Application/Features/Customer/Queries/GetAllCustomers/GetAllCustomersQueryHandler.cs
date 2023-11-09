using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Customer;

namespace OlimPlus.Application.Features.Customer.Queries.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerRepository.GetAllAsync();
            var data = _mapper.Map<List<CustomerDto>>(customers);

            return data;
        }
    }
}