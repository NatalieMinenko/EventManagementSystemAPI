namespace EventManagementSystemAPI.Models.Responses
{
    public class FullInfoEventResponse
    {
        public Guid Id { get; set; }

        public int NumberOfParticipants { get; set; }

        public List<UserResponse> Users { get; set; }
    }
}
