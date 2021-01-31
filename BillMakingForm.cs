using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace print
{
    public partial class BillMakingForm : Form
    {
        public BillMakingForm()
        {
            InitializeComponent();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {

            InputBillremunerationExam f2 = new InputBillremunerationExam();
            string Cnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx = new SqlConnection(Cnx);

            conx.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry = "SELECT * FROM CSETeacherInformation where TeacherName='" + TeacherNamTxt.Text + "'AND Faculty= 'CSE'";
                // int intRecs;


                SqlCommand comd = new SqlCommand(Qry, conx);

                SqlDataReader dtr = comd.ExecuteReader();
                dtr.Read();
                try
                {

                    String a = dtr["TeacherName"].ToString();
                    String b = dtr["Designation"].ToString();
                    String c = dtr["Address"].ToString();

                    f2.TeacherNamtxt.Text = a;
                    f2.DesigCmbBox.Text = b;
                    f2.Addresstxt.Text = c;

                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
            else if (facultyCmbBox.Text == "BBA")
            {

                string Qry1 = "SELECT * FROM BBATeacherInformation where TeacherName='" + TeacherNamTxt.Text + "'AND Faculty= 'CSE'";
                //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
                // int intRecs;


                SqlCommand comd1 = new SqlCommand(Qry1, conx);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {

                    String a = dtr1["TeacherName"].ToString();
                    String b = dtr1["Designation"].ToString();
                    String c = dtr1["Address"].ToString();

                    f2.TeacherNamtxt.Text = a;
                    f2.DesigCmbBox.Text = b;
                    f2.Addresstxt.Text = c;
                    f2.FinalExm1hr.Text = b;

                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
            






            conx.Close();

            if (facultyCmbBox.Text == "CSE" && SemsCmbBox.Text == "1")
            {
                //f2.semestercmb.Text = "1";
                
                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM  CSECourseInformation where  Semester='" + SemsCmbBox.Text + "'AND CourseCode = '" + CourseCodeTxt.Text + "'";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
              
                dtr1.Read();
                try
                {
                    String a = dtr1["CourseCode"].ToString();
                    String b = dtr1["CourseTitle"].ToString();

                    f2.coursecodetxt.Text = a;
                    f2.coursetitletxt.Text = b;
                    

                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                f2.Show();
            }
            this.Hide();
            }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AccountingSection a = new AccountingSection();
            a.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherNamTxt_TextChanged(object sender, EventArgs e)
        {

        }
        }

      
       
    }

