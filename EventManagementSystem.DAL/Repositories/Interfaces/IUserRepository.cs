using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL.Repositories.Interfaces;
public interface IUserRepository
{
    public void AddUser(UserDto user);
    public UserDto? GetUserByEmail(string email);
    public List<UserDto> GetAllUsers();
    public UserDto GetUserById(Guid id);
    public UserDto GetUserRoleByUserId(Guid userId);
    public void UpdateUser(UserDto user, UserDto userUpdate);
    public void UpdatePassword(UserDto user, string password);
    public void DeleteUser(UserDto user);
    public void DeactivateUser(UserDto user);
    public List<EventDto> GetEventsByUserId(Guid userId);
}
