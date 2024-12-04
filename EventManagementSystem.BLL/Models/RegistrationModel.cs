using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Models;
public class RegistrationModel
{
    public Guid UserId { get; set; }
    public Guid EventId { get; set; }
}