using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.DAL.Repositories;

public class RegisterRepository (Context _context): IRegisterRepository
{
    public RegistrationDto Registrate (RegistrationDto registration)
    {
        var RegistrationDto = _context.Registrations.ToList();
        return registration;
    }
    public RegistrationDto? GetRegistrationById(Guid id)
    {
        var registration = _context.Registrations.Where(r => r.Id == id).FirstOrDefault();
        return registration;
    }
    public void DeleteRegistration(RegistrationDto registration)
    {
        _context.Registrations.Remove(registration);
        _context.SaveChanges();
    }
}
