namespace _10353766CA
{
    partial class AdminOnlyRegistration
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
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtStaffFullName = new System.Windows.Forms.TextBox();
            this.lblStaffFN = new System.Windows.Forms.Label();
            this.txtStaffPass = new System.Windows.Forms.TextBox();
            this.lblStaffPass = new System.Windows.Forms.Label();
            this.txtStaffUN = new System.Windows.Forms.TextBox();
            this.lblStaffUser = new System.Windows.Forms.Label();
            this.gbRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.btnAddStaff);
            this.gbRegistration.Controls.Add(this.txtStaffFullName);
            this.gbRegistration.Controls.Add(this.lblStaffFN);
            this.gbRegistration.Controls.Add(this.txtStaffPass);
            this.gbRegistration.Controls.Add(this.lblStaffPass);
            this.gbRegistration.Controls.Add(this.txtStaffUN);
            this.gbRegistration.Controls.Add(this.lblStaffUser);
            this.gbRegistration.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistration.Location = new System.Drawing.Point(3, 3);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(269, 246);
            this.gbRegistration.TabIndex = 0;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Staff Registration Form";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(74, 180);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(149, 27);
            this.btnAddStaff.TabIndex = 6;
            this.btnAddStaff.Text = "Add Staff Login to DB";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtStaffFullName
            // 
            this.txtStaffFullName.Location = new System.Drawing.Point(123, 121);
            this.txtStaffFullName.Name = "txtStaffFullName";
            this.txtStaffFullName.Size = new System.Drawing.Size(100, 23);
            this.txtStaffFullName.TabIndex = 5;
            // 
            // lblStaffFN
            // 
            this.lblStaffFN.AutoSize = true;
            this.lblStaffFN.Location = new System.Drawing.Point(19, 124);
            this.lblStaffFN.Name = "lblStaffFN";
            this.lblStaffFN.Size = new System.Drawing.Size(96, 16);
            this.lblStaffFN.TabIndex = 4;
            this.lblStaffFN.Text = "Staff Full Name";
            // 
            // txtStaffPass
            // 
            this.txtStaffPass.Location = new System.Drawing.Point(123, 79);
            this.txtStaffPass.Name = "txtStaffPass";
            this.txtStaffPass.Size = new System.Drawing.Size(100, 23);
            this.txtStaffPass.TabIndex = 3;
            // 
            // lblStaffPass
            // 
            this.lblStaffPass.AutoSize = true;
            this.lblStaffPass.Location = new System.Drawing.Point(19, 86);
            this.lblStaffPass.Name = "lblStaffPass";
            this.lblStaffPass.Size = new System.Drawing.Size(63, 16);
            this.lblStaffPass.TabIndex = 2;
            this.lblStaffPass.Text = "Password";
            // 
            // txtStaffUN
            // 
            this.txtStaffUN.Location = new System.Drawing.Point(123, 43);
            this.txtStaffUN.Name = "txtStaffUN";
            this.txtStaffUN.Size = new System.Drawing.Size(100, 23);
            this.txtStaffUN.TabIndex = 1;
            // 
            // lblStaffUser
            // 
            this.lblStaffUser.AutoSize = true;
            this.lblStaffUser.Location = new System.Drawing.Point(19, 50);
            this.lblStaffUser.Name = "lblStaffUser";
            this.lblStaffUser.Size = new System.Drawing.Size(98, 16);
            this.lblStaffUser.TabIndex = 0;
            this.lblStaffUser.Text = "Staff UserName";
            // 
            // AdminOnlyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbRegistration);
            this.Name = "AdminOnlyRegistration";
            this.Text = "AdminOnlyRegistration";
            this.Load += new System.EventHandler(this.AdminOnlyRegistration_Load);
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtStaffFullName;
        private System.Windows.Forms.Label lblStaffFN;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Label lblStaffPass;
        private System.Windows.Forms.TextBox txtStaffUN;
        private System.Windows.Forms.Label lblStaffUser;
    }
}