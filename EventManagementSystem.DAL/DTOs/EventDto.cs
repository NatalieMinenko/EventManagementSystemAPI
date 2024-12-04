namespace EventManagementSystem.DAL.DTOs;

public class EventDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public string AdressOfEvent { get; set; }
    public int MaxParticipants { get; set; }
    public bool IsDeactivated { get; set; }
    public List<RegistrationDto> Registrations { get; set; }
    public List<UserDto> Users { get; set; }
}
