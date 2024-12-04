using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.DAL.Repositories;
public class EventRepository : IEventRepository
{
    private Context _context;

    public EventRepository()
    {
        _context = new Context();
    }
    public void AddEvent(EventDto events)
    {
        _context.Events.Add(events);
        _context.SaveChanges();
    }
    public List<EventDto> GetAllEvents()
    {
        var events = _context.Events.Where(e => e.IsDeactivated == false).ToList();
        return events;
    }
    public EventDto? GetEventById(Guid id)
    {
        var events = _context.Events.Where(e => e.Id == id).FirstOrDefault();
        return events;
    }
    public void UpdateEvent(EventDto events, EventDto eventUpdate)
    {
        events.Name = eventUpdate.Name;
        events.Description = eventUpdate.Description;
        events.AdressOfEvent = eventUpdate.AdressOfEvent;
        events.DateTime = eventUpdate.DateTime;
        events.MaxParticipants = eventUpdate.MaxParticipants;
        _context.SaveChanges();
    }
    public void DeleteEvent(EventDto events)
    {
        _context.Events.Remove(events);
        _context.SaveChanges();
    }
    public void DeactivateEvent(EventDto events)
    {
        events.IsDeactivated = true;
        _context.SaveChanges();
    }
    public IEnumerable<UserDto> GetUsersByEventId(Guid eventId)
    {
        var user = _context.Users.Include(u => u.Events).Where(u => u.Id == eventId).FirstOrDefault();
        return _context.Users.ToList();
    }
}