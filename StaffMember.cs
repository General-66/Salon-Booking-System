using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Appointment_System
{
    public class StaffMember
    {
        public int StaffID { get; private set; }
        public string Name { get; set; }
        public List<Appointment> appointments;

        public StaffMember(string name, int staffID)
        {
            Name = name;
            appointments = new List<Appointment>();
            StaffID = staffID;
        }
    }
}
