using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Appointment_System
{
    public class Receptionist : Person
    {
        public Receptionist(string firstName, string lastName, string username, string password, string staffId)
            : base(firstName, lastName, username, password, staffId)
        {
            //StaffId = staffId;
        }
        public void ScheduleAppointment(Appointment appointment)
        {
            // Logic to schedule an appointment
        }
        public void CancelAppointment(Appointment appointment)
        {
            // Logic to cancel an appointment
        }
    }
}
