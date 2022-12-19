using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinicLibrary.User;

public class Userr : IUserr
{
    public int UserrId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordRepeat { get; set; }
    public int RoleeId { get ; set ; }
    public Rolee Rolee { get ; set ; }
}
