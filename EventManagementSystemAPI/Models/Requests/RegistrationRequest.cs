namespace EventManagementSystemAPI.Models.Requests
{
    public class RegistrationRequest
    {
        public Guid UserId { get; set; }    

        public Guid EventId { get; set; }
    }
}
