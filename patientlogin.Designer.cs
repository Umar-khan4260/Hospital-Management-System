namespace Database_project
{
    partial class patientlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientlogin));
            this.patientpasscheck = new System.Windows.Forms.CheckBox();
            this.patientpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientloginbtn = new System.Windows.Forms.Button();
            this.patientusernamtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientpasscheck
            // 
            this.patientpasscheck.AutoSize = true;
            this.patientpasscheck.BackColor = System.Drawing.Color.Transparent;
            this.patientpasscheck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientpasscheck.Location = new System.Drawing.Point(193, 212);
            this.patientpasscheck.Name = "patientpasscheck";
            this.patientpasscheck.Size = new System.Drawing.Size(119, 21);
            this.patientpasscheck.TabIndex = 15;
            this.patientpasscheck.Text = "Show password";
            this.patientpasscheck.UseVisualStyleBackColor = false;
            this.patientpasscheck.CheckedChanged += new System.EventHandler(this.patientpasscheck_CheckedChanged);
            // 
            // patientpasstxt
            // 
            this.patientpasstxt.Location = new System.Drawing.Point(193, 186);
            this.patientpasstxt.Name = "patientpasstxt";
            this.patientpasstxt.Size = new System.Drawing.Size(169, 20);
            this.patientpasstxt.TabIndex = 10;
            this.patientpasstxt.UseSystemPasswordChar = true;
            this.patientpasstxt.TextChanged += new System.EventHandler(this.patientpasstxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // patientloginbtn
            // 
            this.patientloginbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.patientloginbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientloginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientloginbtn.Location = new System.Drawing.Point(340, 242);
            this.patientloginbtn.Name = "patientloginbtn";
            this.patientloginbtn.Size = new System.Drawing.Size(88, 35);
            this.patientloginbtn.TabIndex = 12;
            this.patientloginbtn.Text = "Login";
            this.patientloginbtn.UseVisualStyleBackColor = false;
            this.patientloginbtn.Click += new System.EventHandler(this.patientloginbtn_Click);
            // 
            // patientusernamtxt
            // 
            this.patientusernamtxt.Location = new System.Drawing.Point(193, 129);
            this.patientusernamtxt.Name = "patientusernamtxt";
            this.patientusernamtxt.Size = new System.Drawing.Size(169, 20);
            this.patientusernamtxt.TabIndex = 9;
            this.patientusernamtxt.TextChanged += new System.EventHandler(this.patientusernamtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hospital Management System";
            // 
            // patientsignup
            // 
            this.patientsignup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.patientsignup.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsignup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientsignup.Location = new System.Drawing.Point(109, 242);
            this.patientsignup.Name = "patientsignup";
            this.patientsignup.Size = new System.Drawing.Size(88, 35);
            this.patientsignup.TabIndex = 16;
            this.patientsignup.Text = "Sign up";
            this.patientsignup.UseVisualStyleBackColor = false;
            this.patientsignup.Click += new System.EventHandler(this.patientsignup_Click);
            // 
            // patientlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patientsignup);
            this.Controls.Add(this.patientpasscheck);
            this.Controls.Add(this.patientpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientloginbtn);
            this.Controls.Add(this.patientusernamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "patientlogin";
            this.Text = "patientlogin";
            this.Load += new System.EventHandler(this.patientlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox patientpasscheck;
        private System.Windows.Forms.TextBox patientpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button patientloginbtn;
        private System.Windows.Forms.TextBox patientusernamtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientsignup;
    }
}