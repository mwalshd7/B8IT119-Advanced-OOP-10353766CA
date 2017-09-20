using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biz;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace _10353766CA
{
    public partial class AddStudent : Form
    {
        
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtAddStuFN.Text == string.Empty || txtAddStuSN.Text == string.Empty
                ||txtAddStuEmail.Text==string.Empty||txtAddStuAdd1.Text==string.Empty
                ||txtAddStuAdd2.Text==string.Empty||txtAddStuCity.Text==string.Empty
                ||cbAddStCounty.Text==string.Empty||cbAddStuCourses.Text==string.Empty)

            {
                MessageBox.Show("Please make sure text Fields are not blank");
                return;
            }
            else if (txtAddStuPhone.Text == string.Empty)
            {
                MessageBox.Show("Please make sure Phone Number format is correct 087123456 or 011234567");
                return;
            }
            else {
                string fname = txtAddStuFN.Text;
                string sname = txtAddStuSN.Text;
                string em = txtAddStuEmail.Text;
                string ph = txtAddStuPhone.Text;
                string add1 = txtAddStuAdd1.Text;
                string add2 = txtAddStuAdd2.Text;
                string city = txtAddStuCity.Text;
                string county = cbAddStCounty.Text;

                string level = "UnderGrad";
                if (rboAddStuUnderGrad.Checked)
                {
                    level = "UnderGrad";
                }
                else if (rboAddStuPostGrad.Checked)
                {
                    level = "PostGrad";
                }
                string course = cbAddStuCourses.Text;


                AddNewStudent ns = new AddNewStudent(fname, sname, em, ph, add1, add2, city, county, level, course);
                if (ns.Validate())
                {
                    ns.AddStuToDB();
                    MessageBox.Show("Student Database Updated");


                    txtAddStuFN.Clear();
                    txtAddStuSN.Clear();
                    txtAddStuEmail.Clear();
                    txtAddStuPhone.Clear();
                    txtAddStuAdd1.Clear();
                    txtAddStuAdd2.Clear();
                    txtAddStuCity.Clear();
                    cbAddStCounty.ResetText();
                    cbAddStuCourses.ResetText();
                    this.Close();
                }
                else MessageBox.Show("Invalid details entered.Please check");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cbAddStCounty.DataSource = Enum.GetValues(typeof(Counties));
            cbAddStuCourses.DataSource = Enum.GetValues(typeof(Subjects));
        }
    }
}
