using EventManagementSystemAPI.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystemAPI.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RegisterUserRequest request)
    {
        return Ok();
    }

    [HttpPost("login")]
    public ActionResult LogIn([FromBody] LoginRequest request)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetUsersById([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpGet]
    public ActionResult GetUsers()
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpPatch("{id}/deactivate")]
    public IActionResult DeactivateUser([FromRoute] Guid id)
    {
        return Ok();
    }
}
