using Microsoft.AspNetCore.Mvc;
using EventManagementSystemAPI.Models.Requests;

namespace EventManagementSystemAPI.Controllers;

[Route("api/registration")]
[ApiController]
public class RegistrationsController : ControllerBase
{
    [HttpPost()]
    public ActionResult<Guid> Registrate([FromBody] RegistrationRequest request)
    {
        var newRegistrationId = Guid.NewGuid();
        return Ok(newRegistrationId);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        return NoContent();
    }
}
