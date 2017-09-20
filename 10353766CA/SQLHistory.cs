using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10353766CA
{
    public partial class SQLHistory : Form
    {
        public SQLHistory()
        {
            InitializeComponent();
        }

        private void SQLHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.Student_Audit' table. You can move, or remove it, as needed.
            this.student_AuditTableAdapter.Fill(this.studentDataSet1.Student_Audit);
            UpdateSQL();

        }

        private void btnSQLClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateSQL()
        {
            DAO dao = new DAO();
            SqlDataAdapter da;
            DataTable dt;
            BindingSource bs;
            dt = new DataTable();
            bs = new BindingSource();
            da = new SqlDataAdapter();
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetXML";
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            bs.DataSource = dt;
            dgvSQL.DataSource = bs;
        }
    }
}
