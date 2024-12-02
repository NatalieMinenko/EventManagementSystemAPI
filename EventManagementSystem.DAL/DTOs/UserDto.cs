using EventManagementSystem.Core;

namespace EventManagementSystem.DAL.DTOs;

public class UserDto
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }
    public string Email { get; set; }
    public UserRoleDto Role { get; set; }
    public List<RegistrationDto> Registrations { get; set; }
}
