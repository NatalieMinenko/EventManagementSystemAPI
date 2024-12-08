namespace EventManagementSystem.BLL.ExceptionMiddleware;
public class EntityConflictException(string message) : Exception(message)
{ }
