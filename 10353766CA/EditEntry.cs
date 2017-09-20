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
using Biz;
using System.Xml.Serialization;
using System.Xml;

namespace _10353766CA
{
    public partial class EditEntry : Form
    {
        int curID;
        public EditEntry()
        {
            InitializeComponent();
            
        }

    

        public EditEntry(AddNewStudent Edit)
        {
            InitializeComponent();
            curID = Edit.StudentID;
            txtStuNumber.Text = curID.ToString();
            txtEditStuFN.Text = Edit.StudentFN;
            txtEditStuSN.Text = Edit.StudentSN;
            txtEditStuEmail.Text = Edit.StudentEmail;
            txtEditStuPhone.Text = Edit.StudentPhone;
            txtEditStuAdd1.Text = Edit.StudentAdd1;
            txtEditStuAdd2.Text = Edit.StudentAdd2;
            txtEditStuCity.Text = Edit.StudentCity;
            cbEditStCounty.Text = Edit.StudentCounty;
            if (Edit.StudentAcademicLevel.Equals("PostGrad")) this.rboEditStuPostGrad.Select();
            cbEditStuCourses.Text = Edit.StudentAcademicCourse;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (txtEditStuFN.Text == string.Empty || txtEditStuSN.Text == string.Empty
                || txtEditStuEmail.Text == string.Empty || txtEditStuAdd1.Text == string.Empty
                || txtEditStuAdd2.Text == string.Empty || txtEditStuCity.Text == string.Empty
                || cbEditStCounty.Text == string.Empty || cbEditStuCourses.Text == string.Empty)

            {
                MessageBox.Show("Please make sure text Fields are not blank");
                return;
            }
            else if (txtEditStuPhone.Text == string.Empty)
            {
                MessageBox.Show("Please make sure Phone Number format is correct 087123456 or 011234567");
                return;
            }
            else
            {

                EditStudent ed = new DAL.EditStudent();
                ed.EditStu(
                    curID, txtEditStuFN.Text, txtEditStuSN.Text, txtEditStuEmail.Text, txtEditStuPhone.Text,
                    txtEditStuAdd1.Text, txtEditStuAdd2.Text, txtEditStuCity.Text, cbEditStCounty.Text,
                    (rboEditStuPostGrad.Checked) ? "Postgrad" : "UnderGrad", cbEditStuCourses.Text);
                MessageBox.Show("Details Updated");
                this.Close();

            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serialiser;
            XmlWriter xmlWriter;
            string filePath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            string stID = txtStuNumber.Text;
            string fname = txtEditStuFN.Text;
            string sname = txtEditStuSN.Text;
            string em = txtEditStuEmail.Text;
            string ph = txtEditStuPhone.Text;
            string add1 = txtEditStuAdd1.Text;
            string add2 = txtEditStuAdd2.Text;
            string city = txtEditStuCity.Text;
            string county = cbEditStCounty.SelectedItem.ToString();

            string level = "UnderGrad";
            if (rboEditStuUnderGrad.Checked)
            {
                level = "UnderGrad";
            }
            else if (rboEditStuPostGrad.Checked)
            {
                level = "PostGrad";
            }
            string course = cbEditStuCourses.Text;

            AddNewStudent ns = new AddNewStudent(fname, sname, em, ph, add1, add2, city, county, level, course);
            if (ns.Validate())
            {
                sfd.InitialDirectory = "C:\\";
                sfd.Filter = "xml files (*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filePath = sfd.FileName;

                    serialiser = new XmlSerializer(typeof(AddNewStudent));
                    xmlWriter = XmlWriter.Create(filePath);
                    serialiser.Serialize(xmlWriter, ns);
                
                   MessageBox.Show("XML saved");
                    }
                    else
                    {
                        MessageBox.Show("Invalid details entered.Please check");
                    }
                }
            }

        private void EditEntry_Load(object sender, EventArgs e)
        {
            
        }
    }
    }



