using EventManagementSystemAPI.Models.Requests;
using EventManagementSystemAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystemAPI.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public ActionResult Register([FromBody] RegisterUserRequest request)
    {
        var AddedUserId = new Guid();
        return Ok(AddedUserId);
    }

    [HttpPost("login")]
    public IActionResult LogIn([FromBody] LoginRequest request)
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    public ActionResult<UserWithEventsResponse> GetUsersById([FromRoute] Guid id)
    {
        var user = new UserWithEventsResponse();
        return Ok(user);
    }

    [HttpGet]
    public ActionResult<List<UserResponse>> GetUsers()
    {
        List<UserResponse> users = new List<UserResponse>();
        return Ok(users);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute] Guid id)
    {
        return NoContent();
    }

    [HttpPatch("{id}/deactivate")]
    public IActionResult DeactivateUser([FromRoute] Guid id)
    {
        return NoContent();
    }
}
