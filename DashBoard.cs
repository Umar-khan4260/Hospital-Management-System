using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class DashBoard : Form
    {
        private string Adminemail;
        public DashBoard(string adminemail)
        {
            InitializeComponent();
            Adminemail = adminemail;
            patientlabel_Click(null, null);
            doctorslabel_Click(null, null);
            appointmentslabel_Click(null, null);
            customerSupportlabel_Click(null, null);
            receptionistlabel_Click(null, null);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void patientlabel_Click(object sender, EventArgs e)
        {
            // Define connection string
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";

            // Define SQL query to get the count of patients
            string query = "SELECT COUNT(*) FROM Patient";

            // Create OracleConnection and OracleCommand
            using (OracleConnection con = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int patientCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the patient count in the label
                    patientlabel.Text = "Registered Patients: " + patientCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doctorslabel_Click(object sender, EventArgs e)
        {
            DisplayDoctorCount();
        }

        private void DisplayDoctorCount()
        {
            // Define connection string
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";

            // Define SQL query to get the count of doctors
            string query = "SELECT COUNT(*) FROM Doctor";

            // Create OracleConnection and OracleCommand
            using (OracleConnection con = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int doctorCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the doctor count in the label
                    doctorslabel.Text = "Total Doctors: " + doctorCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void appointmentslabel_Click(object sender, EventArgs e)
        {
            DisplayAppointmentCount();
        }

        private void DisplayAppointmentCount()
        {
            // Define connection string
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";

            // Define SQL query to get the count of appointments
            string query = "SELECT COUNT(*) FROM Appointment";

            // Create OracleConnection and OracleCommand
            using (OracleConnection con = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int appointmentCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the appointment count in the label
                    appointmentslabel.Text = "Total Appointments: " + appointmentCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void customerSupportlabel_Click(object sender, EventArgs e)
        {
            DisplayCustomerCareCount();
        }

        private void DisplayCustomerCareCount()
        {
            // Define connection string
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";

            // Define SQL query to get the count of appointments
            string query = "SELECT COUNT(*) FROM Customer_support_Staff";

            // Create OracleConnection and OracleCommand
            using (OracleConnection con = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int customercareCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the appointment count in the label
                    customerSupportlabel.Text = "Total Customer Care: " + customercareCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void receptionistlabel_Click(object sender, EventArgs e)
        {
            DisplayReceptionistCount();
        }

        private void DisplayReceptionistCount()
        {
            // Define connection string
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";

            // Define SQL query to get the count of appointments
            string query = "SELECT COUNT(*) FROM Receptionist";

            // Create OracleConnection and OracleCommand
            using (OracleConnection con = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query and get the result
                    int receptionistCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the appointment count in the label
                    receptionistlabel.Text = "Total Receptionist: " + receptionistCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(Adminemail);
            adminHome.Show();
            this.Hide();

        }
    }
}
