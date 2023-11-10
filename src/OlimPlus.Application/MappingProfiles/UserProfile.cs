using AutoMapper;
using OlimPlus.Application.DTO.User;
using OlimPlus.Application.Features.User.Commands.CreateUserCommand;
using OlimPlus.Application.Features.User.Commands.UpdateUserCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<User, UserDetailDto>();
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
        }
    }
}