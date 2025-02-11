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

    public partial class ManagePatients : Form
    {
        string tempEmail;
        private string adminemail;
        OracleConnection con;
        DataTable doctorTable;
        public ManagePatients()
        {
            InitializeComponent();
        }

        private void ManagePatients_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);

            doctorTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            doctorTable.Columns.Add("Name");
            doctorTable.Columns.Add("CNIC");
            doctorTable.Columns.Add("Age", typeof(int));
            doctorTable.Columns.Add("Gender");
            doctorTable.Columns.Add("DOB", typeof(DateTime));
            doctorTable.Columns.Add("Address");
            doctorTable.Columns.Add("Email");
            doctorTable.Columns.Add("Password");

            // Bind DataTable to DataGridView in each tab
            DOCdataGridView.DataSource = doctorTable;
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


                string query = "SELECT * FROM Patient";
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

        private void docAdd_Click(object sender, EventArgs e)
        {
            if (docname.Text == "" ||
                !IsValidCNIC(docCnic.Text) ||
             // docAge.Text == "" ||
                docGen.SelectedIndex == -1 ||
                docDOB.Value == DateTime.MinValue ||
                docAddress.Text == "" ||
                !IsValidEmail(docEmail.Text) ||
                docPass.Text == "" ||
                docConpass.Text == "" 

                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                if (docPass.Text == docConpass.Text)
                {
                    int age=CalculateAge(docDOB.Value);
                    // Check if the database connection is not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            // wrtiting query
                            string InsertDate = "INSERT INTO Patient VALUES (:Name , :CNIC , :Age , :Gender , :DOB , :Address , :Email , :Password )";
                            // Create a new OracleCommand object with the SQL query and the connection.
                            using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                            {
                                cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = docname.Text;
                                cmd.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = docCnic.Text;
                                cmd.Parameters.Add("Age", OracleDbType.Int32).Value = age;
                                cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = docGen.SelectedItem.ToString();
                                cmd.Parameters.Add("DOB", OracleDbType.Date).Value = docDOB.Value.Date;
                                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = docAddress.Text;
                                cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = docEmail.Text;
                                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = docPass.Text;


                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected >= 0)
                                {
                                    MessageBox.Show("Record inserted  Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh DataGridView to show newly added data
                                    DocFillDataGridView();

                                }
                                else
                                {
                                    MessageBox.Show("Insertion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("Password and Conform Password must be same!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    docPass.Clear();
                    docConpass.Clear();
                    docPass.Focus();
                }
            }
        }

        private void docupdate_Click(object sender, EventArgs e)
        {
            if (docname.Text == "" ||
                !IsValidCNIC(docCnic.Text) ||
              //  docAge.Text == "" ||
                docGen.SelectedIndex == -1 ||
                docDOB.Value == DateTime.MinValue ||
                docAddress.Text == "" ||
                !IsValidEmail(docEmail.Text) ||
                docPass.Text == "" ||
                docConpass.Text == ""

                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                int age = CalculateAge(docDOB.Value);
                // Check if the connection is not already open
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        // Define the SQL query for updating the Doctor record
                        string query = "UPDATE Patient SET Name=:name, CNIC=:cnic, Age=:age, Gender=:gen, DOB=:dob, Address=:address, Password=:password WHERE Email=:OldEmail";

                        // Create a new OracleCommand object with the SQL query and the connection
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {

                            // Set parameter values using the TextBox and ComboBox values
                            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = docname.Text;
                            cmd.Parameters.Add("cnic", OracleDbType.Varchar2).Value = docCnic.Text;
                            cmd.Parameters.Add("age", OracleDbType.Int32).Value = age;
                            cmd.Parameters.Add("gen", OracleDbType.Varchar2).Value = docGen.SelectedItem.ToString();
                            cmd.Parameters.Add("dob", OracleDbType.Date).Value = docDOB.Value.Date;
                            cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = docAddress.Text;
                            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = docPass.Text;
                            cmd.Parameters.Add("OldEmail", OracleDbType.Varchar2).Value = tempEmail;



                            // MessageBox.Show(docEmail.Text);
                            // Execute the update operation
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh DataGridView to reflect the changes
                                DocFillDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("No records were updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Updating Record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection after updating
                        con.Close();
                    }
                }
            }
            
        }

        private void docdelete_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    // Define the SQL query for updating the Doctor record
                    string updateQuery = "DELETE FROM Patient WHERE Email = :email";

                    // Create a new OracleCommand object with the SQL query and the connection
                    using (OracleCommand cmd = new OracleCommand(updateQuery, con))
                    {
                        // Set parameter values using the TextBox and ComboBox values

                        cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = tempEmail.ToString(); // Use the stored email value


                        // Execute the update operation
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted  Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh DataGridView to reflect the changes
                            DocFillDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Updating Record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection after updating
                    con.Close();
                }
            }
        }

        private void docreset_Click(object sender, EventArgs e)
        {
            docname.Text = "";
            docCnic.Text = "";
            //docAge.Text = "";
            docGen.SelectedIndex = -1;
            docDOB.Value = DateTime.Today;
            docAddress.Text = "";
            docEmail.Text = "";
            docPass.Text = "";
            docConpass.Text = "";

        }

        private void homebtn1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(adminemail);
            adminHome.Show();
            this.Hide();

        }

        private void DOCdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            docname.Text = DOCdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            docCnic.Text = DOCdataGridView.SelectedRows[0].Cells[1].Value.ToString();
           // docAge.Text = DOCdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            docGen.Text = DOCdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            docDOB.Text = DOCdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            docAddress.Text = DOCdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            docEmail.Text = DOCdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            tempEmail = DOCdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            docPass.Text = DOCdataGridView.SelectedRows[0].Cells[7].Value.ToString();

        }
    }
}
