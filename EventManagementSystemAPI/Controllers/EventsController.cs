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
        return Ok();
    }

    [HttpGet]
    public ActionResult<List<EventResponse>> GetEvents()
    {
        var courses = new List<EventResponse>();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public ActionResult<FullInfoEventResponse> GetEventById([FromRoute] Guid id)
    {
        var course = new FullInfoEventResponse();
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
