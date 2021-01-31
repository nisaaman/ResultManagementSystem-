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
    public partial class TeacherInformationInput : Form
    {
        SqlConnection con;
        SqlCommand com;

        public TeacherInformationInput()
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
                com = new SqlCommand("INSERT INTO CSETeacherInformation  values ('" + TeacherNamTxt.Text + "','" + DesigCmbBox.Text + "','" + facultyCmbBox.Text + "','" + AddressTxt.Text + "')", con);
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
                com = new SqlCommand("INSERT INTO BBATeacherInformation  values ('" + TeacherNamTxt.Text + "','" + DesigCmbBox.Text + "','" + facultyCmbBox.Text + "','" + AddressTxt.Text + "')", con);
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string strDel = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strDel);

            cnx.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQrydel = "DELETE FROM CSETeacherInformation  WHERE TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";
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
                string strQrydel = "DELETE FROM BBATeacherInformation  WHERE TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";
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

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx1 = new SqlConnection(Cnx1);

            conx1.Open();

            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM CSETeacherInformation Where TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                    DesigCmbBox.Hide();
                    AddressTxt.Hide();

                    String m1 = dtr1["Designation"].ToString(); DesigCmbBox.Show();
                    String m2 = dtr1["Address"].ToString(); AddressTxt.Show();
                    
                    //txtbx
                    DesigCmbBox.Text = m1;
                    AddressTxt.Text = m2;
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            else if (facultyCmbBox.Text == "BBA")
            {
                //This code is susceptible to SQL injection attacks.
                string Qry1 = "SELECT * FROM BBATeacherInformation Where TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";

                SqlCommand comd1 = new SqlCommand(Qry1, conx1);

                SqlDataReader dtr1 = comd1.ExecuteReader();
                dtr1.Read();
                try
                {
                    DesigCmbBox.Hide();
                    AddressTxt.Hide();

                    String m1 = dtr1["Designation"].ToString(); DesigCmbBox.Show();
                    String m2 = dtr1["Address"].ToString(); AddressTxt.Show();

                    //txtbx
                    DesigCmbBox.Text = m1;
                    AddressTxt.Text = m2;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            conx1.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string strUpd = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strUpd);

            cnx.Open();
            if (facultyCmbBox.Text == "CSE")
            {
                //This code is susceptible to SQL injection attacks.
                string strQry = "UPDATE CSETeacherInformation  set Designation = '" + this.DesigCmbBox.Text + "', Address = '" + this.AddressTxt.Text + "'WHERE TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";
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
                string strQry = "UPDATE BBATeacherInformation  set Designation = '" + this.DesigCmbBox.Text + "', Address = '" + this.AddressTxt.Text + "'WHERE TeacherName = '" + this.TeacherNamTxt.Text + "'AND  Faculty = '" + this.facultyCmbBox.Text + "'";
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

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            AccountingSection f2 = new AccountingSection();
            f2.Show();
            this.Hide();

        }

       
    }
}
