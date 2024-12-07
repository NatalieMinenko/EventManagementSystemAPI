using AutoMapper;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.BLL.Mappings;

public class EventMapperProfile : Profile
{
    public EventMapperProfile()
    {
        CreateMap<EventModel, EventDto>();
        CreateMap<EventDto, EventModel>();
    }
}
