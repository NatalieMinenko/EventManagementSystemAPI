using EventManagementSystem.Core;

namespace EventManagementSystem.DAL.DTOs;

public class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }
    public string Email { get; set; }
    public UserRole Role { get; set; }
    public List<Registration> Registrations { get; set; }
}
