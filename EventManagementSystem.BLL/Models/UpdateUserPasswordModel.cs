using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Models;
public class UpdateUserPasswordModel
{
    public string Password { get; set; }
    public string NewPassword { get; set; }
}
