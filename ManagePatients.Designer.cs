namespace Database_project
{
    partial class ManagePatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePatients));
            this.homebtn1 = new System.Windows.Forms.Button();
            this.docupdate = new System.Windows.Forms.Button();
            this.docdelete = new System.Windows.Forms.Button();
            this.docreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.docCnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.docname = new System.Windows.Forms.TextBox();
            this.docGen = new System.Windows.Forms.ComboBox();
            this.docDOB = new System.Windows.Forms.DateTimePicker();
            this.docAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.docEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.docPass = new System.Windows.Forms.TextBox();
            this.docConpass = new System.Windows.Forms.TextBox();
            this.DOCdataGridView = new System.Windows.Forms.DataGridView();
            this.docAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DOCdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homebtn1
            // 
            this.homebtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homebtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn1.Location = new System.Drawing.Point(575, 288);
            this.homebtn1.Name = "homebtn1";
            this.homebtn1.Size = new System.Drawing.Size(86, 29);
            this.homebtn1.TabIndex = 24;
            this.homebtn1.Text = "Home";
            this.homebtn1.UseVisualStyleBackColor = true;
            this.homebtn1.Click += new System.EventHandler(this.homebtn1_Click);
            // 
            // docupdate
            // 
            this.docupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.docupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docupdate.Location = new System.Drawing.Point(575, 98);
            this.docupdate.Name = "docupdate";
            this.docupdate.Size = new System.Drawing.Size(86, 29);
            this.docupdate.TabIndex = 23;
            this.docupdate.Text = "UPDATE";
            this.docupdate.UseVisualStyleBackColor = true;
            this.docupdate.Click += new System.EventHandler(this.docupdate_Click);
            // 
            // docdelete
            // 
            this.docdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.docdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docdelete.Location = new System.Drawing.Point(575, 160);
            this.docdelete.Name = "docdelete";
            this.docdelete.Size = new System.Drawing.Size(86, 29);
            this.docdelete.TabIndex = 22;
            this.docdelete.Text = "DELETE";
            this.docdelete.UseVisualStyleBackColor = true;
            this.docdelete.Click += new System.EventHandler(this.docdelete_Click);
            // 
            // docreset
            // 
            this.docreset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.docreset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docreset.Location = new System.Drawing.Point(575, 227);
            this.docreset.Name = "docreset";
            this.docreset.Size = new System.Drawing.Size(86, 29);
            this.docreset.TabIndex = 21;
            this.docreset.Text = "RESET";
            this.docreset.UseVisualStyleBackColor = true;
            this.docreset.Click += new System.EventHandler(this.docreset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25121F));
            this.tableLayoutPanel1.Controls.Add(this.docCnic, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.docname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.docGen, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.docDOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.docAddress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.docEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.docPass, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.docConpass, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 323);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // docCnic
            // 
            this.docCnic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docCnic.Location = new System.Drawing.Point(150, 38);
            this.docCnic.Name = "docCnic";
            this.docCnic.Size = new System.Drawing.Size(221, 20);
            this.docCnic.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "CNIC";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // docname
            // 
            this.docname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docname.Location = new System.Drawing.Point(150, 6);
            this.docname.Name = "docname";
            this.docname.Size = new System.Drawing.Size(221, 20);
            this.docname.TabIndex = 0;
            // 
            // docGen
            // 
            this.docGen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docGen.FormattingEnabled = true;
            this.docGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.docGen.Location = new System.Drawing.Point(150, 101);
            this.docGen.Name = "docGen";
            this.docGen.Size = new System.Drawing.Size(221, 21);
            this.docGen.TabIndex = 3;
            // 
            // docDOB
            // 
            this.docDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docDOB.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.docDOB.Location = new System.Drawing.Point(150, 134);
            this.docDOB.Name = "docDOB";
            this.docDOB.Size = new System.Drawing.Size(221, 20);
            this.docDOB.TabIndex = 4;
            // 
            // docAddress
            // 
            this.docAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docAddress.Location = new System.Drawing.Point(150, 163);
            this.docAddress.Multiline = true;
            this.docAddress.Name = "docAddress";
            this.docAddress.Size = new System.Drawing.Size(221, 58);
            this.docAddress.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // docEmail
            // 
            this.docEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docEmail.Location = new System.Drawing.Point(150, 230);
            this.docEmail.Name = "docEmail";
            this.docEmail.Size = new System.Drawing.Size(221, 20);
            this.docEmail.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Conform Password  ";
            // 
            // docPass
            // 
            this.docPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docPass.Location = new System.Drawing.Point(150, 262);
            this.docPass.Name = "docPass";
            this.docPass.Size = new System.Drawing.Size(221, 20);
            this.docPass.TabIndex = 8;
            this.docPass.UseSystemPasswordChar = true;
            // 
            // docConpass
            // 
            this.docConpass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.docConpass.Location = new System.Drawing.Point(150, 295);
            this.docConpass.Name = "docConpass";
            this.docConpass.Size = new System.Drawing.Size(221, 20);
            this.docConpass.TabIndex = 9;
            this.docConpass.UseSystemPasswordChar = true;
            // 
            // DOCdataGridView
            // 
            this.DOCdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DOCdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DOCdataGridView.Location = new System.Drawing.Point(-3, 336);
            this.DOCdataGridView.Name = "DOCdataGridView";
            this.DOCdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DOCdataGridView.Size = new System.Drawing.Size(870, 196);
            this.DOCdataGridView.TabIndex = 18;
            this.DOCdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DOCdataGridView_CellClick);
            // 
            // docAdd
            // 
            this.docAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.docAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docAdd.Location = new System.Drawing.Point(575, 38);
            this.docAdd.Name = "docAdd";
            this.docAdd.Size = new System.Drawing.Size(86, 29);
            this.docAdd.TabIndex = 19;
            this.docAdd.Text = "Add";
            this.docAdd.UseVisualStyleBackColor = true;
            this.docAdd.Click += new System.EventHandler(this.docAdd_Click);
            // 
            // ManagePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 533);
            this.Controls.Add(this.homebtn1);
            this.Controls.Add(this.docupdate);
            this.Controls.Add(this.docdelete);
            this.Controls.Add(this.docreset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DOCdataGridView);
            this.Controls.Add(this.docAdd);
            this.Name = "ManagePatients";
            this.Text = "ManagePatients";
            this.Load += new System.EventHandler(this.ManagePatients_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DOCdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homebtn1;
        private System.Windows.Forms.Button docupdate;
        private System.Windows.Forms.Button docdelete;
        private System.Windows.Forms.Button docreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox docCnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox docname;
        private System.Windows.Forms.TextBox docEmail;
        private System.Windows.Forms.TextBox docPass;
        private System.Windows.Forms.TextBox docConpass;
        private System.Windows.Forms.ComboBox docGen;
        private System.Windows.Forms.DateTimePicker docDOB;
        private System.Windows.Forms.TextBox docAddress;
        private System.Windows.Forms.DataGridView DOCdataGridView;
        private System.Windows.Forms.Button docAdd;
    }
}