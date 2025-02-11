using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class patientHome : Form
    {
        private string PateintEmail;
        public patientHome(string pateintEmail)
        {
            InitializeComponent();
            PateintEmail = pateintEmail;
        }

        private void patientHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientChkProfile patientChkProfile = new PatientChkProfile(PateintEmail);
            patientChkProfile.Show();
            this.Hide();
        }

        private void bookAppBtn_Click(object sender, EventArgs e)
        {
            PatientAppointment patientAppointment = new PatientAppointment(PateintEmail);
            patientAppointment.Show();
            this.Hide();
        }

        private void patientFeedbackbtn_Click(object sender, EventArgs e)
        {
            PatientFeedback patientFeedback = new PatientFeedback(PateintEmail);
            patientFeedback.Show();
            this.Hide();
        }
    }
}
