namespace Database_project
{
    partial class PatientFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFeedback));
            this.doctordataGrid = new System.Windows.Forms.DataGridView();
            this.homebtn = new System.Windows.Forms.Button();
            this.SubmitFeedbackbtn = new System.Windows.Forms.Button();
            this.feedbacktxt = new System.Windows.Forms.TextBox();
            this.doctorEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // doctordataGrid
            // 
            this.doctordataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctordataGrid.Location = new System.Drawing.Point(334, 105);
            this.doctordataGrid.Name = "doctordataGrid";
            this.doctordataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctordataGrid.Size = new System.Drawing.Size(260, 168);
            this.doctordataGrid.TabIndex = 39;
            this.doctordataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctordataGrid_CellClick);
            this.doctordataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctordataGrid_CellContentClick);
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(712, 335);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(85, 27);
            this.homebtn.TabIndex = 36;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // SubmitFeedbackbtn
            // 
            this.SubmitFeedbackbtn.BackColor = System.Drawing.Color.DarkGray;
            this.SubmitFeedbackbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitFeedbackbtn.Location = new System.Drawing.Point(78, 287);
            this.SubmitFeedbackbtn.Name = "SubmitFeedbackbtn";
            this.SubmitFeedbackbtn.Size = new System.Drawing.Size(157, 27);
            this.SubmitFeedbackbtn.TabIndex = 35;
            this.SubmitFeedbackbtn.Text = "Submit Feedback";
            this.SubmitFeedbackbtn.UseVisualStyleBackColor = false;
            this.SubmitFeedbackbtn.Click += new System.EventHandler(this.SubmitFeedbackbtn_Click);
            // 
            // feedbacktxt
            // 
            this.feedbacktxt.Location = new System.Drawing.Point(78, 180);
            this.feedbacktxt.Multiline = true;
            this.feedbacktxt.Name = "feedbacktxt";
            this.feedbacktxt.Size = new System.Drawing.Size(211, 84);
            this.feedbacktxt.TabIndex = 33;
            // 
            // doctorEmail
            // 
            this.doctorEmail.Location = new System.Drawing.Point(78, 115);
            this.doctorEmail.Name = "doctorEmail";
            this.doctorEmail.Size = new System.Drawing.Size(211, 20);
            this.doctorEmail.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Doctor Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Feedback";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "FeedBack";
            // 
            // PatientFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctordataGrid);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.SubmitFeedbackbtn);
            this.Controls.Add(this.feedbacktxt);
            this.Controls.Add(this.doctorEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "PatientFeedback";
            this.Text = "PatientFeedback";
            this.Load += new System.EventHandler(this.PatientFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctordataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctordataGrid;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button SubmitFeedbackbtn;
        private System.Windows.Forms.TextBox feedbacktxt;
        private System.Windows.Forms.TextBox doctorEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}