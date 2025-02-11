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

namespace Database_project
{
    public partial class ManageEmp : Form
    {
        string tempEmail;
        private string adminemail;
        OracleConnection con;
        DataTable doctorTable;
        DataTable RPTTable;
        DataTable CSTable;

        public ManageEmp(string adminEmail)
        {
            InitializeComponent();
            this.adminemail = adminEmail;
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

        private void doctab_Click(object sender, EventArgs e)
        {
            doctorTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            doctorTable.Columns.Add("Name");
            doctorTable.Columns.Add("CNIC");
            doctorTable.Columns.Add("Age", typeof(int));
            doctorTable.Columns.Add("Gender");
            doctorTable.Columns.Add("DOB", typeof(DateTime));
            doctorTable.Columns.Add("Address");
            doctorTable.Columns.Add("Experience", typeof(int));
            doctorTable.Columns.Add("Email");
            doctorTable.Columns.Add("Password");
            doctorTable.Columns.Add("Job Status");
            // Bind DataTable to DataGridView in each tab
            DOCdataGridView.DataSource = doctorTable;
            // Fetch existing data from the database and display in DataGridView
            DocFillDataGridView();

        }

        private void receptab_Click(object sender, EventArgs e)
        {
            //********************Receptionist data grid*********************
            RPTTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            RPTTable.Columns.Add("Name");
            RPTTable.Columns.Add("CNIC");
            RPTTable.Columns.Add("Age", typeof(int));
            RPTTable.Columns.Add("Gender");
            RPTTable.Columns.Add("DOB", typeof(DateTime));
            RPTTable.Columns.Add("Address");
            RPTTable.Columns.Add("Experience", typeof(int));
            RPTTable.Columns.Add("Email");
            RPTTable.Columns.Add("Password");
            RPTTable.Columns.Add("Job Status");
            // Bind DataTable to DataGridView in each tab
            RPTdataGridView.DataSource = RPTTable;
            // Fetch existing data from the database and display in DataGridView
            RPTFillDataGridView();

        }

        private void customersupporttab_Click(object sender, EventArgs e)
        {
            //********************Customer Support Staff data grid*********************
            CSTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            CSTable.Columns.Add("Name");
            CSTable.Columns.Add("CNIC");
            CSTable.Columns.Add("Age", typeof(int));
            CSTable.Columns.Add("Gender");
            CSTable.Columns.Add("DOB", typeof(DateTime));
            CSTable.Columns.Add("Address");
            CSTable.Columns.Add("Experience", typeof(int));
            CSTable.Columns.Add("Email");
            CSTable.Columns.Add("Password");
            CSTable.Columns.Add("Job Status");
            // Bind DataTable to DataGridView in each tab
            CSdataGridView.DataSource = CSTable;
            // Fetch existing data from the database and display in DataGridView
            CSFillDataGridView();
        }

        private void ManageEmp_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);

        
            

        }

        private void DocFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                
                string query = "SELECT * FROM Doctor";
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

        private void RPTFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT * FROM Receptionist";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                RPTTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    RPTTable.Rows.Add(row.ItemArray);
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

        private void CSFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT * FROM Customer_support_Staff";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CSTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    CSTable.Rows.Add(row.ItemArray);
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
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void patientReset_Click(object sender, EventArgs e)
        {

        }

        private void docSubmit_Click(object sender, EventArgs e)
        {
            if (docname.Text == "" ||
                !IsValidCNIC(docCnic.Text) ||
               // docAge.Text == "" ||
                docGen.SelectedIndex == -1 ||
                docDOB.Value == DateTime.MinValue ||
                docAddress.Text == "" ||
                !IsValidEmail(docEmail.Text) ||
                docPass.Text == "" ||
                docConpass.Text == ""||
                DOCjob.SelectedIndex==-1
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                if (docPass.Text == docConpass.Text)
                {
                    int age = CalculateAge(docDOB.Value);
                    // Check if the database connection is not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            // wrtiting query
                            string InsertDate = "INSERT INTO Doctor VALUES (:Name , :CNIC , :Age , :Gender , :DOB , :Address , :Experience , :Email , :Password , :JOB)";
                            // Create a new OracleCommand object with the SQL query and the connection.
                            using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                            {
                                cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = docname.Text;
                                cmd.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = docCnic.Text;
                                cmd.Parameters.Add("Age", OracleDbType.Int32).Value = age;
                                cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = docGen.SelectedItem.ToString();
                                cmd.Parameters.Add("DOB", OracleDbType.Date).Value = docDOB.Value.Date;
                                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = docAddress.Text;
                                cmd.Parameters.Add("Experience", OracleDbType.Int32).Value = docExp.Text;
                                cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = docEmail.Text;
                                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = docPass.Text;
                                cmd.Parameters.Add("JOB", OracleDbType.Varchar2).Value = DOCjob.SelectedItem.ToString();

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
                // docAge.Text == "" ||
                docGen.SelectedIndex == -1 ||
                docDOB.Value == DateTime.MinValue ||
                docAddress.Text == "" ||
                !IsValidEmail(docEmail.Text) ||
                docPass.Text == "" ||
                docConpass.Text == "" ||
                DOCjob.SelectedIndex == -1
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
                        string query = "UPDATE Doctor SET Name=:name, CNIC=:cnic, Age=:age, Gender=:gen, DOB=:dob, Address=:address, Experience=:exp, Password=:password WHERE Email=:OldEmail";

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
                            cmd.Parameters.Add("exp", OracleDbType.Int32).Value = docExp.Text;
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
            // Check if the connection is not already open
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    // Define the SQL query for updating the Doctor record
                    string updateQuery = "DELETE FROM Doctor WHERE Email = :email";

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
           // docAge.Text = "";
            docGen.SelectedIndex = -1;
            docDOB.Value = DateTime.Today;
            docAddress.Text = "";
            docExp.Text = "";
            docEmail.Text = "";
            docPass.Text = "";
            docConpass.Text = "";
            DOCjob.SelectedIndex = -1;
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
            docExp.Text = DOCdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            docEmail.Text = DOCdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            tempEmail = DOCdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            docPass.Text = DOCdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            DOCjob.Text = DOCdataGridView.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void RPTaddbtn_Click(object sender, EventArgs e)
        {
            if (RPTnametxt.Text == "" ||
               !IsValidCNIC(RPTcnictxt.Text) ||
              // RPTagetxt.Text == "" ||
               RPTgen.SelectedIndex == -1 ||
               RPTdob.Value == DateTime.MinValue ||
               RPTaddresstxt.Text == "" ||
               !IsValidEmail(RPTemailtxt.Text) ||
               RPTpasstxt.Text == "" ||
               RPTconpasstxt.Text == "" ||
               RPTjob.SelectedIndex == -1
               )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                if (RPTpasstxt.Text == RPTconpasstxt.Text)
                {
                    int age = CalculateAge(RPTdob.Value);
                    // Check if the database connection is not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            // wrtiting query
                            string InsertDate = "INSERT INTO Receptionist VALUES (:Name , :CNIC , :Age , :Gender , :DOB , :Address , :Experience , :Email , :Password , :JOB)";
                            // Create a new OracleCommand object with the SQL query and the connection.
                            using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                            {
                                cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = RPTnametxt.Text;
                                cmd.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = RPTcnictxt.Text;
                                cmd.Parameters.Add("Age", OracleDbType.Int32).Value = age;
                                cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = RPTgen.SelectedItem.ToString();
                                cmd.Parameters.Add("DOB", OracleDbType.Date).Value = RPTdob.Value.Date;
                                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = RPTaddresstxt.Text;
                                cmd.Parameters.Add("Experience", OracleDbType.Int32).Value =RPTexptxt.Text;
                                cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = RPTemailtxt.Text;
                                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = RPTpasstxt.Text;
                                cmd.Parameters.Add("JOB", OracleDbType.Varchar2).Value = RPTjob.SelectedItem.ToString();

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected >= 0)
                                {
                                    MessageBox.Show("Record inserted  Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh DataGridView to show newly added data
                                    RPTFillDataGridView();

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
                    RPTpasstxt.Clear();
                    RPTconpasstxt.Clear();
                    RPTpasstxt.Focus();
                }
            }
        }

        private void RPTupdatebtn_Click(object sender, EventArgs e)
        {
            if (RPTnametxt.Text == "" ||
               !IsValidCNIC(RPTcnictxt.Text) ||
              //  RPTagetxt.Text == "" ||
                RPTgen.SelectedIndex == -1 ||
                RPTdob.Value == DateTime.MinValue ||
                RPTaddresstxt.Text == "" ||
                !IsValidEmail(RPTemailtxt.Text) ||
                RPTpasstxt.Text == "" ||
                RPTconpasstxt.Text == "" ||
                RPTjob.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                int age = CalculateAge(RPTdob.Value);
                // Check if the connection is not already open
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        // Define the SQL query for updating the Doctor record
                        string query = "UPDATE Receptionist SET Name=:name, CNIC=:cnic, Age=:age, Gender=:gen, DOB=:dob, Address=:address, Experience=:exp, Password=:password WHERE Email=:OldEmail";

                        // Create a new OracleCommand object with the SQL query and the connection
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {

                            // Set parameter values using the TextBox and ComboBox values
                            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = RPTnametxt.Text;
                            cmd.Parameters.Add("cnic", OracleDbType.Varchar2).Value = RPTcnictxt.Text;
                            cmd.Parameters.Add("age", OracleDbType.Int32).Value = age;
                            cmd.Parameters.Add("gen", OracleDbType.Varchar2).Value = RPTgen.SelectedItem.ToString();
                            cmd.Parameters.Add("dob", OracleDbType.Date).Value = RPTdob.Value.Date;
                            cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = RPTaddresstxt.Text;
                            cmd.Parameters.Add("exp", OracleDbType.Int32).Value = RPTexptxt.Text;
                            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = RPTpasstxt.Text;
                            cmd.Parameters.Add("OldEmail", OracleDbType.Varchar2).Value = tempEmail;



                            // MessageBox.Show(docEmail.Text);
                            // Execute the update operation
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh DataGridView to reflect the changes
                                RPTFillDataGridView();
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

        private void RPTdeletebtn_Click(object sender, EventArgs e)
        {
            // Check if the connection is not already open
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    // Define the SQL query for updating the Doctor record
                    string updateQuery = "DELETE FROM Receptionist WHERE Email = :email";

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
                            RPTFillDataGridView();
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

        private void RPTresetbtn_Click(object sender, EventArgs e)
        {
            RPTnametxt.Text = "";
            RPTcnictxt.Text = "";
           // RPTagetxt.Text = "";
            RPTgen.SelectedIndex = -1;
            RPTdob.Value = DateTime.Today;
            RPTaddresstxt.Text = "";
            RPTexptxt.Text = "";
            RPTemailtxt.Text = "";
            RPTpasstxt.Text = "";
            RPTconpasstxt.Text = "";
            RPTjob.SelectedIndex = -1;
        }

        private void RPThomebtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(adminemail);
            adminHome.Show();
            this.Hide();
        }

        private void RPTdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RPTnametxt.Text = RPTdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            RPTcnictxt.Text = RPTdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //RPTagetxt.Text = RPTdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            RPTgen.Text = RPTdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            RPTdob.Text = RPTdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            RPTaddresstxt.Text = RPTdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            RPTexptxt.Text = RPTdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            RPTemailtxt.Text = RPTdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            tempEmail = RPTdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            RPTpasstxt.Text = RPTdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            RPTjob.Text = RPTdataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void CSaddbtn_Click(object sender, EventArgs e)
        {
            if (CSnametxt.Text == "" ||
              !IsValidCNIC(CScnictxt.Text) ||
              //CSagetxt.Text == "" ||
              CSgentxt.SelectedIndex == -1 ||
              CSdob.Value == DateTime.MinValue ||
              CSaddresstxt.Text == "" ||
              !IsValidEmail(CSemailtxt.Text) ||
              CSpasstxt.Text == "" ||
              CSconpasstxt.Text == "" ||
              CSjob.SelectedIndex == -1
              )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                if (CSpasstxt.Text == CSconpasstxt.Text)
                {
                    int age = CalculateAge(CSdob.Value);
                    // Check if the database connection is not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            // wrtiting query
                            string InsertDate = "INSERT INTO  Customer_support_Staff VALUES (:Name , :CNIC , :Age , :Gender , :DOB , :Address , :Experience , :Email , :Password , :JOB)";
                            // Create a new OracleCommand object with the SQL query and the connection.
                            using (OracleCommand cmd = new OracleCommand(InsertDate, con))
                            {
                                cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = CSnametxt.Text;
                                cmd.Parameters.Add("CNIC", OracleDbType.Varchar2).Value = CScnictxt.Text;
                                cmd.Parameters.Add("Age", OracleDbType.Int32).Value = age;                                cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = CSgentxt.SelectedItem.ToString();
                                cmd.Parameters.Add("DOB", OracleDbType.Date).Value = CSdob.Value.Date;
                                cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = CSaddresstxt.Text;
                                cmd.Parameters.Add("Experience", OracleDbType.Int32).Value = CSexptxt.Text;
                                cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = CSemailtxt.Text;
                                cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = CSpasstxt.Text;
                                cmd.Parameters.Add("JOB", OracleDbType.Varchar2).Value = CSjob.SelectedItem.ToString();

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected >= 0)
                                {
                                    MessageBox.Show("Record inserted  Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh DataGridView to show newly added data
                                    CSFillDataGridView();

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
                    CSpasstxt.Clear();
                    CSconpasstxt.Clear();
                    CSpasstxt.Focus();
                }
            }
        }

        private void CSupdatebtn_Click(object sender, EventArgs e)
        {
            if (CSnametxt.Text == "" ||
            !IsValidCNIC(CScnictxt.Text) ||
            //CSagetxt.Text == "" ||
            CSgentxt.SelectedIndex == -1 ||
            CSdob.Value == DateTime.MinValue ||
            CSaddresstxt.Text == "" ||
           !IsValidEmail(CSemailtxt.Text) ||
            CSpasstxt.Text == "" ||
            CSconpasstxt.Text == "" ||
            CSjob.SelectedIndex == -1
             )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                int age = CalculateAge(CSdob.Value);
                // Check if the connection is not already open
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        // Define the SQL query for updating the Doctor record
                        string query = "UPDATE Customer_support_Staff SET Name=:name, CNIC=:cnic, Age=:age, Gender=:gen, DOB=:dob, Address=:address, Experience=:exp, Password=:password WHERE Email=:OldEmail";

                        // Create a new OracleCommand object with the SQL query and the connection
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {

                            // Set parameter values using the TextBox and ComboBox values
                            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = CSnametxt.Text;
                            cmd.Parameters.Add("cnic", OracleDbType.Varchar2).Value = CScnictxt.Text;
                            cmd.Parameters.Add("age", OracleDbType.Int32).Value = age;
                            cmd.Parameters.Add("gen", OracleDbType.Varchar2).Value = CSgentxt.SelectedItem.ToString();
                            cmd.Parameters.Add("dob", OracleDbType.Date).Value = CSdob.Value.Date;
                            cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = CSaddresstxt.Text;
                            cmd.Parameters.Add("exp", OracleDbType.Int32).Value = CSexptxt.Text;
                            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = CSpasstxt.Text;
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

        private void CSdeletebtn_Click(object sender, EventArgs e)
        {
            // Check if the connection is not already open
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    // Define the SQL query for updating the Doctor record
                    string updateQuery = "DELETE FROM Customer_support_Staff  WHERE Email = :email";

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
                            CSFillDataGridView();
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

        private void CSresetbtn_Click(object sender, EventArgs e)
        {
            CSnametxt.Text = "";
            CScnictxt.Text = "";
            //CSagetxt.Text = "";
            CSgentxt.SelectedIndex = -1;
            CSdob.Value = DateTime.Today;
            CSaddresstxt.Text = "";
            CSexptxt.Text = "";
            CSemailtxt.Text = "";
            CSpasstxt.Text = "";
            CSconpasstxt.Text = "";
            CSjob.SelectedIndex = -1;
        }

        private void CShomebtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(adminemail);
            adminHome.Show();
            this.Hide();
        }

        private void CSdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CSnametxt.Text = CSdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            CScnictxt.Text = CSdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //CSagetxt.Text = CSdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            CSgentxt.Text = CSdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            CSdob.Text = CSdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            CSaddresstxt.Text = CSdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            CSexptxt.Text = CSdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            CSemailtxt.Text = CSdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            tempEmail = CSdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            CSpasstxt.Text = CSdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            CSjob.Text = CSdataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
