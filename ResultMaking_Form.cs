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
    public partial class ResultMaking_Form : Form
    {
        public ResultMaking_Form()
        {
            InitializeComponent();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            CSEinputform f2 = new CSEinputform();
            BBAinput_Form f3 = new BBAinput_Form();
            string Cnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx = new SqlConnection(Cnx);

            conx.Open();

            if (facultycmb.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry = "SELECT * FROM Student_infotb where Reg_no='" + regtxt.Text + "'AND Faculty= 'CSE'";
                //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
                // int intRecs;


                SqlCommand comd = new SqlCommand(Qry, conx);

                SqlDataReader dtr = comd.ExecuteReader();
                dtr.Read();
                try
                {

                    String a = dtr["Student_name"].ToString();
                    String b = dtr["Reg_no"].ToString();
                    String c = dtr["Session"].ToString();

                    // String x = dtr["Student_name"].ToString();
                    // String y = dtr["Reg_no"].ToString();
                    //String z = dtr["Session"].ToString();

                    f2.stnametxt.Text = a;
                    f2.rgtxt.Text = b;
                    f2.sessiontxt.Text = c;

                    // f3.stnametxt1.Text = x;
                    //f3.rgtxt1.Text = y;
                    // f3.sessiontxt1.Text = z;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
            if (facultycmb.Text == "BBA")
            {

                string Qry1 = "SELECT * FROM Student_infotb where (Reg_no='" + regtxt.Text + "'AND Faculty= 'BBA') ";
                //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
                // int intRecs;


                SqlCommand comd1 = new SqlCommand(Qry1, conx);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {

                    String a = dtr1["Student_name"].ToString();
                    String b = dtr1["Reg_no"].ToString();
                    String c = dtr1["Session"].ToString();


                    f3.stnametxt.Text = a;
                    f3.rgtxt.Text = b;
                    f3.sessiontxt.Text = c;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }







            conx.Close();

        
            if (facultycmb.Text == "CSE" && semcmb.Text == "1")
            {
                f2.semestercmb.Text = "1";
                
                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM  CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
              
                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;
                            
                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;
                            
                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();

            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "2")
            {
                f2.semestercmb.Text = "2";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM  CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "3")
            {
                f2.semestercmb.Text = "3";
            

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "4")
            {
                f2.semestercmb.Text = "4";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString();          f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString();   f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString();  f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString();   f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString();         f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString();  f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString();  f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "5")
            {
                f2.semestercmb.Text = "5";


                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "6")
            {
                f2.semestercmb.Text = "6";


                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "7")
            {
                f2.semestercmb.Text = "7";


                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();
            }
            if (facultycmb.Text == "CSE" && semcmb.Text == "8")
            {
                f2.semestercmb.Text = "8";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSECourseInformation where  Semester='" + f2.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f2.sl1txt.Hide();
                            f2.crscd1txt.Hide();
                            f2.crsttl1txt.Hide();
                            f2.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr1txt.Show();

                            //txtbx
                            f2.sl1txt.Text = m;
                            f2.crscd1txt.Text = m1;
                            f2.crsttl1txt.Text = m2;
                            f2.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f2.sl2txt.Hide();
                            f2.crscd2txt.Hide();
                            f2.crsttl2txt.Hide();
                            f2.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr2txt.Show();

                            //txtbx
                            f2.sl2txt.Text = m;
                            f2.crscd2txt.Text = m1;
                            f2.crsttl2txt.Text = m2;
                            f2.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f2.sl3txt.Hide();
                            f2.crscd3txt.Hide();
                            f2.crsttl3txt.Hide();
                            f2.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr3txt.Show();

                            //txtbx
                            f2.sl3txt.Text = m;
                            f2.crscd3txt.Text = m1;
                            f2.crsttl3txt.Text = m2;
                            f2.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f2.sl4txt.Hide();
                            f2.crscd4txt.Hide();
                            f2.crsttl4txt.Hide();
                            f2.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr4txt.Show();

                            //txtbx
                            f2.sl4txt.Text = m;
                            f2.crscd4txt.Text = m1;
                            f2.crsttl4txt.Text = m2;
                            f2.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f2.sl5txt.Hide();
                            f2.crscd5txt.Hide();
                            f2.crsttl5txt.Hide();
                            f2.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr5txt.Show();

                            //txtbx
                            f2.sl5txt.Text = m;
                            f2.crscd5txt.Text = m1;
                            f2.crsttl5txt.Text = m2;
                            f2.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f2.sl6txt.Hide();
                            f2.crscd6txt.Hide();
                            f2.crsttl6txt.Hide();
                            f2.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr6txt.Show();

                            //txtbx
                            f2.sl6txt.Text = m;
                            f2.crscd6txt.Text = m1;
                            f2.crsttl6txt.Text = m2;
                            f2.crdhr6txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(07))
                        {
                            f2.sl7txt.Hide();
                            f2.crscd7txt.Hide();
                            f2.crsttl7txt.Hide();
                            f2.crdhr7txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl7txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd7txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl7txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr7txt.Show();

                            //txtbx
                            f2.sl7txt.Text = m;
                            f2.crscd7txt.Text = m1;
                            f2.crsttl7txt.Text = m2;
                            f2.crdhr7txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(08))
                        {
                            f2.sl8txt.Hide();
                            f2.crscd8txt.Hide();
                            f2.crsttl8txt.Hide();
                            f2.crdhr8txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl8txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd8txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl8txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr8txt.Show();

                            //txtbx
                            f2.sl8txt.Text = m;
                            f2.crscd8txt.Text = m1;
                            f2.crsttl8txt.Text = m2;
                            f2.crdhr8txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(09))
                        {
                            f2.sl9txt.Hide();
                            f2.crscd9txt.Hide();
                            f2.crsttl9txt.Hide();
                            f2.crdhr9txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl9txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd9txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl9txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr9txt.Show();

                            //txtbx
                            f2.sl9txt.Text = m;
                            f2.crscd9txt.Text = m1;
                            f2.crsttl9txt.Text = m2;
                            f2.crdhr9txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(10))
                        {
                            f2.sl10txt.Hide();
                            f2.crscd10txt.Hide();
                            f2.crsttl10txt.Hide();
                            f2.crdhr10txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl10txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd10txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl10txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr10txt.Show();

                            //txtbx
                            f2.sl10txt.Text = m;
                            f2.crscd10txt.Text = m1;
                            f2.crsttl10txt.Text = m2;
                            f2.crdhr10txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(11))
                        {
                            f2.sl11txt.Hide();
                            f2.crscd11txt.Hide();
                            f2.crsttl11txt.Hide();
                            f2.crdhr11txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f2.sl11txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f2.crscd11txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f2.crsttl11txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f2.crdhr11txt.Show();

                            //txtbx
                            f2.sl11txt.Text = m;
                            f2.crscd11txt.Text = m1;
                            f2.crsttl11txt.Text = m2;
                            f2.crdhr11txt.Text = m3;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f2.Show();
                conx1.Close();

            }



            if (facultycmb.Text == "BBA" && semcmb.Text == "1")
            {
                f3.semestercmb.Text = "1";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }
                       
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "2")
            {
                f3.semestercmb.Text = "2";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "3")
            {
                f3.semestercmb.Text = "3";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "4")
            {
                f3.semestercmb.Text = "4";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "5")
            {
                f3.semestercmb.Text = "5";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "6")
            {
                f3.semestercmb.Text = "6";

                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "7")
            {
                f3.semestercmb.Text = "7";
                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            if (facultycmb.Text == "BBA" && semcmb.Text == "8")
            {
                f3.semestercmb.Text = "8";
                string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conx1 = new SqlConnection(Cnx1);

                conx1.Open();

                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBACourseInformation where  Semester='" + f3.semestercmb.Text + "' ";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();

                try
                {
                    while (dtr1.Read())
                    {
                        if (dtr1["SlNo"].Equals(01))
                        {
                            f3.sl1txt.Hide();
                            f3.crscd1txt.Hide();
                            f3.crsttl1txt.Hide();
                            f3.crdhr1txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl1txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd1txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl1txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr1txt.Show();

                            //txtbx
                            f3.sl1txt.Text = m;
                            f3.crscd1txt.Text = m1;
                            f3.crsttl1txt.Text = m2;
                            f3.crdhr1txt.Text = m3;

                        }

                        else if (dtr1["SlNo"].Equals(02))
                        {
                            f3.sl2txt.Hide();
                            f3.crscd2txt.Hide();
                            f3.crsttl2txt.Hide();
                            f3.crdhr2txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl2txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd2txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl2txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr2txt.Show();

                            //txtbx
                            f3.sl2txt.Text = m;
                            f3.crscd2txt.Text = m1;
                            f3.crsttl2txt.Text = m2;
                            f3.crdhr2txt.Text = m3;

                        }
                        else if (dtr1["SlNo"].Equals(03))
                        {
                            f3.sl3txt.Hide();
                            f3.crscd3txt.Hide();
                            f3.crsttl3txt.Hide();
                            f3.crdhr3txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl3txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd3txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl3txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr3txt.Show();

                            //txtbx
                            f3.sl3txt.Text = m;
                            f3.crscd3txt.Text = m1;
                            f3.crsttl3txt.Text = m2;
                            f3.crdhr3txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(04))
                        {
                            f3.sl4txt.Hide();
                            f3.crscd4txt.Hide();
                            f3.crsttl4txt.Hide();
                            f3.crdhr4txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl4txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd4txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl4txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr4txt.Show();

                            //txtbx
                            f3.sl4txt.Text = m;
                            f3.crscd4txt.Text = m1;
                            f3.crsttl4txt.Text = m2;
                            f3.crdhr4txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(05))
                        {
                            f3.sl5txt.Hide();
                            f3.crscd5txt.Hide();
                            f3.crsttl5txt.Hide();
                            f3.crdhr5txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl5txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd5txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl5txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr5txt.Show();

                            //txtbx
                            f3.sl5txt.Text = m;
                            f3.crscd5txt.Text = m1;
                            f3.crsttl5txt.Text = m2;
                            f3.crdhr5txt.Text = m3;
                        }
                        else if (dtr1["SlNo"].Equals(06))
                        {
                            f3.sl6txt.Hide();
                            f3.crscd6txt.Hide();
                            f3.crsttl6txt.Hide();
                            f3.crdhr6txt.Hide();

                            String m = dtr1["SlNo"].ToString(); f3.sl6txt.Show();
                            String m1 = dtr1["CourseCode"].ToString(); f3.crscd6txt.Show();
                            String m2 = dtr1["CourseTitle"].ToString(); f3.crsttl6txt.Show();
                            String m3 = dtr1["CreditHour"].ToString(); f3.crdhr6txt.Show();

                            //txtbx
                            f3.sl6txt.Text = m;
                            f3.crscd6txt.Text = m1;
                            f3.crsttl6txt.Text = m2;
                            f3.crdhr6txt.Text = m3;
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                f3.Show();
                conx1.Close();
               
            }
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Result_Section f2 = new Result_Section();
            f2.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            CSEinputform f6 = new CSEinputform();
            f6.Show();
            this.Hide();
        }
    }
}
