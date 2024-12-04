namespace EventManagementSystemAPI.Models.Responses
{
    public class EventResponse
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }
        public string AddressOfEvent { get; set; }
    }
}
