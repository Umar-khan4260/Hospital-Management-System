using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_project
{
    public partial class Admin_Chk_profile : Form
    {
        OracleConnection con;
        private string adminEmail;
        public Admin_Chk_profile(string adminemail)
        {
            InitializeComponent();
            adminEmail = adminemail;
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

        private void Admin_Chk_profile_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);


        }

        private void viewprofiletab_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // wrtiting query
                string InsertDate = "SELECT * FROM Admin WHERE email=:Email";
                // Create a new OracleCommand object with the SQL query and the connection.
                using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                {
                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = adminEmail;

                    using (OracleDataReader reader=cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            // Retrieve admin details from the database
                            string adminName = reader["name"].ToString();
                            string ademail = reader["email"].ToString();
                            string adminpass = reader["password"].ToString();
                            namelable.Visible = true;
                            EmailLable.Visible = true;
                            passlabel.Visible = true;

                            //showing data in labels
                           // MessageBox.Show("Admin Name: " + adminName);
                            namelable.Text = adminName;
                            EmailLable.Text = ademail;
                            passlabel.Text = adminpass;
                        
                        }
                        else
                        {
                            MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void editprofiletab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(adminEmail);
            adminHome.Show();
            this.Hide();

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text==""||
                passtxt.Text==""||
                !IsValidEmail(emailtxt.Text)
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Admin SET name=:Name, email=:Email, password=:Password WHERE email=:OldEmail";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = nametxt.Text;
                        cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = emailtxt.Text;
                        cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = passtxt.Text;
                        cmd.Parameters.Add("OldEmail", OracleDbType.Varchar2).Value = adminEmail;

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated > 0)
                        {
                            // Update successful
                            MessageBox.Show("Admin profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Update admin details labels
                            namelable.Text = nametxt.Text;
                            EmailLable.Text = emailtxt.Text;
                            passlabel.Text = passtxt.Text;
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

                // Switch back to view mode
                namelable.Visible = true;
                EmailLable.Visible = true;
                passlabel.Visible = true;

                nametxt.Visible = false;
                emailtxt.Visible = false;
                passtxt.Visible = false;

                // Show the "Edit Profile" tab
                editprofiletab.Visible = true;

                // Hide the "Save Changes" button
                submitbtn.Visible = false;
            }
            
        }


    }
}

