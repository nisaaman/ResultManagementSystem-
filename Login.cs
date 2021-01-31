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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void admloginbtn_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            a = admlogintxt.Text;
            b = admpasswordtxt.Text;
            if ((a == "pstu" ) && b == "123")
            {
                Overview f2 = new Overview();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Wrong User Name OR Password");
                admlogintxt.Text = "";
                admpasswordtxt.Text = "";
            }
            this.Hide();
        }

        private void stloginbtn_Click(object sender, EventArgs e)
        {
            string strCnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strCnx);

            cnx.Open();

            //This code is susceptible to SQL injection attacks.
            string strQry = "SELECT Count(*) FROM Registrationtb WHERE name='" + Logintxt.Text + "' AND Password='" + Passwordtxt.Text + "'";
            int intRecs;

            SqlCommand cmd = new SqlCommand(strQry, cnx);
            intRecs = (int)cmd.ExecuteScalar();

            if (intRecs > 0)
            {
                Overview mp = new Overview();
                mp.Show();
                Logintxt.Text = "";
                Passwordtxt.Text = "";
                this.Hide();

                //MessageBox.Show("login successfull");
            }
            else
            {
                MessageBox.Show("invalid information");
            }

            cnx.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Registration_Form Registration_Form = new Registration_Form();

            Registration_Form.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void changepasswordbtn_Click(object sender, EventArgs e)
        {
            Registration_Form Registration_Form = new Registration_Form();

            Registration_Form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
