using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Appointment_System
{
    public partial class CreateAppointment : Form
    {
        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int ID = randomNumber.Next(10000, 100000); // Generate a random number for AppointmentID
            Appointment appointment = new Appointment(
                ID, // This should be replaced with a method to generate a unique ID
                dtpDate.Value,
                txtClientName.Text,
                cmbService.SelectedText,
                cmbStaffMember.SelectedText,
                Status.Scheduled.ToString(), // Default status
                0,
                DateTime.Now
            );
            
            
        }
    }
}
