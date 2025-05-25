using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Appointment_System
{
    public class Appointment
    {
        public int AppointmentID { get; private set; }
        public DateTime AppointmentDT { get; set; }
        public string CustomerName { get; set; }
        public string ServiceType { get; set; }
        public string StaffName { get; set; }
        public string Status { get; set; } // e.g., Scheduled, Completed, Cancelled

        public Appointment(int AppointmentID, DateTime AdateTime, string ACusName, string ASerType, string StaffName, string status) 
        {
            this.AppointmentID = AppointmentID;
            this.AppointmentDT = AdateTime;
            this.CustomerName = ACusName;
            this.ServiceType = ASerType;
            this.StaffName = StaffName;
            this.Status = status;
        }
    }
}
