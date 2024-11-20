using EventManagementSystemAPI.Models.Requests;
using EventManagementSystemAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystemAPI.Controllers;

[Route("api/events")]
[ApiController]
public class EventsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateEvent([FromBody] CreateEventRequest request)
    {
        var newEventId = Guid.NewGuid();
        return Ok(newEventId);
    }

    [HttpGet]
    public ActionResult<List<EventResponse>> GetEvents()
    {
        var courses = new List<EventResponse>();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public ActionResult<EventWithUsersResponse> GetEventById([FromRoute] Guid id)
    {
        var course = new EventWithUsersResponse();
        return Ok(course);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEvent([FromRoute] Guid id, [FromBody] UpdateEventRequest request)
    {
        return NoContent();
    }

    [HttpPatch("{id}/deactivate")]
    public IActionResult DeactivateEvent([FromRoute] Guid id)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEvents([FromRoute] Guid id)
    {
        return NoContent();
    }
}
