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
    public partial class CourseCodeCourseTitleCreditHour : Form
    {
        SqlConnection con;
        SqlCommand com;


        public CourseCodeCourseTitleCreditHour()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            if (facultyCmbBox.Text == "CSE")
            {
                com = new SqlCommand("INSERT INTO CSECourseInformation  values ('" + SlNoTxt.Text + "','" + CourseCodeTxt.Text + "','" + CourseTitleTxt.Text + "','" + CreditHourTxt.Text + "','" + SemesCmbBox.Text + "')", con);
                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Insert successfull");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (facultyCmbBox.Text == "BBA")
            {
                com = new SqlCommand("INSERT INTO BBACourseInformation  values ('" + SlNoTxt.Text + "','" + CourseCodeTxt.Text + "','" + CourseTitleTxt.Text + "','" + CreditHourTxt.Text + "','" + SemesCmbBox.Text + "')", con);
                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Insert successfull");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            this.Close();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string strUpd = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strUpd);

            cnx.Open();
            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQry = "UPDATE CSECourseInformation  set SlNo = '" + this.SlNoTxt.Text + "', CourseCode = '" + this.CourseCodeTxt.Text + "' , CourseTitle = '" + this.CourseTitleTxt.Text + "', CreditHour = '" + this.CreditHourTxt.Text + "', Semester = '" + this.SemesCmbBox.Text + "'WHERE SlNo = '" + this.SlNoTxt.Text + "'AND  Semester = '" + this.SemesCmbBox.Text + "'";
                SqlCommand cmd = new SqlCommand(strQry, cnx);
                try
                {


                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Update successfull");
            }
            else if (facultyCmbBox.Text == "BBA")
            {
                //This code is susceptible to SQL injection attacks.
                string strQry = "UPDATE BBACourseInformation  set SlNo = '" + this.SlNoTxt.Text + "', CourseCode = '" + this.CourseCodeTxt.Text + "' , CourseTitle = '" + this.CourseTitleTxt.Text + "', CreditHour = '" + this.CreditHourTxt.Text + "', Semester = '" + this.SemesCmbBox.Text + "'WHERE SlNo = '" + this.SlNoTxt.Text + "'AND  Semester = '" + this.SemesCmbBox.Text + "'";
                SqlCommand cmd = new SqlCommand(strQry, cnx);
                try
                {


                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Update successfull");
            }

            cnx.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx1 = new SqlConnection(Cnx1);

            conx1.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where SlNo='" + SlNoTxt.Text + "'AND Semester='" + SemesCmbBox.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                    CourseCodeTxt.Hide();
                    CourseTitleTxt.Hide();
                    CreditHourTxt.Hide();
                    String m1 = dtr1["CourseCode"].ToString(); CourseCodeTxt.Show();
                    String m2 = dtr1["CourseTitle"].ToString(); CourseTitleTxt.Show();
                    String m3 = dtr1["CreditHour"].ToString(); CreditHourTxt.Show();

                    //txtbx
                    CourseCodeTxt.Text = m1;
                    CourseTitleTxt.Text = m2;
                    CreditHourTxt.Text = m3;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            else if (facultyCmbBox.Text == "BBA")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where SlNo='" + SlNoTxt.Text + "'AND Semester='" + SemesCmbBox.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                    CourseCodeTxt.Hide();
                    CourseTitleTxt.Hide();
                    CreditHourTxt.Hide();
                    String m1 = dtr1["CourseCode"].ToString(); CourseCodeTxt.Show();
                    String m2 = dtr1["CourseTitle"].ToString(); CourseTitleTxt.Show();
                    String m3 = dtr1["CreditHour"].ToString(); CreditHourTxt.Show();

                    //txtbx
                    CourseCodeTxt.Text = m1;
                    CourseTitleTxt.Text = m2;
                    CreditHourTxt.Text = m3;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            conx1.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string strDel = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strDel);

            cnx.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQrydel = "DELETE FROM CSECourseInformation  WHERE SlNo = '" + this.SlNoTxt.Text + "'AND  Semester = '" + this.SemesCmbBox.Text + "'";
                SqlCommand cmdDel = new SqlCommand(strQrydel, cnx);
                try
                {


                    cmdDel.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Delete successfull");
            }

            if (facultyCmbBox.Text == "BBA")
            {
                //This code is susceptible to SQL injection attacks.
                string strQrydel = "DELETE FROM BBACourseInformation  WHERE SlNo = '" + this.SlNoTxt.Text + "'AND  Semester = '" + this.SemesCmbBox.Text + "'";
                SqlCommand cmdDel = new SqlCommand(strQrydel, cnx);
                try
                {


                    cmdDel.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Delete successfull");
            }
            cnx.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Result_Section f2 = new Result_Section();
            f2.Show();
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
     
     
        
     
    }
}
