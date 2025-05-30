using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Appointment_System
{
    public class Person
    {
        public int StaffID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; private set; }

        public Person(string firstName, string lastName, string username, string password, string staffID) 
        {
            int staffId = 0; //Edit assignment of  
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            if(int.TryParse(staffID, out staffId)) 
            {
                StaffID = staffId;
            }
            else
            {
                throw new ArgumentException("Enter valid Staff ID.");
            }
        }
    }
}
