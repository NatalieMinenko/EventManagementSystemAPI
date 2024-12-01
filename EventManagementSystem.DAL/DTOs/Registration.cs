namespace EventManagementSystem.DAL.DTOs;

public class Registration
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
    public Guid EventID { get; set; }
    public Event Event { get; set; }
}
