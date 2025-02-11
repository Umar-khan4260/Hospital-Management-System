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

namespace Database_project
{
    public partial class DocmngAppointment : Form
    {
        private int tempAppointmentId;
        private string temp;
        private string temp2;
        OracleConnection con;
        DataTable AppointmentTable;
        private string DocEmail;
        string oldStatus;
        string newStatus;

        public DocmngAppointment(string docemail)
        {
            InitializeComponent();
            DocEmail = docemail;
        }

        private void DocmngAppointment_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);

            AppointmentTable = new DataTable();
            // Add columns to DataTable to match Appointment table in the database
            AppointmentTable.Columns.Add("Appointment ID", typeof(int));
            AppointmentTable.Columns.Add("Patient Email");
            AppointmentTable.Columns.Add("Doctor Email");
            AppointmentTable.Columns.Add("Appointment Date", typeof(DateTime));
            AppointmentTable.Columns.Add("Appointment Time");
            AppointmentTable.Columns.Add("Appointment Status");

            // Bind DataTable to DataGridView in each tab
            AppointmentdataGridView.DataSource = AppointmentTable;
            // Fetch existing data from the database and display in DataGridView
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "SELECT * FROM Appointment WHERE Doctor_Email = :DoctorEmail";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                adapter.SelectCommand.Parameters.Add(new OracleParameter("DoctorEmail", DocEmail));

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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusBox.SelectedIndex == -1 || string.IsNullOrEmpty(temp) || string.IsNullOrEmpty(temp2))
                {
                    MessageBox.Show("Kindly Fill All Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                newStatus = statusBox.SelectedItem.ToString();

                int appointmentId = Convert.ToInt32(AppointmentdataGridView.SelectedRows[0].Cells[0].Value.ToString());

                using (OracleConnection con = new OracleConnection(@"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123"))
                {
                    con.Open();

                    // Update the appointment status
                    string updateQuery = "UPDATE Appointment SET Appointment_Status = :status WHERE Doctor_Email = :doc AND Patient_Email = :pat";
                    using (OracleCommand cmd = new OracleCommand(updateQuery, con))
                    {
                        cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = newStatus;
                        cmd.Parameters.Add("doc", OracleDbType.Varchar2).Value = temp2;
                        cmd.Parameters.Add("pat", OracleDbType.Varchar2).Value = temp;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDataGridView(); // Refresh DataGridView to reflect the changes

                            // Check if the status is changed from "Pending" to "Attend"
                              if (statusBox.SelectedItem.ToString() == "Attended")
                              {
                                  // Insert data into the Revenue table
                                  string insertQuery = "INSERT INTO Revenue (Appointment_ID, Fee) VALUES (:appointmentId, :fee)";
                                  using (OracleCommand revenueCmd = new OracleCommand(insertQuery, con))
                                  {
                                      revenueCmd.Parameters.Add("appointmentId", OracleDbType.Int32).Value = tempAppointmentId;
                                      revenueCmd.Parameters.Add("fee", OracleDbType.Decimal).Value = 2000; // Fee for each appointment

                                      revenueCmd.ExecuteNonQuery();
                                  }
                              }
                          }
                          else
                          {
                              MessageBox.Show("No records were updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            DocHome docHome = new DocHome(DocEmail);
            docHome.Show();
            this.Hide();
        }

        private void AppointmentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row data
                tempAppointmentId = Convert.ToInt32(AppointmentdataGridView.SelectedRows[0].Cells[0].Value.ToString());
                temp = AppointmentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                temp2 = AppointmentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                statusBox.Text = AppointmentdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                oldStatus = AppointmentdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}