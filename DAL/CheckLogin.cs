using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//New Using
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace Biz
{
   
    public class CheckLogin : DAO
    {
        public string UserLoginName { get; set; }
        public string CheckUser(string user, string pass)
        {
            
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM StaffLogIn WHERE StaffUserName=@user AND StaffPassword=@pass", OpenCon());
            cmd.Parameters.AddWithValue("@user", user);
            //MessageBox.Show("H:" + pass);
            cmd.Parameters.AddWithValue("@pass", pass);      
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return UserLoginName = dr.GetString(1);
            }
            else
            {
                string no = "no";
                return no;
            }                       
        }
    }
}
