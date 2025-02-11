using iTextSharp.text;
//using iText.Layout;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Database_project
{
    public partial class AdminHome : Form
    {
        private String adminemail;
        public AdminHome(string adminEmail)
        {
            InitializeComponent();
            adminemail = adminEmail;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void mngEmpBtn_Click(object sender, EventArgs e)
        {
            ManageEmp manageEmp = new ManageEmp(adminemail);
            manageEmp.Show();
            this.Close();
        }

        private void chkprofilebtn_Click(object sender, EventArgs e)
        {
            Admin_Chk_profile admin_Chk_Profile = new Admin_Chk_profile(adminemail);
            admin_Chk_Profile.Show();
            this.Hide();
        }

        private void mangAppointment_Click(object sender, EventArgs e)
        {
            AdminManageAppointment admin_ManageAppointment = new AdminManageAppointment(adminemail);
            admin_ManageAppointment.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard(adminemail);
            dashBoard.Show();
            this.Hide();
        }

        private void mngPatientbtn_Click(object sender, EventArgs e)
        {
            ManagePatients managePatients = new ManagePatients();
            managePatients.Show();
            this.Hide();
        }

        private void revenueReportbtn_Click(object sender, EventArgs e)
        {
            //RevenueReport revenueReport = new RevenueReport();
            //revenueReport.Show();
            //this.Hide();
            try
            {
                // Query the database to fetch data from the Revenue and Appointment tables
                string connectionString = "Data Source=localhost:1521/XE;User Id=HMS;Password=123;";
                string query = @"
                    SELECT R.Appointment_ID, A.Patient_Email, A.Doctor_Email, R.Fee
                    FROM Revenue R
                    JOIN Appointment A ON R.Appointment_ID = A.Appointment_ID";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Create a PDF document
                            Document document = new Document();
                            string outputPath = @"E:\revenue_report.pdf";

                            // Create a PdfWriter instance to write to the PDF file
                            PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                            // Open the document
                            document.Open();

                            // Add headers to the PDF content
                            PdfPTable table = new PdfPTable(4);
                            table.AddCell("Appointment ID");
                            table.AddCell("Patient Email");
                            table.AddCell("Doctor Email");
                            table.AddCell("Fee");

                            // Iterate through the data reader and add each row to the PDF table
                            while (reader.Read())
                            {
                                table.AddCell(reader["Appointment_ID"].ToString());
                                table.AddCell(reader["Patient_Email"].ToString());
                                table.AddCell(reader["Doctor_Email"].ToString());
                                table.AddCell(reader["Fee"].ToString());
                            }

                            // Add the table to the document
                            document.Add(table);

                            // Close the document
                            document.Close();

                            // Display success message
                            //MessageBox.Show("Revenue report generated successfully as PDF file.");
                            // Display the message box with two options
                            DialogResult result = MessageBox.Show("Revenue report generated successfully. Do you want to open the file?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            // Check which button the user clicked
                            if (result == DialogResult.Yes)
                            {
                                // Code to open the PDF file
                                System.Diagnostics.Process.Start(outputPath);
                            }
                            else if (result == DialogResult.No)
                            {
                                // User chose not to open the file, you can add any additional actions here
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating revenue report: " + ex.Message);
            }

        }

        private void viewFeedback_Click(object sender, EventArgs e)
        {
            AdminViewFeedback adminViewFeedback = new AdminViewFeedback(adminemail);
            adminViewFeedback.Show();
            this.Hide();
            //AdminHome adminHome = new AdminHome(adminemail);
            //adminHome.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
