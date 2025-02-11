namespace Database_project
{
    partial class Doclogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doclogin));
            this.Docpasscheck = new System.Windows.Forms.CheckBox();
            this.Docpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Docloginbtn = new System.Windows.Forms.Button();
            this.Docusernamtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Docpasscheck
            // 
            this.Docpasscheck.AutoSize = true;
            this.Docpasscheck.BackColor = System.Drawing.Color.Transparent;
            this.Docpasscheck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docpasscheck.Location = new System.Drawing.Point(373, 217);
            this.Docpasscheck.Name = "Docpasscheck";
            this.Docpasscheck.Size = new System.Drawing.Size(119, 21);
            this.Docpasscheck.TabIndex = 23;
            this.Docpasscheck.Text = "Show password";
            this.Docpasscheck.UseVisualStyleBackColor = false;
            this.Docpasscheck.CheckedChanged += new System.EventHandler(this.Docpasscheck_CheckedChanged);
            // 
            // Docpasstxt
            // 
            this.Docpasstxt.Location = new System.Drawing.Point(373, 179);
            this.Docpasstxt.Name = "Docpasstxt";
            this.Docpasstxt.Size = new System.Drawing.Size(169, 20);
            this.Docpasstxt.TabIndex = 18;
            this.Docpasstxt.UseSystemPasswordChar = true;
            this.Docpasstxt.TextChanged += new System.EventHandler(this.Docpasstxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // Docloginbtn
            // 
            this.Docloginbtn.BackColor = System.Drawing.Color.Blue;
            this.Docloginbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docloginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Docloginbtn.Location = new System.Drawing.Point(356, 244);
            this.Docloginbtn.Name = "Docloginbtn";
            this.Docloginbtn.Size = new System.Drawing.Size(205, 35);
            this.Docloginbtn.TabIndex = 20;
            this.Docloginbtn.Text = "Login";
            this.Docloginbtn.UseVisualStyleBackColor = false;
            this.Docloginbtn.Click += new System.EventHandler(this.Docloginbtn_Click);
            // 
            // Docusernamtxt
            // 
            this.Docusernamtxt.Location = new System.Drawing.Point(373, 137);
            this.Docusernamtxt.Name = "Docusernamtxt";
            this.Docusernamtxt.Size = new System.Drawing.Size(169, 20);
            this.Docusernamtxt.TabIndex = 17;
            this.Docusernamtxt.TextChanged += new System.EventHandler(this.Docusernamtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hospital Management System";
            // 
            // Doclogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Docpasscheck);
            this.Controls.Add(this.Docpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Docloginbtn);
            this.Controls.Add(this.Docusernamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doclogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doclogin";
            this.Load += new System.EventHandler(this.Doclogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Docpasscheck;
        private System.Windows.Forms.TextBox Docpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Docloginbtn;
        private System.Windows.Forms.TextBox Docusernamtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}