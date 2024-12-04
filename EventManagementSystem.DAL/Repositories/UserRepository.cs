using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.DAL.Repositories;
public class UserRepository : IUserRepository
{
    private Context _context;

    public UserRepository()
    {
        _context = new Context();
    }
    public void AddUser(UserDto user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
    public UserDto? GetUserByEmail(string email)
    {
        var user = _context.Users.Where(u => u.Email == email).SingleOrDefault();
        return user;
    }
    public List<UserDto> GetAllUsers()
    {
        var user = _context.Users.Where(u => u.IsDeactivated == false).ToList();
        return user;
    }
    public UserDto GetUserById(Guid id)
    {
        var user = _context.Users.Where(s => s.Id == id).FirstOrDefault();
        return user;
    }
    public UserDto GetUserRoleByUserId(Guid userId)
    {
        var role = _context.Users.Include(u => u.Role).Where(r => r.Id == userId).FirstOrDefault();
        return role;
    }
    public void UpdateUser(UserDto user, UserDto userUpdate)
    {
        user.FirstName = userUpdate.FirstName;
        user.LastName = userUpdate.LastName;
        user.Email = userUpdate.Email;
        user.Phone = userUpdate.Phone;
        _context.SaveChanges();
    }
    public void UpdatePassword(UserDto user, string password)
    {
        user.Password = password;
        _context.SaveChanges();
    }
    public void DeleteUser(UserDto user)
    {
        _context.Users.Remove(user);
        _context.SaveChanges();
    }
    public void DeactivateUser(UserDto user)
    {
        user.IsDeactivated = true;
        _context.SaveChanges();
    }
    public IEnumerable<UserDto> GetUsersByEventId(Guid eventId)
    {
        var user = _context.Users.Include(u => u.Events).Where(u => u.Id == eventId).FirstOrDefault();
        return _context.Users.ToList();
    }
    public IEnumerable<EventDto> GetEventsByUserId(Guid userId)
    {
        var events = _context.Events.Include(e => e.Users).Where(e => e.Id == userId).FirstOrDefault();
        return _context.Events.ToList();
    }
}

