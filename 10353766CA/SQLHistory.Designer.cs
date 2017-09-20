namespace _10353766CA
{
    partial class SQLHistory
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
            this.components = new System.ComponentModel.Container();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAuditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new _10353766CA.StudentDataSet1();
            this.student_AuditTableAdapter = new _10353766CA.StudentDataSet1TableAdapters.Student_AuditTableAdapter();
            this.btnSQLClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAuditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSQL
            // 
            this.dgvSQL.AllowUserToAddRows = false;
            this.dgvSQL.AllowUserToDeleteRows = false;
            this.dgvSQL.AutoGenerateColumns = false;
            this.dgvSQL.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentAddress1DataGridViewTextBoxColumn,
            this.studentAddress2DataGridViewTextBoxColumn,
            this.studentCityDataGridViewTextBoxColumn,
            this.studentCountyDataGridViewTextBoxColumn,
            this.studentLevelDataGridViewTextBoxColumn,
            this.studentCourseDataGridViewTextBoxColumn,
            this.auditActionDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn});
            this.dgvSQL.DataSource = this.studentAuditBindingSource;
            this.dgvSQL.Location = new System.Drawing.Point(12, 12);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.ReadOnly = true;
            this.dgvSQL.Size = new System.Drawing.Size(893, 150);
            this.dgvSQL.TabIndex = 0;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "StudentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "StudentFirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            this.studentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            this.studentEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            this.studentPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentAddress1DataGridViewTextBoxColumn
            // 
            this.studentAddress1DataGridViewTextBoxColumn.DataPropertyName = "StudentAddress1";
            this.studentAddress1DataGridViewTextBoxColumn.HeaderText = "StudentAddress1";
            this.studentAddress1DataGridViewTextBoxColumn.Name = "studentAddress1DataGridViewTextBoxColumn";
            this.studentAddress1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentAddress2DataGridViewTextBoxColumn
            // 
            this.studentAddress2DataGridViewTextBoxColumn.DataPropertyName = "StudentAddress2";
            this.studentAddress2DataGridViewTextBoxColumn.HeaderText = "StudentAddress2";
            this.studentAddress2DataGridViewTextBoxColumn.Name = "studentAddress2DataGridViewTextBoxColumn";
            this.studentAddress2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCityDataGridViewTextBoxColumn
            // 
            this.studentCityDataGridViewTextBoxColumn.DataPropertyName = "StudentCity";
            this.studentCityDataGridViewTextBoxColumn.HeaderText = "StudentCity";
            this.studentCityDataGridViewTextBoxColumn.Name = "studentCityDataGridViewTextBoxColumn";
            this.studentCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCountyDataGridViewTextBoxColumn
            // 
            this.studentCountyDataGridViewTextBoxColumn.DataPropertyName = "StudentCounty";
            this.studentCountyDataGridViewTextBoxColumn.HeaderText = "StudentCounty";
            this.studentCountyDataGridViewTextBoxColumn.Name = "studentCountyDataGridViewTextBoxColumn";
            this.studentCountyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLevelDataGridViewTextBoxColumn
            // 
            this.studentLevelDataGridViewTextBoxColumn.DataPropertyName = "StudentLevel";
            this.studentLevelDataGridViewTextBoxColumn.HeaderText = "StudentLevel";
            this.studentLevelDataGridViewTextBoxColumn.Name = "studentLevelDataGridViewTextBoxColumn";
            this.studentLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCourseDataGridViewTextBoxColumn
            // 
            this.studentCourseDataGridViewTextBoxColumn.DataPropertyName = "StudentCourse";
            this.studentCourseDataGridViewTextBoxColumn.HeaderText = "StudentCourse";
            this.studentCourseDataGridViewTextBoxColumn.Name = "studentCourseDataGridViewTextBoxColumn";
            this.studentCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditActionDataGridViewTextBoxColumn
            // 
            this.auditActionDataGridViewTextBoxColumn.DataPropertyName = "AuditAction";
            this.auditActionDataGridViewTextBoxColumn.HeaderText = "AuditAction";
            this.auditActionDataGridViewTextBoxColumn.Name = "auditActionDataGridViewTextBoxColumn";
            this.auditActionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentAuditBindingSource
            // 
            this.studentAuditBindingSource.DataMember = "Student_Audit";
            this.studentAuditBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_AuditTableAdapter
            // 
            this.student_AuditTableAdapter.ClearBeforeFill = true;
            // 
            // btnSQLClose
            // 
            this.btnSQLClose.Location = new System.Drawing.Point(428, 168);
            this.btnSQLClose.Name = "btnSQLClose";
            this.btnSQLClose.Size = new System.Drawing.Size(75, 23);
            this.btnSQLClose.TabIndex = 1;
            this.btnSQLClose.Text = "Close";
            this.btnSQLClose.UseVisualStyleBackColor = true;
            this.btnSQLClose.Click += new System.EventHandler(this.btnSQLClose_Click);
            // 
            // SQLHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 261);
            this.Controls.Add(this.btnSQLClose);
            this.Controls.Add(this.dgvSQL);
            this.Name = "SQLHistory";
            this.Text = "SQLHistory";
            this.Load += new System.EventHandler(this.SQLHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAuditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSQL;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource studentAuditBindingSource;
        private StudentDataSet1TableAdapters.Student_AuditTableAdapter student_AuditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCountyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSQLClose;
    }
}