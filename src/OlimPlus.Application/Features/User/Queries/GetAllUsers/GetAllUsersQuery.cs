using MediatR;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<UserDto>>
    {
    }
}