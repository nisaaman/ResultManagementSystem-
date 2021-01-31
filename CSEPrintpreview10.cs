using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace print
{
    public partial class CSEPrintpreview10 : Form
    {
        String s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s38, s39, s40, s41, s42, s43, s44, s45, s46, s47, s49, s50, s51, s52, s53, s54, s55, s56, s57, s58, s60, s61, s62, s63, s64, s65, s66, s67, s68, s69, s71, s72, s73, s74, s75, s76, s77, s78, s79, s80, s81, s82, s83, s84, s85, s86, s87, s88, s89, s90, s91, s92, s93, s94, s95, s96, s97, s98, s99, s100, s101, s102, s103, s104, s105, s106, s107, s108, s109, s110, s111, s112, s113, s114, s115, s116, s117, s118, s119, s120, s121, s122, s123, s124, s125, s126, s127, s128, s129, s130, s131, s132, s133, s134, s135, s136, s137, s138, s139, s140, s141, s142, s143, s144, s145, s146, s147, s148, s149, s150, s151, s152, s153, s154, s155, s156, s157, s158, s159, s160, s161, s162;

        public CSEPrintpreview10(String str1, String str2, String str3, String str4, String str5, String str6, String str7, String str8, String str9, String str10, String str11, String str12, String str13, String str14, String str16, String str17, String str18, String str19, String str20, String str21, String str22, String str23, String str24, String str25, String str27, String str28, String str29, String str30, String str31, String str32, String str33, String str34, String str35, String str36, String str38, String str39, String str40, String str41, String str42, String str43, String str44, String str45, String str46, String str47, String str49, String str50, String str51, String str52, String str53, String str54, String str55, String str56, String str57, String str58, String str60, String str61, String str62, String str63, String str64, String str65, String str66, String str67, String str68, String str69, String str71, String str72, String str73, String str74, String str75, String str76, String str77)
        {
            InitializeComponent();
            final_exam.Text = str77;
            nametxt.Text = str1;
            regtxt.Text = str2;
            sessiontxt.Text = str3;
            exm_roltxt.Text = str4;
            sl_no_1txt.Text = str5;
            sl_no_2txt.Text = str6;
            sl_no_3txt.Text = str7;
            sl_no_4txt.Text = str8;
            sl_no_5txt.Text = str9;
            sl_no_6txt.Text = str10;
            sl_no_7txt.Text = str11;
            sl_no_8txt.Text = str12;
            sl_no_9txt.Text = str13;
            sl_no_10txt.Text = str14;

            course_code_1txt.Text = str16;
            course_code_2txt.Text = str17;
            course_code_3txt.Text = str18;
            course_code_4txt.Text = str19;
            course_code_5txt.Text = str20;
            course_code_6txt.Text = str21;
            course_code_7txt.Text = str22;
            course_code_8txt.Text = str23;
            course_code_9txt.Text = str24;
            course_code_10txt.Text = str25;

            course_ttl_1txt.Text = str27;
            course_ttl_2txt.Text = str28;
            course_ttl_3txt.Text = str29;
            course_ttl_4txt.Text = str30;
            course_ttl_5txt.Text = str31;
            course_ttl_6txt.Text = str32;
            course_ttl_7txt.Text = str33;
            course_ttl_8txt.Text = str34;
            course_ttl_9txt.Text = str35;
            course_ttl_10txt.Text = str36;

            crdt_hr_1txt.Text = str38;
            crdt_hr_2txt.Text = str39;
            crdt_hr_3txt.Text = str40;
            crdt_hr_4txt.Text = str41;
            crdt_hr_5txt.Text = str42;
            crdt_hr_6txt.Text = str43;
            crdt_hr_7txt.Text = str44;
            crdt_hr_8txt.Text = str45;
            crdt_hr_9txt.Text = str46;
            crdt_hr_10txt.Text = str47;

            letter_grd_1txt.Text = str49;
            letter_grd_2txt.Text = str50;
            letter_grd_3txt.Text = str51;
            letter_grd_4txt.Text = str52;
            letter_grd_5txt.Text = str53;
            letter_grd_6txt.Text = str54;
            letter_grd_7txt.Text = str55;
            letter_grd_8txt.Text = str56;
            letter_grd_9txt.Text = str57;
            letter_grd_10txt.Text = str58;

            gp_1txt.Text = str60;
            gp_2txt.Text = str61;
            gp_3txt.Text = str62;
            gp_4txt.Text = str63;
            gp_5txt.Text = str64;
            gp_6txt.Text = str65;
            gp_7txt.Text = str66;
            gp_8txt.Text = str67;
            gp_9txt.Text = str68;
            gp_10txt.Text = str69;

            gpalbl.Text = str71;
            pre_cgpalbl.Text = str72;
            pre_cchlbl.Text = str73;
            cgpalbl.Text = str74;
            cchlbl.Text = str75;
            remarkslbl.Text = str76;

            String str78 = name_st_txt.Text;
            String str79 = reg_no_txt.Text;
            String str80 = session_txt.Text;
            String str81 = exm_roll_txt.Text;
            String str82 = sl_np_txt.Text;
            String str83 = course_code_txt.Text;
            String str84 = course_ttl_txt.Text;
            String str85 = crdt_hr_txt.Text;
            String str86 = letter_grd_txt.Text;
            String str87 = gp_txt.Text;
            String str88 = gpa_txt.Text;
            String str89 = pre_cgpa_txt.Text;
            String str90 = pre_cch_txt.Text;
            String str91 = cgpa_txt.Text;
            String str92 = cch_txt.Text;
            String str93 = remarks_txt.Text;
            String str94 = clm1.Text;
            String str95 = clm2.Text;
            String str96 = clm3.Text;
            String str97 = clm4.Text;
            String str98 = clm5.Text;
            String str99 = clm6.Text;
            String str100 = clm7.Text;
            String str101 = clm8.Text;
            String str102 = clm9.Text;
            String str155 = clm10.Text;
            String str156 = clm11.Text;
            String str157 = clm12.Text;

            String str103 = grad_stm.Text;
            String str104 = score_pnt.Text;
            String str105 = letter_grd_pnt.Text;
            String str106 = grade_pnt.Text;
            String str107 = assmnt_comnt.Text;
            String str108 = score_pnt1.Text;
            String str109 = letter_grd_pnt1.Text;
            String str110 = grade_pnt1.Text;
            String str111 = assmnt_comnt1.Text;
            String str112 = score_pnt2.Text;
            String str113 = letter_grd_pnt2.Text;
            String str114 = grade_pnt2.Text;
            String str115 = assmnt_comnt2.Text;
            String str116 = score_pnt3.Text;
            String str117 = letter_grd_pnt3.Text;
            String str118 = grade_pnt3.Text;
            String str119 = assmnt_comnt3.Text;
            String str120 = score_pnt4.Text;
            String str121 = letter_grd_pnt4.Text;
            String str122 = grade_pnt4.Text;
            String str123 = assmnt_comnt4.Text;
            String str124 = score_pnt5.Text;
            String str125 = letter_grd_pnt5.Text;
            String str126 = grade_pnt5.Text;
            String str127 = assmnt_comnt5.Text;
            String str128 = score_pnt6.Text;
            String str129 = letter_grd_pnt6.Text;
            String str130 = grade_pnt6.Text;
            String str131 = assmnt_comnt6.Text;


            String str132 = grad_2_stm.Text;
            String str133 = score_2_pnt.Text;
            String str134 = letter_grd_2_pnt.Text;
            String str135 = grade_2_pnt.Text;
            String str136 = assmnt_2_comnt.Text;
            String str137 = score_2_pnt1.Text;
            String str138 = letter_grd_2_pnt1.Text;
            String str139 = grade_2_pnt1.Text;
            String str140 = assmnt_2_comnt1.Text;
            String str141 = score_2_pnt2.Text;
            String str142 = letter_grd_2_pnt2.Text;
            String str143 = grade_2_pnt2.Text;
            String str144 = assmnt_2_comnt2.Text;
            String str145 = score_2_pnt3.Text;
            String str146 = letter_grd_2_pnt3.Text;
            String str147 = grade_2_pnt3.Text;
            String str148 = assmnt_2_comnt3.Text;
            String str149 = letter_grd_2_pnt4.Text;
            String str150 = assmnt_2_comnt4.Text;
            String str151 = letter_grd_2_pnt5.Text;
            String str152 = assmnt_2_comnt5.Text;
            String str153 = letter_grd_2_pnt6.Text;
            String str154 = assmnt_2_comnt6.Text;


            String str158 = final_exam.Text;
            String str159 = versity_name.Text;
            String str160 = dumki.Text;
            String str161 = mrks_cert_name.Text;
            String str162 = provisional.Text;

            //PictureBox pic = pictureBox1.Image;



            s78 = str78;
            s79 = str79;
            s80 = str80;
            s81 = str81;
            s82 = str82;
            s83 = str83;
            s84 = str84;
            s85 = str85;
            s86 = str86;
            s87 = str87;
            s88 = str88;
            s89 = str89;
            s90 = str90;
            s91 = str91;
            s92 = str92;
            s93 = str93;
            s94 = str94;
            s95 = str95;
            s96 = str96;
            s97 = str97;
            s98 = str98;
            s99 = str99;
            s100 = str100;
            s101 = str101;
            s102 = str102;
            s103 = str103;
            s104 = str104;
            s105 = str105;
            s106 = str106;
            s107 = str107;
            s108 = str108;
            s109 = str109;
            s110 = str110;
            s111 = str111;
            s112 = str112;
            s113 = str113;
            s114 = str114;
            s115 = str115;
            s116 = str116;
            s117 = str117;
            s118 = str118;
            s119 = str119;
            s120 = str120;
            s121 = str121;
            s122 = str122;
            s123 = str123;
            s124 = str124;
            s125 = str125;
            s126 = str126;
            s127 = str127;
            s128 = str128;
            s129 = str129;
            s130 = str130;
            s131 = str131;

            s132 = str132;
            s133 = str133;
            s134 = str134;
            s135 = str135;
            s136 = str136;
            s137 = str137;
            s138 = str138;
            s139 = str139;
            s140 = str140;
            s141 = str141;
            s142 = str142;
            s143 = str143;
            s144 = str144;
            s145 = str145;
            s146 = str146;
            s147 = str147;
            s148 = str148;
            s149 = str149;
            s150 = str150;
            s151 = str151;
            s152 = str152;
            s153 = str153;
            s154 = str154;
            s155 = str155;
            s156 = str156;
            s157 = str157;

            s158 = str158;
            s159 = str159;
            s160 = str160;
            s161 = str161;
            s162 = str162;

            s1 = str1;
            s2 = str2;
            s3 = str3;
            s4 = str4;
            s5 = str5;
            s6 = str6;
            s7 = str7;
            s8 = str8;
            s9 = str9;
            s10 = str10;
            s11 = str11;
            s12 = str12;
            s13 = str13;
            s14 = str14;


            s16 = str16;
            s17 = str17;
            s18 = str18;
            s19 = str19;
            s20 = str20;
            s21 = str21;
            s22 = str22;
            s23 = str23;
            s24 = str24;
            s25 = str25;

            s27 = str27;
            s28 = str28;
            s29 = str29;
            s30 = str30;
            s31 = str31;
            s32 = str32;
            s33 = str33;
            s34 = str34;
            s35 = str35;
            s36 = str36;

            s38 = str38;
            s39 = str39;
            s40 = str40;
            s41 = str41;
            s42 = str42;
            s43 = str43;
            s44 = str44;
            s45 = str45;
            s46 = str46;
            s47 = str47;

            s49 = str49;
            s50 = str50;
            s51 = str51;
            s52 = str52;
            s53 = str53;
            s54 = str54;
            s55 = str55;
            s56 = str56;
            s57 = str57;
            s58 = str58;

            s60 = str60;
            s61 = str61;
            s62 = str62;
            s63 = str63;
            s64 = str64;
            s65 = str65;
            s66 = str66;
            s67 = str67;
            s68 = str68;
            s69 = str69;

            s71 = str71;
            s72 = str72;
            s73 = str73;
            s74 = str74;
            s75 = str75;
            s76 = str76;

            s77 = str77;
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Font font2 = new Font("Arial", 7);
            Font font3 = new Font("Arial", 14);
            Font font4 = new Font("Arial", 12);

            e.Graphics.DrawImage(pictureBox1.Image, 270, 10);

            e.Graphics.DrawString(s78, font, Brushes.Black, 10, 245);
            e.Graphics.DrawString(s79, font, Brushes.Black, 510, 245);
            e.Graphics.DrawString(s80, font, Brushes.Black, 720, 245);
            e.Graphics.DrawString(s81, font, Brushes.Black, 930, 245);
            e.Graphics.DrawString(s82, font, Brushes.Black, 0, 285);
            e.Graphics.DrawString(s83, font, Brushes.Black, 55, 280);
            e.Graphics.DrawString(s84, font, Brushes.Black, 230, 285);
            e.Graphics.DrawString(s85, font, Brushes.Black, 442, 285);
            e.Graphics.DrawString(s86, font, Brushes.Black, 515, 278);
            e.Graphics.DrawString(s87, font, Brushes.Black, 590, 285);
            e.Graphics.DrawString(s88, font, Brushes.Black, 658, 285);
            e.Graphics.DrawString(s89, font, Brushes.Black, 715, 280);
            e.Graphics.DrawString(s90, font, Brushes.Black, 784, 280);
            e.Graphics.DrawString(s91, font, Brushes.Black, 862, 280);
            e.Graphics.DrawString(s92, font, Brushes.Black, 938, 280);
            e.Graphics.DrawString(s93, font, Brushes.Black, 1002, 280);
            e.Graphics.DrawString(s94, font, Brushes.Black, 12, 352);
            e.Graphics.DrawString(s95, font, Brushes.Black, 72, 352);
            e.Graphics.DrawString(s96, font, Brushes.Black, 265, 352);
            e.Graphics.DrawString(s97, font, Brushes.Black, 458, 352);
            e.Graphics.DrawString(s98, font, Brushes.Black, 527, 352);
            e.Graphics.DrawString(s99, font, Brushes.Black, 596, 352);
            e.Graphics.DrawString(s100, font, Brushes.Black, 665, 352);
            e.Graphics.DrawString(s101, font, Brushes.Black, 736, 352);
            e.Graphics.DrawString(s102, font, Brushes.Black, 805, 352);
            e.Graphics.DrawString(s155, font, Brushes.Black, 874, 352);
            e.Graphics.DrawString(s156, font, Brushes.Black, 943, 352);
            e.Graphics.DrawString(s157, font, Brushes.Black, 1025, 352);

            e.Graphics.DrawString(s103, font, Brushes.Black, 70, 21);
            e.Graphics.DrawString(s104, font2, Brushes.Black, 0, 40);
            e.Graphics.DrawString(s105, font2, Brushes.Black, 60, 40);
            e.Graphics.DrawString(s106, font2, Brushes.Black, 102, 40);
            e.Graphics.DrawString(s107, font2, Brushes.Black, 168, 40);
            e.Graphics.DrawString(s108, font2, Brushes.Black, 0, 65);
            e.Graphics.DrawString(s109, font2, Brushes.Black, 65, 65);
            e.Graphics.DrawString(s110, font2, Brushes.Black, 107, 65);
            e.Graphics.DrawString(s111, font2, Brushes.Black, 164, 65);
            e.Graphics.DrawString(s112, font2, Brushes.Black, 0, 85);
            e.Graphics.DrawString(s113, font2, Brushes.Black, 65, 85);
            e.Graphics.DrawString(s114, font2, Brushes.Black, 107, 85);
            e.Graphics.DrawString(s115, font2, Brushes.Black, 164, 85);
            e.Graphics.DrawString(s116, font2, Brushes.Black, 0, 105);
            e.Graphics.DrawString(s117, font2, Brushes.Black, 65, 105);
            e.Graphics.DrawString(s118, font2, Brushes.Black, 107, 105);
            e.Graphics.DrawString(s119, font2, Brushes.Black, 164, 105);
            e.Graphics.DrawString(s120, font2, Brushes.Black, 0, 125);
            e.Graphics.DrawString(s121, font2, Brushes.Black, 65, 125);
            e.Graphics.DrawString(s122, font2, Brushes.Black, 107, 125);
            e.Graphics.DrawString(s123, font2, Brushes.Black, 164, 125);
            e.Graphics.DrawString(s124, font2, Brushes.Black, 0, 145);
            e.Graphics.DrawString(s125, font2, Brushes.Black, 65, 145);
            e.Graphics.DrawString(s126, font2, Brushes.Black, 107, 145);
            e.Graphics.DrawString(s127, font2, Brushes.Black, 164, 145);
            e.Graphics.DrawString(s128, font2, Brushes.Black, 0, 165);
            e.Graphics.DrawString(s129, font2, Brushes.Black, 65, 165);
            e.Graphics.DrawString(s130, font2, Brushes.Black, 107, 165);
            e.Graphics.DrawString(s131, font2, Brushes.Black, 164, 165);


            e.Graphics.DrawString(s132, font, Brushes.Black, 912, 21);
            e.Graphics.DrawString(s133, font2, Brushes.Black, 842, 40);
            e.Graphics.DrawString(s134, font2, Brushes.Black, 897, 40);
            e.Graphics.DrawString(s135, font2, Brushes.Black, 948, 40);
            e.Graphics.DrawString(s136, font2, Brushes.Black, 1007, 40);
            e.Graphics.DrawString(s137, font2, Brushes.Black, 842, 65);
            e.Graphics.DrawString(s138, font2, Brushes.Black, 905, 65);
            e.Graphics.DrawString(s139, font2, Brushes.Black, 948, 65);
            e.Graphics.DrawString(s140, font2, Brushes.Black, 995, 65);
            e.Graphics.DrawString(s141, font2, Brushes.Black, 842, 85);
            e.Graphics.DrawString(s142, font2, Brushes.Black, 905, 85);
            e.Graphics.DrawString(s143, font2, Brushes.Black, 948, 85);
            e.Graphics.DrawString(s144, font2, Brushes.Black, 995, 85);
            e.Graphics.DrawString(s145, font2, Brushes.Black, 842, 105);
            e.Graphics.DrawString(s146, font2, Brushes.Black, 905, 105);
            e.Graphics.DrawString(s147, font2, Brushes.Black, 948, 105);
            e.Graphics.DrawString(s148, font2, Brushes.Black, 995, 105);
            e.Graphics.DrawString(s149, font2, Brushes.Black, 905, 125);
            e.Graphics.DrawString(s150, font2, Brushes.Black, 995, 125);
            e.Graphics.DrawString(s151, font2, Brushes.Black, 905, 145);
            e.Graphics.DrawString(s152, font2, Brushes.Black, 995, 145);
            e.Graphics.DrawString(s153, font2, Brushes.Black, 905, 165);
            e.Graphics.DrawString(s154, font2, Brushes.Black, 995, 165);


            e.Graphics.DrawString(s158, font4, Brushes.Black, 252, 205);
            e.Graphics.DrawString(s159, font4, Brushes.Navy, 360, 20);
            e.Graphics.DrawString(s160, font, Brushes.Black, 480, 50);
            e.Graphics.DrawString(s161, font, Brushes.Indigo, 420, 80);
            e.Graphics.DrawString(s162, font, Brushes.Black, 558, 110);

            e.Graphics.DrawString(s1, font, Brushes.Black, 155, 245);
            e.Graphics.DrawString(s2, font, Brushes.Black, 578, 245);
            e.Graphics.DrawString(s3, font, Brushes.Black, 785, 245);
            e.Graphics.DrawString(s4, font, Brushes.Black, 1030, 245);
            e.Graphics.DrawString(s5, font, Brushes.Black, 12, 377);
            e.Graphics.DrawString(s6, font, Brushes.Black, 12, 405);
            e.Graphics.DrawString(s7, font, Brushes.Black, 12, 433);
            e.Graphics.DrawString(s8, font, Brushes.Black, 12, 464);
            e.Graphics.DrawString(s9, font, Brushes.Black, 12, 495);
            e.Graphics.DrawString(s10, font, Brushes.Black, 12, 528);
            e.Graphics.DrawString(s11, font, Brushes.Black, 12, 555);
            e.Graphics.DrawString(s12, font, Brushes.Black, 12, 585);
            e.Graphics.DrawString(s13, font, Brushes.Black, 12, 615);
            e.Graphics.DrawString(s14, font, Brushes.Black, 8, 646);



            e.Graphics.DrawString(s16, font, Brushes.Black, 43, 377);
            e.Graphics.DrawString(s17, font, Brushes.Black, 43, 405);
            e.Graphics.DrawString(s18, font, Brushes.Black, 43, 433);
            e.Graphics.DrawString(s19, font, Brushes.Black, 43, 464);
            e.Graphics.DrawString(s20, font, Brushes.Black, 43, 495);
            e.Graphics.DrawString(s21, font, Brushes.Black, 43, 528);
            e.Graphics.DrawString(s22, font, Brushes.Black, 43, 555);
            e.Graphics.DrawString(s23, font, Brushes.Black, 43, 585);
            e.Graphics.DrawString(s24, font, Brushes.Black, 43, 615);
            e.Graphics.DrawString(s25, font, Brushes.Black, 43, 646);



            e.Graphics.DrawString(s27, font, Brushes.Black, 121, 377);
            e.Graphics.DrawString(s28, font, Brushes.Black, 121, 405);
            e.Graphics.DrawString(s29, font, Brushes.Black, 121, 433);
            e.Graphics.DrawString(s30, font, Brushes.Black, 121, 464);
            e.Graphics.DrawString(s31, font, Brushes.Black, 121, 495);
            e.Graphics.DrawString(s32, font, Brushes.Black, 121, 528);
            e.Graphics.DrawString(s33, font, Brushes.Black, 121, 555);
            e.Graphics.DrawString(s34, font, Brushes.Black, 121, 585);
            e.Graphics.DrawString(s35, font, Brushes.Black, 121, 615);
            e.Graphics.DrawString(s36, font, Brushes.Black, 121, 646);



            e.Graphics.DrawString(s38, font, Brushes.Black, 450, 377);
            e.Graphics.DrawString(s39, font, Brushes.Black, 450, 405);
            e.Graphics.DrawString(s40, font, Brushes.Black, 450, 433);
            e.Graphics.DrawString(s41, font, Brushes.Black, 450, 464);
            e.Graphics.DrawString(s42, font, Brushes.Black, 450, 495);
            e.Graphics.DrawString(s43, font, Brushes.Black, 450, 528);
            e.Graphics.DrawString(s44, font, Brushes.Black, 450, 555);
            e.Graphics.DrawString(s45, font, Brushes.Black, 450, 585);
            e.Graphics.DrawString(s46, font, Brushes.Black, 450, 615);
            e.Graphics.DrawString(s47, font, Brushes.Black, 450, 646);



            e.Graphics.DrawString(s49, font, Brushes.Black, 525, 377);
            e.Graphics.DrawString(s50, font, Brushes.Black, 525, 405);
            e.Graphics.DrawString(s51, font, Brushes.Black, 525, 433);
            e.Graphics.DrawString(s52, font, Brushes.Black, 525, 464);
            e.Graphics.DrawString(s53, font, Brushes.Black, 525, 495);
            e.Graphics.DrawString(s54, font, Brushes.Black, 525, 528);
            e.Graphics.DrawString(s55, font, Brushes.Black, 525, 555);
            e.Graphics.DrawString(s56, font, Brushes.Black, 525, 585);
            e.Graphics.DrawString(s57, font, Brushes.Black, 525, 615);
            e.Graphics.DrawString(s58, font, Brushes.Black, 525, 646);


            e.Graphics.DrawString(s60, font, Brushes.Black, 588, 377);
            e.Graphics.DrawString(s61, font, Brushes.Black, 588, 405);
            e.Graphics.DrawString(s62, font, Brushes.Black, 588, 433);
            e.Graphics.DrawString(s63, font, Brushes.Black, 588, 464);
            e.Graphics.DrawString(s64, font, Brushes.Black, 588, 495);
            e.Graphics.DrawString(s65, font, Brushes.Black, 588, 528);
            e.Graphics.DrawString(s66, font, Brushes.Black, 588, 555);
            e.Graphics.DrawString(s67, font, Brushes.Black, 588, 585);
            e.Graphics.DrawString(s68, font, Brushes.Black, 588, 615);
            e.Graphics.DrawString(s69, font, Brushes.Black, 588, 646);



            e.Graphics.DrawString(s71, font, Brushes.Black, 660, 528);
            e.Graphics.DrawString(s72, font, Brushes.Black, 730, 528);
            e.Graphics.DrawString(s73, font, Brushes.Black, 793, 528);
            e.Graphics.DrawString(s74, font, Brushes.Black, 870, 528);
            e.Graphics.DrawString(s75, font, Brushes.Black, 933, 528);
            e.Graphics.DrawString(s76, font, Brushes.Black, 1000, 528);


            //e.Graphics.DrawImage(
            //e.Graphics.DrawImage(Image pic,50,80)
            Pen p = new Pen(Color.Black, 1f);


            e.Graphics.DrawLine(p, 0, 240, 1090, 240);
            e.Graphics.DrawLine(p, 0, 270, 1090, 270);
            e.Graphics.DrawLine(p, 0, 350, 1090, 350);
            e.Graphics.DrawLine(p, 0, 370, 1090, 370);
            e.Graphics.DrawLine(p, 0, 400, 640, 400);
            e.Graphics.DrawLine(p, 0, 430, 640, 430);
            e.Graphics.DrawLine(p, 0, 460, 640, 460);
            e.Graphics.DrawLine(p, 0, 490, 640, 490);
            e.Graphics.DrawLine(p, 0, 520, 640, 520);
            e.Graphics.DrawLine(p, 0, 550, 640, 550);
            e.Graphics.DrawLine(p, 0, 580, 640, 580);
            e.Graphics.DrawLine(p, 0, 610, 640, 610);
            e.Graphics.DrawLine(p, 0, 640, 640, 640);
            //e.Graphics.DrawLine(p, 0, 670, 640, 670);
            e.Graphics.DrawLine(p, 0, 670, 1090, 670);


            e.Graphics.DrawLine(p, 0, 240, 0, 670);
            e.Graphics.DrawLine(p, 40, 270, 40, 670);
            e.Graphics.DrawLine(p, 120, 270, 120, 670);
            e.Graphics.DrawLine(p, 430, 270, 430, 670);
            e.Graphics.DrawLine(p, 500, 240, 500, 670);
            e.Graphics.DrawLine(p, 570, 270, 570, 670);
            e.Graphics.DrawLine(p, 640, 270, 640, 670);
            e.Graphics.DrawLine(p, 710, 240, 710, 670);
            e.Graphics.DrawLine(p, 780, 270, 780, 670);
            e.Graphics.DrawLine(p, 850, 270, 850, 670);
            e.Graphics.DrawLine(p, 920, 240, 920, 670);
            e.Graphics.DrawLine(p, 990, 270, 990, 670);
            e.Graphics.DrawLine(p, 1090, 240, 1090, 670);





            e.Graphics.DrawLine(p, 0, 20, 250, 20);
            e.Graphics.DrawLine(p, 0, 40, 250, 40);
            e.Graphics.DrawLine(p, 0, 62, 250, 62);
            e.Graphics.DrawLine(p, 0, 82, 250, 82);
            e.Graphics.DrawLine(p, 0, 102, 250, 102);
            e.Graphics.DrawLine(p, 0, 122, 250, 122);
            e.Graphics.DrawLine(p, 0, 142, 250, 142);
            e.Graphics.DrawLine(p, 0, 162, 250, 162);
            e.Graphics.DrawLine(p, 0, 182, 250, 182);


            e.Graphics.DrawLine(p, 0, 20, 0, 182);
            e.Graphics.DrawLine(p, 50, 40, 50, 182);
            e.Graphics.DrawLine(p, 95, 40, 95, 182);
            e.Graphics.DrawLine(p, 145, 40, 145, 182);
            e.Graphics.DrawLine(p, 250, 20, 250, 182);

            e.Graphics.DrawLine(p, 840, 20, 1090, 20);
            e.Graphics.DrawLine(p, 840, 40, 1090, 40);
            e.Graphics.DrawLine(p, 840, 62, 1090, 62);
            e.Graphics.DrawLine(p, 840, 82, 1090, 82);
            e.Graphics.DrawLine(p, 840, 102, 1090, 102);
            e.Graphics.DrawLine(p, 840, 122, 1090, 122);
            e.Graphics.DrawLine(p, 840, 142, 1090, 142);
            e.Graphics.DrawLine(p, 840, 162, 1090, 162);
            e.Graphics.DrawLine(p, 840, 182, 1090, 182);


            e.Graphics.DrawLine(p, 840, 20, 840, 182);
            e.Graphics.DrawLine(p, 890, 40, 890, 182);
            e.Graphics.DrawLine(p, 935, 40, 935, 182);
            e.Graphics.DrawLine(p, 985, 40, 985, 182);
            e.Graphics.DrawLine(p, 1090, 20, 1090, 182);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;

            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;

            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
