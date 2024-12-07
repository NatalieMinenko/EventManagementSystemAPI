using AutoMapper;
using EventManagementSystem.BLL.Exceptions;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Mappings;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace EventManagementSystem.BLL;

public class EventsServices : IEventsServices
{
    private readonly EventRepository _eventRepository;

    private readonly IMapper _mapper;

    public EventsServices(IEventRepository repository)
    {
        _eventRepository = new();

        var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new UserMapperProfile());
            });
        _mapper = new Mapper(config);
    }
    public void AddEvent(EventModel events)
    {
        var eventId = _mapper.Map<EventDto>(events);

        if (events == null)

            throw new EntityNotFoundException($"Event with {eventId} not found");

        _eventRepository.AddEvent(eventId);
    }
    public List<EventModel> GetAllEvents()
    {
        var eventDto = _eventRepository.GetAllEvents();

        var events = _mapper.Map<List<EventModel>>(eventDto);

        return events;
    }
    public EventModel GetEventById(Guid eventId)
    {
        var eventDto = _eventRepository.GetEventById(eventId);

        if (eventDto == null)

            throw new EntityNotFoundException($"Event with id{eventId} was not found");

        var result = _mapper.Map<EventModel>(eventDto);

        return result;
    }
    public void UpdateEvent(Guid id, UpdateEventModel events)
    {
        var existingEvent = _eventRepository.GetEventById(id);

        if (existingEvent == null)

            throw new EntityNotFoundException($"Event with id {id} was not found");

        var updatedEvent = _mapper.Map(events, existingEvent);

        _eventRepository.UpdateEvent(existingEvent, updatedEvent);
    }
    public void DeleteEvent(Guid eventId)
    {
        var eventDto = _eventRepository.GetEventById(eventId);

        var events = _mapper.Map<EventModel>(eventDto);

        if (eventDto == null)

            throw new EntityNotFoundException($"Event with {eventId} was not found");

        _eventRepository.DeleteEvent(eventDto);
    }
    public void DeactivateEvent(Guid eventId)
    {
        var eventDto = _eventRepository.GetEventById(eventId);

        if (eventDto == null)

            throw new EntityNotFoundException($"Event with id {eventId} was not found");

        _eventRepository.DeactivateEvent(eventDto);
    }
    public IEnumerable<EventModel> GetUsersByEventId(Guid eventId)
    {
        var users = _eventRepository.GetUsersByEventId(eventId);

        if (users == null)

            throw new EntityNotFoundException($"Users with id{eventId} was not found");

        var result = _mapper.Map<IEnumerable<EventModel>>(users);

        return result;
    }
}
