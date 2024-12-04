using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL.Repositories.Interfaces;
public interface IEventRepository
{
    public void AddEvent(EventDto events);
    public List<EventDto> GetAllEvents();
    public EventDto? GetEventById(Guid id);
    public void UpdateEvent(EventDto events, EventDto eventUpdate);
    public void DeleteEvent(EventDto events);
    public void DeactivateEvent(EventDto events);
    public IEnumerable<UserDto> GetUsersByEventId(Guid eventId);
}

