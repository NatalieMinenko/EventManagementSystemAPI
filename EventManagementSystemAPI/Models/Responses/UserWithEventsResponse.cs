namespace EventManagementSystemAPI.Models.Responses
{
    public class UserWithEventsResponse : UserResponse
    {
        public List<EventResponse> Event { get; set; }
    }
}
