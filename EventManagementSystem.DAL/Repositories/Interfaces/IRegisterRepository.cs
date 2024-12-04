﻿using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL.Repositories.Interfaces;
public interface IRegisterRepository
{
    public List<RegistrationDto> GetAllRegistrations();
    public RegistrationDto? GetRegistrationById(Guid id);
    public void DeleteRegistration(RegistrationDto registration);
}