namespace Database_project
{
    partial class CustomerSuppLogin
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
            this.CSpasscheck = new System.Windows.Forms.CheckBox();
            this.CSpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CSloginbtn = new System.Windows.Forms.Button();
            this.CSusernamtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CSpasscheck
            // 
            this.CSpasscheck.AutoSize = true;
            this.CSpasscheck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSpasscheck.Location = new System.Drawing.Point(365, 226);
            this.CSpasscheck.Name = "CSpasscheck";
            this.CSpasscheck.Size = new System.Drawing.Size(119, 21);
            this.CSpasscheck.TabIndex = 37;
            this.CSpasscheck.Text = "Show password";
            this.CSpasscheck.UseVisualStyleBackColor = true;
            this.CSpasscheck.CheckedChanged += new System.EventHandler(this.CSpasscheck_CheckedChanged);
            // 
            // CSpasstxt
            // 
            this.CSpasstxt.Location = new System.Drawing.Point(365, 188);
            this.CSpasstxt.Name = "CSpasstxt";
            this.CSpasstxt.Size = new System.Drawing.Size(169, 20);
            this.CSpasstxt.TabIndex = 32;
            this.CSpasstxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Password";
            // 
            // CSloginbtn
            // 
            this.CSloginbtn.BackColor = System.Drawing.Color.Blue;
            this.CSloginbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSloginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CSloginbtn.Location = new System.Drawing.Point(348, 253);
            this.CSloginbtn.Name = "CSloginbtn";
            this.CSloginbtn.Size = new System.Drawing.Size(205, 35);
            this.CSloginbtn.TabIndex = 34;
            this.CSloginbtn.Text = "Login";
            this.CSloginbtn.UseVisualStyleBackColor = false;
            this.CSloginbtn.Click += new System.EventHandler(this.CSloginbtn_Click);
            // 
            // CSusernamtxt
            // 
            this.CSusernamtxt.Location = new System.Drawing.Point(365, 146);
            this.CSusernamtxt.Name = "CSusernamtxt";
            this.CSusernamtxt.Size = new System.Drawing.Size(169, 20);
            this.CSusernamtxt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hospital Management System";
            // 
            // CustomerSuppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CSpasscheck);
            this.Controls.Add(this.CSpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CSloginbtn);
            this.Controls.Add(this.CSusernamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSuppLogin";
            this.Text = "CustomerSuppLogin";
            this.Load += new System.EventHandler(this.CustomerSuppLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CSpasscheck;
        private System.Windows.Forms.TextBox CSpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CSloginbtn;
        private System.Windows.Forms.TextBox CSusernamtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}