namespace EventManagementSystemAPI.Models.Responses
{
    public class EventWithUsersResponse : EventResponse
    {
        public List<UserResponse> Users { get; set; }
    }
}
