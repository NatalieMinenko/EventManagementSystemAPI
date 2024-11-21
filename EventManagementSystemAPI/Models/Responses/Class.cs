namespace EventManagementSystemAPI.Models.Responses;

public class Class
{
    public Guid Id { get; set; }

    public int NumberOfParticipants { get; set; }

    public List<UserResponse> Users { get; set; }
}
