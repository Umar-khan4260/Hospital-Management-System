using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class ReceptionistChkProfile : Form
    {
        OracleConnection con;
        private string RptEmail;
        public ReceptionistChkProfile(string rptEmail)
        {
            InitializeComponent();
            RptEmail = rptEmail;
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

        private void ReceptionistChkProfile_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void viewprofile_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // wrtiting query
                string InsertDate = "SELECT * FROM Receptionist WHERE Email=:email";
                // Create a new OracleCommand object with the SQL query and the connection.
                using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                {
                    cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = RptEmail;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve admin details from the database
                            string docName = reader["Name"].ToString();
                            string docCnic = reader["CNIC"].ToString();
                            string docage = reader["Age"].ToString();
                            string docgen = reader["Gender"].ToString();
                            string docdob = reader["DOB"].ToString();
                            string docaddress = reader["Address"].ToString();
                            string docexp = reader["Experience"].ToString();
                            string docemail = reader["Email"].ToString();
                            string docpass = reader["Password"].ToString();
                            namelable.Visible = true;
                            cniclable.Visible = true;
                            agelabel.Visible = true;
                            genlabel.Visible = true;
                            doblabel.Visible = true;
                            addresslabel.Visible = true;
                            experiencelabel.Visible = true;
                            emailLable.Visible = true;
                            passlabel.Visible = true;

                            //showing data in labels
                            // MessageBox.Show("Admin Name: " + adminName);
                            namelable.Text = docName;
                            cniclable.Text = docCnic;
                            agelabel.Text = docage;
                            genlabel.Text = docgen;
                            doblabel.Text = docdob;
                            addresslabel.Text = docaddress;
                            experiencelabel.Text = docexp;
                            emailLable.Text = docemail;
                            passlabel.Text = docpass;

                        }
                        else
                        {
                            MessageBox.Show("Receptionist not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                con.Close();
            }
        }

        private void editprofile_Click(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" ||
                !IsValidCNIC(cnictxt.Text) ||
                //agetxt.Text == "" ||
                genbox.SelectedIndex == -1 ||
                dob.Value == DateTime.MinValue ||
                addresstxt.Text == "" ||
                exptxt.Text == "" ||
                passtxt.Text == ""

                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int age = CalculateAge(dob.Value);
                    con.Open();
                    string query = "UPDATE Receptionist SET Name=:name, CNIC=:cnic, Age=:age, Gender=:gen, DOB=:dob, Address=:address, Experience=:exp, Password=:password WHERE Email=:OldEmail";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = nametxt.Text;
                        cmd.Parameters.Add("cnic", OracleDbType.Varchar2).Value = cnictxt.Text;
                        cmd.Parameters.Add("age", OracleDbType.Int32).Value = age;
                        cmd.Parameters.Add("gen", OracleDbType.Varchar2).Value = genbox.SelectedItem.ToString();
                        cmd.Parameters.Add("dob", OracleDbType.Date).Value = dob.Value.Date;
                        cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = addresstxt.Text;
                        cmd.Parameters.Add("exp", OracleDbType.Int32).Value = exptxt.Text;
                        cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = passtxt.Text;
                        cmd.Parameters.Add("OldEmail", OracleDbType.Varchar2).Value = RptEmail;

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated > 0)
                        {
                            // Update successful
                            MessageBox.Show("Receptionist profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Update admin details labels
                            //namelable.Text = nametxt.Text;
                            //EmailLable.Text = emailtxt.Text;
                            //passlabel.Text = passtxt.Text;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update admin profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating admin profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                //// Switch back to view mode
                //namelable.Visible = true;
                //EmailLable.Visible = true;
                //passlabel.Visible = true;

                //nametxt.Visible = false;
                //emailtxt.Visible = false;
                //passtxt.Visible = false;

                //// Show the "Edit Profile" tab
                //editprofiletab.Visible = true;

                //// Hide the "Save Changes" button
                //submitbtn.Visible = false;
            }
        }

        private void Dochomebtn_Click(object sender, EventArgs e)
        {
            ReceptionistHome receptionistHome = new ReceptionistHome(RptEmail);
            receptionistHome.Show();
            this.Hide();
        }
    }
}
