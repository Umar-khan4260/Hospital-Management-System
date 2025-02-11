namespace Database_project
{
    partial class DocmngAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocmngAppointment));
            this.homebtn = new System.Windows.Forms.Button();
            this.AppointmentdataGridView = new System.Windows.Forms.DataGridView();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(725, 363);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 28);
            this.homebtn.TabIndex = 3;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // AppointmentdataGridView
            // 
            this.AppointmentdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGridView.Location = new System.Drawing.Point(1, 3);
            this.AppointmentdataGridView.Name = "AppointmentdataGridView";
            this.AppointmentdataGridView.Size = new System.Drawing.Size(799, 171);
            this.AppointmentdataGridView.TabIndex = 2;
            this.AppointmentdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentdataGridView_CellClick);
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Attended",
            "Pending"});
            this.statusBox.Location = new System.Drawing.Point(238, 222);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(152, 21);
            this.statusBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appointment Status";
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(165, 310);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(181, 28);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update Appoinment";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // DocmngAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.AppointmentdataGridView);
            this.Name = "DocmngAppointment";
            this.Text = "DocmngAppointment";
            this.Load += new System.EventHandler(this.DocmngAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.DataGridView AppointmentdataGridView;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatebtn;
    }
}