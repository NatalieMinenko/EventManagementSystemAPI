using AutoMapper;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.BLL.Mappings;
public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<UserModel, UserDto>();
        CreateMap<UserDto, UserModel>();
    }
}
