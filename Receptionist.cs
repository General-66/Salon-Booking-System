using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Appointment_System
{
    public class Receptionist : Person
    {
        private List<Appointment> appointments;
        public Receptionist(string firstName, string lastName, string username, string password, string staffId)
            : base(firstName, lastName, username, password, staffId)
        {
            //StaffId = staffId;
            appointments = new List<Appointment>();
        }
        public void ScheduleAppointment(Appointment appointment)
        {
            // Logic to schedule an appointment
            if (appointment != null)
            {
                appointments.Add(appointment);
            }
            else
            {
                throw new ArgumentNullException(nameof(appointment), "There is no appointment to schedule.");
            }
        }
        public void CancelAppointment(Appointment appointment)
        {
            // Logic to cancel an appointment
            if (appointment != null && appointments.Contains(appointment))
            {
                appointments.Remove(appointment);
            }
            else
            {
                throw new ArgumentException("Appointment not found or is null.");
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            // Logic to update an appointment
        }

        public List<Appointment> ViewAppointments()
        {
            // Logic to view appointments
            if (appointments.Count == 0)
            {
                throw new ArgumentException("There are no appointments");
            }
            return appointments;
        }

        //Add UpdateAppointment
        //View Appointments
    }
}
