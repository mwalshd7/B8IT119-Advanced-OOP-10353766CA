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
using DAL;

namespace _10353766CA
{

    public partial class AdminOnlyRegistration : Form
    {
        HashCode hc = new HashCode();
        public AdminOnlyRegistration()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            
            string fullName = txtStaffFullName.Text;
            string regUser = txtStaffUN.Text;
            string regPass = txtStaffPass.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Desktop\Advanced Programming\10353766CA\10353766CA\Student.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO StaffLogin (StaffUserName, StaffPassword, StaffFullName) VALUES (@un, @pw, @fn)", con);
            cmd.Parameters.AddWithValue("@un", regUser);
            cmd.Parameters.AddWithValue("@pw", /*hc.PassHash*/regPass);
            cmd.Parameters.AddWithValue("@fn", fullName);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Details Added");
            txtStaffFullName.Clear();
            txtStaffUN.Clear();
            txtStaffPass.Clear();
            con.Close();
         
        }

        private void AdminOnlyRegistration_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
