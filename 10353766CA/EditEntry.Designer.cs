namespace _10353766CA
{
    partial class EditEntry
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
            this.gbEditStu = new System.Windows.Forms.GroupBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.gbEditStuAcademic = new System.Windows.Forms.GroupBox();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.lblEditStuNumber = new System.Windows.Forms.Label();
            this.cbEditStuCourses = new System.Windows.Forms.ComboBox();
            this.lblAddStuCourses = new System.Windows.Forms.Label();
            this.rboEditStuPostGrad = new System.Windows.Forms.RadioButton();
            this.rboEditStuUnderGrad = new System.Windows.Forms.RadioButton();
            this.gbEditStuDetail = new System.Windows.Forms.GroupBox();
            this.lblEditStuFN = new System.Windows.Forms.Label();
            this.txtEditStuFN = new System.Windows.Forms.TextBox();
            this.txtEditStuPhone = new System.Windows.Forms.TextBox();
            this.lblEditStuSN = new System.Windows.Forms.Label();
            this.lblEditStuPhone = new System.Windows.Forms.Label();
            this.txtEditStuSN = new System.Windows.Forms.TextBox();
            this.txtEditStuEmail = new System.Windows.Forms.TextBox();
            this.lblEditStuEmail = new System.Windows.Forms.Label();
            this.gbEditStuAddress = new System.Windows.Forms.GroupBox();
            this.cbEditStCounty = new System.Windows.Forms.ComboBox();
            this.lblEditStuCounty = new System.Windows.Forms.Label();
            this.txtEditStuCity = new System.Windows.Forms.TextBox();
            this.lblEditStuCity = new System.Windows.Forms.Label();
            this.txtEditStuAdd1 = new System.Windows.Forms.TextBox();
            this.txtEditStuAdd2 = new System.Windows.Forms.TextBox();
            this.lblEditStuAdd1 = new System.Windows.Forms.Label();
            this.lblEditStuAdd2 = new System.Windows.Forms.Label();
            this.gbEditStu.SuspendLayout();
            this.gbEditStuAcademic.SuspendLayout();
            this.gbEditStuDetail.SuspendLayout();
            this.gbEditStuAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditStu
            // 
            this.gbEditStu.Controls.Add(this.btnXML);
            this.gbEditStu.Controls.Add(this.btnUpdateStudent);
            this.gbEditStu.Controls.Add(this.gbEditStuAcademic);
            this.gbEditStu.Controls.Add(this.gbEditStuDetail);
            this.gbEditStu.Controls.Add(this.gbEditStuAddress);
            this.gbEditStu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditStu.Location = new System.Drawing.Point(3, 2);
            this.gbEditStu.Name = "gbEditStu";
            this.gbEditStu.Size = new System.Drawing.Size(719, 355);
            this.gbEditStu.TabIndex = 1;
            this.gbEditStu.TabStop = false;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(459, 317);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(139, 23);
            this.btnXML.TabIndex = 16;
            this.btnXML.Text = "Save to XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(227, 318);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(225, 23);
            this.btnUpdateStudent.TabIndex = 15;
            this.btnUpdateStudent.Text = "Saves Changes to DataBase";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // gbEditStuAcademic
            // 
            this.gbEditStuAcademic.Controls.Add(this.txtStuNumber);
            this.gbEditStuAcademic.Controls.Add(this.lblEditStuNumber);
            this.gbEditStuAcademic.Controls.Add(this.cbEditStuCourses);
            this.gbEditStuAcademic.Controls.Add(this.lblAddStuCourses);
            this.gbEditStuAcademic.Controls.Add(this.rboEditStuPostGrad);
            this.gbEditStuAcademic.Controls.Add(this.rboEditStuUnderGrad);
            this.gbEditStuAcademic.Location = new System.Drawing.Point(10, 212);
            this.gbEditStuAcademic.Name = "gbEditStuAcademic";
            this.gbEditStuAcademic.Size = new System.Drawing.Size(625, 100);
            this.gbEditStuAcademic.TabIndex = 14;
            this.gbEditStuAcademic.TabStop = false;
            this.gbEditStuAcademic.Text = "Student Academic Details";
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(476, 30);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.ReadOnly = true;
            this.txtStuNumber.Size = new System.Drawing.Size(100, 23);
            this.txtStuNumber.TabIndex = 17;
            // 
            // lblEditStuNumber
            // 
            this.lblEditStuNumber.AutoSize = true;
            this.lblEditStuNumber.Location = new System.Drawing.Point(369, 29);
            this.lblEditStuNumber.Name = "lblEditStuNumber";
            this.lblEditStuNumber.Size = new System.Drawing.Size(101, 16);
            this.lblEditStuNumber.TabIndex = 16;
            this.lblEditStuNumber.Text = "Student Number";
            // 
            // cbEditStuCourses
            // 
            this.cbEditStuCourses.Enabled = false;
            this.cbEditStuCourses.FormattingEnabled = true;
            this.cbEditStuCourses.Items.AddRange(new object[] {
            "Coumputer Science",
            "Applied Physics",
            "Arts",
            "Economics",
            "Business Studies"});
            this.cbEditStuCourses.Location = new System.Drawing.Point(217, 29);
            this.cbEditStuCourses.Name = "cbEditStuCourses";
            this.cbEditStuCourses.Size = new System.Drawing.Size(121, 24);
            this.cbEditStuCourses.TabIndex = 15;
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
            // rboEditStuPostGrad
            // 
            this.rboEditStuPostGrad.AutoSize = true;
            this.rboEditStuPostGrad.Location = new System.Drawing.Point(7, 49);
            this.rboEditStuPostGrad.Name = "rboEditStuPostGrad";
            this.rboEditStuPostGrad.Size = new System.Drawing.Size(81, 20);
            this.rboEditStuPostGrad.TabIndex = 1;
            this.rboEditStuPostGrad.Text = "Post Grad";
            this.rboEditStuPostGrad.UseVisualStyleBackColor = true;
            // 
            // rboEditStuUnderGrad
            // 
            this.rboEditStuUnderGrad.AutoSize = true;
            this.rboEditStuUnderGrad.Checked = true;
            this.rboEditStuUnderGrad.Location = new System.Drawing.Point(7, 23);
            this.rboEditStuUnderGrad.Name = "rboEditStuUnderGrad";
            this.rboEditStuUnderGrad.Size = new System.Drawing.Size(91, 20);
            this.rboEditStuUnderGrad.TabIndex = 0;
            this.rboEditStuUnderGrad.TabStop = true;
            this.rboEditStuUnderGrad.Text = "Under Grad";
            this.rboEditStuUnderGrad.UseVisualStyleBackColor = true;
            // 
            // gbEditStuDetail
            // 
            this.gbEditStuDetail.Controls.Add(this.lblEditStuFN);
            this.gbEditStuDetail.Controls.Add(this.txtEditStuFN);
            this.gbEditStuDetail.Controls.Add(this.txtEditStuPhone);
            this.gbEditStuDetail.Controls.Add(this.lblEditStuSN);
            this.gbEditStuDetail.Controls.Add(this.lblEditStuPhone);
            this.gbEditStuDetail.Controls.Add(this.txtEditStuSN);
            this.gbEditStuDetail.Controls.Add(this.txtEditStuEmail);
            this.gbEditStuDetail.Controls.Add(this.lblEditStuEmail);
            this.gbEditStuDetail.Location = new System.Drawing.Point(9, 9);
            this.gbEditStuDetail.Name = "gbEditStuDetail";
            this.gbEditStuDetail.Size = new System.Drawing.Size(325, 196);
            this.gbEditStuDetail.TabIndex = 13;
            this.gbEditStuDetail.TabStop = false;
            this.gbEditStuDetail.Text = "Student Details";
            // 
            // lblEditStuFN
            // 
            this.lblEditStuFN.AutoSize = true;
            this.lblEditStuFN.Location = new System.Drawing.Point(18, 33);
            this.lblEditStuFN.Name = "lblEditStuFN";
            this.lblEditStuFN.Size = new System.Drawing.Size(70, 16);
            this.lblEditStuFN.TabIndex = 0;
            this.lblEditStuFN.Text = "First Name";
            // 
            // txtEditStuFN
            // 
            this.txtEditStuFN.Location = new System.Drawing.Point(94, 30);
            this.txtEditStuFN.Name = "txtEditStuFN";
            this.txtEditStuFN.ReadOnly = true;
            this.txtEditStuFN.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuFN.TabIndex = 1;
            // 
            // txtEditStuPhone
            // 
            this.txtEditStuPhone.Location = new System.Drawing.Point(94, 117);
            this.txtEditStuPhone.Name = "txtEditStuPhone";
            this.txtEditStuPhone.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuPhone.TabIndex = 7;
            // 
            // lblEditStuSN
            // 
            this.lblEditStuSN.AutoSize = true;
            this.lblEditStuSN.Location = new System.Drawing.Point(18, 62);
            this.lblEditStuSN.Name = "lblEditStuSN";
            this.lblEditStuSN.Size = new System.Drawing.Size(60, 16);
            this.lblEditStuSN.TabIndex = 2;
            this.lblEditStuSN.Text = "Surname";
            // 
            // lblEditStuPhone
            // 
            this.lblEditStuPhone.AutoSize = true;
            this.lblEditStuPhone.Location = new System.Drawing.Point(18, 120);
            this.lblEditStuPhone.Name = "lblEditStuPhone";
            this.lblEditStuPhone.Size = new System.Drawing.Size(43, 16);
            this.lblEditStuPhone.TabIndex = 6;
            this.lblEditStuPhone.Text = "Phone";
            // 
            // txtEditStuSN
            // 
            this.txtEditStuSN.Location = new System.Drawing.Point(94, 59);
            this.txtEditStuSN.Name = "txtEditStuSN";
            this.txtEditStuSN.ReadOnly = true;
            this.txtEditStuSN.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuSN.TabIndex = 3;
            // 
            // txtEditStuEmail
            // 
            this.txtEditStuEmail.Location = new System.Drawing.Point(94, 88);
            this.txtEditStuEmail.Name = "txtEditStuEmail";
            this.txtEditStuEmail.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuEmail.TabIndex = 5;
            // 
            // lblEditStuEmail
            // 
            this.lblEditStuEmail.AutoSize = true;
            this.lblEditStuEmail.Location = new System.Drawing.Point(18, 91);
            this.lblEditStuEmail.Name = "lblEditStuEmail";
            this.lblEditStuEmail.Size = new System.Drawing.Size(39, 16);
            this.lblEditStuEmail.TabIndex = 4;
            this.lblEditStuEmail.Text = "Email";
            // 
            // gbEditStuAddress
            // 
            this.gbEditStuAddress.Controls.Add(this.cbEditStCounty);
            this.gbEditStuAddress.Controls.Add(this.lblEditStuCounty);
            this.gbEditStuAddress.Controls.Add(this.txtEditStuCity);
            this.gbEditStuAddress.Controls.Add(this.lblEditStuCity);
            this.gbEditStuAddress.Controls.Add(this.txtEditStuAdd1);
            this.gbEditStuAddress.Controls.Add(this.txtEditStuAdd2);
            this.gbEditStuAddress.Controls.Add(this.lblEditStuAdd1);
            this.gbEditStuAddress.Controls.Add(this.lblEditStuAdd2);
            this.gbEditStuAddress.Location = new System.Drawing.Point(340, 9);
            this.gbEditStuAddress.Name = "gbEditStuAddress";
            this.gbEditStuAddress.Size = new System.Drawing.Size(295, 196);
            this.gbEditStuAddress.TabIndex = 12;
            this.gbEditStuAddress.TabStop = false;
            this.gbEditStuAddress.Text = "Student Adress";
            // 
            // cbEditStCounty
            // 
            this.cbEditStCounty.FormattingEnabled = true;
            this.cbEditStCounty.Items.AddRange(new object[] {
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
            this.cbEditStCounty.Location = new System.Drawing.Point(92, 118);
            this.cbEditStCounty.Name = "cbEditStCounty";
            this.cbEditStCounty.Size = new System.Drawing.Size(121, 24);
            this.cbEditStCounty.TabIndex = 15;
            // 
            // lblEditStuCounty
            // 
            this.lblEditStuCounty.AutoSize = true;
            this.lblEditStuCounty.Location = new System.Drawing.Point(16, 117);
            this.lblEditStuCounty.Name = "lblEditStuCounty";
            this.lblEditStuCounty.Size = new System.Drawing.Size(47, 16);
            this.lblEditStuCounty.TabIndex = 14;
            this.lblEditStuCounty.Text = "County";
            // 
            // txtEditStuCity
            // 
            this.txtEditStuCity.Location = new System.Drawing.Point(92, 83);
            this.txtEditStuCity.Name = "txtEditStuCity";
            this.txtEditStuCity.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuCity.TabIndex = 13;
            // 
            // lblEditStuCity
            // 
            this.lblEditStuCity.AutoSize = true;
            this.lblEditStuCity.Location = new System.Drawing.Point(16, 86);
            this.lblEditStuCity.Name = "lblEditStuCity";
            this.lblEditStuCity.Size = new System.Drawing.Size(29, 16);
            this.lblEditStuCity.TabIndex = 12;
            this.lblEditStuCity.Text = "City";
            // 
            // txtEditStuAdd1
            // 
            this.txtEditStuAdd1.Location = new System.Drawing.Point(92, 25);
            this.txtEditStuAdd1.Name = "txtEditStuAdd1";
            this.txtEditStuAdd1.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuAdd1.TabIndex = 9;
            // 
            // txtEditStuAdd2
            // 
            this.txtEditStuAdd2.Location = new System.Drawing.Point(92, 54);
            this.txtEditStuAdd2.Name = "txtEditStuAdd2";
            this.txtEditStuAdd2.Size = new System.Drawing.Size(166, 23);
            this.txtEditStuAdd2.TabIndex = 11;
            // 
            // lblEditStuAdd1
            // 
            this.lblEditStuAdd1.AutoSize = true;
            this.lblEditStuAdd1.Location = new System.Drawing.Point(16, 28);
            this.lblEditStuAdd1.Name = "lblEditStuAdd1";
            this.lblEditStuAdd1.Size = new System.Drawing.Size(65, 16);
            this.lblEditStuAdd1.TabIndex = 8;
            this.lblEditStuAdd1.Text = "Address 1";
            // 
            // lblEditStuAdd2
            // 
            this.lblEditStuAdd2.AutoSize = true;
            this.lblEditStuAdd2.Location = new System.Drawing.Point(16, 57);
            this.lblEditStuAdd2.Name = "lblEditStuAdd2";
            this.lblEditStuAdd2.Size = new System.Drawing.Size(65, 16);
            this.lblEditStuAdd2.TabIndex = 10;
            this.lblEditStuAdd2.Text = "Address 2";
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 458);
            this.Controls.Add(this.gbEditStu);
            this.Name = "EditEntry";
            this.Text = "DBS MS EditStudent";
            this.gbEditStu.ResumeLayout(false);
            this.gbEditStuAcademic.ResumeLayout(false);
            this.gbEditStuAcademic.PerformLayout();
            this.gbEditStuDetail.ResumeLayout(false);
            this.gbEditStuDetail.PerformLayout();
            this.gbEditStuAddress.ResumeLayout(false);
            this.gbEditStuAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditStu;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.GroupBox gbEditStuAcademic;
        private System.Windows.Forms.ComboBox cbEditStuCourses;
        private System.Windows.Forms.Label lblAddStuCourses;
        private System.Windows.Forms.RadioButton rboEditStuPostGrad;
        private System.Windows.Forms.RadioButton rboEditStuUnderGrad;
        private System.Windows.Forms.GroupBox gbEditStuDetail;
        private System.Windows.Forms.Label lblEditStuFN;
        private System.Windows.Forms.TextBox txtEditStuFN;
        private System.Windows.Forms.TextBox txtEditStuPhone;
        private System.Windows.Forms.Label lblEditStuSN;
        private System.Windows.Forms.Label lblEditStuPhone;
        private System.Windows.Forms.TextBox txtEditStuSN;
        private System.Windows.Forms.TextBox txtEditStuEmail;
        private System.Windows.Forms.Label lblEditStuEmail;
        private System.Windows.Forms.GroupBox gbEditStuAddress;
        private System.Windows.Forms.ComboBox cbEditStCounty;
        private System.Windows.Forms.Label lblEditStuCounty;
        private System.Windows.Forms.TextBox txtEditStuCity;
        private System.Windows.Forms.Label lblEditStuCity;
        private System.Windows.Forms.TextBox txtEditStuAdd1;
        private System.Windows.Forms.TextBox txtEditStuAdd2;
        private System.Windows.Forms.Label lblEditStuAdd1;
        private System.Windows.Forms.Label lblEditStuAdd2;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.Label lblEditStuNumber;
    }
}