using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Database_project
{
    public partial class patientsignup : Form
    {
        string randomCode;
        public static string to;
        OracleConnection con;
        public patientsignup()
        {
            InitializeComponent();

        }

        // Email validation method
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

        //CNIC Validation
        private bool IsValidCNIC(string cnic)
        {
            // Regular expression for CNIC: XXXXX-XXXXXXX-X
            string pattern = @"^[0-9]{5}-[0-9]{7}-[0-9]{1}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(cnic);
        }
        //calculating date of dirth

        private int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            // Go back to the previous year if the birthday hasn't occurred yet this year
            if (dob.Date > today.AddYears(-age)) age--;

            return age;
        }

        private void patientsignup_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void patientname_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientage_TextChanged(object sender, EventArgs e)
        {

        }

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void patientaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientconpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientSubmit_Click(object sender, EventArgs e)
        {
            if(patientname.Text==""||
                !IsValidCNIC(patientcnic.Text)||
               // patientage.Text==""||
                GendercomboBox.SelectedIndex==-1||
                DOB.Value==DateTime.MinValue||
                patientaddress.Text==""||
                !IsValidEmail(patientemail.Text) ||
                patientpass.Text==""||
                GenOtp.Checked==false||
                otptxt.Text==""||
                patientconpass.Text==""
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email","Failure",MessageBoxButtons.OK);
            }
            else
            {
                if(patientpass.Text==patientconpass.Text&&otptxt.Text==randomCode)
                {
                    int age = CalculateAge(DOB.Value);
                    // Check if the database connection is not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            // wrtiting query
                            string InsertDate = "INSERT INTO Patient VALUES (:Name , :CNIC , :Age , :Gender , :DOB , :Address , :Email , :Password)";
                            // Create a new OracleCommand object with the SQL query and the connection.
                            using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                            {
                                cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = patientname.Text;
                                cmd.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = patientcnic.Text;
                                cmd.Parameters.Add("Age", OracleDbType.Int32).Value = age;
                                cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = GendercomboBox.SelectedItem.ToString();
                                cmd.Parameters.Add("DOB", OracleDbType.Date).Value = DOB.Value.Date;
                                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = patientaddress.Text;
                                cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = patientemail.Text;
                                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = patientpass.Text;
                               
                                int rowsAffected=cmd.ExecuteNonQuery();
                                if (rowsAffected >= 0)
                                {
                                    MessageBox.Show("Account activated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    patientlogin patlogin =new patientlogin();
                                    patlogin.Show();
                                    this.Hide();


                                }
                                else
                                {
                                    MessageBox.Show("Insertion Failed", "Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password and Conform Password must be same!!!","Failure", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    patientpass.Clear();
                    patientconpass.Clear();
                    patientpass.Focus();
                }
            }
        }

        private void patientReset_Click(object sender, EventArgs e)
        {
            patientname.Text = "";
            patientcnic.Text = "";
            //patientage.Text = "";
            GendercomboBox.SelectedIndex = -1;
            DOB.Value = DateTime.Today;
            patientaddress.Text = "";
            patientemail.Text = "";
            patientpass.Text = "";
            patientconpass.Text = "";
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void otptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenOtp_CheckedChanged(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (patientemail.Text).ToString();
            from = "f223281@cfd.nu.edu.pk";
            pass = "vgey spka fmly jnep";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
