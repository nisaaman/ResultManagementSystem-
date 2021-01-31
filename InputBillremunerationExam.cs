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
    public partial class InputBillremunerationExam : Form
    {
        SqlConnection con;
        SqlCommand com;
        public InputBillremunerationExam()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            string noOfStudent = NoOfStdtxt.Text;
            string OneInstractorMidThory = OneInstMidThortxt.Text;

            int OneInstractorMidThory1 = Convert.ToInt32(OneInstractorMidThory);

            int noOfStudent1 = Convert.ToInt32(noOfStudent);

            int productforMidTher = noOfStudent1 * OneInstractorMidThory1;

            MidTherAmount.Text = productforMidTher.ToString();

            string FinalExm1hur = FinalExm1hr.Text;
            string FinalExm2hur = FinalExm2hr.Text;
            string FinalExm3hur = FinalExm3hr.Text;

            int FinalExm1hur1 = Convert.ToInt32(FinalExm1hur);
            int FinalExm1hur2 = Convert.ToInt32(FinalExm2hur);
            int FinalExm1hur3 = Convert.ToInt32(FinalExm3hur);

            int ProductForFinalExm1hur1 = noOfStudent1 * FinalExm1hur3;

            FinalExmAmount.Text = ProductForFinalExm1hur1.ToString();

            string ClassTesTxt = ClassTestTxt.Text;

            int ClassTestTxt1 = Convert.ToInt32(ClassTesTxt);

            ClassTestAmount.Text = ClassTesTxt.ToString();


            String Fina1hr = Final1hr.Text;
            String Fina2hr = Final2hr.Text;
            String Fina3hr = Final3hr.Text;

            int Final1hr1 = Convert.ToInt32(Fina1hr);
            int Final2hr2 = Convert.ToInt32(Fina2hr);
            int Final3hr3 = Convert.ToInt32(Fina3hr);

            FinalAmount.Text = Final3hr.Text;

            String QusMo1hr = QusMod1hr.Text;
            String QusMo2hr = QusMod2hr.Text;
            String QusMo3hr = QuesMod3hr.Text;

            int QusMod1hr1 = Convert.ToInt32(QusMo1hr);
            int QusMod2hr2 = Convert.ToInt32(QusMo2hr);
            int QusMod3hr3 = Convert.ToInt32(QusMo3hr);

            QusModAmount.Text = QuesMod3hr.Text;

            String Tabulatiorate = tabulationrate.Text;

            int Tabulationrate1 = Convert.ToInt32(Tabulatiorate);

            int productOfTabule = noOfStudent1 * Tabulationrate1;

            tabulationAmount.Text = productOfTabule.ToString();

            int totalAount = productforMidTher + ProductForFinalExm1hur1 + ClassTestTxt1 ;
            int totalAmount1 = totalAount + Final3hr3 + QusMod3hr3 + Tabulationrate1;

            totalAmount.Text = totalAmount1.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            if (facultyCmbBox.Text == "CSE")
            {
                com = new SqlCommand("INSERT INTO CSEBillRemunerationExm  values ('" + TeacherNamtxt.Text + "','" + DesigCmbBox.Text + "','" + Addresstxt.Text + "','" + coursecodetxt.Text + "','" + Sessiontxt.Text + "','" + NoOfStdtxt.Text + "','" + noofgrptxt.Text + "','" + MidTherAmount.Text + "','" + MidPracAmn.Text + "','" + FinalExmAmount.Text + "','" + ClassTestAmount.Text + "','" + FinalAmount.Text + "','" + QusModAmount.Text + "','" + tabulationAmount.Text + "','" + totalAmount.Text + "')", con);
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
                com = new SqlCommand("INSERT INTO BBABillRemunerationExm  values ('" + TeacherNamtxt.Text + "','" + DesigCmbBox.Text + "','" + Addresstxt.Text + "','" + coursecodetxt.Text + "','" + Sessiontxt.Text + "','" + NoOfStdtxt.Text + "','" + noofgrptxt.Text + "','" + MidTherAmount.Text + "','" + MidPracAmn.Text + "','" + FinalExmAmount.Text + "','" + ClassTestAmount.Text + "','" + FinalAmount.Text + "','" + QusModAmount.Text + "','" + tabulationAmount.Text + "','" + totalAmount.Text + "')", con);
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
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            BillRemunerationExamPrint Bi = new BillRemunerationExamPrint();
            Bi.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            BillMakingForm b = new BillMakingForm();
            b.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string strUpd = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strUpd);

            cnx.Open();
            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQry = "UPDATE CSEBillRemunerationExm set  Session = '" + this.Sessiontxt.Text + "', NoOfStudent = '" + this.NoOfStdtxt.Text + "', NoOfPactGroup = '" + this.noofgrptxt.Text + "',MidTherAmn = '" + this.MidTherAmount.Text + "', MidPracAmn ='" + this.MidPracAmn.Text + "', FinalExmAmn ='" + this.FinalExmAmount.Text + "', ClassTestAmn  ='" + this.ClassTestAmount.Text + "', FinalAmn = '" + this.FinalAmount.Text + "', QusAmn = '" + this.QusModAmount.Text + "', TbulAmn = '" + this.tabulationAmount.Text + "', totelAmn = '" + this.totalAmount.Text + "'WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";
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
                string strQry = "UPDATE BBABillRemunerationExm  set  Session = '" + this.Sessiontxt.Text + "', NoOfStudent = '" + this.NoOfStdtxt.Text + "', NoOfPactGroup = '" + this.noofgrptxt.Text + "',MidTherAmn = '" + this.MidTherAmount.Text + "', MidPracAmn ='" + this.MidPracAmn.Text + "', FinalExmAmn ='" + this.FinalExmAmount.Text + "', ClassTestAmn  ='" + this.ClassTestAmount.Text + "', FinalAmn = '" + this.FinalAmount.Text + "', QusAmn = '" + this.QusModAmount.Text + "', TbulAmn = '" + this.tabulationAmount.Text + "', totelAmn = '" + this.totalAmount.Text + "'WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx1 = new SqlConnection(Cnx1);

            conx1.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSEBillRemunerationExm WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";
                
                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                   // DesigCmbBox.Hide();
                    //Addresstxt.Hide();
                    Sessiontxt.Hide();
                    NoOfStdtxt.Hide();
                    noofgrptxt.Hide();
                    MidTherAmount.Hide();
                    MidPracAmn.Hide();
                    FinalExmAmount.Hide();
                    ClassTestAmount.Hide();
                    FinalAmount.Hide();
                    QusModAmount.Hide();
                    tabulationAmount.Hide();
                    totalAmount.Hide();

                    //String n1 = dtr1["Designtion"].ToString(); DesigCmbBox.Show();
                    //String n2 = dtr1["Address"].ToString(); Addresstxt.Show();
                    String n3 = dtr1["Session"].ToString(); Sessiontxt.Show();
                    String n4 = dtr1["NoOfStudent"].ToString(); NoOfStdtxt.Show();
                    String n5 = dtr1["NoOfPactGroup"].ToString(); noofgrptxt.Show();
                    String n6 = dtr1["MidTherAmn"].ToString(); MidTherAmount.Show();
                    String n7 = dtr1["MidPracAmn"].ToString(); MidPracAmn.Show();
                    String n8 = dtr1["ClassTestAmn"].ToString(); ClassTestAmount.Show();
                    String n9 = dtr1["FinalAmn"].ToString(); FinalAmount.Show();
                    String n10 = dtr1["QusAmn"].ToString(); QusModAmount.Show();
                    String n11 = dtr1["TbulAmn"].ToString(); tabulationAmount.Show();
                    String n12 = dtr1["totelAmn"].ToString(); totalAmount.Show();
                    String n13 = dtr1["FinalExmAmn"].ToString(); FinalExmAmount.Show();

                    //txtbx
                    //DesigCmbBox.Text = n1;
                    //Addresstxt.Text = n2;
                    Sessiontxt.Text = n3;
                    NoOfStdtxt.Text = n4;
                    noofgrptxt.Text = n5;
                    MidTherAmount.Text = n6;
                    MidPracAmn.Text = n7;
                    FinalExmAmount.Text = n13;
                    ClassTestAmount.Text = n8;
                    FinalAmount.Text = n9;
                    QusModAmount.Text = n10;
                    tabulationAmount.Text = n11;
                    totalAmount.Text = n12;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            else if (facultyCmbBox.Text == "BBA")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBABillRemunerationExm WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                    //DesigCmbBox.Hide();
                    //Addresstxt.Hide();
                    Sessiontxt.Hide();
                    NoOfStdtxt.Hide();
                    noofgrptxt.Hide();
                    MidTherAmount.Hide();
                    MidPracAmn.Hide();
                    FinalExmAmount.Hide();
                    ClassTestAmount.Hide();
                    FinalAmount.Hide();
                    QusModAmount.Hide();
                    tabulationAmount.Hide();
                    totalAmount.Hide();

                    //String n1 = dtr1["Designtion"].ToString(); DesigCmbBox.Show();
                    //String n2 = dtr1["Address"].ToString(); Addresstxt.Show();
                    String n3 = dtr1["Session"].ToString(); Sessiontxt.Show();
                    String n4 = dtr1["NoOfStudent"].ToString(); NoOfStdtxt.Show();
                    String n5 = dtr1["NoOfPactGroup"].ToString(); noofgrptxt.Show();
                    String n6 = dtr1["MidTherAmn"].ToString(); MidTherAmount.Show();
                    String n7 = dtr1["MidPracAmn"].ToString(); MidPracAmn.Show();
                    String n8 = dtr1["ClassTestAmn"].ToString(); ClassTestAmount.Show();
                    String n9 = dtr1["FinalAmn"].ToString(); FinalAmount.Show();
                    String n10 = dtr1["QusAmn"].ToString(); QusModAmount.Show();
                    String n11 = dtr1["TbulAmn"].ToString(); tabulationAmount.Show();
                    String n12 = dtr1["totelAmn"].ToString(); totalAmount.Show();
                    String n13 = dtr1["FinalExmAmn"].ToString(); FinalExmAmount.Show();

                    //txtbx
                    //DesigCmbBox.Text = n1;
                    //Addresstxt.Text = n2;
                    Sessiontxt.Text = n3;
                    NoOfStdtxt.Text = n4;
                    noofgrptxt.Text = n5;
                    MidTherAmount.Text = n6;
                    MidPracAmn.Text = n7;
                    FinalExmAmount.Text = n13;
                    ClassTestAmount.Text = n8;
                    FinalAmount.Text = n9;
                    QusModAmount.Text = n10;
                    tabulationAmount.Text = n11;
                    totalAmount.Text = n12;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            conx1.Close();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string strDel = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strDel);

            cnx.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQrydel = "DELETE FROM CSEBillRemunerationExm  WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";
                
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
                string strQrydel = "DELETE FROM CSEBillRemunerationExm  WHERE TeacherName = '" + this.TeacherNamtxt.Text + "'AND  CourseCode ='" + this.coursecodetxt.Text + "'";
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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   

      

      


    }
}
