using EventManagementSystem.BLL.Exceptions;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL;

//public class RegisterServices(
//    IUserRepository _userRepository,
//    IRegisterRepository _registerRepository,
//    IEventRepository _eventRepository,
//    IMapper _mapper) : IRegisterServices
//{
//    public List<RegistrationDto> GetAllRegistrations(Guid eventId)
//    {
//        var eventDto = _eventRepository.GetEventById(eventId);

//        if (eventDto == null)

//            throw new EntityNotFoundException($"Event with id{eventId} was not found");

//        var result = _mapper.Map<EventModel>(eventDto);

//        return result;
//    }
//}