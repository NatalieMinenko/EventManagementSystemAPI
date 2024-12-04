namespace EventManagementSystemAPI.Models.Requests;

public class UpdateEventRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DateTime { get; set; }
    public string? AddressOfEvent { get; set; }
    public int MaxParticipants { get; set; }
}
