namespace EventManagementSystem.DAL.DTOs;

public class RegistrationDto
{
    public Guid Id { get; set; }
    public Guid UserID { get; set; }
    public List<UserDto> Users { get; set; }
    public Guid EventID { get; set; }
    public EventDto Event { get; set; }
}
