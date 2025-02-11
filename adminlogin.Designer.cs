namespace Database_project
{
    partial class adminlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.passcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(215, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(154, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // usernamtxt
            // 
            this.usernamtxt.Location = new System.Drawing.Point(245, 129);
            this.usernamtxt.Name = "usernamtxt";
            this.usernamtxt.Size = new System.Drawing.Size(169, 20);
            this.usernamtxt.TabIndex = 0;
            this.usernamtxt.TextChanged += new System.EventHandler(this.usernamtxt_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Blue;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginbtn.Location = new System.Drawing.Point(245, 259);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(200, 35);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(154, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(245, 188);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(169, 20);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // passcheck
            // 
            this.passcheck.AutoSize = true;
            this.passcheck.BackColor = System.Drawing.Color.Transparent;
            this.passcheck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.passcheck.Location = new System.Drawing.Point(245, 214);
            this.passcheck.Name = "passcheck";
            this.passcheck.Size = new System.Drawing.Size(119, 21);
            this.passcheck.TabIndex = 8;
            this.passcheck.Text = "Show password";
            this.passcheck.UseVisualStyleBackColor = false;
            this.passcheck.CheckedChanged += new System.EventHandler(this.passcheck_CheckedChanged);
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passcheck);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.usernamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminlogin";
            this.Text = "adminlogin";
            this.Load += new System.EventHandler(this.adminlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.CheckBox passcheck;
    }
}