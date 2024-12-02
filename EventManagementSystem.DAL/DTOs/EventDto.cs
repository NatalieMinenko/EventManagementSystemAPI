namespace EventManagementSystem.DAL.DTOs;

public class EventDto
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public string AdressOfEvent { get; set; }
    public int MaxParticipants { get; set; }
    public List<RegistrationDto> Registrations { get; set; }
}
