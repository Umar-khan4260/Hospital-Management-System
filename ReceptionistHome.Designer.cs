namespace Database_project
{
    partial class ReceptionistHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistHome));
            this.chkprofilebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkprofilebtn
            // 
            this.chkprofilebtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkprofilebtn.Location = new System.Drawing.Point(60, 147);
            this.chkprofilebtn.Name = "chkprofilebtn";
            this.chkprofilebtn.Size = new System.Drawing.Size(124, 27);
            this.chkprofilebtn.TabIndex = 1;
            this.chkprofilebtn.Text = "Check Profile";
            this.chkprofilebtn.UseVisualStyleBackColor = true;
            this.chkprofilebtn.Click += new System.EventHandler(this.chkprofilebtn_Click);
            // 
            // ReceptionistHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkprofilebtn);
            this.Name = "ReceptionistHome";
            this.Text = "ReceptionistHome";
            this.Load += new System.EventHandler(this.ReceptionistHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chkprofilebtn;
    }
}