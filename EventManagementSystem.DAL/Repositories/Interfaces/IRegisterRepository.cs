using EventManagementSystem.DAL.DTOs;

namespace EventManagementSystem.DAL.Repositories.Interfaces;
public interface IRegisterRepository
{
    public RegistrationDto? Registrate(RegistrationDto registration);
    public RegistrationDto? GetRegistrationById(Guid id);
    public void DeleteRegistration(RegistrationDto registration);
}
