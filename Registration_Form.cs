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
    public partial class Registration_Form : Form
    {
        SqlConnection con;
        SqlCommand com;
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void updtlogininfobtn_Click(object sender, EventArgs e)
        {
            string strCnx =@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx = new SqlConnection(strCnx);

            cnx.Open();

            string strQry = "SELECT Count(*) FROM Registrationtb WHERE name='" + otherNametxt.Text + "' AND Password='" + updtoldpassword.Text + "'";
                int intRecs;

                SqlCommand cmd = new SqlCommand(strQry, cnx);
                intRecs = (int)cmd.ExecuteScalar();

                if (intRecs > 0)
                {
                    try
                    {
                        com = new SqlCommand(("update Registrationtb set Password='" + updtnewpassword.Text + "' where Password='" + updtoldpassword.Text + "'"), cnx);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Password change successfully");
                        Login loginfrm = new Login();
                        loginfrm.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else MessageBox.Show("Invalid information");
                cnx.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            com = new SqlCommand("INSERT INTO Registrationtb values ('" + Nametxt.Text + "','" + Passwordtxt.Text + "')", con);
            try
                {

                    if (con.State == ConnectionState.Open)
                    {                                                
                        com.ExecuteNonQuery();
                        MessageBox.Show("Registration successfull");

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                con.Close();
                Login loginfrm = new Login();
                loginfrm.Show();
                this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
