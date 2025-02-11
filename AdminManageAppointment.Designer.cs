namespace Database_project
{
    partial class AdminManageAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageAppointment));
            this.AppointmentdataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientEmail = new System.Windows.Forms.TextBox();
            this.doctorEmail = new System.Windows.Forms.TextBox();
            this.appointmentTime = new System.Windows.Forms.TextBox();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.BookAppointmentBtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patienttab = new System.Windows.Forms.TabPage();
            this.patientdataGrid = new System.Windows.Forms.DataGridView();
            this.doctortab = new System.Windows.Forms.TabPage();
            this.doctordataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.appointstatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.patienttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientdataGrid)).BeginInit();
            this.doctortab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentdataGrid
            // 
            this.AppointmentdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGrid.Location = new System.Drawing.Point(-1, 299);
            this.AppointmentdataGrid.Name = "AppointmentdataGrid";
            this.AppointmentdataGrid.Size = new System.Drawing.Size(801, 150);
            this.AppointmentdataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(22, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Appointment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(24, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doctor Email";
            // 
            // patientEmail
            // 
            this.patientEmail.Location = new System.Drawing.Point(117, 73);
            this.patientEmail.Name = "patientEmail";
            this.patientEmail.Size = new System.Drawing.Size(160, 20);
            this.patientEmail.TabIndex = 5;
            // 
            // doctorEmail
            // 
            this.doctorEmail.Location = new System.Drawing.Point(117, 120);
            this.doctorEmail.Name = "doctorEmail";
            this.doctorEmail.Size = new System.Drawing.Size(160, 20);
            this.doctorEmail.TabIndex = 6;
            // 
            // appointmentTime
            // 
            this.appointmentTime.Location = new System.Drawing.Point(117, 216);
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(160, 20);
            this.appointmentTime.TabIndex = 7;
            // 
            // appointmentDate
            // 
            this.appointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDate.Location = new System.Drawing.Point(117, 170);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(160, 20);
            this.appointmentDate.TabIndex = 8;
            // 
            // BookAppointmentBtn
            // 
            this.BookAppointmentBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAppointmentBtn.Location = new System.Drawing.Point(117, 396);
            this.BookAppointmentBtn.Name = "BookAppointmentBtn";
            this.BookAppointmentBtn.Size = new System.Drawing.Size(157, 27);
            this.BookAppointmentBtn.TabIndex = 9;
            this.BookAppointmentBtn.Text = "Book Appointment";
            this.BookAppointmentBtn.UseVisualStyleBackColor = true;
            this.BookAppointmentBtn.Click += new System.EventHandler(this.BookAppointmentBtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(715, 422);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(85, 27);
            this.homebtn.TabIndex = 10;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patienttab);
            this.tabControl1.Controls.Add(this.doctortab);
            this.tabControl1.Location = new System.Drawing.Point(330, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 205);
            this.tabControl1.TabIndex = 11;
            // 
            // patienttab
            // 
            this.patienttab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patienttab.Controls.Add(this.patientdataGrid);
            this.patienttab.Location = new System.Drawing.Point(4, 22);
            this.patienttab.Name = "patienttab";
            this.patienttab.Padding = new System.Windows.Forms.Padding(3);
            this.patienttab.Size = new System.Drawing.Size(330, 179);
            this.patienttab.TabIndex = 0;
            this.patienttab.Text = "Patient";
            this.patienttab.Click += new System.EventHandler(this.patienttab_Click);
            // 
            // patientdataGrid
            // 
            this.patientdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientdataGrid.Location = new System.Drawing.Point(0, 0);
            this.patientdataGrid.Name = "patientdataGrid";
            this.patientdataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientdataGrid.Size = new System.Drawing.Size(330, 150);
            this.patientdataGrid.TabIndex = 0;
            this.patientdataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientdataGrid_CellClick);
            this.patientdataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientdataGrid_CellContentClick);
            // 
            // doctortab
            // 
            this.doctortab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctortab.Controls.Add(this.doctordataGrid);
            this.doctortab.Location = new System.Drawing.Point(4, 22);
            this.doctortab.Name = "doctortab";
            this.doctortab.Padding = new System.Windows.Forms.Padding(3);
            this.doctortab.Size = new System.Drawing.Size(317, 179);
            this.doctortab.TabIndex = 1;
            this.doctortab.Text = "Doctor";
            this.doctortab.Click += new System.EventHandler(this.doctortab_Click);
            // 
            // doctordataGrid
            // 
            this.doctordataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctordataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctordataGrid.Location = new System.Drawing.Point(0, 1);
            this.doctordataGrid.Name = "doctordataGrid";
            this.doctordataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctordataGrid.Size = new System.Drawing.Size(317, 150);
            this.doctordataGrid.TabIndex = 1;
            this.doctordataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctordataGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(24, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Appointment Status";
            // 
            // appointstatus
            // 
            this.appointstatus.FormattingEnabled = true;
            this.appointstatus.Items.AddRange(new object[] {
            "Pending",
            "Attended"});
            this.appointstatus.Location = new System.Drawing.Point(117, 262);
            this.appointstatus.Name = "appointstatus";
            this.appointstatus.Size = new System.Drawing.Size(160, 21);
            this.appointstatus.TabIndex = 13;
            // 
            // AdminManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.BookAppointmentBtn);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.appointmentTime);
            this.Controls.Add(this.doctorEmail);
            this.Controls.Add(this.patientEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentdataGrid);
            this.Name = "AdminManageAppointment";
            this.Text = "AdminManageAppointment";
            this.Load += new System.EventHandler(this.AdminManageAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.patienttab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientdataGrid)).EndInit();
            this.doctortab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentdataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientEmail;
        private System.Windows.Forms.TextBox doctorEmail;
        private System.Windows.Forms.TextBox appointmentTime;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private System.Windows.Forms.Button BookAppointmentBtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patienttab;
        private System.Windows.Forms.TabPage doctortab;
        private System.Windows.Forms.DataGridView patientdataGrid;
        private System.Windows.Forms.DataGridView doctordataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox appointstatus;
    }
}