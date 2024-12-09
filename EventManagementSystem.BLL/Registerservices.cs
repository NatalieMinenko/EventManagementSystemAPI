using EventManagementSystem.BLL.Exceptions;
using EventManagementSystem.BLL.ExceptionMiddleware;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.Core;
using EventManagementSystem.DAL.Repositories;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.Extensions.Configuration.UserSecrets;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL;

public class RegisterServices(IUserRepository _userRepository,
                              IRegisterRepository _registerRepository,
                              IEventRepository _eventRepository,
                              IMapper _mapper) : IRegisterServices
{
    public void Registrate(RegistrationDto registration, Guid userId, Guid eventId)
    {
        var eventsDto = _eventRepository.GetEventById(eventId);

        if (eventsDto.IsDeactivated)

            throw new EntityConflictException($"Event with id {eventId} is deactivated");

        var userDto = _userRepository.GetUserById(userId);

        if (userDto.IsDeactivated)

            throw new EntityConflictException($"User with id {userId} is deactivated");

        var registationDto = _registerRepository.GetRegistrationById(registration.Id);

        if (registationDto != null)
            throw new EntityConflictException($"Registaration with user id {userId} and event id {eventId} already exists");

        var newRegistration = new RegistrationDto()
        {
            Event = eventsDto,
            User = userDto
        };

        _registerRepository.Registrate(newRegistration);
    }
    public RegistrationModel GetRegistrationById(Guid id)
    {
        var registration = _registerRepository.GetRegistrationById(id);

        if (registration == null)
        {
            throw new EntityNotFoundException($"Registartion with id {id} was not found");
        }
        var result = _mapper.Map<RegistrationModel>(registration);

        return result;
    }
    public void DeleteRegistration(Guid registrationId)
    {
        var registrationDto = _registerRepository.GetRegistrationById(registrationId);

        if (registrationDto == null)
        {
            throw new EntityNotFoundException($"Registartion with id {registrationId} was not found");
        }
        _registerRepository.DeleteRegistration(registrationDto);
    }
}

