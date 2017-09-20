namespace _10353766CA
{
    partial class AddStudent
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
            this.gbAddStu = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gbAddStuAcademic = new System.Windows.Forms.GroupBox();
            this.cbAddStuCourses = new System.Windows.Forms.ComboBox();
            this.lblAddStuCourses = new System.Windows.Forms.Label();
            this.rboAddStuPostGrad = new System.Windows.Forms.RadioButton();
            this.rboAddStuUnderGrad = new System.Windows.Forms.RadioButton();
            this.gbAddStuDetail = new System.Windows.Forms.GroupBox();
            this.lblAddStuFN = new System.Windows.Forms.Label();
            this.txtAddStuFN = new System.Windows.Forms.TextBox();
            this.txtAddStuPhone = new System.Windows.Forms.TextBox();
            this.lblAddStuSN = new System.Windows.Forms.Label();
            this.lblAddStuPhone = new System.Windows.Forms.Label();
            this.txtAddStuSN = new System.Windows.Forms.TextBox();
            this.txtAddStuEmail = new System.Windows.Forms.TextBox();
            this.lblAddStuEmail = new System.Windows.Forms.Label();
            this.gbAddStuAddress = new System.Windows.Forms.GroupBox();
            this.cbAddStCounty = new System.Windows.Forms.ComboBox();
            this.lblAddStuCounty = new System.Windows.Forms.Label();
            this.txtAddStuCity = new System.Windows.Forms.TextBox();
            this.lblAddStuCity = new System.Windows.Forms.Label();
            this.txtAddStuAdd1 = new System.Windows.Forms.TextBox();
            this.txtAddStuAdd2 = new System.Windows.Forms.TextBox();
            this.lblAddStuAdd1 = new System.Windows.Forms.Label();
            this.lblAddStuAdd2 = new System.Windows.Forms.Label();
            this.gbAddStu.SuspendLayout();
            this.gbAddStuAcademic.SuspendLayout();
            this.gbAddStuDetail.SuspendLayout();
            this.gbAddStuAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddStu
            // 
            this.gbAddStu.Controls.Add(this.btnAddStudent);
            this.gbAddStu.Controls.Add(this.gbAddStuAcademic);
            this.gbAddStu.Controls.Add(this.gbAddStuDetail);
            this.gbAddStu.Controls.Add(this.gbAddStuAddress);
            this.gbAddStu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddStu.Location = new System.Drawing.Point(3, 3);
            this.gbAddStu.Name = "gbAddStu";
            this.gbAddStu.Size = new System.Drawing.Size(719, 355);
            this.gbAddStu.TabIndex = 0;
            this.gbAddStu.TabStop = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(123, 318);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(225, 23);
            this.btnAddStudent.TabIndex = 15;
            this.btnAddStudent.Text = "Add Student to DataBase";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gbAddStuAcademic
            // 
            this.gbAddStuAcademic.Controls.Add(this.cbAddStuCourses);
            this.gbAddStuAcademic.Controls.Add(this.lblAddStuCourses);
            this.gbAddStuAcademic.Controls.Add(this.rboAddStuPostGrad);
            this.gbAddStuAcademic.Controls.Add(this.rboAddStuUnderGrad);
            this.gbAddStuAcademic.Location = new System.Drawing.Point(10, 212);
            this.gbAddStuAcademic.Name = "gbAddStuAcademic";
            this.gbAddStuAcademic.Size = new System.Drawing.Size(625, 100);
            this.gbAddStuAcademic.TabIndex = 14;
            this.gbAddStuAcademic.TabStop = false;
            this.gbAddStuAcademic.Text = "Student Academic Details";
            // 
            // cbAddStuCourses
            // 
            this.cbAddStuCourses.FormattingEnabled = true;
            this.cbAddStuCourses.Location = new System.Drawing.Point(217, 29);
            this.cbAddStuCourses.Name = "cbAddStuCourses";
            this.cbAddStuCourses.Size = new System.Drawing.Size(121, 24);
            this.cbAddStuCourses.TabIndex = 15;
            // 
            // lblAddStuCourses
            // 
            this.lblAddStuCourses.AutoSize = true;
            this.lblAddStuCourses.Location = new System.Drawing.Point(163, 29);
            this.lblAddStuCourses.Name = "lblAddStuCourses";
            this.lblAddStuCourses.Size = new System.Drawing.Size(48, 16);
            this.lblAddStuCourses.TabIndex = 2;
            this.lblAddStuCourses.Text = "Course";
            // 
            // rboAddStuPostGrad
            // 
            this.rboAddStuPostGrad.AutoSize = true;
            this.rboAddStuPostGrad.Location = new System.Drawing.Point(7, 49);
            this.rboAddStuPostGrad.Name = "rboAddStuPostGrad";
            this.rboAddStuPostGrad.Size = new System.Drawing.Size(81, 20);
            this.rboAddStuPostGrad.TabIndex = 1;
            this.rboAddStuPostGrad.Text = "Post Grad";
            this.rboAddStuPostGrad.UseVisualStyleBackColor = true;
            // 
            // rboAddStuUnderGrad
            // 
            this.rboAddStuUnderGrad.AutoSize = true;
            this.rboAddStuUnderGrad.Checked = true;
            this.rboAddStuUnderGrad.Location = new System.Drawing.Point(7, 23);
            this.rboAddStuUnderGrad.Name = "rboAddStuUnderGrad";
            this.rboAddStuUnderGrad.Size = new System.Drawing.Size(91, 20);
            this.rboAddStuUnderGrad.TabIndex = 0;
            this.rboAddStuUnderGrad.TabStop = true;
            this.rboAddStuUnderGrad.Text = "Under Grad";
            this.rboAddStuUnderGrad.UseVisualStyleBackColor = true;
            // 
            // gbAddStuDetail
            // 
            this.gbAddStuDetail.Controls.Add(this.lblAddStuFN);
            this.gbAddStuDetail.Controls.Add(this.txtAddStuFN);
            this.gbAddStuDetail.Controls.Add(this.txtAddStuPhone);
            this.gbAddStuDetail.Controls.Add(this.lblAddStuSN);
            this.gbAddStuDetail.Controls.Add(this.lblAddStuPhone);
            this.gbAddStuDetail.Controls.Add(this.txtAddStuSN);
            this.gbAddStuDetail.Controls.Add(this.txtAddStuEmail);
            this.gbAddStuDetail.Controls.Add(this.lblAddStuEmail);
            this.gbAddStuDetail.Location = new System.Drawing.Point(9, 9);
            this.gbAddStuDetail.Name = "gbAddStuDetail";
            this.gbAddStuDetail.Size = new System.Drawing.Size(325, 196);
            this.gbAddStuDetail.TabIndex = 13;
            this.gbAddStuDetail.TabStop = false;
            this.gbAddStuDetail.Text = "Student Details";
            // 
            // lblAddStuFN
            // 
            this.lblAddStuFN.AutoSize = true;
            this.lblAddStuFN.Location = new System.Drawing.Point(18, 33);
            this.lblAddStuFN.Name = "lblAddStuFN";
            this.lblAddStuFN.Size = new System.Drawing.Size(70, 16);
            this.lblAddStuFN.TabIndex = 0;
            this.lblAddStuFN.Text = "First Name";
            // 
            // txtAddStuFN
            // 
            this.txtAddStuFN.Location = new System.Drawing.Point(94, 30);
            this.txtAddStuFN.Name = "txtAddStuFN";
            this.txtAddStuFN.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuFN.TabIndex = 1;
            // 
            // txtAddStuPhone
            // 
            this.txtAddStuPhone.Location = new System.Drawing.Point(94, 117);
            this.txtAddStuPhone.Name = "txtAddStuPhone";
            this.txtAddStuPhone.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuPhone.TabIndex = 7;
            // 
            // lblAddStuSN
            // 
            this.lblAddStuSN.AutoSize = true;
            this.lblAddStuSN.Location = new System.Drawing.Point(18, 62);
            this.lblAddStuSN.Name = "lblAddStuSN";
            this.lblAddStuSN.Size = new System.Drawing.Size(60, 16);
            this.lblAddStuSN.TabIndex = 2;
            this.lblAddStuSN.Text = "Surname";
            // 
            // lblAddStuPhone
            // 
            this.lblAddStuPhone.AutoSize = true;
            this.lblAddStuPhone.Location = new System.Drawing.Point(18, 120);
            this.lblAddStuPhone.Name = "lblAddStuPhone";
            this.lblAddStuPhone.Size = new System.Drawing.Size(43, 16);
            this.lblAddStuPhone.TabIndex = 6;
            this.lblAddStuPhone.Text = "Phone";
            // 
            // txtAddStuSN
            // 
            this.txtAddStuSN.Location = new System.Drawing.Point(94, 59);
            this.txtAddStuSN.Name = "txtAddStuSN";
            this.txtAddStuSN.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuSN.TabIndex = 3;
            // 
            // txtAddStuEmail
            // 
            this.txtAddStuEmail.Location = new System.Drawing.Point(94, 88);
            this.txtAddStuEmail.Name = "txtAddStuEmail";
            this.txtAddStuEmail.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuEmail.TabIndex = 5;
            // 
            // lblAddStuEmail
            // 
            this.lblAddStuEmail.AutoSize = true;
            this.lblAddStuEmail.Location = new System.Drawing.Point(18, 91);
            this.lblAddStuEmail.Name = "lblAddStuEmail";
            this.lblAddStuEmail.Size = new System.Drawing.Size(39, 16);
            this.lblAddStuEmail.TabIndex = 4;
            this.lblAddStuEmail.Text = "Email";
            // 
            // gbAddStuAddress
            // 
            this.gbAddStuAddress.Controls.Add(this.cbAddStCounty);
            this.gbAddStuAddress.Controls.Add(this.lblAddStuCounty);
            this.gbAddStuAddress.Controls.Add(this.txtAddStuCity);
            this.gbAddStuAddress.Controls.Add(this.lblAddStuCity);
            this.gbAddStuAddress.Controls.Add(this.txtAddStuAdd1);
            this.gbAddStuAddress.Controls.Add(this.txtAddStuAdd2);
            this.gbAddStuAddress.Controls.Add(this.lblAddStuAdd1);
            this.gbAddStuAddress.Controls.Add(this.lblAddStuAdd2);
            this.gbAddStuAddress.Location = new System.Drawing.Point(340, 9);
            this.gbAddStuAddress.Name = "gbAddStuAddress";
            this.gbAddStuAddress.Size = new System.Drawing.Size(295, 196);
            this.gbAddStuAddress.TabIndex = 12;
            this.gbAddStuAddress.TabStop = false;
            this.gbAddStuAddress.Text = "Student Adress";
            // 
            // cbAddStCounty
            // 
            this.cbAddStCounty.FormattingEnabled = true;
            this.cbAddStCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbAddStCounty.Location = new System.Drawing.Point(92, 118);
            this.cbAddStCounty.Name = "cbAddStCounty";
            this.cbAddStCounty.Size = new System.Drawing.Size(121, 24);
            this.cbAddStCounty.TabIndex = 15;
            // 
            // lblAddStuCounty
            // 
            this.lblAddStuCounty.AutoSize = true;
            this.lblAddStuCounty.Location = new System.Drawing.Point(16, 117);
            this.lblAddStuCounty.Name = "lblAddStuCounty";
            this.lblAddStuCounty.Size = new System.Drawing.Size(47, 16);
            this.lblAddStuCounty.TabIndex = 14;
            this.lblAddStuCounty.Text = "County";
            // 
            // txtAddStuCity
            // 
            this.txtAddStuCity.Location = new System.Drawing.Point(92, 83);
            this.txtAddStuCity.Name = "txtAddStuCity";
            this.txtAddStuCity.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuCity.TabIndex = 13;
            // 
            // lblAddStuCity
            // 
            this.lblAddStuCity.AutoSize = true;
            this.lblAddStuCity.Location = new System.Drawing.Point(16, 86);
            this.lblAddStuCity.Name = "lblAddStuCity";
            this.lblAddStuCity.Size = new System.Drawing.Size(29, 16);
            this.lblAddStuCity.TabIndex = 12;
            this.lblAddStuCity.Text = "City";
            // 
            // txtAddStuAdd1
            // 
            this.txtAddStuAdd1.Location = new System.Drawing.Point(92, 25);
            this.txtAddStuAdd1.Name = "txtAddStuAdd1";
            this.txtAddStuAdd1.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuAdd1.TabIndex = 9;
            // 
            // txtAddStuAdd2
            // 
            this.txtAddStuAdd2.Location = new System.Drawing.Point(92, 54);
            this.txtAddStuAdd2.Name = "txtAddStuAdd2";
            this.txtAddStuAdd2.Size = new System.Drawing.Size(166, 23);
            this.txtAddStuAdd2.TabIndex = 11;
            // 
            // lblAddStuAdd1
            // 
            this.lblAddStuAdd1.AutoSize = true;
            this.lblAddStuAdd1.Location = new System.Drawing.Point(16, 28);
            this.lblAddStuAdd1.Name = "lblAddStuAdd1";
            this.lblAddStuAdd1.Size = new System.Drawing.Size(65, 16);
            this.lblAddStuAdd1.TabIndex = 8;
            this.lblAddStuAdd1.Text = "Address 1";
            // 
            // lblAddStuAdd2
            // 
            this.lblAddStuAdd2.AutoSize = true;
            this.lblAddStuAdd2.Location = new System.Drawing.Point(16, 57);
            this.lblAddStuAdd2.Name = "lblAddStuAdd2";
            this.lblAddStuAdd2.Size = new System.Drawing.Size(65, 16);
            this.lblAddStuAdd2.TabIndex = 10;
            this.lblAddStuAdd2.Text = "Address 2";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 370);
            this.Controls.Add(this.gbAddStu);
            this.Name = "AddStudent";
            this.Text = "DBS SMS Add New Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.gbAddStu.ResumeLayout(false);
            this.gbAddStuAcademic.ResumeLayout(false);
            this.gbAddStuAcademic.PerformLayout();
            this.gbAddStuDetail.ResumeLayout(false);
            this.gbAddStuDetail.PerformLayout();
            this.gbAddStuAddress.ResumeLayout(false);
            this.gbAddStuAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddStu;
        private System.Windows.Forms.Label lblAddStuFN;
        private System.Windows.Forms.TextBox txtAddStuFN;
        private System.Windows.Forms.GroupBox gbAddStuAddress;
        private System.Windows.Forms.TextBox txtAddStuAdd2;
        private System.Windows.Forms.Label lblAddStuAdd2;
        private System.Windows.Forms.TextBox txtAddStuAdd1;
        private System.Windows.Forms.Label lblAddStuAdd1;
        private System.Windows.Forms.TextBox txtAddStuPhone;
        private System.Windows.Forms.Label lblAddStuPhone;
        private System.Windows.Forms.TextBox txtAddStuEmail;
        private System.Windows.Forms.Label lblAddStuEmail;
        private System.Windows.Forms.TextBox txtAddStuSN;
        private System.Windows.Forms.Label lblAddStuSN;
        private System.Windows.Forms.GroupBox gbAddStuDetail;
        private System.Windows.Forms.TextBox txtAddStuCity;
        private System.Windows.Forms.Label lblAddStuCity;
        private System.Windows.Forms.Label lblAddStuCounty;
        private System.Windows.Forms.GroupBox gbAddStuAcademic;
        private System.Windows.Forms.RadioButton rboAddStuPostGrad;
        private System.Windows.Forms.RadioButton rboAddStuUnderGrad;
        private System.Windows.Forms.ComboBox cbAddStuCourses;
        private System.Windows.Forms.Label lblAddStuCourses;
        private System.Windows.Forms.ComboBox cbAddStCounty;
        private System.Windows.Forms.Button btnAddStudent;
    }
}