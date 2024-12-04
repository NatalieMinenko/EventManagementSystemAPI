namespace EventManagementSystemAPI.Models.Requests;

public class UpdatePasswordRequest
{
    public string Password { get; set; }
    public string NewPassword { get; set; }
}
