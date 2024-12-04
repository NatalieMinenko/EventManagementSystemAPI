using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.BLL.Models;

public class UpdateEventModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public string AdressOfEvent { get; set; }
    public int MaxParticipants { get; set; }
}
