namespace EventManagementSystem.Core;

public class Options
{
    public static string Conection
    {
        get
        {
            return Environment.GetEnvironmentVariable("EventManagementSystemAPI")!;
        }

        private set { }
    }
}