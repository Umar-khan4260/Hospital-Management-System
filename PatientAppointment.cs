using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Database_project
{
    public partial class PatientAppointment : Form
    {
        private const string AccountSid = "AC11432fbfbcb13d6c746c32df5cab5b1a";
        private const string AuthToken = "f4576cac0dcbc0f9f4d518d28d5c85e8";
        private const string FromPhoneNumber = "+12096538811";
        string tempEmail;
        private string patientEmail;
        OracleConnection con;
        DataTable doctorTable;
        DataTable AppointmentTable;
        public PatientAppointment(string PatientEmail)
        {
            InitializeComponent();
            patientEmail = PatientEmail;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void PatientAppointment_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);


            AppointmentTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            AppointmentTable.Columns.Add("Appointment ID", typeof(int));
            AppointmentTable.Columns.Add("Patient Email");
            AppointmentTable.Columns.Add("Doctor Email");
            AppointmentTable.Columns.Add("Appointment Date", typeof(DateTime));
            AppointmentTable.Columns.Add("Appointment Time");
            AppointmentTable.Columns.Add("Appointment Status");

            // Bind DataTable to DataGridView in each tab
            AppointmentdataGrid.DataSource = AppointmentTable;
            // Fetch existing data from the database and display in DataGridView
            AppointmentFillDataGridView();


            //******************Doctor DataGrid View**********************
            doctorTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            doctorTable.Columns.Add("Name");

            doctorTable.Columns.Add("Email");

            // Bind DataTable to DataGridView in each tab
            doctordataGrid.DataSource = doctorTable;
            // Fetch existing data from the database and display in DataGridView
            DocFillDataGridView();


        }

        private void DocFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT Name,Email FROM Doctor";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                doctorTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    doctorTable.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void AppointmentFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT * FROM Appointment";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                AppointmentTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    AppointmentTable.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void doctordataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doctorEmail.Text = doctordataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BookAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (
                !IsValidEmail(doctorEmail.Text) ||
                appointmentDate.Value == DateTime.MinValue ||
                appointmentTime.Text == "" ||
                appointstatus.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                // Check if the database connection is not already open.
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        // Writing query
                        string selectDate = "SELECT COUNT(*) FROM Appointment WHERE Doctor_Email=:docEmail AND Appointment_Date=:appDate AND Appointment_Time=:appTime";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand cmd = new OracleCommand(selectDate, con))
                        {
                            cmd.Parameters.Add("docEmail", OracleDbType.Varchar2).Value = doctorEmail.Text;
                            cmd.Parameters.Add("appDate", OracleDbType.Date).Value = appointmentDate.Value.Date;
                            cmd.Parameters.Add("appTime", OracleDbType.Varchar2).Value = appointmentTime.Text;

                            int appointmentCount = Convert.ToInt32(cmd.ExecuteScalar());
                            if (appointmentCount > 0)
                            {
                                MessageBox.Show("This Appointment Time Already Booked", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                doctorEmail.Clear();
                                appointmentDate.Value = DateTime.Today;
                                appointmentTime.Clear();
                                doctorEmail.Focus();
                            }
                            else
                            {
                                string InsertDate = "INSERT INTO Appointment VALUES ( (SELECT COALESCE(MAX(Appointment_ID), 0) + 1 FROM Appointment), :patEmail, :docEmail,:appDate, :appTime,:appStatus)";
                                // Create a new OracleCommand object with the SQL query and the connection.
                                using (OracleCommand command = new OracleCommand(InsertDate, con))
                                {
                                    command.Parameters.Add("patEmail", OracleDbType.Varchar2).Value = patientEmail;
                                    command.Parameters.Add("docEmail", OracleDbType.Varchar2).Value = doctorEmail.Text;
                                    command.Parameters.Add("appDate", OracleDbType.Date).Value = appointmentDate.Value.Date;
                                    command.Parameters.Add("appTime", OracleDbType.Varchar2).Value = appointmentTime.Text;
                                    command.Parameters.Add("appStatus", OracleDbType.Varchar2).Value = appointstatus.SelectedItem.ToString();

                                    int rows = command.ExecuteNonQuery();
                                    if (rows > 0)
                                    {
                                        MessageBox.Show("Appointment Booked Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Refresh DataGridView to show newly added data
                                        AppointmentFillDataGridView();

                                        // Send SMS notification to the patient
                                        try
                                        {
                                            TwilioClient.Init(AccountSid, AuthToken);

                                            // Format the Pakistani phone number with the country code (+92)
                                            var toPhoneNumber = "+92" + phn_no_txt.Text.Trim();

                                           var messageOptions = new CreateMessageOptions(
                                               new PhoneNumber(toPhoneNumber))
                                            {
                                               From = new PhoneNumber(FromPhoneNumber),
                                              Body = $"Dear Patient {patientEmail}, Your appointment has been successfully booked with Doctor {doctorEmail.Text} at {appointmentTime.Text} on {appointmentDate.Value.ToShortDateString()}.\nKindly Visit Your Doctor Timely.\nWe hope for your speedy recovery!\nRegards, PULSE PEAK HOSPITAL LOONAY WALA\nDesigned By: Mustehsan Nisar Rao && Umar Anjum Khan Collectively"
                                            };

                                           var message = MessageResource.Create(messageOptions);

                                           MessageBox.Show($"Message sent! SID: {message.Sid}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Insertion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State != ConnectionState.Closed)
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            patientHome patHome = new patientHome(patientEmail);
            patHome.Show();
            this.Hide();
        }

    }
}
