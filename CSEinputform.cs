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
    public partial class CSEinputform : Form
    {
        SqlConnection con;
        SqlCommand com;
        public CSEinputform()
        {
            InitializeComponent();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            String str1 = stnametxt.Text;
            String str2 = rgtxt.Text;
            String str3 = sessiontxt.Text;
            String str4 = exmroltxt.Text;
            String str5 = sl1txt.Text;
            String str6 = sl2txt.Text;
            String str7 = sl3txt.Text;
            String str8 = sl4txt.Text;
            String str9 = sl5txt.Text;
            String str10 = sl6txt.Text;
            String str11 = sl7txt.Text;
            String str12 = sl8txt.Text;
            String str13 = sl9txt.Text;
            String str14= sl10txt.Text;
            String str15 = sl11txt.Text;
            String str16 = crscd1txt.Text;
            String str17 = crscd2txt.Text;
            String str18 = crscd3txt.Text;
            String str19 = crscd4txt.Text;
            String str20 = crscd5txt.Text;
            String str21 = crscd6txt.Text;
            String str22 = crscd7txt.Text;
            String str23 = crscd8txt.Text;
            String str24 = crscd9txt.Text;
            String str25 = crscd10txt.Text;
            String str26 = crscd11txt.Text;
            String str27 = crsttl1txt.Text;
            String str28 = crsttl2txt.Text;
            String str29 = crsttl3txt.Text;
            String str30 = crsttl4txt.Text;
            String str31 = crsttl5txt.Text;
            String str32 = crsttl6txt.Text;
            String str33 = crsttl7txt.Text;
            String str34 = crsttl8txt.Text;
            String str35 = crsttl9txt.Text;
            String str36 = crsttl10txt.Text;
            String str37 = crsttl11txt.Text;
            String str38 = crdhr1txt.Text;
            String str39 = crdhr2txt.Text;
            String str40 = crdhr3txt.Text;
            String str41 = crdhr4txt.Text;
            String str42 = crdhr5txt.Text;
            String str43 = crdhr6txt.Text;
            String str44 = crdhr7txt.Text;
            String str45 = crdhr8txt.Text;
            String str46 = crdhr9txt.Text;
            String str47 = crdhr10txt.Text;
            String str48 = crdhr11txt.Text;
            String str49 = lettergrd1txt.Text;
            String str50 = lettergrd2txt.Text;
            String str51 = lettergrd3txt.Text;
            String str52 = lettergrd4txt.Text;
            String str53 = lettergrd5txt.Text;
            String str54 = lettergrd6txt.Text;
            String str55 = lettergrd7txt.Text;
            String str56 = lettergrd8txt.Text;
            String str57 = lettergrd9txt.Text;
            String str58 = lettergrd10txt.Text;
            String str59 = lettergrd11txt.Text;
            String str60 = gp1txt.Text;
            String str61 = gp2txt.Text;
            String str62 = gp3txt.Text;
            String str63 = gp4txt.Text;
            String str64 = gp5txt.Text;
            String str65 = gp6txt.Text;
            String str66 = gp7txt.Text;
            String str67 = gp8txt.Text;
            String str68 = gp9txt.Text;
            String str69 = gp10txt.Text;
            String str70 = gp11txt.Text;
            String str71 = gpatxt.Text;
            String str72 = precgpatxt.Text;
            String str73 = precchtxt.Text;
            String str74 = cgpatxt.Text;
            String str75 = cchtxt.Text;
            String str76 = remarkstxt.Text;
            String str77 = semestercmb.Text;
            int str77i = Convert.ToInt32(str77);
            if (str77i == 1)
            {                
                str77 = "First Semester(Level-1,Semester-1)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 2)
            {
                str77 = "Second Semester(Level-1,Semester-2)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 3)
            {
                str77 = "Third Semester(Level-2,Semester-1)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 4)
            {
                str77 = "Fourth Semester(Level-2,Semester-2)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 5)
            {
                str77 = "Fifth Semester(Level-3,Semester-1)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 6)
            {
                str77 = "Sixth Semester(Level-3,Semester-2)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 7)
            {
                str77 = "Seventh Semester(Level-4,Semester-1)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 8)
            {
                str77 = "Eight Semester(Level-4,Semester-2)Final Examination of B.SC.Engg.(CSE)";
            }
            if (str77i == 1 || str77i == 6 || str77i == 8)
            {
                CSEprintPrev11 f2 = new CSEprintPrev11(str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, str16, str17, str18, str19, str20, str21, str22, str23, str24, str25, str26, str27, str28, str29, str30, str31, str32, str33, str34, str35, str36, str37, str38, str39, str40, str41, str42, str43, str44, str45, str46, str47, str48, str49, str50, str51, str52, str53, str54, str55, str56, str57, str58, str59, str60, str61, str62, str63, str64, str65, str66, str67, str68, str69, str70, str71, str72, str73, str74, str75, str76, str77);
                f2.Show();
            }
            if (str77i == 2 || str77i == 3 || str77i == 4 || str77i == 5 || str77i == 7)
            {
                CSEPrintpreview10 f3 = new CSEPrintpreview10(str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str16, str17, str18, str19, str20, str21, str22, str23, str24, str25, str27, str28, str29, str30, str31, str32, str33, str34, str35, str36, str38, str39, str40, str41, str42, str43, str44, str45, str46, str47, str49, str50, str51, str52, str53, str54, str55, str56, str57, str58, str60, str61, str62, str63, str64, str65, str66, str67, str68, str69, str71, str72, str73, str74, str75, str76, str77);
                f3.Show();
            }
            
           
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
            int mid1i = Convert.ToInt32(mid1);
            int aten1i = Convert.ToInt32(aten1);
            int final1i = Convert.ToInt32(final1);
            if (mid1i < 0 || mid1i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk1txt.Text = " ";
            }
            if (aten1i < 0 || aten1i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc1txt.Text = "0.00 ";
            }
            if (final1i < 0 || final1i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk1txt.Text = " ";
            }
            int total1i = mid1i + aten1i + final1i;
            //string total = totali.ToString();
            ttlmrk1txt.Text = total1i.ToString();
            scor1txt.Text = total1i.ToString();
            if (total1i >= 80 && total1i <= 100)
            {
                lettergrd1txt.Text = "A+";
                gp1txt.Text = "4";
            }
            if (total1i >= 75 && total1i < 80)
            {
                lettergrd1txt.Text = "A";
                gp1txt.Text = "3.75";
            }
            if (total1i >= 70 && total1i <= 74)
            {
                lettergrd1txt.Text = "A-";
                gp1txt.Text = "3.5";
            }
            if (total1i >= 65 && total1i <= 69)
            {
                lettergrd1txt.Text = "B+";
                gp1txt.Text = "3.25";
            }
            if (total1i >= 60 && total1i <= 64)
            {
                lettergrd1txt.Text = "B";
                gp1txt.Text = "3.00";
            }
            if (total1i >= 55 && total1i <= 59)
            {
                lettergrd1txt.Text = "B-";
                gp1txt.Text = "2.75";
            }
            if (total1i >= 50 && total1i <= 54)
            {
                lettergrd1txt.Text = "C";
                gp1txt.Text = "2.50";
            }
            if (total1i >= 45 && total1i <= 49)
            {
                lettergrd1txt.Text = "D";
                gp1txt.Text = "2.00";
            }
            if (total1i < 45)
            {
                remrkf1txt.Text = "F";
                lettergrd1txt.Text = "F";
                gp1txt.Text = "0.00";
            }



            string mid2 = mdmrk2txt.Text;
            string aten2 = atdnc2txt.Text;
            string final2 = fnlmrk2txt.Text;
            int mid2i = Convert.ToInt32(mid2);
            int aten2i = Convert.ToInt32(aten2);
            int final2i = Convert.ToInt32(final2);
            if (mid2i < 0 || mid2i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk2txt.Text = " ";
            }
            if (aten2i < 0 || aten2i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc2txt.Text = "0.00";
            }
            if (final2i < 0 || final2i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk2txt.Text = " ";
            }
            int total2i = mid2i + aten2i + final2i;
            ttlmrk2txt.Text = total2i.ToString();
            scor2txt.Text = total2i.ToString();
            if (total2i >= 80 && total2i <= 100)
            {
                lettergrd2txt.Text = "A+";
                gp2txt.Text = "4";
            }
            if (total2i >= 75 && total2i < 80)
            {
                lettergrd2txt.Text = "A";
                gp2txt.Text = "3.75";
            }
            if (total2i >= 70 && total2i <= 74)
            {
                lettergrd2txt.Text = "A-";
                gp2txt.Text = "3.5";
            }
            if (total2i >= 65 && total2i <= 69)
            {
                lettergrd2txt.Text = "B+";
                gp2txt.Text = "3.25";
            }
            if (total2i >= 60 && total2i <= 64)
            {
                lettergrd2txt.Text = "B";
                gp2txt.Text = "3.00";
            }
            if (total2i >= 55 && total2i <= 59)
            {
                lettergrd2txt.Text = "B-";
                gp2txt.Text = "2.75";
            }
            if (total2i >= 50 && total2i <= 54)
            {
                lettergrd2txt.Text = "C";
                gp2txt.Text = "2.50";
            }
            if (total2i >= 45 && total2i <= 49)
            {
                lettergrd2txt.Text = "D";
                gp2txt.Text = "2.00";
            }
            if (total2i < 45)
            {
                remrkf2txt.Text = "F";
                lettergrd2txt.Text = "F";
                gp2txt.Text = "0.00";
            }


            string mid3 = mdmrk3txt.Text;
            string aten3 = atdnc3txt.Text;
            string final3 = fnlmrk3txt.Text;
            int mid3i = Convert.ToInt32(mid3);
            int aten3i = Convert.ToInt32(aten3);
            int final3i = Convert.ToInt32(final3);
            if (mid3i < 0 || mid3i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk3txt.Text = " ";
            }
            if (aten3i < 0 || aten3i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc3txt.Text = "0.00";
            }
            if (final3i < 0 || final3i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk3txt.Text = " ";
            }
            int total3i = mid3i + aten3i + final3i;
            ttlmrk3txt.Text = total3i.ToString();
            scor3txt.Text = total3i.ToString();
            if (total3i >= 80 && total3i <= 100)
            {
                lettergrd3txt.Text = "A+";
                gp3txt.Text = "4";
            }
            if (total3i >= 75 && total3i < 80)
            {
                lettergrd3txt.Text = "A";
                gp3txt.Text = "3.75";
            }
            if (total3i >= 70 && total3i <= 74)
            {
                lettergrd3txt.Text = "A-";
                gp3txt.Text = "3.5";
            }
            if (total3i >= 65 && total3i <= 69)
            {
                lettergrd3txt.Text = "B+";
                gp3txt.Text = "3.25";
            }
            if (total3i >= 60 && total3i <= 64)
            {
                lettergrd3txt.Text = "B";
                gp3txt.Text = "3.00";
            }
            if (total3i >= 55 && total3i <= 59)
            {
                lettergrd3txt.Text = "B-";
                gp3txt.Text = "2.75";
            }
            if (total3i >= 50 && total3i <= 54)
            {
                lettergrd3txt.Text = "C";
                gp3txt.Text = "2.50";
            }
            if (total3i >= 45 && total3i <= 49)
            {
                lettergrd3txt.Text = "D";
                gp3txt.Text = "2.00";
            }
            if (total3i < 45)
            {
                remrkf3txt.Text = "F";
                lettergrd3txt.Text = "F";
                gp3txt.Text = "0.00";
            }


            string mid4 = mdmrk4txt.Text;
            string aten4 = atdnc4txt.Text;
            string final4 = fnlmrk4txt.Text;
            int mid4i = Convert.ToInt32(mid4);
            int aten4i = Convert.ToInt32(aten4);
            int final4i = Convert.ToInt32(final4);
            if (mid4i < 0 || mid4i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk4txt.Text = " ";
            }
            if (aten4i < 0 || aten4i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc4txt.Text = "0.00";
            }
            if (final4i < 0 || final4i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk4txt.Text = " ";
            }
            int total4i = mid4i + aten4i + final4i;
            ttlmrk4txt.Text = total4i.ToString();
            scor4txt.Text = total4i.ToString();
            if (total4i >= 80 && total4i <= 100)
            {
                lettergrd4txt.Text = "A+";
                gp4txt.Text = "4";
            }
            if (total4i >= 75 && total4i < 80)
            {
                lettergrd4txt.Text = "A";
                gp4txt.Text = "3.75";
            }
            if (total4i >= 70 && total4i <= 74)
            {
                lettergrd4txt.Text = "A-";
                gp4txt.Text = "3.5";
            }
            if (total4i >= 65 && total4i <= 69)
            {
                lettergrd4txt.Text = "B+";
                gp4txt.Text = "3.25";
            }
            if (total4i >= 60 && total4i <= 64)
            {
                lettergrd4txt.Text = "B";
                gp4txt.Text = "3.00";
            }
            if (total4i >= 55 && total4i <= 59)
            {
                lettergrd4txt.Text = "B-";
                gp4txt.Text = "2.75";
            }
            if (total4i >= 50 && total4i <= 54)
            {
                lettergrd4txt.Text = "C";
                gp4txt.Text = "2.50";
            }
            if (total4i >= 45 && total4i <= 49)
            {
                lettergrd4txt.Text = "D";
                gp4txt.Text = "2.00";
            }
            if (total4i < 45)
            {
                remrkf4txt.Text = "F";
                lettergrd4txt.Text = "F";
                gp4txt.Text = "0.00";
            }


            string mid5 = mdmrk5txt.Text;
            string aten5 = atdnc5txt.Text;
            string final5 = fnlmrk5txt.Text;
            int mid5i = Convert.ToInt32(mid5);
            int aten5i = Convert.ToInt32(aten5);
            int final5i = Convert.ToInt32(final5);
            if (mid5i < 0 || mid5i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk5txt.Text = " ";
            }
            if (aten5i < 0 || aten5i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc5txt.Text = "0.00";
            }
            if (final5i < 0 || final5i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk5txt.Text = " ";
            }
            int total5i = mid5i + aten5i + final5i;
            ttlmrk5txt.Text = total5i.ToString();
            scor5txt.Text = total5i.ToString();
            if (total5i >= 80 && total5i <= 100)
            {
                lettergrd5txt.Text = "A+";
                gp5txt.Text = "4";
            }
            if (total5i >= 75 && total5i < 80)
            {
                lettergrd5txt.Text = "A";
                gp5txt.Text = "3.75";
            }
            if (total5i >= 70 && total5i <= 74)
            {
                lettergrd5txt.Text = "A-";
                gp5txt.Text = "3.5";
            }
            if (total5i >= 65 && total5i <= 69)
            {
                lettergrd5txt.Text = "B+";
                gp5txt.Text = "3.25";
            }
            if (total5i >= 60 && total5i <= 64)
            {
                lettergrd5txt.Text = "B";
                gp5txt.Text = "3.00";
            }
            if (total5i >= 55 && total5i <= 59)
            {
                lettergrd5txt.Text = "B-";
                gp5txt.Text = "2.75";
            }
            if (total5i >= 50 && total5i <= 54)
            {
                lettergrd5txt.Text = "C";
                gp5txt.Text = "2.50";
            }
            if (total5i >= 45 && total5i <= 49)
            {
                lettergrd5txt.Text = "D";
                gp5txt.Text = "2.00";
            }
            if (total5i < 45)
            {
                remrkf5txt.Text = "F";
                lettergrd5txt.Text = "F";
                gp5txt.Text = "0.00";
            }


            string mid6 = mdmrk6txt.Text;
            string aten6 = atdnc6txt.Text;
            string final6 = fnlmrk6txt.Text;
            int mid6i = Convert.ToInt32(mid6);
            int aten6i = Convert.ToInt32(aten6);
            int final6i = Convert.ToInt32(final6);
            if (mid6i < 0 || mid6i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk6txt.Text = " ";
            }
            if (aten6i < 0 || aten6i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc6txt.Text = "0.00";
            }
            if (final6i < 0 || final6i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk6txt.Text = " ";
            }
            int total6i = mid6i + aten6i + final6i;
            ttlmrk6txt.Text = total6i.ToString();
            scor6txt.Text = total6i.ToString();
            if (total6i >= 80 && total6i <= 100)
            {
                lettergrd6txt.Text = "A+";
                gp6txt.Text = "4";
            }
            if (total6i >= 75 && total6i < 80)
            {
                lettergrd6txt.Text = "A";
                gp6txt.Text = "3.75";
            }
            if (total6i >= 70 && total6i <= 74)
            {
                lettergrd6txt.Text = "A-";
                gp6txt.Text = "3.5";
            }
            if (total6i >= 65 && total6i <= 69)
            {
                lettergrd6txt.Text = "B+";
                gp6txt.Text = "3.25";
            }
            if (total6i >= 60 && total6i <= 64)
            {
                lettergrd6txt.Text = "B";
                gp6txt.Text = "3.00";
            }
            if (total6i >= 55 && total6i <= 59)
            {
                lettergrd6txt.Text = "B-";
                gp6txt.Text = "2.75";
            }
            if (total6i >= 50 && total6i <= 54)
            {
                lettergrd6txt.Text = "C";
                gp6txt.Text = "2.50";
            }
            if (total6i >= 45 && total6i <= 49)
            {
                lettergrd6txt.Text = "D";
                gp6txt.Text = "2.00";
            }
            if (total6i < 45)
            {
                remrkf6txt.Text = "F";
                lettergrd6txt.Text = "F";
                gp6txt.Text = "0.00";
            }




            string mid7 = mdmrk7txt.Text;
            string aten7 = atdnc7txt.Text;
            string final7 = fnlmrk7txt.Text;
            int mid7i = Convert.ToInt32(mid7);
            int aten7i = Convert.ToInt32(aten7);
            int final7i = Convert.ToInt32(final7);
            if (mid7i < 0 || mid7i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk7txt.Text = " ";
            }
            if (aten7i < 0 || aten7i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc1txt.Text = "0.00";
            }
            if (final7i < 0 || final7i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk7txt.Text = " ";
            }
            int total7i = mid7i + aten7i + final7i;
            ttlmrk7txt.Text = total7i.ToString();
            scor7txt.Text = total7i.ToString();
            if (total7i >= 80 && total7i <= 100)
            {
                lettergrd7txt.Text = "A+";
                gp7txt.Text = "4";
            }
            if (total7i >= 75 && total7i < 80)
            {
                lettergrd7txt.Text = "A";
                gp7txt.Text = "3.75";
            }
            if (total7i >= 70 && total7i <= 74)
            {
                lettergrd7txt.Text = "A-";
                gp7txt.Text = "3.5";
            }
            if (total7i >= 65 && total7i <= 69)
            {
                lettergrd7txt.Text = "B+";
                gp7txt.Text = "3.25";
            }
            if (total7i >= 60 && total7i <= 64)
            {
                lettergrd7txt.Text = "B";
                gp7txt.Text = "3.00";
            }
            if (total7i >= 55 && total7i <= 59)
            {
                lettergrd7txt.Text = "B-";
                gp7txt.Text = "2.75";
            }
            if (total7i >= 50 && total7i <= 54)
            {
                lettergrd7txt.Text = "C";
                gp7txt.Text = "2.50";
            }
            if (total7i >= 45 && total7i <= 49)
            {
                lettergrd7txt.Text = "D";
                gp7txt.Text = "2.00";
            }
            if (total7i < 45)
            {
                remrkf7txt.Text = "F";
                lettergrd7txt.Text = "F";
                gp7txt.Text = "0.00";
            }



            string mid8 = mdmrk8txt.Text;
            string aten8 = atdnc8txt.Text;
            string final8 = fnlmrk8txt.Text;
            int mid8i = Convert.ToInt32(mid8);
            int aten8i = Convert.ToInt32(aten8);
            int final8i = Convert.ToInt32(final8);
            if (mid8i < 0 || mid8i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk1txt.Text = " ";
            }
            if (aten8i < 0 || aten8i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc8txt.Text = "0.00";
            }
            if (final8i < 0 || final8i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk8txt.Text = " ";
            }
            int total8i = mid8i + aten8i + final8i;
            ttlmrk8txt.Text = total8i.ToString();
            scor8txt.Text = total8i.ToString();
            if (total8i >= 80 && total8i <= 100)
            {
                lettergrd8txt.Text = "A+";
                gp8txt.Text = "4";
            }
            if (total8i >= 75 && total8i < 80)
            {
                lettergrd8txt.Text = "A";
                gp8txt.Text = "3.75";
            }
            if (total8i >= 70 && total8i <= 74)
            {
                lettergrd8txt.Text = "A-";
                gp8txt.Text = "3.5";
            }
            if (total8i >= 65 && total8i <= 69)
            {
                lettergrd8txt.Text = "B+";
                gp8txt.Text = "3.25";
            }
            if (total8i >= 60 && total8i <= 64)
            {
                lettergrd8txt.Text = "B";
                gp8txt.Text = "3.00";
            }
            if (total8i >= 55 && total8i <= 59)
            {
                lettergrd8txt.Text = "B-";
                gp8txt.Text = "2.75";
            }
            if (total8i >= 50 && total8i <= 54)
            {
                lettergrd8txt.Text = "C";
                gp8txt.Text = "2.50";
            }
            if (total8i >= 45 && total8i <= 49)
            {
                lettergrd8txt.Text = "D";
                gp8txt.Text = "2.00";
            }
            if (total8i < 45)
            {
                remrkf8txt.Text = "F";
                lettergrd8txt.Text = "F";
                gp8txt.Text = "0.00";
            }

            string mid9 = mdmrk9txt.Text;
            string aten9 = atdnc9txt.Text;
            string final9 = fnlmrk9txt.Text;
            int mid9i = Convert.ToInt32(mid9);
            int aten9i = Convert.ToInt32(aten9);
            int final9i = Convert.ToInt32(final9);
            if (mid9i < 0 || mid9i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk9txt.Text = " ";
            }
            if (aten9i < 0 || aten9i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc9txt.Text = "0.00";
            }
            if (final9i < 0 || final9i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk9txt.Text = " ";
            }
            int total9i = mid9i + aten9i + final9i;
            ttlmrk9txt.Text = total9i.ToString();
            scor9txt.Text = total9i.ToString();
            if (total9i >= 80 && total9i <= 100)
            {
                lettergrd9txt.Text = "A+";
                gp9txt.Text = "4";
            }
            if (total9i >= 75 && total9i < 80)
            {
                lettergrd9txt.Text = "A";
                gp9txt.Text = "3.75";
            }
            if (total9i >= 70 && total9i <= 74)
            {
                lettergrd9txt.Text = "A-";
                gp9txt.Text = "3.5";
            }
            if (total9i >= 65 && total9i <= 69)
            {
                lettergrd9txt.Text = "B+";
                gp9txt.Text = "3.25";
            }
            if (total9i >= 60 && total9i <= 64)
            {
                lettergrd9txt.Text = "B";
                gp9txt.Text = "3.00";
            }
            if (total9i >= 55 && total9i <= 59)
            {
                lettergrd9txt.Text = "B-";
                gp9txt.Text = "2.75";
            }
            if (total9i >= 50 && total9i <= 54)
            {
                lettergrd9txt.Text = "C";
                gp9txt.Text = "2.50";
            }
            if (total9i >= 45 && total9i <= 49)
            {
                lettergrd9txt.Text = "D";
                gp9txt.Text = "2.00";
            }
            if (total9i < 45)
            {
                remrkf9txt.Text = "F";
                lettergrd9txt.Text = "F";
                gp9txt.Text = "0.00";
            }


            string mid10 = mdmrk10txt.Text;
            string aten10 = atdnc10txt.Text;
            string final10 = fnlmrk10txt.Text;
            int mid10i = Convert.ToInt32(mid10);
            int aten10i = Convert.ToInt32(aten10);
            int final10i = Convert.ToInt32(final10);
            if (mid10i < 0 || mid10i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk10txt.Text = " ";
            }
            if (aten10i < 0 || aten10i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc10txt.Text = "0.00";
            }
            if (final10i < 0 || final10i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk10txt.Text = " ";
            }
            int total10i = mid10i + aten10i + final10i;
            ttlmrk10txt.Text = total10i.ToString();
            scor10txt.Text = total10i.ToString();
            if (total10i >= 80 && total10i <= 100)
            {
                lettergrd10txt.Text = "A+";
                gp10txt.Text = "4";
            }
            if (total10i >= 75 && total10i < 80)
            {
                lettergrd10txt.Text = "A";
                gp10txt.Text = "3.75";
            }
            if (total10i >= 70 && total10i <= 74)
            {
                lettergrd10txt.Text = "A-";
                gp10txt.Text = "3.5";
            }
            if (total10i >= 65 && total10i <= 69)
            {
                lettergrd10txt.Text = "B+";
                gp10txt.Text = "3.25";
            }
            if (total10i >= 60 && total10i <= 64)
            {
                lettergrd10txt.Text = "B";
                gp10txt.Text = "3.00";
            }
            if (total10i >= 55 && total10i <= 59)
            {
                lettergrd10txt.Text = "B-";
                gp10txt.Text = "2.75";
            }
            if (total10i >= 50 && total10i <= 54)
            {
                lettergrd10txt.Text = "C";
                gp10txt.Text = "2.50";
            }
            if (total10i >= 45 && total10i <= 49)
            {
                lettergrd10txt.Text = "D";
                gp10txt.Text = "2.00";
            }
            if (total10i < 45)
            {
                remrkf10txt.Text = "F";
                lettergrd10txt.Text = "F";
                gp10txt.Text = "0.00";
            }

            string mid11 = mdmrk11txt.Text;
            string aten11 = atdnc11txt.Text;
            string final11 = fnlmrk11txt.Text;
            int mid11i = Convert.ToInt32(mid11);
            int aten11i = Convert.ToInt32(aten11);
            int final11i = Convert.ToInt32(final11);
            if (mid11i < 0 || mid11i > 20)
            {
                MessageBox.Show("Invalid Data");
                mdmrk11txt.Text = " ";
            }
            if (aten11i < 0 || aten11i > 10)
            {
                MessageBox.Show("Invalid Data");
                atdnc11txt.Text = "0.00";
            }
            if (final11i < 0 || final11i > 70)
            {
                MessageBox.Show("Invalid Data");
                fnlmrk11txt.Text = " ";
            }
            int total11i = mid11i + aten11i + final11i;
            ttlmrk11txt.Text = total11i.ToString();
            scor11txt.Text = total11i.ToString();
            if (total11i >= 80 && total11i <= 100)
            {
                lettergrd11txt.Text = "A+";
                gp11txt.Text = "4";
            }
            if (total11i >= 75 && total11i < 80)
            {
                lettergrd11txt.Text = "A";
                gp11txt.Text = "3.75";
            }
            if (total11i >= 70 && total11i <= 74)
            {
                lettergrd11txt.Text = "A-";
                gp11txt.Text = "3.5";
            }
            if (total11i >= 65 && total11i <= 69)
            {
                lettergrd11txt.Text = "B+";
                gp11txt.Text = "3.25";
            }
            if (total11i >= 60 && total11i <= 64)
            {
                lettergrd11txt.Text = "B";
                gp11txt.Text = "3.00";
            }
            if (total11i >= 55 && total11i <= 59)
            {
                lettergrd11txt.Text = "B-";
                gp11txt.Text = "2.75";
            }
            if (total11i >= 50 && total11i <= 54)
            {
                lettergrd11txt.Text = "C";
                gp11txt.Text = "2.50";
            }
            if (total11i >= 45 && total11i <= 49)
            {
                lettergrd11txt.Text = "D";
                gp11txt.Text = "2.00";
            }
            if (total11i < 45)
            {
                remrkf11txt.Text = "F";
                lettergrd11txt.Text = "F";
                gp11txt.Text = "0.00";
            }



            string b1 = gp1txt.Text;
            string b2 = gp2txt.Text;
            string b3 = gp3txt.Text;
            string b4 = gp4txt.Text;
            string b5 = gp5txt.Text;
            string b6 = gp6txt.Text;
            string b7 = gp7txt.Text;
            string b8 = gp8txt.Text;
            string b9 = gp9txt.Text;
            string b10 = gp10txt.Text;
            string b11 = gp11txt.Text;

            double b1i = Convert.ToDouble(b1);
            double b2i = Convert.ToDouble(b2);
            double b3i = Convert.ToDouble(b3);
            double b4i = Convert.ToDouble(b4);
            double b5i = Convert.ToDouble(b5);
            double b6i = Convert.ToDouble(b6);
            double b7i = Convert.ToDouble(b7);
            double b8i = Convert.ToDouble(b8);
            double b9i = Convert.ToDouble(b9);
            double b10i = Convert.ToDouble(b10);
            double b11i = Convert.ToDouble(b11);


            string p1 = crdhr1txt.Text;
            string p2 = crdhr2txt.Text;
            string p3 = crdhr3txt.Text;
            string p4 = crdhr4txt.Text;
            string p5 = crdhr5txt.Text;
            string p6 = crdhr6txt.Text;
            string p7 = crdhr7txt.Text;
            string p8 = crdhr8txt.Text;
            string p9 = crdhr9txt.Text;
            string p10 = crdhr10txt.Text;
            string p11 = crdhr11txt.Text;



            double p1i = Convert.ToDouble(p1);
            double p2i = Convert.ToDouble(p2);
            double p3i = Convert.ToDouble(p3);
            double p4i = Convert.ToDouble(p4);
            double p5i = Convert.ToDouble(p5);
            double p6i = Convert.ToDouble(p6);
            double p7i = Convert.ToDouble(p7);
            double p8i = Convert.ToDouble(p8);
            double p9i = Convert.ToDouble(p9);
            double p10i = Convert.ToDouble(p10);
            double p11i = Convert.ToDouble(p11);


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
            if (b7i == 0.00)
            {
                p7i = 0.00;
            }
            if (b8i == 0.00)
            {
                p8i = 0.00;
            }
            if (b9i == 0.00)
            {
                p9i = 0.00;
            }
            if (b10i == 0.00)
            {
                p10i = 0.00;
            }
            if (b11i == 0.00)
            {
                p11i = 0.00;
            }


            double pp = p1i + p2i + p3i + p4i + p5i + p6i + p7i + p8i + p9i + p10i + p11i;
            //cchtxt.Text = pp.ToString();
            double c = (b1i * p1i + b2i * p2i + b3i * p3i + b4i * p4i + b5i * p5i + b6i * p6i + b7i * p7i + b8i * p8i + b9i * p9i + b10i * p10i + b11i * p11i) / pp;
            //gpatxt.Text = c.ToString();
            String c1 = String.Format("{0:F2}",c);
            gpatxt.Text = c1;
            string d1 = gpatxt.Text;
            string d2 = precgpatxt.Text;
            string d3 = precchtxt.Text;
            double d1i = Convert.ToDouble(d1);
            double d2i = Convert.ToDouble(d2);
            double d3i = Convert.ToDouble(d3);
            double dd = (d1i * pp + d2i * d3i) / (pp + d3i);
            String dd1 = String.Format("{0:F2}", dd);
            cgpatxt.Text = dd1;
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
                if (semestercmb.Text == "1")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl11txt.Text + "','" + crscd11txt.Text + "','" + crsttl11txt.Text + "','" + crdhr11txt.Text + "','" + mdmrk11txt.Text + "','" + atdnc11txt.Text + "','" + fnlmrk11txt.Text + "','" + ttlmrk11txt.Text + "','" + remrkf11txt.Text + "','" + scor11txt.Text + "','" + lettergrd11txt.Text + "','" + gp11txt.Text + "')", con);

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


                }


                if (semestercmb.Text == "2")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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

                }


                if (semestercmb.Text == "3")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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

                }


                if (semestercmb.Text == "4")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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

                }



                if (semestercmb.Text == "5")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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

                }



                if (semestercmb.Text == "6")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl11txt.Text + "','" + crscd11txt.Text + "','" + crsttl11txt.Text + "','" + crdhr11txt.Text + "','" + mdmrk11txt.Text + "','" + atdnc11txt.Text + "','" + fnlmrk11txt.Text + "','" + ttlmrk11txt.Text + "','" + remrkf11txt.Text + "','" + scor11txt.Text + "','" + lettergrd11txt.Text + "','" + gp11txt.Text + "')", con);

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


                }


                if (semestercmb.Text == "7")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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

                }


                if (semestercmb.Text == "8")
                {
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl1txt.Text + "','" + crscd1txt.Text + "','" + crsttl1txt.Text + "','" + crdhr1txt.Text + "','" + mdmrk1txt.Text + "','" + atdnc1txt.Text + "','" + fnlmrk1txt.Text + "','" + ttlmrk1txt.Text + "','" + remrkf1txt.Text + "','" + scor1txt.Text + "','" + lettergrd1txt.Text + "','" + gp1txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl2txt.Text + "','" + crscd2txt.Text + "','" + crsttl2txt.Text + "','" + crdhr2txt.Text + "','" + mdmrk2txt.Text + "','" + atdnc2txt.Text + "','" + fnlmrk2txt.Text + "','" + ttlmrk2txt.Text + "','" + remrkf2txt.Text + "','" + scor2txt.Text + "','" + lettergrd2txt.Text + "','" + gp2txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl3txt.Text + "','" + crscd3txt.Text + "','" + crsttl3txt.Text + "','" + crdhr3txt.Text + "','" + mdmrk3txt.Text + "','" + atdnc3txt.Text + "','" + fnlmrk3txt.Text + "','" + ttlmrk3txt.Text + "','" + remrkf3txt.Text + "','" + scor3txt.Text + "','" + lettergrd3txt.Text + "','" + gp3txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl4txt.Text + "','" + crscd4txt.Text + "','" + crsttl4txt.Text + "','" + crdhr4txt.Text + "','" + mdmrk4txt.Text + "','" + atdnc4txt.Text + "','" + fnlmrk4txt.Text + "','" + ttlmrk4txt.Text + "','" + remrkf4txt.Text + "','" + scor4txt.Text + "','" + lettergrd4txt.Text + "','" + gp4txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl5txt.Text + "','" + crscd5txt.Text + "','" + crsttl5txt.Text + "','" + crdhr5txt.Text + "','" + mdmrk5txt.Text + "','" + atdnc5txt.Text + "','" + fnlmrk5txt.Text + "','" + ttlmrk5txt.Text + "','" + remrkf5txt.Text + "','" + scor5txt.Text + "','" + lettergrd5txt.Text + "','" + gp5txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl6txt.Text + "','" + crscd6txt.Text + "','" + crsttl6txt.Text + "','" + crdhr6txt.Text + "','" + mdmrk6txt.Text + "','" + atdnc6txt.Text + "','" + fnlmrk6txt.Text + "','" + ttlmrk6txt.Text + "','" + remrkf6txt.Text + "','" + scor6txt.Text + "','" + lettergrd6txt.Text + "','" + gp6txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl7txt.Text + "','" + crscd7txt.Text + "','" + crsttl7txt.Text + "','" + crdhr7txt.Text + "','" + mdmrk7txt.Text + "','" + atdnc7txt.Text + "','" + fnlmrk7txt.Text + "','" + ttlmrk7txt.Text + "','" + remrkf7txt.Text + "','" + scor7txt.Text + "','" + lettergrd7txt.Text + "','" + gp7txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl8txt.Text + "','" + crscd8txt.Text + "','" + crsttl8txt.Text + "','" + crdhr8txt.Text + "','" + mdmrk8txt.Text + "','" + atdnc8txt.Text + "','" + fnlmrk8txt.Text + "','" + ttlmrk8txt.Text + "','" + remrkf8txt.Text + "','" + scor8txt.Text + "','" + lettergrd8txt.Text + "','" + gp8txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl9txt.Text + "','" + crscd9txt.Text + "','" + crsttl9txt.Text + "','" + crdhr9txt.Text + "','" + mdmrk9txt.Text + "','" + atdnc9txt.Text + "','" + fnlmrk9txt.Text + "','" + ttlmrk9txt.Text + "','" + remrkf9txt.Text + "','" + scor9txt.Text + "','" + lettergrd9txt.Text + "','" + gp9txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl10txt.Text + "','" + crscd10txt.Text + "','" + crsttl10txt.Text + "','" + crdhr10txt.Text + "','" + mdmrk10txt.Text + "','" + atdnc10txt.Text + "','" + fnlmrk10txt.Text + "','" + ttlmrk10txt.Text + "','" + remrkf10txt.Text + "','" + scor10txt.Text + "','" + lettergrd10txt.Text + "','" + gp10txt.Text + "')", con);

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
                    com = new SqlCommand("INSERT INTO Marks1tb values ('" + stnametxt.Text + "','" + rgtxt.Text + "','" + semestercmb.Text + "','" + sessiontxt.Text + "','" + exmroltxt.Text + "','" + sl11txt.Text + "','" + crscd11txt.Text + "','" + crsttl11txt.Text + "','" + crdhr11txt.Text + "','" + mdmrk11txt.Text + "','" + atdnc11txt.Text + "','" + fnlmrk11txt.Text + "','" + ttlmrk11txt.Text + "','" + remrkf11txt.Text + "','" + scor11txt.Text + "','" + lettergrd11txt.Text + "','" + gp11txt.Text + "')", con);

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
                }
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
                com = new SqlCommand("DELETE FROM Marks1tb WHERE Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "' ", con);

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
                gpatxt.Hide();
                precgpatxt.Hide();
                precchtxt.Hide();
                cgpatxt.Hide();
                cchtxt.Hide();
                remarkstxt.Hide();
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
            string Qry2 = "SELECT * FROM Marks1tb where Reg='" + rgtxt.Text + "'AND Semester='" + semestercmb.Text + "' ";


            sl1txt.Hide();
            sl2txt.Hide();
            sl3txt.Hide();
            sl4txt.Hide();
            sl5txt.Hide();
            sl6txt.Hide();
            sl7txt.Hide();
            sl8txt.Hide();
            sl9txt.Hide();
            sl10txt.Hide();
            sl11txt.Hide();

            crscd1txt.Hide();
            crscd2txt.Hide();
            crscd3txt.Hide();
            crscd4txt.Hide();
            crscd5txt.Hide();
            crscd6txt.Hide();
            crscd7txt.Hide();
            crscd8txt.Hide();
            crscd9txt.Hide();
            crscd10txt.Hide();
            crscd11txt.Hide();


            crsttl1txt.Hide();
            crsttl2txt.Hide();
            crsttl3txt.Hide();
            crsttl4txt.Hide();
            crsttl5txt.Hide();
            crsttl6txt.Hide();
            crsttl7txt.Hide();
            crsttl8txt.Hide();
            crsttl9txt.Hide();
            crsttl10txt.Hide();
            crsttl11txt.Hide();


            crdhr1txt.Hide();
            crdhr2txt.Hide();
            crdhr3txt.Hide();
            crdhr4txt.Hide();
            crdhr5txt.Hide();
            crdhr6txt.Hide();
            crdhr7txt.Hide();
            crdhr8txt.Hide();
            crdhr9txt.Hide();
            crdhr10txt.Hide();
            crdhr11txt.Hide();

            mdmrk1txt.Hide();
            mdmrk2txt.Hide();
            mdmrk3txt.Hide();
            mdmrk4txt.Hide();
            mdmrk5txt.Hide();
            mdmrk6txt.Hide();
            mdmrk7txt.Hide();
            mdmrk8txt.Hide();
            mdmrk9txt.Hide();
            mdmrk10txt.Hide();
            mdmrk11txt.Hide();


            atdnc1txt.Hide();
            atdnc2txt.Hide();
            atdnc3txt.Hide();
            atdnc4txt.Hide();
            atdnc5txt.Hide();
            atdnc6txt.Hide();
            atdnc7txt.Hide();
            atdnc8txt.Hide();
            atdnc9txt.Hide();
            atdnc10txt.Hide();
            atdnc11txt.Hide();



            fnlmrk1txt.Hide();
            fnlmrk2txt.Hide();
            fnlmrk3txt.Hide();
            fnlmrk4txt.Hide();
            fnlmrk5txt.Hide();
            fnlmrk6txt.Hide();
            fnlmrk7txt.Hide();
            fnlmrk8txt.Hide();
            fnlmrk9txt.Hide();
            fnlmrk10txt.Hide();
            fnlmrk11txt.Hide();

            ttlmrk1txt.Hide();
            ttlmrk2txt.Hide();
            ttlmrk3txt.Hide();
            ttlmrk4txt.Hide();
            ttlmrk5txt.Hide();
            ttlmrk6txt.Hide();
            ttlmrk7txt.Hide();
            ttlmrk8txt.Hide();
            ttlmrk9txt.Hide();
            ttlmrk10txt.Hide();
            ttlmrk11txt.Hide();


            remrkf1txt.Hide();
            remrkf2txt.Hide();
            remrkf3txt.Hide();
            remrkf4txt.Hide();
            remrkf5txt.Hide();
            remrkf6txt.Hide();
            remrkf7txt.Hide();
            remrkf8txt.Hide();
            remrkf9txt.Hide();
            remrkf10txt.Hide();
            remrkf11txt.Hide();



            scor1txt.Hide();
            scor2txt.Hide();
            scor3txt.Hide();
            scor4txt.Hide();
            scor5txt.Hide();
            scor6txt.Hide();
            scor7txt.Hide();
            scor8txt.Hide();
            scor9txt.Hide();
            scor10txt.Hide();
            scor11txt.Hide();

            lettergrd1txt.Hide();
            lettergrd2txt.Hide();
            lettergrd3txt.Hide();
            lettergrd4txt.Hide();
            lettergrd5txt.Hide();
            lettergrd6txt.Hide();
            lettergrd7txt.Hide();
            lettergrd8txt.Hide();
            lettergrd9txt.Hide();
            lettergrd10txt.Hide();
            lettergrd11txt.Hide();


            gp1txt.Hide();
            gp2txt.Hide();
            gp3txt.Hide();
            gp4txt.Hide();
            gp5txt.Hide();
            gp6txt.Hide();
            gp7txt.Hide();
            gp8txt.Hide();
            gp9txt.Hide();
            gp10txt.Hide();
            gp11txt.Hide();







            SqlCommand comd2 = new SqlCommand(Qry2, conx2);

            SqlDataReader dtr2 = comd2.ExecuteReader();

            for (int i = 0; dtr2.Read(); i++)
            {

                if (i == 0) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl1txt.Show(); sl1txt.Text = dtr2["SL_NO"].ToString(); crscd1txt.Show(); crscd1txt.Text = dtr2["Course_code"].ToString(); crsttl1txt.Show(); crsttl1txt.Text = dtr2["Course_Tittle"].ToString(); crdhr1txt.Show(); crdhr1txt.Text = dtr2["Credit_hour"].ToString(); mdmrk1txt.Show(); mdmrk1txt.Text = dtr2["Mid_exam"].ToString(); atdnc1txt.Show(); atdnc1txt.Text = dtr2["Attendence"].ToString(); fnlmrk1txt.Show(); fnlmrk1txt.Text = dtr2["Final_exam"].ToString(); ttlmrk1txt.Show(); ttlmrk1txt.Text = dtr2["Total_marks"].ToString(); remrkf1txt.Show(); remrkf1txt.Text = dtr2["Remarks_FI"].ToString(); scor1txt.Show(); scor1txt.Text = dtr2["Score"].ToString(); lettergrd1txt.Show(); lettergrd1txt.Text = dtr2["Letter_grade"].ToString(); gp1txt.Show(); gp1txt.Text = dtr2["GP"].ToString(); }
                if (i == 1) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl2txt.Show(); sl2txt.Text = dtr2["SL_NO"].ToString(); crscd2txt.Show(); crscd2txt.Text = dtr2["Course_code"].ToString(); crsttl2txt.Show(); crsttl2txt.Text = dtr2["Course_Tittle"].ToString(); crdhr2txt.Show(); crdhr2txt.Text = dtr2["Credit_hour"].ToString(); mdmrk2txt.Show(); mdmrk2txt.Text = dtr2["Mid_exam"].ToString(); atdnc2txt.Show(); atdnc2txt.Text = dtr2["Attendence"].ToString(); fnlmrk2txt.Show(); fnlmrk2txt.Text = dtr2["Final_exam"].ToString(); ttlmrk2txt.Show(); ttlmrk2txt.Text = dtr2["Total_marks"].ToString(); remrkf2txt.Show(); remrkf2txt.Text = dtr2["Remarks_FI"].ToString(); scor2txt.Show(); scor2txt.Text = dtr2["Score"].ToString(); lettergrd2txt.Show(); lettergrd2txt.Text = dtr2["Letter_grade"].ToString(); gp2txt.Show(); gp2txt.Text = dtr2["GP"].ToString(); }
                if (i == 2) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl3txt.Show(); sl3txt.Text = dtr2["SL_NO"].ToString(); crscd3txt.Show(); crscd3txt.Text = dtr2["Course_code"].ToString(); crsttl3txt.Show(); crsttl3txt.Text = dtr2["Course_Tittle"].ToString(); crdhr3txt.Show(); crdhr3txt.Text = dtr2["Credit_hour"].ToString(); mdmrk3txt.Show(); mdmrk3txt.Text = dtr2["Mid_exam"].ToString(); atdnc3txt.Show(); atdnc3txt.Text = dtr2["Attendence"].ToString(); fnlmrk3txt.Show(); fnlmrk3txt.Text = dtr2["Final_exam"].ToString(); ttlmrk3txt.Show(); ttlmrk3txt.Text = dtr2["Total_marks"].ToString(); remrkf3txt.Show(); remrkf3txt.Text = dtr2["Remarks_FI"].ToString(); scor3txt.Show(); scor3txt.Text = dtr2["Score"].ToString(); lettergrd3txt.Show(); lettergrd3txt.Text = dtr2["Letter_grade"].ToString(); gp3txt.Show(); gp3txt.Text = dtr2["GP"].ToString(); }
                if (i == 3) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl4txt.Show(); sl4txt.Text = dtr2["SL_NO"].ToString(); crscd4txt.Show(); crscd4txt.Text = dtr2["Course_code"].ToString(); crsttl4txt.Show(); crsttl4txt.Text = dtr2["Course_Tittle"].ToString(); crdhr4txt.Show(); crdhr4txt.Text = dtr2["Credit_hour"].ToString(); mdmrk4txt.Show(); mdmrk4txt.Text = dtr2["Mid_exam"].ToString(); atdnc4txt.Show(); atdnc4txt.Text = dtr2["Attendence"].ToString(); fnlmrk4txt.Show(); fnlmrk4txt.Text = dtr2["Final_exam"].ToString(); ttlmrk4txt.Show(); ttlmrk4txt.Text = dtr2["Total_marks"].ToString(); remrkf4txt.Show(); remrkf4txt.Text = dtr2["Remarks_FI"].ToString(); scor4txt.Show(); scor4txt.Text = dtr2["Score"].ToString(); lettergrd4txt.Show(); lettergrd4txt.Text = dtr2["Letter_grade"].ToString(); gp4txt.Show(); gp4txt.Text = dtr2["GP"].ToString(); }
                if (i == 4) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl5txt.Show(); sl5txt.Text = dtr2["SL_NO"].ToString(); crscd5txt.Show(); crscd5txt.Text = dtr2["Course_code"].ToString(); crsttl5txt.Show(); crsttl5txt.Text = dtr2["Course_Tittle"].ToString(); crdhr5txt.Show(); crdhr5txt.Text = dtr2["Credit_hour"].ToString(); mdmrk5txt.Show(); mdmrk5txt.Text = dtr2["Mid_exam"].ToString(); atdnc5txt.Show(); atdnc5txt.Text = dtr2["Attendence"].ToString(); fnlmrk5txt.Show(); fnlmrk5txt.Text = dtr2["Final_exam"].ToString(); ttlmrk5txt.Show(); ttlmrk5txt.Text = dtr2["Total_marks"].ToString(); remrkf5txt.Show(); remrkf5txt.Text = dtr2["Remarks_FI"].ToString(); scor5txt.Show(); scor5txt.Text = dtr2["Score"].ToString(); lettergrd5txt.Show(); lettergrd5txt.Text = dtr2["Letter_grade"].ToString(); gp5txt.Show(); gp5txt.Text = dtr2["GP"].ToString(); }
                if (i == 5) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl6txt.Show(); sl6txt.Text = dtr2["SL_NO"].ToString(); crscd6txt.Show(); crscd6txt.Text = dtr2["Course_code"].ToString(); crsttl6txt.Show(); crsttl6txt.Text = dtr2["Course_Tittle"].ToString(); crdhr6txt.Show(); crdhr6txt.Text = dtr2["Credit_hour"].ToString(); mdmrk6txt.Show(); mdmrk6txt.Text = dtr2["Mid_exam"].ToString(); atdnc6txt.Show(); atdnc6txt.Text = dtr2["Attendence"].ToString(); fnlmrk6txt.Show(); fnlmrk6txt.Text = dtr2["Final_exam"].ToString(); ttlmrk6txt.Show(); ttlmrk6txt.Text = dtr2["Total_marks"].ToString(); remrkf6txt.Show(); remrkf6txt.Text = dtr2["Remarks_FI"].ToString(); scor6txt.Show(); scor6txt.Text = dtr2["Score"].ToString(); lettergrd6txt.Show(); lettergrd6txt.Text = dtr2["Letter_grade"].ToString(); gp6txt.Show(); gp6txt.Text = dtr2["GP"].ToString(); }
                if (i == 6) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl7txt.Show(); sl7txt.Text = dtr2["SL_NO"].ToString(); crscd7txt.Show(); crscd7txt.Text = dtr2["Course_code"].ToString(); crsttl7txt.Show(); crsttl7txt.Text = dtr2["Course_Tittle"].ToString(); crdhr7txt.Show(); crdhr7txt.Text = dtr2["Credit_hour"].ToString(); mdmrk7txt.Show(); mdmrk7txt.Text = dtr2["Mid_exam"].ToString(); atdnc7txt.Show(); atdnc7txt.Text = dtr2["Attendence"].ToString(); fnlmrk7txt.Show(); fnlmrk7txt.Text = dtr2["Final_exam"].ToString(); ttlmrk7txt.Show(); ttlmrk7txt.Text = dtr2["Total_marks"].ToString(); remrkf7txt.Show(); remrkf7txt.Text = dtr2["Remarks_FI"].ToString(); scor7txt.Show(); scor7txt.Text = dtr2["Score"].ToString(); lettergrd7txt.Show(); lettergrd7txt.Text = dtr2["Letter_grade"].ToString(); gp7txt.Show(); gp7txt.Text = dtr2["GP"].ToString(); }
                if (i == 7) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl8txt.Show(); sl8txt.Text = dtr2["SL_NO"].ToString(); crscd8txt.Show(); crscd8txt.Text = dtr2["Course_code"].ToString(); crsttl8txt.Show(); crsttl8txt.Text = dtr2["Course_Tittle"].ToString(); crdhr8txt.Show(); crdhr8txt.Text = dtr2["Credit_hour"].ToString(); mdmrk8txt.Show(); mdmrk8txt.Text = dtr2["Mid_exam"].ToString(); atdnc8txt.Show(); atdnc8txt.Text = dtr2["Attendence"].ToString(); fnlmrk8txt.Show(); fnlmrk8txt.Text = dtr2["Final_exam"].ToString(); ttlmrk8txt.Show(); ttlmrk8txt.Text = dtr2["Total_marks"].ToString(); remrkf8txt.Show(); remrkf8txt.Text = dtr2["Remarks_FI"].ToString(); scor8txt.Show(); scor8txt.Text = dtr2["Score"].ToString(); lettergrd8txt.Show(); lettergrd8txt.Text = dtr2["Letter_grade"].ToString(); gp8txt.Show(); gp8txt.Text = dtr2["GP"].ToString(); }
                if (i == 8) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl9txt.Show(); sl9txt.Text = dtr2["SL_NO"].ToString(); crscd9txt.Show(); crscd9txt.Text = dtr2["Course_code"].ToString(); crsttl9txt.Show(); crsttl9txt.Text = dtr2["Course_Tittle"].ToString(); crdhr9txt.Show(); crdhr9txt.Text = dtr2["Credit_hour"].ToString(); mdmrk9txt.Show(); mdmrk9txt.Text = dtr2["Mid_exam"].ToString(); atdnc9txt.Show(); atdnc9txt.Text = dtr2["Attendence"].ToString(); fnlmrk9txt.Show(); fnlmrk9txt.Text = dtr2["Final_exam"].ToString(); ttlmrk9txt.Show(); ttlmrk9txt.Text = dtr2["Total_marks"].ToString(); remrkf9txt.Show(); remrkf9txt.Text = dtr2["Remarks_FI"].ToString(); scor9txt.Show(); scor9txt.Text = dtr2["Score"].ToString(); lettergrd9txt.Show(); lettergrd9txt.Text = dtr2["Letter_grade"].ToString(); gp9txt.Show(); gp9txt.Text = dtr2["GP"].ToString(); }
                if (i == 9) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl10txt.Show(); sl10txt.Text = dtr2["SL_NO"].ToString(); crscd10txt.Show(); crscd10txt.Text = dtr2["Course_code"].ToString(); crsttl10txt.Show(); crsttl10txt.Text = dtr2["Course_Tittle"].ToString(); crdhr10txt.Show(); crdhr10txt.Text = dtr2["Credit_hour"].ToString(); mdmrk10txt.Show(); mdmrk10txt.Text = dtr2["Mid_exam"].ToString(); atdnc10txt.Show(); atdnc10txt.Text = dtr2["Attendence"].ToString(); fnlmrk10txt.Show(); fnlmrk10txt.Text = dtr2["Final_exam"].ToString(); ttlmrk10txt.Show(); ttlmrk10txt.Text = dtr2["Total_marks"].ToString(); remrkf10txt.Show(); remrkf10txt.Text = dtr2["Remarks_FI"].ToString(); scor10txt.Show(); scor10txt.Text = dtr2["Score"].ToString(); lettergrd10txt.Show(); lettergrd10txt.Text = dtr2["Letter_grade"].ToString(); gp10txt.Show(); gp10txt.Text = dtr2["GP"].ToString(); }
                if (i == 10) { exmroltxt.Text = dtr2["Exam_roll"].ToString(); sl11txt.Show(); sl11txt.Text = dtr2["SL_NO"].ToString(); crscd11txt.Show(); crscd11txt.Text = dtr2["Course_code"].ToString(); crsttl11txt.Show(); crsttl11txt.Text = dtr2["Course_Tittle"].ToString(); crdhr11txt.Show(); crdhr11txt.Text = dtr2["Credit_hour"].ToString(); mdmrk11txt.Show(); mdmrk11txt.Text = dtr2["Mid_exam"].ToString(); atdnc11txt.Show(); atdnc11txt.Text = dtr2["Attendence"].ToString(); fnlmrk11txt.Show(); fnlmrk11txt.Text = dtr2["Final_exam"].ToString(); ttlmrk11txt.Show(); ttlmrk11txt.Text = dtr2["Total_marks"].ToString(); remrkf11txt.Show(); remrkf11txt.Text = dtr2["Remarks_FI"].ToString(); scor11txt.Show(); scor11txt.Text = dtr2["Score"].ToString(); lettergrd11txt.Show(); lettergrd11txt.Text = dtr2["Letter_grade"].ToString(); gp11txt.Show(); gp11txt.Text = dtr2["GP"].ToString(); }

                //MessageBox.Show(dtr1["CourseTitle"].ToString());
            }


            conx2.Close();


            //Input_Form f2 = new Input_Form();
            string Cnx3 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
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



            string strCnx6 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\data 3 new\Final project\print\controller.mdf;Integrated Security=True;User Instance=True";
            SqlConnection cnx6 = new SqlConnection(strCnx6);

            cnx6.Open();

            //This code is susceptible to SQL injection attacks.
            string strQry6 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd1txt.Text + "', Course_Tittle = '" + this.crsttl1txt.Text + "', Credit_hour = '" + this.crdhr1txt.Text + "', Mid_exam = '" + this.mdmrk1txt.Text + "', Attendence = '" + this.atdnc1txt.Text + "', Final_exam = '" + this.fnlmrk1txt.Text + "', Total_marks = '" + this.ttlmrk1txt.Text + "', Remarks_FI = '" + this.remrkf1txt.Text + "', Score = '" + this.scor1txt.Text + "', Letter_grade = '" + this.lettergrd1txt.Text + "', GP = '" + this.gp1txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '01'";
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

            string strQry7 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd2txt.Text + "', Course_Tittle = '" + this.crsttl2txt.Text + "', Credit_hour = '" + this.crdhr2txt.Text + "', Mid_exam = '" + this.mdmrk2txt.Text + "', Attendence = '" + this.atdnc2txt.Text + "', Final_exam = '" + this.fnlmrk2txt.Text + "', Total_marks = '" + this.ttlmrk2txt.Text + "', Remarks_FI = '" + this.remrkf2txt.Text + "', Score = '" + this.scor2txt.Text + "', Letter_grade = '" + this.lettergrd2txt.Text + "', GP = '" + this.gp2txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '02'";
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



            string strQry8 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd3txt.Text + "', Course_Tittle = '" + this.crsttl3txt.Text + "', Credit_hour = '" + this.crdhr3txt.Text + "', Mid_exam = '" + this.mdmrk3txt.Text + "', Attendence = '" + this.atdnc3txt.Text + "', Final_exam = '" + this.fnlmrk3txt.Text + "', Total_marks = '" + this.ttlmrk3txt.Text + "', Remarks_FI = '" + this.remrkf3txt.Text + "', Score = '" + this.scor3txt.Text + "', Letter_grade = '" + this.lettergrd3txt.Text + "', GP = '" + this.gp3txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '03'";
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


            string strQry9 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd4txt.Text + "', Course_Tittle = '" + this.crsttl4txt.Text + "', Credit_hour = '" + this.crdhr4txt.Text + "', Mid_exam = '" + this.mdmrk4txt.Text + "', Attendence = '" + this.atdnc4txt.Text + "', Final_exam = '" + this.fnlmrk4txt.Text + "', Total_marks = '" + this.ttlmrk4txt.Text + "', Remarks_FI = '" + this.remrkf4txt.Text + "', Score = '" + this.scor4txt.Text + "', Letter_grade = '" + this.lettergrd4txt.Text + "', GP = '" + this.gp4txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '04'";
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

            string strQry10 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd5txt.Text + "', Course_Tittle = '" + this.crsttl5txt.Text + "', Credit_hour = '" + this.crdhr5txt.Text + "', Mid_exam = '" + this.mdmrk5txt.Text + "', Attendence = '" + this.atdnc5txt.Text + "', Final_exam = '" + this.fnlmrk5txt.Text + "', Total_marks = '" + this.ttlmrk5txt.Text + "', Remarks_FI = '" + this.remrkf5txt.Text + "', Score = '" + this.scor5txt.Text + "', Letter_grade = '" + this.lettergrd5txt.Text + "', GP = '" + this.gp5txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '05'";
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

            string strQry11 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd6txt.Text + "', Course_Tittle = '" + this.crsttl6txt.Text + "', Credit_hour = '" + this.crdhr6txt.Text + "', Mid_exam = '" + this.mdmrk6txt.Text + "', Attendence = '" + this.atdnc6txt.Text + "', Final_exam = '" + this.fnlmrk6txt.Text + "', Total_marks = '" + this.ttlmrk6txt.Text + "', Remarks_FI = '" + this.remrkf6txt.Text + "', Score = '" + this.scor6txt.Text + "', Letter_grade = '" + this.lettergrd6txt.Text + "', GP = '" + this.gp6txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '06'";
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

            string strQry12 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd7txt.Text + "', Course_Tittle = '" + this.crsttl7txt.Text + "', Credit_hour = '" + this.crdhr7txt.Text + "', Mid_exam = '" + this.mdmrk7txt.Text + "', Attendence = '" + this.atdnc7txt.Text + "', Final_exam = '" + this.fnlmrk7txt.Text + "', Total_marks = '" + this.ttlmrk7txt.Text + "', Remarks_FI = '" + this.remrkf7txt.Text + "', Score = '" + this.scor7txt.Text + "', Letter_grade = '" + this.lettergrd7txt.Text + "', GP = '" + this.gp7txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '07'";
            SqlCommand cmd12 = new SqlCommand(strQry12, cnx6);
            try
            {


                cmd12.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            string strQry13 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd8txt.Text + "', Course_Tittle = '" + this.crsttl8txt.Text + "', Credit_hour = '" + this.crdhr8txt.Text + "', Mid_exam = '" + this.mdmrk8txt.Text + "', Attendence = '" + this.atdnc8txt.Text + "', Final_exam = '" + this.fnlmrk8txt.Text + "', Total_marks = '" + this.ttlmrk8txt.Text + "', Remarks_FI = '" + this.remrkf8txt.Text + "', Score = '" + this.scor8txt.Text + "', Letter_grade = '" + this.lettergrd8txt.Text + "', GP = '" + this.gp8txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '08'";
            SqlCommand cmd13 = new SqlCommand(strQry13, cnx6);
            try
            {


                cmd13.ExecuteNonQuery();
                // MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            string strQry14 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd9txt.Text + "', Course_Tittle = '" + this.crsttl9txt.Text + "', Credit_hour = '" + this.crdhr9txt.Text + "', Mid_exam = '" + this.mdmrk9txt.Text + "', Attendence = '" + this.atdnc9txt.Text + "', Final_exam = '" + this.fnlmrk9txt.Text + "', Total_marks = '" + this.ttlmrk9txt.Text + "', Remarks_FI = '" + this.remrkf9txt.Text + "', Score = '" + this.scor9txt.Text + "', Letter_grade = '" + this.lettergrd9txt.Text + "', GP = '" + this.gp9txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '09'";
            SqlCommand cmd14 = new SqlCommand(strQry14, cnx6);
            try
            {


                cmd14.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string strQry15 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd10txt.Text + "', Course_Tittle = '" + this.crsttl10txt.Text + "', Credit_hour = '" + this.crdhr10txt.Text + "', Mid_exam = '" + this.mdmrk10txt.Text + "', Attendence = '" + this.atdnc10txt.Text + "', Final_exam = '" + this.fnlmrk10txt.Text + "', Total_marks = '" + this.ttlmrk10txt.Text + "', Remarks_FI = '" + this.remrkf10txt.Text + "', Score = '" + this.scor10txt.Text + "', Letter_grade = '" + this.lettergrd10txt.Text + "', GP = '" + this.gp10txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '10'";
            SqlCommand cmd15 = new SqlCommand(strQry15, cnx6);
            try
            {


                cmd15.ExecuteNonQuery();
                //MessageBox.Show("Update successfull");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string strQry16 = "UPDATE Marks1tb set Student_name = '" + this.stnametxt.Text + "', Session = '" + this.sessiontxt.Text + "' , Exam_roll = '" + this.exmroltxt.Text + "', Course_code = '" + this.crscd11txt.Text + "', Course_Tittle = '" + this.crsttl11txt.Text + "', Credit_hour = '" + this.crdhr11txt.Text + "', Mid_exam = '" + this.mdmrk11txt.Text + "', Attendence = '" + this.atdnc11txt.Text + "', Final_exam = '" + this.fnlmrk11txt.Text + "', Total_marks = '" + this.ttlmrk11txt.Text + "', Remarks_FI = '" + this.remrkf11txt.Text + "', Score = '" + this.scor11txt.Text + "', Letter_grade = '" + this.lettergrd11txt.Text + "', GP = '" + this.gp11txt.Text + "'WHERE Reg='" + this.rgtxt.Text + "'AND  Semester = '" + this.semestercmb.Text + "'AND  SL_NO = '11'";
            SqlCommand cmd16 = new SqlCommand(strQry16, cnx6);
            try
            {


                cmd16.ExecuteNonQuery();
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

      
    }
}
