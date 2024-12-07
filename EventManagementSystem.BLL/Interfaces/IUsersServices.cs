using EventManagementSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Interfaces;

public interface IUsersServices
{
    string? Authenticate(string email, string password);
    void AddUser(UserModel user);
    UserModel GetUserByEmail(string email);
    List<UserModel> GetAllUsers();
    UserModel GetUsersById(Guid userId);
    UserModel GetUserRoleByUserId(Guid userId);
    void UpdateUser(Guid id, UpdateUserModel user);
    void DeleteUser(Guid id);
    void DeactivateUser(Guid id);
    List<EventModel> GetEventsByUserId(Guid userId);
}
