namespace EventManagementSystem.DAL.DTOs;

public class RegistrationDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
    public Guid EventId { get; set; }
    public EventDto Event { get; set; }
}
