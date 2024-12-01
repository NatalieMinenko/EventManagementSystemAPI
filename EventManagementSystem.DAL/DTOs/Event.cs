namespace EventManagementSystem.DAL.DTOs;

public class Event
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public string AdressOfEvent { get; set; }
    public int MaxParticipants { get; set; }
    public List<Registration> Registrations { get; set; }
}
