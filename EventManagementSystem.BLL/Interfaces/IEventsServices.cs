using EventManagementSystem.BLL.Models;

namespace EventManagementSystem.BLL.Interfaces;

public interface IEventsServices
{
    void AddEvent(CreateEventModel events);
    List<EventModel> GetAllEvents();
    EventModel GetEventById(Guid eventId);
    void UpdateEvent(Guid id, UpdateEventModel events);
    void DeleteEvent(Guid eventId);
    void DeactivateEvent(Guid eventId);
    IEnumerable<EventModel> GetUsersByEventId(Guid eventId);
}
