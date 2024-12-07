using EventManagementSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Interfaces;

public interface IEventsServices
{
    void AddEvent(EventModel events);
    List<EventModel> GetAllEvents();
    EventModel GetEventById(Guid eventId);
    void UpdateEvent(Guid id, UpdateEventModel events);
    void DeleteEvent(Guid eventId);
    void DeactivateEvent(Guid eventId);
    IEnumerable<EventModel> GetUsersByEventId(Guid eventId);
}
