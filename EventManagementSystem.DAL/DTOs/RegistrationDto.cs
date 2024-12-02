namespace EventManagementSystem.DAL.DTOs;

public class RegistrationDto
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public UserDto User { get; set; }
    public Guid EventID { get; set; }
    public EventDto Event { get; set; }
}
