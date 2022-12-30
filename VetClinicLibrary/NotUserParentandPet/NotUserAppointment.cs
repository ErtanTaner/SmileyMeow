using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinicLibrary.Appointmentt.AppointmentStatuss;
using VetClinicLibrary.Person;

namespace VetClinicLibrary.NotUserParentandPet;

public class NotUserAppointment : INotUserAppointment
{
    public int AppointmentId { get; set; }
    public int NotUserParentnPersonId { get; set; }
    public NotUserParentnPet NotUserParentnPet { get; set; }
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime TimeCreated { get; set; } = DateTime.Now.AddDays(-40);
    public DateTime AppointmentDate { get; set; }
    public int AppointmentStatussId { get; set; }
    public AppointmentStatus AppointmentStatus { get; set; }
}
