using EventManagementSystem.BLL.Models;
using EventManagementSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Interfaces;

public interface IRegisterServices
{
    void Registrate(RegistrationDto registration, Guid userId, Guid eventId);
    RegistrationModel GetRegistrationById(Guid id);
    void DeleteRegistration(Guid registrationId);
}
