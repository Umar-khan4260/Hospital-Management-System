namespace Database_project
{
    partial class PatientAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppointment));
            this.appointstatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.BookAppointmentBtn = new System.Windows.Forms.Button();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.appointmentTime = new System.Windows.Forms.TextBox();
            this.doctorEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppointmentdataGrid = new System.Windows.Forms.DataGridView();
            this.doctordataGrid = new System.Windows.Forms.DataGridView();
            this.phn_no = new System.Windows.Forms.Label();
            this.phn_no_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // appointstatus
            // 
            this.appointstatus.FormattingEnabled = true;
            this.appointstatus.Items.AddRange(new object[] {
            "Pending",
            "Attended"});
            this.appointstatus.Location = new System.Drawing.Point(210, 318);
            this.appointstatus.Name = "appointstatus";
            this.appointstatus.Size = new System.Drawing.Size(160, 21);
            this.appointstatus.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(38, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Appointment Status";
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(716, 423);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(85, 27);
            this.homebtn.TabIndex = 24;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // BookAppointmentBtn
            // 
            this.BookAppointmentBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAppointmentBtn.Location = new System.Drawing.Point(118, 397);
            this.BookAppointmentBtn.Name = "BookAppointmentBtn";
            this.BookAppointmentBtn.Size = new System.Drawing.Size(157, 27);
            this.BookAppointmentBtn.TabIndex = 23;
            this.BookAppointmentBtn.Text = "Book Appointment";
            this.BookAppointmentBtn.UseVisualStyleBackColor = true;
            this.BookAppointmentBtn.Click += new System.EventHandler(this.BookAppointmentBtn_Click);
            // 
            // appointmentDate
            // 
            this.appointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDate.Location = new System.Drawing.Point(210, 210);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(160, 20);
            this.appointmentDate.TabIndex = 22;
            // 
            // appointmentTime
            // 
            this.appointmentTime.Location = new System.Drawing.Point(210, 266);
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(160, 20);
            this.appointmentTime.TabIndex = 21;
            // 
            // doctorEmail
            // 
            this.doctorEmail.Location = new System.Drawing.Point(210, 158);
            this.doctorEmail.Name = "doctorEmail";
            this.doctorEmail.Size = new System.Drawing.Size(160, 20);
            this.doctorEmail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Doctor Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(38, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appointment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(38, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Appointment Time";
            // 
            // AppointmentdataGrid
            // 
            this.AppointmentdataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGrid.Location = new System.Drawing.Point(0, 0);
            this.AppointmentdataGrid.Name = "AppointmentdataGrid";
            this.AppointmentdataGrid.Size = new System.Drawing.Size(801, 150);
            this.AppointmentdataGrid.TabIndex = 14;
            // 
            // doctordataGrid
            // 
            this.doctordataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctordataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctordataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctordataGrid.Location = new System.Drawing.Point(541, 156);
            this.doctordataGrid.Name = "doctordataGrid";
            this.doctordataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctordataGrid.Size = new System.Drawing.Size(260, 168);
            this.doctordataGrid.TabIndex = 28;
            this.doctordataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctordataGrid_CellClick);
            // 
            // phn_no
            // 
            this.phn_no.AutoSize = true;
            this.phn_no.BackColor = System.Drawing.Color.Transparent;
            this.phn_no.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phn_no.ForeColor = System.Drawing.SystemColors.Window;
            this.phn_no.Location = new System.Drawing.Point(38, 360);
            this.phn_no.Name = "phn_no";
            this.phn_no.Size = new System.Drawing.Size(82, 19);
            this.phn_no.TabIndex = 29;
            this.phn_no.Text = "Phone No.";
            // 
            // phn_no_txt
            // 
            this.phn_no_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phn_no_txt.Location = new System.Drawing.Point(207, 360);
            this.phn_no_txt.Name = "phn_no_txt";
            this.phn_no_txt.Size = new System.Drawing.Size(160, 20);
            this.phn_no_txt.TabIndex = 30;
            // 
            // PatientAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phn_no_txt);
            this.Controls.Add(this.phn_no);
            this.Controls.Add(this.doctordataGrid);
            this.Controls.Add(this.appointstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.BookAppointmentBtn);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.appointmentTime);
            this.Controls.Add(this.doctorEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppointmentdataGrid);
            this.Name = "PatientAppointment";
            this.Text = "PatientAppointment";
            this.Load += new System.EventHandler(this.PatientAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appointstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button BookAppointmentBtn;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private System.Windows.Forms.TextBox appointmentTime;
        private System.Windows.Forms.TextBox doctorEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AppointmentdataGrid;
        private System.Windows.Forms.DataGridView doctordataGrid;
        private System.Windows.Forms.Label phn_no;
        private System.Windows.Forms.TextBox phn_no_txt;
    }
}