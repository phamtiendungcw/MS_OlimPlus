﻿using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Order.Commands.CreateOrderCommand
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToCreate = _mapper.Map<Domain.Entity.Order>(request);
            await _orderRepository.CreateAsync(orderToCreate);

            return orderToCreate.Id;
        }
    }
}