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
    public partial class Student_Info : Form
    {
        SqlConnection con;
        SqlCommand com;

        public Student_Info()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Cnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx = new SqlConnection(Cnx);

            conx.Open();

            //This code is susceptible to SQL injection attacks.
            string Qry = "SELECT * FROM Student_infotb where Reg_no='" + stregtxt.Text + "' ";
            //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
            // int intRecs;


            SqlCommand comd = new SqlCommand(Qry, conx);

            SqlDataReader dtr = comd.ExecuteReader();
            dtr.Read();
            try
            {

                String a = dtr["Student_name"].ToString();
                String b = dtr["Reg_no"].ToString();
                String c = dtr["Faculty"].ToString();
                String d = dtr["Session"].ToString();

                stnametxt.Text = a;
                stregtxt.Text = b;
                facultycmb.Text = c;
                stsessiontxt.Text = d;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


            conx.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string strCnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strCnx);

            cnx.Open();

            //This code is susceptible to SQL injection attacks.
            string strQry = "UPDATE Student_infotb set Student_name = '" + this.stnametxt.Text + "',Faculty = '" + this.facultycmb.Text + "', Session = '" + this.stsessiontxt.Text + "' WHERE Reg_no='" + this.stregtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(strQry, cnx);
            try
            {


                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();



            if (con.State == ConnectionState.Open)
            {


                com = new SqlCommand("INSERT INTO Student_infotb values ('" + stnametxt.Text + "','" + stregtxt.Text + "','" + facultycmb.Text + "','" + stsessiontxt.Text + "')", con);

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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();



            if (con.State == ConnectionState.Open)
            {


                SqlCommand cmd = new SqlCommand("DELETE FROM CSE WHERE one='11'", con);
                com = new SqlCommand("DELETE FROM Student_infotb WHERE Reg_no='" + this.stregtxt.Text + "'", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Delete successfull");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Result_Section f1 = new Result_Section();
            f1.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            stnametxt.Text = " ";
            stregtxt.Text = " ";
            facultycmb.Text = " ";
            stsessiontxt.Text = " ";
            this.Show();
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
