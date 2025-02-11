namespace Database_project
{
    partial class DocHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocHome));
            this.DocChkProbtn = new System.Windows.Forms.Button();
            this.viewRecord = new System.Windows.Forms.Button();
            this.mngAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocChkProbtn
            // 
            this.DocChkProbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocChkProbtn.Location = new System.Drawing.Point(174, 63);
            this.DocChkProbtn.Name = "DocChkProbtn";
            this.DocChkProbtn.Size = new System.Drawing.Size(119, 38);
            this.DocChkProbtn.TabIndex = 0;
            this.DocChkProbtn.Text = "Check Profile";
            this.DocChkProbtn.UseVisualStyleBackColor = true;
            this.DocChkProbtn.Click += new System.EventHandler(this.DocChkProbtn_Click);
            // 
            // viewRecord
            // 
            this.viewRecord.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecord.Location = new System.Drawing.Point(174, 126);
            this.viewRecord.Name = "viewRecord";
            this.viewRecord.Size = new System.Drawing.Size(131, 54);
            this.viewRecord.TabIndex = 1;
            this.viewRecord.Text = "View Medical Record";
            this.viewRecord.UseVisualStyleBackColor = true;
            this.viewRecord.Click += new System.EventHandler(this.viewRecord_Click);
            // 
            // mngAppointment
            // 
            this.mngAppointment.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngAppointment.Location = new System.Drawing.Point(174, 208);
            this.mngAppointment.Name = "mngAppointment";
            this.mngAppointment.Size = new System.Drawing.Size(135, 54);
            this.mngAppointment.TabIndex = 2;
            this.mngAppointment.Text = "Manage Appointment";
            this.mngAppointment.UseVisualStyleBackColor = true;
            this.mngAppointment.Click += new System.EventHandler(this.mngAppointment_Click);
            // 
            // DocHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mngAppointment);
            this.Controls.Add(this.viewRecord);
            this.Controls.Add(this.DocChkProbtn);
            this.Name = "DocHome";
            this.Text = "DocHome";
            this.Load += new System.EventHandler(this.DocHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DocChkProbtn;
        private System.Windows.Forms.Button viewRecord;
        private System.Windows.Forms.Button mngAppointment;
    }
}