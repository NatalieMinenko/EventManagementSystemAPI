using AutoMapper;
using EventManagementSystem.BLL.Exceptions;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Mappings;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.Core;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EventManagementSystem.BLL;
public class UsersServices : IUsersServices
{
    private readonly IUserRepository _userRepository;

    private readonly IEventRepository _eventRepository;

    private readonly IMapper _mapper;
    public UsersServices(IUserRepository repository)
    {
        _userRepository = repository;

        var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new UserMapperProfile());
                cfg.AddProfile(new EventMapperProfile());
            });
        _mapper = new Mapper(config);
    }
    public string? Authenticate(string email, string password)
    {
        var user = _userRepository.GetUserByEmail(email);

        if (user != null && user.Password == password)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(OptionsAuth.Key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
            issuer: OptionsAuth.Issuer,
            audience: OptionsAuth.Audience,
            claims: new List<Claim>(),
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }
        else return null;
    }
    public void AddUser(UserModel user)
    {
        var userId = _mapper.Map<UserDto>(user);

        if (userId == null)

            throw new EntityNotFoundException($"User with id{user} was not found");

        _userRepository.AddUser(userId);
    }
    public UserModel GetUserByEmail(string email)
    {
        var user = _userRepository.GetUserByEmail(email);

        var users = _mapper.Map<UserDto>(email);

        if (email == null)
        {
            throw new EntityNotFoundException($"User with email{user} was not found");
        }
        else
        {
            return _mapper.Map<UserModel>(users);
        }
    }
    public List<UserModel> GetAllUsers()
    {
        var user = _userRepository.GetAllUsers();

        var users = _mapper.Map<List<UserModel>>(user);

        return users;
    }
    public UserModel GetUsersById(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);

        if (user == null)

            throw new EntityNotFoundException($"Role with id{userId} was not found");

        var result = _mapper.Map<UserModel>(user);

        return result;
    }
    public UserModel GetUserRoleByUserId(Guid userId)
    {
        var role = _userRepository.GetUserRoleByUserId(userId);

        if (role == null)

            throw new EntityNotFoundException($"Role with id{role} was not found");

        var result = _mapper.Map<UserModel>(role);

        return result;
    }
    public void UpdateUser(Guid id, UpdateUserModel user)
    {
        var existingUser = _userRepository.GetUserById(id);

        if (existingUser == null)
        {
            throw new EntityNotFoundException($"User with id {id} was not found");
        }

        var updatedUser = _mapper.Map(id, existingUser);

        _userRepository.UpdateUser(existingUser, updatedUser);
    }
    public void DeleteUser(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);

        if (user == null)

            throw new EntityNotFoundException($"User with {userId} was not found");

        _userRepository.DeleteUser(user);
    }
    public void DeactivateUser(Guid userId)
    {
        var userDto = _userRepository.GetUserById(userId);

        if (userDto == null)

            throw new EntityNotFoundException($"User with id {userId} was not found");

        _userRepository.DeactivateUser(userDto);
    }
    public List<EventModel> GetEventsByUserId(Guid userId)
    {
        var eventDtos = _userRepository.GetEventsByUserId(userId);

        if (eventDtos == null)

            throw new EntityNotFoundException($"Events with id{userId} was not found");

        var events = _mapper.Map<List<EventModel>>(eventDtos);

        return events;
    }
}

