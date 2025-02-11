namespace Database_project
{
    partial class CustomerSuppHome
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
            this.chkprofilebtn = new System.Windows.Forms.Button();
            this.viewfeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkprofilebtn
            // 
            this.chkprofilebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkprofilebtn.Location = new System.Drawing.Point(77, 133);
            this.chkprofilebtn.Name = "chkprofilebtn";
            this.chkprofilebtn.Size = new System.Drawing.Size(124, 27);
            this.chkprofilebtn.TabIndex = 2;
            this.chkprofilebtn.Text = "Check Profile";
            this.chkprofilebtn.UseVisualStyleBackColor = true;
            this.chkprofilebtn.Click += new System.EventHandler(this.chkprofilebtn_Click);
            // 
            // viewfeedback
            // 
            this.viewfeedback.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewfeedback.Location = new System.Drawing.Point(299, 133);
            this.viewfeedback.Name = "viewfeedback";
            this.viewfeedback.Size = new System.Drawing.Size(124, 27);
            this.viewfeedback.TabIndex = 3;
            this.viewfeedback.Text = "View Feedback";
            this.viewfeedback.UseVisualStyleBackColor = true;
            this.viewfeedback.Click += new System.EventHandler(this.viewfeedback_Click);
            // 
            // CustomerSuppHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewfeedback);
            this.Controls.Add(this.chkprofilebtn);
            this.Name = "CustomerSuppHome";
            this.Text = "CustomerSuppHome";
            this.Load += new System.EventHandler(this.CustomerSuppHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chkprofilebtn;
        private System.Windows.Forms.Button viewfeedback;
    }
}