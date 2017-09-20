using System;
using System.Windows.Forms;
using Biz;
using DAL;

namespace _10353766CA
{
    public partial class LoginForm : Form
    {
        HashCode hc = new HashCode();
        public LoginForm()
        {
            InitializeComponent();
        }

        CheckLogin c = new CheckLogin();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass =  /*hc.PassHash*/(txtPass.Text);
            string status = c.CheckUser(user, pass);
            if (status == "no")
            {
                MessageBox.Show("Invalid login. Please try again.");
            }
            else
            {
                MessageBox.Show("Login Succesfull. Please close this window to continue.");
                Form1.mobj.logoutToolStripMenuItem1.Visible = true;
                Form1.mobj.accountToolStripMenuItem1.Visible = true;
                Form1.mobj.loginToolStripMenuItem1.Visible = false;
                Form1.mobj.dgResults.Visible = true;
                Form1.mobj.lblUser.Text = "Welcome " + user;
                Form1.mobj.lblUser.Show();
                if (user == "Admin")
                {
                    Form1.mobj.adminToolStripMenuItem.Visible = true;
                }
                Close();
            }
            
            c.ClosedCon();
            
            
        }
    }
}
