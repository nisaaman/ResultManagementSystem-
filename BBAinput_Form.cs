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
    public partial class BBAinput_Form : Form
    {
        SqlConnection con;

        SqlCommand com;
        public BBAinput_Form()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(semestercmb.Text) - 1;

            string Cnx = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx = new SqlConnection(Cnx);

            conx.Open();
            string Qry = "SELECT * FROM Marks2tb where Reg='" + rgtxt.Text + "'AND Semester='" + semester.ToString() + "' ";
            SqlCommand comd = new SqlCommand(Qry, conx);
            SqlDataReader dtr = comd.ExecuteReader();
            dtr.Read();
            try
            {
                precgpatxt.Text = dtr["CGPA"].ToString();
            }
            catch
            {
                precgpatxt.Text = "0.00";
            }
            try
            {
                //String a1 = dtr["Pre_CCH"].ToString();
                String a2 = dtr["CCH"].ToString();
                //double a1i = Convert.ToDouble(a1);
                double a2i = Convert.ToDouble(a2);
                //double a1a2 = a1i + a2i;
                precchtxt.Text = a2i.ToString();
            }
            catch
            {
                precchtxt.Text = "0.00";
            }

            string mid1 = mdmrk1txt.Text;
            string aten1 = atdnc1txt.Text;
            string final1 = fnlmrk1txt.Text;
            string sspresen1 = sesprsnt1txt.Text;
            int mid1i = Convert.ToInt32(mid1);
            int aten1i = Convert.ToInt32(aten1);
            int final1i = Convert.ToInt32(final1);
            int sspresen1i = Convert.ToInt32(sspresen1);
            if (mid1i < 0 || mid1i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk1txt.Text = " ";
            }

            if (aten1i < 7 || aten1i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc1txt.Text = "0.00";
            }
            if (final1i < 0 || final1i > 50)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk1txt.Text = " ";
            }
            if (sspresen1i < 0 || sspresen1i > 20)
            {
                MessageBox.Show("Invalid Data");
                sesprsnt1txt.Text = " ";
            }
            int total1i = mid1i + aten1i + final1i;
            int totalob1i = total1i + sspresen1i;

            //string total = totali.ToString();
            ttlmrk1txt.Text = total1i.ToString();
            ttlmrkobtnd1txt.Text = totalob1i.ToString();
            scor1txt.Text = totalob1i.ToString();
            if (totalob1i >= 80 && totalob1i <= 100)
            {
                lettergrd1txt.Text = "A+";
                gp1txt.Text = "4";
            }
            if (totalob1i >= 75 && totalob1i < 80)
            {
                lettergrd1txt.Text = "A";
                gp1txt.Text = "3.75";
            }
            if (totalob1i >= 70 && totalob1i <= 74)
            {
                lettergrd1txt.Text = "A-";
                gp1txt.Text = "3.5";
            }
            if (totalob1i >= 65 && totalob1i <= 69)
            {
                lettergrd1txt.Text = "B+";
                gp1txt.Text = "3.25";
            }
            if (totalob1i >= 60 && totalob1i <= 64)
            {
                lettergrd1txt.Text = "B";
                gp1txt.Text = "3.00";
            }
            if (totalob1i >= 55 && totalob1i <= 59)
            {
                lettergrd1txt.Text = "B-";
                gp1txt.Text = "2.75";
            }
            if (totalob1i >= 50 && totalob1i <= 54)
            {
                lettergrd1txt.Text = "C";
                gp1txt.Text = "2.50";
            }
            if (totalob1i >= 45 && totalob1i <= 49)
            {
                lettergrd1txt.Text = "D";
                gp1txt.Text = "2.00";
            }
            if (totalob1i < 45)
            {
                remrkf1txt.Text = "F";
                lettergrd1txt.Text = "F";
                gp1txt.Text = "0.00";
            }



            string mid2 = mdmrk2txt.Text;
            string aten2 = atdnc2txt.Text;
            string final2 = fnlmrk2txt.Text;
            string sspresen2 = sesprsnt2txt.Text;
            int mid2i = Convert.ToInt32(mid2);
            int aten2i = Convert.ToInt32(aten2);
            int final2i = Convert.ToInt32(final2);
            int sspresen2i = Convert.ToInt32(sspresen2);
            if (mid2i < 0 || mid2i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk2txt.Text = " ";
            }
            if (aten2i < 0 || aten2i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc2txt.Text = " ";
            }
            if (final2i < 7 || final2i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk2txt.Text = "0.00";
            }
            if (sspresen2i < 0 || sspresen2i > 20)
            {
                MessageBox.Show("Invalid Data");
                sesprsnt2txt.Text = " ";
            }
            int total2i = mid2i + aten2i + final2i;
            int totalob2i = total2i + sspresen2i;
            ttlmrk2txt.Text = total2i.ToString();
            ttlmrkobtnd2txt.Text = totalob2i.ToString();
            scor2txt.Text = totalob2i.ToString();
            if (totalob2i >= 80 && totalob2i <= 100)
            {
                lettergrd2txt.Text = "A+";
                gp2txt.Text = "4";
            }
            if (totalob2i >= 75 && totalob2i < 80)
            {
                lettergrd2txt.Text = "A";
                gp2txt.Text = "3.75";
            }
            if (totalob2i >= 70 && totalob2i <= 74)
            {
                lettergrd2txt.Text = "A-";
                gp2txt.Text = "3.5";
            }
            if (totalob2i >= 65 && totalob2i <= 69)
            {
                lettergrd2txt.Text = "B+";
                gp2txt.Text = "3.25";
            }
            if (totalob2i >= 60 && totalob2i <= 64)
            {
                lettergrd2txt.Text = "B";
                gp2txt.Text = "3.00";
            }
            if (totalob2i >= 55 && totalob2i <= 59)
            {
                lettergrd2txt.Text = "B-";
                gp2txt.Text = "2.75";
            }
            if (totalob2i >= 50 && totalob2i <= 54)
            {
                lettergrd2txt.Text = "C";
                gp2txt.Text = "2.50";
            }
            if (totalob2i >= 45 && totalob2i <= 49)
            {
                lettergrd2txt.Text = "D";
                gp2txt.Text = "2.00";
            }
            if (totalob2i < 45)
            {
                remrkf2txt.Text = "F";
                lettergrd2txt.Text = "F";
                gp2txt.Text = "0.00";
            }


            string mid3 = mdmrk3txt.Text;
            string aten3 = atdnc3txt.Text;
            string final3 = fnlmrk3txt.Text;
            string sspresen3 = sesprsnt3txt.Text;
            int mid3i = Convert.ToInt32(mid3);
            int aten3i = Convert.ToInt32(aten3);
            int final3i = Convert.ToInt32(final3);
            int sspresen3i = Convert.ToInt32(sspresen3);
            if (mid3i < 0 || mid3i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk3txt.Text = " ";
            }
            if (aten3i < 7 || aten3i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc3txt.Text = "0.00";
            }
            if (final3i < 0 || final3i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk3txt.Text = " ";
            }
            if (sspresen3i < 0 || sspresen3i > 20)
            {
                MessageBox.Show("Invalid Data");
                sesprsnt3txt.Text = " ";
            }
            int total3i = mid3i + aten3i + final3i;
            int totalob3i = total3i + sspresen3i;
            ttlmrk3txt.Text = total3i.ToString();
            ttlmrkobtnd3txt.Text = totalob3i.ToString();
            scor3txt.Text = totalob3i.ToString();
            if (totalob3i >= 80 && totalob3i <= 100)
            {
                lettergrd3txt.Text = "A+";
                gp3txt.Text = "4";
            }
            if (totalob3i >= 75 && totalob3i < 80)
            {
                lettergrd3txt.Text = "A";
                gp3txt.Text = "3.75";
            }
            if (totalob3i >= 70 && totalob3i <= 74)
            {
                lettergrd3txt.Text = "A-";
                gp3txt.Text = "3.5";
            }
            if (totalob3i >= 65 && totalob3i <= 69)
            {
                lettergrd3txt.Text = "B+";
                gp3txt.Text = "3.25";
            }
            if (totalob3i >= 60 && totalob3i <= 64)
            {
                lettergrd3txt.Text = "B";
                gp3txt.Text = "3.00";
            }
            if (totalob3i >= 55 && totalob3i <= 59)
            {
                lettergrd3txt.Text = "B-";
                gp3txt.Text = "2.75";
            }
            if (totalob3i >= 50 && totalob3i <= 54)
            {
                lettergrd3txt.Text = "C";
                gp3txt.Text = "2.50";
            }
            if (totalob3i >= 45 && totalob3i <= 49)
            {
                lettergrd3txt.Text = "D";
                gp3txt.Text = "2.00";
            }
            if (totalob3i < 45)
            {
                remrkf3txt.Text = "F";
                lettergrd3txt.Text = "F";
                gp3txt.Text = "0.00";
            }


            string mid4 = mdmrk4txt.Text;
            string aten4 = atdnc4txt.Text;
            string final4 = fnlmrk4txt.Text;
            string sspresen4 = sesprsnt4txt.Text;
            int mid4i = Convert.ToInt32(mid4);
            int aten4i = Convert.ToInt32(aten4);
            int final4i = Convert.ToInt32(final4);
            int sspresen4i = Convert.ToInt32(sspresen4);
            if (mid4i < 0 || mid4i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk4txt.Text = " ";
            }
            if (aten4i < 7 || aten4i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc4txt.Text = "0.00";
            }
            if (final4i < 0 || final4i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk4txt.Text = " ";
            }
            if (sspresen4i < 0 || sspresen4i > 20)
            {
                MessageBox.Show("Invalid Data");
                sesprsnt4txt.Text = " ";
            }
            int total4i = mid4i + aten4i + final4i;
            int totalob4i = total4i + sspresen4i;
            ttlmrk4txt.Text = total4i.ToString();
            ttlmrkobtnd4txt.Text = totalob4i.ToString();
            scor4txt.Text = totalob4i.ToString();
            if (totalob4i >= 80 && totalob4i <= 100)
            {
                lettergrd4txt.Text = "A+";
                gp4txt.Text = "4";
            }
            if (totalob4i >= 75 && totalob4i < 80)
            {
                lettergrd4txt.Text = "A";
                gp4txt.Text = "3.75";
            }
            if (totalob4i >= 70 && totalob4i <= 74)
            {
                lettergrd4txt.Text = "A-";
                gp4txt.Text = "3.5";
            }
            if (totalob4i >= 65 && totalob4i <= 69)
            {
                lettergrd4txt.Text = "B+";
                gp4txt.Text = "3.25";
            }
            if (totalob4i >= 60 && totalob4i <= 64)
            {
                lettergrd4txt.Text = "B";
                gp4txt.Text = "3.00";
            }
            if (totalob4i >= 55 && totalob4i <= 59)
            {
                lettergrd4txt.Text = "B-";
                gp4txt.Text = "2.75";
            }
            if (totalob4i >= 50 && totalob4i <= 54)
            {
                lettergrd4txt.Text = "C";
                gp4txt.Text = "2.50";
            }
            if (totalob4i >= 45 && totalob4i <= 49)
            {
                lettergrd4txt.Text = "D";
                gp4txt.Text = "2.00";
            }
            if (totalob4i < 45)
            {
                remrkf4txt.Text = "F";
                lettergrd4txt.Text = "F";
                gp4txt.Text = "0.00";
            }


            string mid5 = mdmrk5txt.Text;
            string aten5 = atdnc5txt.Text;
            string final5 = fnlmrk5txt.Text;
            string sspresen5 = sesprsnt5txt.Text;
            int mid5i = Convert.ToInt32(mid5);
            int aten5i = Convert.ToInt32(aten5);
            int final5i = Convert.ToInt32(final5);
            int sspresen5i = Convert.ToInt32(sspresen5);
            if (mid5i < 0 || mid5i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk5txt.Text = " ";
            }
            if (aten5i < 7 || aten5i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc5txt.Text = "0.00";
            }
            if (final5i < 0 || final5i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk5txt.Text = " ";
            }
            if (sspresen5i < 0 || sspresen5i > 20)
            {
                MessageBox.Show("Invalid Data");
                sesprsnt5txt.Text = " ";
            }
            int total5i = mid5i + aten5i + final5i;
            int totalob5i = total5i + sspresen5i;
            ttlmrk5txt.Text = total5i.ToString();
            ttlmrkobtnd5txt.Text = totalob5i.ToString();
            scor5txt.Text = totalob5i.ToString();
            if (totalob5i >= 80 && totalob5i <= 100)
            {
                lettergrd5txt.Text = "A+";
                gp5txt.Text = "4";
            }
            if (totalob5i >= 75 && totalob5i < 80)
            {
                lettergrd5txt.Text = "A";
                gp5txt.Text = "3.75";
            }
            if (totalob5i >= 70 && totalob5i <= 74)
            {
                lettergrd5txt.Text = "A-";
                gp5txt.Text = "3.5";
            }
            if (totalob5i >= 65 && totalob5i <= 69)
            {
                lettergrd5txt.Text = "B+";
                gp5txt.Text = "3.25";
            }
            if (totalob5i >= 60 && totalob5i <= 64)
            {
                lettergrd5txt.Text = "B";
                gp5txt.Text = "3.00";
            }
            if (totalob5i >= 55 && totalob5i <= 59)
            {
                lettergrd5txt.Text = "B-";
                gp5txt.Text = "2.75";
            }
            if (totalob5i >= 50 && totalob5i <= 54)
            {
                lettergrd5txt.Text = "C";
                gp5txt.Text = "2.50";
            }
            if (totalob5i >= 45 && totalob5i <= 49)
            {
                lettergrd5txt.Text = "D";
                gp5txt.Text = "2.00";
            }
            if (totalob5i < 45)
            {
                remrkf5txt.Text = "F";
                lettergrd5txt.Text = "F";
                gp5txt.Text = "0.00";
            }



            string final6 = fnlmrk6txt.Text;

            int final6i = Convert.ToInt32(final6);

            if (final6i < 0 || final6i > 20)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk6txt.Text = " ";
            }
            int total6i = final6i;
            int totalob6i = total6i;
            ttlmrk6txt.Text = total6i.ToString();
            ttlmrkobtnd6txt.Text = totalob6i.ToString();

            int score6 = total6i * 4;
            scor6txt.Text = score6.ToString();
            if (score6 >= 80 && score6 <= 100)
            {
                lettergrd6txt.Text = "A+";
                gp6txt.Text = "4";
            }
            if (score6 >= 75 && score6 < 80)
            {
                lettergrd6txt.Text = "A";
                gp6txt.Text = "3.75";
            }
            if (score6 >= 70 && score6 <= 74)
            {
                lettergrd6txt.Text = "A-";
                gp6txt.Text = "3.5";
            }
            if (score6 >= 65 && score6 <= 69)
            {
                lettergrd6txt.Text = "B+";
                gp6txt.Text = "3.25";
            }
            if (score6 >= 60 && score6 <= 64)
            {
                lettergrd6txt.Text = "B";
                gp6txt.Text = "3.00";
            }
            if (score6 >= 55 && score6 <= 59)
            {
                lettergrd6txt.Text = "B-";
                gp6txt.Text = "2.75";
            }
            if (score6 >= 50 && score6 <= 54)
            {
                lettergrd6txt.Text = "C";
                gp6txt.Text = "2.50";
            }
            if (score6 >= 45 && score6 <= 49)
            {
                lettergrd6txt.Text = "D";
                gp6txt.Text = "2.00";
            }
            if (score6 < 45)
            {
                remrkf6txt.Text = "F";
                lettergrd6txt.Text = "F";
                gp6txt.Text = "0.00";
            }






            string b1 = gp1txt.Text;
            string b2 = gp2txt.Text;
            string b3 = gp3txt.Text;
            string b4 = gp4txt.Text;
            string b5 = gp5txt.Text;
            string b6 = gp6txt.Text;


            double b1i = Convert.ToDouble(b1);
            double b2i = Convert.ToDouble(b2);
            double b3i = Convert.ToDouble(b3);
            double b4i = Convert.ToDouble(b4);
            double b5i = Convert.ToDouble(b5);
            double b6i = Convert.ToDouble(b6);



            string p1 = crdhr1txt.Text;
            string p2 = crdhr2txt.Text;
            string p3 = crdhr3txt.Text;
            string p4 = crdhr4txt.Text;
            string p5 = crdhr5txt.Text;
            string p6 = crdhr6txt.Text;



            double p1i = Convert.ToDouble(p1);
            double p2i = Convert.ToDouble(p2);
            double p3i = Convert.ToDouble(p3);
            double p4i = Convert.ToDouble(p4);
            double p5i = Convert.ToDouble(p5);
            double p6i = Convert.ToDouble(p6);

            if (b1i == 0.00)
            {
                p1i = 0.00;
            }
            if (b2i == 0.00)
            {
                p2i = 0.00;
            }
            if (b3i == 0.00)
            {
                p3i = 0.00;
            }
            if (b4i == 0.00)
            {
                p4i = 0.00;
            }
            if (b5i == 0.00)
            {
                p5i = 0.00;
            }
            if (b6i == 0.00)
            {
                p6i = 0.00;
            }



            double pp = p1i + p2i + p3i + p4i + p5i + p6i;
            //cchtxt.Text = pp.ToString();
            double c = (b1i * p1i + b2i * p2i + b3i * p3i + b4i * p4i + b5i * p5i + b6i * p6i) / pp;
            gpatxt.Text = c.ToString();
            string d1 = gpatxt.Text;
            string d2 = precgpatxt.Text;
            string d3 = precchtxt.Text;
            double d1i = Convert.ToDouble(d1);
            double d2i = Convert.ToDouble(d2);
            double d3i = Convert.ToDouble(d3);
            double dd = (d1i * pp + d2i * d3i) / (pp + d3i);
            cgpatxt.Text = dd.ToString();
            cchtxt.Text = (pp + d3i).ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ResultMaking_Form f2 = new ResultMaking_Form();
            f2.Show();
            this.Hide();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();



            if (con.State == ConnectionState.Open)
            {


                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + sesprsnt1txt.Text + "','" + ttlmrkobtnd1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + sesprsnt2txt.Text + "','" + ttlmrkobtnd2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + sesprsnt3txt.Text + "','" + ttlmrkobtnd3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + sesprsnt4txt.Text + "','" + ttlmrkobtnd4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + sesprsnt5txt.Text + "','" + ttlmrkobtnd5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                com = new SqlCommand("INSERT INTO BBA_Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + sesprsnt6txt.Text + "','" + ttlmrkobtnd6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                //MessageBox.Show(ex.Message);





                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
                con.Open();
                com = new SqlCommand("INSERT INTO Marks2tb values ('" + rgtxt.Text + "','" + semestercmb.Text + "','" + gpatxt.Text + "','" + precgpatxt.Text + "','" + precchtxt.Text + "','" + cgpatxt.Text + "','" + cchtxt.Text + "','" + remarkstxt.Text + "')", con);
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        com.ExecuteNonQuery();

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Insert successfull");
            }

            else MessageBox.Show("Invalid");
            con.Close();      
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            con.Open();



            if (con.State == ConnectionState.Open)
            {


                // SqlCommand cmd = new SqlCommand("DELETE FROM CSE WHERE one='11'", con);
                com = new SqlCommand("DELETE FROM BBA_Marks1tb WHERE Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "' ", con);

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
            if (con.State == ConnectionState.Open)
            {


                // SqlCommand cmd = new SqlCommand("DELETE FROM CSE WHERE one='11'", con);
                com = new SqlCommand("DELETE FROM Marks2tb WHERE Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "'", con);

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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string Cnx1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx1 = new SqlConnection(Cnx1);

            conx1.Open();

            //This code is susceptible to SQL injection attacks.
            string Qry1 = "SELECT * FROM Marks2tb where Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "' ";
            //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
            // int intRecs;


            SqlCommand comd1 = new SqlCommand(Qry1, conx1);

            SqlDataReader dtr1 = comd1.ExecuteReader();
            dtr1.Read();
            try
            {

                String m1 = dtr1["GPA"].ToString(); gpatxt.Show();
                String m2 = dtr1["Pre_CGPA"].ToString(); precgpatxt.Show();
                String m3 = dtr1["Pre_CCH"].ToString(); precchtxt.Show();
                String m4 = dtr1["CGPA"].ToString(); cgpatxt.Show();
                String m5 = dtr1["CCH"].ToString(); cchtxt.Show();
                String m6 = dtr1["Remarks"].ToString(); remarkstxt.Show();

                //txtbx
                gpatxt.Text = m1;
                precgpatxt.Text = m2;
                precchtxt.Text = m3;
                cgpatxt.Text = m4;
                cchtxt.Text = m5;
                remarkstxt.Text = m6;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


            conx1.Close();

            string Cnx2 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx2 = new SqlConnection(Cnx2);

            conx2.Open();

            //This code is susceptible to SQL injection attacks.
            string Qry2 = "SELECT * FROM BBA_Marks1tb where Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "' ";




            SqlCommand comd2 = new SqlCommand(Qry2, conx2);

            SqlDataReader dtr2 = comd2.ExecuteReader();

            for (int i = 0; dtr2.Read(); i++)
            {

                if (i == 0) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl1txt.Text = dtr2["SL_NO"].ToString(); crscd1txt.Text = dtr2["Course_code"].ToString(); crsttl1txt.Text = dtr2["Course_Tittle"].ToString(); crdhr1txt.Text = dtr2["Credit_hour"].ToString(); mdmrk1txt.Text = dtr2["Mid_exam"].ToString(); atdnc1txt.Text = dtr2["Attendence"].ToString(); fnlmrk1txt.Text = dtr2["Final_exam"].ToString(); ttlmrk1txt.Text = dtr2["Total_marks"].ToString(); sesprsnt1txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd1txt.Text = dtr2["Total_marksob"].ToString(); remrkf1txt.Text = dtr2["Remarks_FI"].ToString(); scor1txt.Text = dtr2["Score"].ToString(); lettergrd1txt.Text = dtr2["Letter_grade"].ToString(); gp1txt.Text = dtr2["GP"].ToString(); }
                if (i == 1) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl2txt.Text = dtr2["SL_NO"].ToString(); crscd2txt.Text = dtr2["Course_code"].ToString(); crsttl2txt.Text = dtr2["Course_Tittle"].ToString(); crdhr2txt.Text = dtr2["Credit_hour"].ToString(); mdmrk2txt.Text = dtr2["Mid_exam"].ToString(); atdnc2txt.Text = dtr2["Attendence"].ToString(); fnlmrk2txt.Text = dtr2["Final_exam"].ToString(); ttlmrk2txt.Text = dtr2["Total_marks"].ToString(); sesprsnt2txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd2txt.Text = dtr2["Total_marksob"].ToString(); remrkf2txt.Text = dtr2["Remarks_FI"].ToString(); scor2txt.Text = dtr2["Score"].ToString(); lettergrd2txt.Text = dtr2["Letter_grade"].ToString(); gp2txt.Text = dtr2["GP"].ToString(); }
                if (i == 2) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl3txt.Text = dtr2["SL_NO"].ToString(); crscd3txt.Text = dtr2["Course_code"].ToString(); crsttl3txt.Text = dtr2["Course_Tittle"].ToString(); crdhr3txt.Text = dtr2["Credit_hour"].ToString(); mdmrk3txt.Text = dtr2["Mid_exam"].ToString(); atdnc3txt.Text = dtr2["Attendence"].ToString(); fnlmrk3txt.Text = dtr2["Final_exam"].ToString(); ttlmrk3txt.Text = dtr2["Total_marks"].ToString(); sesprsnt3txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd3txt.Text = dtr2["Total_marksob"].ToString(); remrkf3txt.Text = dtr2["Remarks_FI"].ToString(); scor3txt.Text = dtr2["Score"].ToString(); lettergrd3txt.Text = dtr2["Letter_grade"].ToString(); gp3txt.Text = dtr2["GP"].ToString(); }
                if (i == 3) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl4txt.Text = dtr2["SL_NO"].ToString(); crscd4txt.Text = dtr2["Course_code"].ToString(); crsttl4txt.Text = dtr2["Course_Tittle"].ToString(); crdhr4txt.Text = dtr2["Credit_hour"].ToString(); mdmrk4txt.Text = dtr2["Mid_exam"].ToString(); atdnc4txt.Text = dtr2["Attendence"].ToString(); fnlmrk4txt.Text = dtr2["Final_exam"].ToString(); ttlmrk4txt.Text = dtr2["Total_marks"].ToString(); sesprsnt4txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd4txt.Text = dtr2["Total_marksob"].ToString(); remrkf4txt.Text = dtr2["Remarks_FI"].ToString(); scor4txt.Text = dtr2["Score"].ToString(); lettergrd4txt.Text = dtr2["Letter_grade"].ToString(); gp4txt.Text = dtr2["GP"].ToString(); }
                if (i == 4) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl5txt.Text = dtr2["SL_NO"].ToString(); crscd5txt.Text = dtr2["Course_code"].ToString(); crsttl5txt.Text = dtr2["Course_Tittle"].ToString(); crdhr5txt.Text = dtr2["Credit_hour"].ToString(); mdmrk5txt.Text = dtr2["Mid_exam"].ToString(); atdnc5txt.Text = dtr2["Attendence"].ToString(); fnlmrk5txt.Text = dtr2["Final_exam"].ToString(); ttlmrk5txt.Text = dtr2["Total_marks"].ToString(); sesprsnt5txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd5txt.Text = dtr2["Total_marksob"].ToString(); remrkf5txt.Text = dtr2["Remarks_FI"].ToString(); scor5txt.Text = dtr2["Score"].ToString(); lettergrd5txt.Text = dtr2["Letter_grade"].ToString(); gp5txt.Text = dtr2["GP"].ToString(); }
                if (i == 5) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl6txt.Text = dtr2["SL_NO"].ToString(); crscd6txt.Text = dtr2["Course_code"].ToString(); crsttl6txt.Text = dtr2["Course_Tittle"].ToString(); crdhr6txt.Text = dtr2["Credit_hour"].ToString(); mdmrk6txt.Text = dtr2["Mid_exam"].ToString(); atdnc6txt.Text = dtr2["Attendence"].ToString(); fnlmrk6txt.Text = dtr2["Final_exam"].ToString(); ttlmrk6txt.Text = dtr2["Total_marks"].ToString(); sesprsnt6txt.Text = dtr2["ssPresentation"].ToString(); ttlmrkobtnd6txt.Text = dtr2["Total_marksob"].ToString(); remrkf6txt.Text = dtr2["Remarks_FI"].ToString(); scor6txt.Text = dtr2["Score"].ToString(); lettergrd6txt.Text = dtr2["Letter_grade"].ToString(); gp6txt.Text = dtr2["GP"].ToString(); }

                //MessageBox.Show(dtr1["CourseTitle"].ToString());
            }


            conx2.Close();


            //Input_Form f2 = new Input_Form();
            string Cnx3 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\controller\controller\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conx3 = new SqlConnection(Cnx3);

            conx3.Open();

            //This code is susceptible to SQL injection attacks.
            string Qry3 = "SELECT * FROM Student_infotb where Reg_no='" + rgtxt.Text + "' ";
            //AND authoronefirstname='" + aonefstnm.Text + "' AND bookname='" + bknm.Text + "' ";
            // int intRecs;


            SqlCommand comd3 = new SqlCommand(Qry3, conx3);

            SqlDataReader dtr3 = comd3.ExecuteReader();
            dtr3.Read();
            try
            {

                String a = dtr3["Student_name"].ToString();

                String c = dtr3["Session"].ToString();

                stnametxt.Text = a;

                sessiontxt.Text = c;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


            conx3.Close();
        
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string strCnx5 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx5 = new SqlConnection(strCnx5);

            cnx5.Open();

            //This code is susceptible to SQL injection attacks.
            string strQry5 = "UPDATE Marks2tb set GPA = '" + this.gpatxt.Text + "', Pre_CGPA = '" + this.precgpatxt.Text + "' , Pre_CCH= '" + this.precchtxt.Text + "', CGPA = '" + this.cgpatxt.Text + "', CCH = '" + this.cchtxt.Text + "', Remarks = '" + this.remarkstxt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'";
            SqlCommand cmd5 = new SqlCommand(strQry5, cnx5);
            try
            {


                cmd5.ExecuteNonQuery();
                // MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string strCnx6 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\controller\controller\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx6 = new SqlConnection(strCnx6);

            cnx6.Open();

            //This code is susceptible to SQL injection attacks.
            string strQry6 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd1txt.Text + "', Course_Tittle = '" + this.crsttl1txt.Text + "', Credit_hour = '" + this.crdhr1txt.Text + "', Mid_exam = '" + this.mdmrk1txt.Text + "', Attendence = '" + this.atdnc1txt.Text + "', Final_exam = '" + this.fnlmrk1txt.Text + "', Total_marks = '" + this.ttlmrk1txt.Text + "',ssPresentation = '" + this.sesprsnt1txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd1txt.Text + "',Remarks_FI = '" + this.remrkf1txt.Text + "', Score = '" + this.scor1txt.Text + "', Letter_grade = '" + this.lettergrd1txt.Text + "', GP = '" + this.gp1txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '01'";
            SqlCommand cmd6 = new SqlCommand(strQry6, cnx6);
            try
            {


                cmd6.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string strQry7 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd2txt.Text + "', Course_Tittle = '" + this.crsttl2txt.Text + "', Credit_hour = '" + this.crdhr2txt.Text + "', Mid_exam = '" + this.mdmrk2txt.Text + "', Attendence = '" + this.atdnc2txt.Text + "', Final_exam = '" + this.fnlmrk2txt.Text + "', Total_marks = '" + this.ttlmrk2txt.Text + "',ssPresentation = '" + this.sesprsnt2txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd2txt.Text + "', Remarks_FI = '" + this.remrkf2txt.Text + "', Score = '" + this.scor2txt.Text + "', Letter_grade = '" + this.lettergrd2txt.Text + "', GP = '" + this.gp2txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '02'";
            SqlCommand cmd7 = new SqlCommand(strQry7, cnx6);
            try
            {


                cmd7.ExecuteNonQuery();
                // MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string strQry8 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd3txt.Text + "', Course_Tittle = '" + this.crsttl3txt.Text + "', Credit_hour = '" + this.crdhr3txt.Text + "', Mid_exam = '" + this.mdmrk3txt.Text + "', Attendence = '" + this.atdnc3txt.Text + "', Final_exam = '" + this.fnlmrk3txt.Text + "', Total_marks = '" + this.ttlmrk3txt.Text + "',ssPresentation = '" + this.sesprsnt3txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd3txt.Text + "', Remarks_FI = '" + this.remrkf3txt.Text + "', Score = '" + this.scor3txt.Text + "', Letter_grade = '" + this.lettergrd3txt.Text + "', GP = '" + this.gp3txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '03'";
            SqlCommand cmd8 = new SqlCommand(strQry8, cnx6);
            try
            {


                cmd8.ExecuteNonQuery();
                // MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            string strQry9 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd4txt.Text + "', Course_Tittle = '" + this.crsttl4txt.Text + "', Credit_hour = '" + this.crdhr4txt.Text + "', Mid_exam = '" + this.mdmrk4txt.Text + "', Attendence = '" + this.atdnc4txt.Text + "', Final_exam = '" + this.fnlmrk4txt.Text + "', Total_marks = '" + this.ttlmrk4txt.Text + "',ssPresentation = '" + this.sesprsnt4txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd4txt.Text + "', Remarks_FI = '" + this.remrkf4txt.Text + "', Score = '" + this.scor4txt.Text + "', Letter_grade = '" + this.lettergrd4txt.Text + "', GP = '" + this.gp4txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '04'";
            SqlCommand cmd9 = new SqlCommand(strQry9, cnx6);
            try
            {


                cmd9.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string strQry10 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd5txt.Text + "', Course_Tittle = '" + this.crsttl5txt.Text + "', Credit_hour = '" + this.crdhr5txt.Text + "', Mid_exam = '" + this.mdmrk5txt.Text + "', Attendence = '" + this.atdnc5txt.Text + "', Final_exam = '" + this.fnlmrk5txt.Text + "', Total_marks = '" + this.ttlmrk5txt.Text + "',ssPresentation = '" + this.sesprsnt5txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd5txt.Text + "', Remarks_FI = '" + this.remrkf5txt.Text + "', Score = '" + this.scor5txt.Text + "', Letter_grade = '" + this.lettergrd5txt.Text + "', GP = '" + this.gp5txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '05'";
            SqlCommand cmd10 = new SqlCommand(strQry10, cnx6);
            try
            {


                cmd10.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string strQry11 = "UPDATE BBA_Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd6txt.Text + "', Course_Tittle = '" + this.crsttl6txt.Text + "', Credit_hour = '" + this.crdhr6txt.Text + "',  Final_exam = '" + this.fnlmrk6txt.Text + "', Total_marks = '" + this.ttlmrk6txt.Text + "', Total_marksob = '" + this.ttlmrkobtnd6txt.Text + "',Remarks_FI = '" + this.remrkf6txt.Text + "', Score = '" + this.scor6txt.Text + "', Letter_grade = '" + this.lettergrd6txt.Text + "', GP = '" + this.gp6txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '06'";
            SqlCommand cmd11 = new SqlCommand(strQry11, cnx6);
            try
            {


                cmd11.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            MessageBox.Show("Update successfull");
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            gpatxt.Text = "";
            precgpatxt.Text = "";
            precchtxt.Text = "";
            cgpatxt.Text = "";
            cchtxt.Text = "";
            remarkstxt.Text = "";



            sl1txt.Text = "";
            sl2txt.Text = "";
            sl3txt.Text = "";
            sl4txt.Text = "";
            sl5txt.Text = "";
            sl6txt.Text = "";


            crscd1txt.Text = "";
            crscd2txt.Text = "";
            crscd3txt.Text = "";
            crscd4txt.Text = "";
            crscd5txt.Text = "";
            crscd6txt.Text = "";


            crsttl1txt.Text = "";
            crsttl2txt.Text = "";
            crsttl3txt.Text = "";
            crsttl4txt.Text = "";
            crsttl5txt.Text = "";
            crsttl6txt.Text = "";


            crdhr1txt.Text = "";
            crdhr2txt.Text = "";
            crdhr3txt.Text = "";
            crdhr4txt.Text = "";
            crdhr5txt.Text = "";
            crdhr6txt.Text = "";

            mdmrk1txt.Text = "";
            mdmrk2txt.Text = "";
            mdmrk3txt.Text = "";
            mdmrk4txt.Text = "";
            mdmrk5txt.Text = "";
            mdmrk6txt.Text = "";



            atdnc1txt.Text = "";
            atdnc2txt.Text = "";
            atdnc3txt.Text = "";
            atdnc4txt.Text = "";
            atdnc5txt.Text = "";
            atdnc6txt.Text = "";



            fnlmrk1txt.Text = "";
            fnlmrk2txt.Text = "";
            fnlmrk3txt.Text = "";
            fnlmrk4txt.Text = "";
            fnlmrk5txt.Text = "";
            fnlmrk6txt.Text = "";


            ttlmrk1txt.Text = "";
            ttlmrk2txt.Text = "";
            ttlmrk3txt.Text = "";
            ttlmrk4txt.Text = "";
            ttlmrk5txt.Text = "";
            ttlmrk6txt.Text = "";


            sesprsnt1txt.Text = "";
            sesprsnt2txt.Text = "";
            sesprsnt3txt.Text = "";
            sesprsnt4txt.Text = "";
            sesprsnt5txt.Text = "";
            sesprsnt6txt.Text = "";


            ttlmrkobtnd1txt.Text = "";
            ttlmrkobtnd2txt.Text = "";
            ttlmrkobtnd3txt.Text = "";
            ttlmrkobtnd4txt.Text = "";
            ttlmrkobtnd5txt.Text = "";
            ttlmrkobtnd6txt.Text = "";



            remrkf1txt.Text = "";
            remrkf2txt.Text = "";
            remrkf3txt.Text = "";
            remrkf4txt.Text = "";
            remrkf5txt.Text = "";
            remrkf6txt.Text = "";



            scor1txt.Text = "";
            scor2txt.Text = "";
            scor3txt.Text = "";
            scor4txt.Text = "";
            scor5txt.Text = "";
            scor6txt.Text = "";

            lettergrd1txt.Text = "";
            lettergrd2txt.Text = "";
            lettergrd3txt.Text = "";
            lettergrd4txt.Text = "";
            lettergrd5txt.Text = "";
            lettergrd6txt.Text = "";


            gp1txt.Text = "";
            gp2txt.Text = "";
            gp3txt.Text = "";
            gp4txt.Text = "";
            gp5txt.Text = "";
            gp6txt.Text = "";




            stnametxt.Text = "";
            rgtxt.Text = "";

            exmroltxt.Text = "";

            semestercmb.Text = "";
            sessiontxt.Text = "";
        }

    
    }
}
