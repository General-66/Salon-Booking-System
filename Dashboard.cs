using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Appointment_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //lstAppointments.Items.Add();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAppointment newAppointment = new CreateAppointment();
            newAppointment.Show();
            this.Hide();
            if (newAppointment == null) 
            {
                this.Show();
            }
        }
    }
}
