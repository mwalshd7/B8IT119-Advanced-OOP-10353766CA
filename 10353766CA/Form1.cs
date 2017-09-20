using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
using Biz;

namespace _10353766CA
{

    public partial class Form1 : Form
    {
        public static Form1 mobj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            UpdateGrid();
            dgResults.Visible = false;
            logoutToolStripMenuItem1.Visible = false;
            adminToolStripMenuItem.Visible = false;
            accountToolStripMenuItem1.Visible = false;
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            login.MdiParent = this;
            mobj = this;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgResults.Visible = false;
            logoutToolStripMenuItem1.Visible = false;
            accountToolStripMenuItem1.Visible = false;
            lblUser.Visible = false;
            adminToolStripMenuItem.Visible = false;
            loginToolStripMenuItem1.Visible = true;
            mobj = this;
        }

        private void newStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            AddStudent.Show();
        }

        public void LoadDataGrid()
        {
            UpdateGrid();
            if (dgResults.Columns.Count > 0)
            {
                dgResults.Columns[0].HeaderText = "Student Number";
                dgResults.Columns[1].HeaderText = "First Name";
                dgResults.Columns[2].HeaderText = "Surname";
                dgResults.Columns[3].HeaderText = "Email";
                dgResults.Columns[4].HeaderText = "Phone";
                dgResults.Columns[5].HeaderText = "Address 1";
                dgResults.Columns[6].HeaderText = "Address 2";
                dgResults.Columns[7].HeaderText = "City";
                dgResults.Columns[8].HeaderText = "County";
                dgResults.Columns[9].HeaderText = "Level";
                dgResults.Columns[10].HeaderText = "Student Course";
            }
        }
        public void UpdateGrid()
        {
            DAO dao = new DAO();
            SqlDataAdapter da;
            DataTable dt;
            BindingSource bs;
            dt = new DataTable();
            bs = new BindingSource();
            da = new SqlDataAdapter();
            SqlCommand cmd = dao.OpenCon().CreateCommand(); //string input = "SELECT * FROM Student"; //SqlCommand cmd = new SqlCommand(input, dao.OpenCon());
            cmd.CommandText = "uspGetStudents";
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            bs.DataSource = dt;
            dgResults.DataSource = bs;
        }

      

        private void deleteStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            string del = "DELETE FROM Student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(del, dao.OpenCon());
            cmd.Parameters.AddWithValue("@StudentID", dgResults.SelectedRows[0].Cells[0].Value);
            cmd.ExecuteScalar();
            dao.ClosedCon();
            UpdateGrid();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void editStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgResults.CurrentRow;
            int sID = Convert.ToInt32(row.Cells["StudentId"].Value);
            string fname = Convert.ToString(row.Cells["StudentFirstName"].Value);
            string sname = Convert.ToString(row.Cells["StudentSurname"].Value);
            string email = Convert.ToString(row.Cells["StudentEmail"].Value);
            string phone = Convert.ToString(row.Cells["StudentPhone"].Value);
            string add1 = Convert.ToString(row.Cells["StudentAddress1"].Value);
            string add2 = Convert.ToString(row.Cells["StudentAddress2"].Value);
            string city = Convert.ToString(row.Cells["StudentCity"].Value);
            string county = Convert.ToString(row.Cells["StudentCounty"].Value);
            string level = Convert.ToString(row.Cells["StudentLevel"].Value);
            string course = Convert.ToString(row.Cells["StudentCourse"].Value);
            AddNewStudent student = new AddNewStudent();
            student.StudentID = sID;
            student.StudentFN = fname;
            student.StudentSN = sname;
            student.StudentEmail = email;
            student.StudentPhone = phone;
            student.StudentAdd1 = add1;
            student.StudentAdd2 = add2;
            student.StudentCity = city;
            student.StudentCounty = county;
            student.StudentAcademicLevel = level;
            student.StudentAcademicCourse = course;
            EditEntry es = new EditEntry(student);
            es.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOnlyRegistration ad = new AdminOnlyRegistration();
            ad.Show(); 
        }

        private void viewDatabaseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SQLHistory sh = new SQLHistory();
            sh.Show();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
