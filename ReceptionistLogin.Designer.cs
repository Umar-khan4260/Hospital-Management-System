namespace Database_project
{
    partial class ReceptionistLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistLogin));
            this.RPTpasscheck = new System.Windows.Forms.CheckBox();
            this.RPTpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RPTloginbtn = new System.Windows.Forms.Button();
            this.RPTusernamtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RPTpasscheck
            // 
            this.RPTpasscheck.AutoSize = true;
            this.RPTpasscheck.BackColor = System.Drawing.Color.Transparent;
            this.RPTpasscheck.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPTpasscheck.Location = new System.Drawing.Point(366, 221);
            this.RPTpasscheck.Name = "RPTpasscheck";
            this.RPTpasscheck.Size = new System.Drawing.Size(119, 21);
            this.RPTpasscheck.TabIndex = 30;
            this.RPTpasscheck.Text = "Show password";
            this.RPTpasscheck.UseVisualStyleBackColor = false;
            this.RPTpasscheck.CheckedChanged += new System.EventHandler(this.RPTpasscheck_CheckedChanged);
            // 
            // RPTpasstxt
            // 
            this.RPTpasstxt.Location = new System.Drawing.Point(366, 183);
            this.RPTpasstxt.Name = "RPTpasstxt";
            this.RPTpasstxt.Size = new System.Drawing.Size(169, 20);
            this.RPTpasstxt.TabIndex = 25;
            this.RPTpasstxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // RPTloginbtn
            // 
            this.RPTloginbtn.BackColor = System.Drawing.Color.Blue;
            this.RPTloginbtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPTloginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RPTloginbtn.Location = new System.Drawing.Point(349, 248);
            this.RPTloginbtn.Name = "RPTloginbtn";
            this.RPTloginbtn.Size = new System.Drawing.Size(205, 35);
            this.RPTloginbtn.TabIndex = 27;
            this.RPTloginbtn.Text = "Login";
            this.RPTloginbtn.UseVisualStyleBackColor = false;
            this.RPTloginbtn.Click += new System.EventHandler(this.RPTloginbtn_Click);
            // 
            // RPTusernamtxt
            // 
            this.RPTusernamtxt.Location = new System.Drawing.Point(366, 141);
            this.RPTusernamtxt.Name = "RPTusernamtxt";
            this.RPTusernamtxt.Size = new System.Drawing.Size(169, 20);
            this.RPTusernamtxt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hospital Management System";
            // 
            // ReceptionistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RPTpasscheck);
            this.Controls.Add(this.RPTpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RPTloginbtn);
            this.Controls.Add(this.RPTusernamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionistLogin";
            this.Text = "ReceptionistLogin";
            this.Load += new System.EventHandler(this.ReceptionistLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RPTpasscheck;
        private System.Windows.Forms.TextBox RPTpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RPTloginbtn;
        private System.Windows.Forms.TextBox RPTusernamtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}