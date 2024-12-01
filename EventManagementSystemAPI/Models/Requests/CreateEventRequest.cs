namespace EventManagementSystemAPI.Models.Requests
{
    public class CreateEventRequest
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }

        public string AdressOfEvent { get; set; }

        public int MaxOfParticipants { get; set; }
    }
}
