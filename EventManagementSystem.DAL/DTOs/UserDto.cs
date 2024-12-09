namespace EventManagementSystem.DAL.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public UserRole Role { get; set; }
    public bool IsDeactivated { get; set; }
    public List<RegistrationDto> Registrations { get; set; }
    public List<EventDto> Events { get; set; }
    List<UserDto> allParticipants { get; set; }
}
