using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.User.Commands.UpdateUserCommand
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userToUpdate = _mapper.Map<Domain.Entity.User>(request);
            await _userRepository.UpdateAsync(userToUpdate);

            return Unit.Value;
        }
    }
}