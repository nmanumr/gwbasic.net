using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GwBasic.Net
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region hello world
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM Write Hello World at console\n30 a$= \"Hello World!\"\n40 PRINT a$\n50 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion hello world

        #region happy birthday
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM Say Happy Birthday to GwBasic.Net\n\n20 happy$= \"Happy birthday\"\n30 PRINT happy$; \" to you!\"\n40 PRINT happy$; \" to you!\"\n50 PRINT happy$; \" dear GwBasic.Net!\"\n60 PRINT happy$; \" to you!\"\n70 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion happy birthday

        #region greeting
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM Say Hello to You\n\n20 WHILE 1 = 1\n30     INPUT \"Enter Any Your Name\"; NAM$\n40     PRINT \"Hello \"; NAM$\n50     PRINT \"\"\n60 WEND\n70 END";
            syntaxEditor.Show();
            Parent.Hide();

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion greeting

        #region inclined
        private void Inclined_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM Create an Inclined on console\n\n20 FOR I = 1 TO 5\n30 FOR J = 1 TO I\n40 PRINT \"*\"\n50 NEXT J\n60 PRINT \"\\\"\n70 NEXT I\n80 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void Inclined_MouseLeave(object sender, EventArgs e)
        {
            Inclined.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void Inclined_MouseMove(object sender, MouseEventArgs e)
        {
            Inclined.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion inclined

        #region Calculator
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 cls\n20 input\"Enter First Number\";x\n30 input\"Enter Second Number\";y\n50 print\"1 for *\"\n60 print\"2 for /\"\n70 print\"3 for + \"\n75 input\"select any one from above\";c\n80 if c = 1 goto 120\n90 if c = 2 goto 150\n100 if c = 3 goto 180 else goto 110\n110 print\"wrong input the program is terminated\"\n115 end\n120 z = x * y\n130 print x\"*\"y\"=\"z\n140 end\n150 z = x / y\n160 print x\"/\"y\"='z\n170 end\n180 z = x + y\n190 print x\"+\"y\"=\"z\n200 end";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion Calculator

        #region key buffer
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM flush the keyboard buffer\n20 IF INKEY$<> \"\" THEN GOTO 10\n30 PRINT \"Press Y or N to continue\"\n40 LET k$ = INKEY$\n50 IF k$ <> \"y\" AND k$ <> \"Y\" AND k$ <> \"n\" AND k$ <> \"N\" THEN GOTO 40\n60 PRINT \"The response was \"; k$\n70 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion key buffer

        #region bottle of bear 
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 FOR BOTTLES = 99 TO 1 STEP -1\n20    PRINT BOTTLES \" bottles of beer on the wall\"\n30    PRINT BOTTLES \" bottles of beer\"\n40    PRINT \"Take one down, pass it around\"\n50    PRINT BOTTLES-1 \" bottles of beer on the wall\"\n60 NEXT BOTTLES";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion bottle of bear

        #region Find Previous PRime
        private void miniTimer_Label12_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10  INPUT \"ENTER NUMBER TO SEARCH TO: \";LIMIT\n20  DIM FLAGS(LIMIT)\n30  FOR N = 2 TO SQR(LIMIT)\n40  IF FLAGS(N) < > 0 GOTO 80\n50  FOR K = N * N TO LIMIT STEP N\n60  FLAGS(K) = 1\n70  NEXT K\n80  NEXT N\n90  REM  DISPLAY THE PRIMES\n100  FOR N = 2 TO LIMIT\n110  IF FLAGS(N) = 0 THEN PRINT N; \", \";\n120  NEXT N";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.tile_frame;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.tile_frame_h;
        }
        #endregion Find Next PRime

        #region Bio data
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 REM PRACTICAL 10 (BIO-DATA)\n20 CLS\n30 INPUT \"ENTER STUDENT NAME\"; N$\n40 INPUT \"ENTER FAHTERS NAME\"; F$\n50 INPUT \"ENTER DATE OF BIRTH\"; D$\n60 INPUT \"ENTER QUALIFICATION\"; Q$\n70 INPUT \"ENTER STUDENT SEX\"; S$\n80 INPUT \"ENTER NATIONLAITY\"; P$\n90 INPUT \"ENTER RELIGON\"; R$\n100 CLS\n110 PRINT TAB(15) \"BIO-DATA\"\n120 PRINT TAB(12)\"STUDENT NAME= =\"; N$\n130 PRINT TAB(12)\"FAHTERS NAME= =\"; F$\n140 PRINT TAB(12)\"DATE OF BIRTH= =\"; D$\n150 PRINT TAB(12)\"QUALIFICATION =\"; Q$\n160 PRINT TAB(12)\"SEX= = = =  = = = =\"; S$\n170 PRINT TAB(12)\"NATIONLAITY= = =\"; P$\n180 PRINT TAB(12)\"RELIGON= = = =  =\"; R$\n190 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Bio data

        #region Decimal to Binary
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 ' Step by Step Decimal to binary Convertor\n20 ' Writen By: Nauman Umer\n30 cls\n40 Input \"Enter a no in decimal Number System\";deci\n50 n=0\n60 qout=int(deci/2)\n70 remin = deci-(qout*2)\n80 if n=o then print else print \"------------\"\n90 if n=0 then print \"2 | \"; deci\n100 if n=0 then print \"------------\"\n110 if qout=1 or qout=0 then print \" | \";qout ;\" - \";remin else print \"2 | \";qout ;\" - \";remin\n120 deci=qout\n130 n=n+1\n140 if deci>1 then goto 60\n150 end";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Decimal to Binary

        #region Binary to decimal
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "0 Rem Binary to decimal coverter\n1 rem By: Nauman Umer\n10 CLS\n11 rem on error goto 150\n12 n = 1: i = 1\n13 dim a(50)\n20 INPUT \"Enter a Number in Binary :\" ; bin$\n21 print bin$\n30 lenght = len(bin$)\n40 bina = fix(val(bin$))\n44 rem * *------------step 1-------- - **\n45 a$ = mid$(bin$,n,i)\n50 if (a$= \"0\") or(a$= \"1\") then print \"\"; else print \"Please Enter Correct Number\": end\n52 print \"( \"; a$; \" * (\"; 2; \"^\"; lenght - 1; \"))\";\n54 if  lenght = 0 then goto 71 else print \" + \";\n53 lenght = lenght - 1\n60 n = n + 1\n70 goto 45\n71 rem * *-----------step 2-------- - **\n72 n = 1: i = 1\n73 lenght = len(bin$)\n74 print \"\"\n75 a$ = mid$(bin$,n,i)\n76 ab = fix(val(a$))\n77 lenght = lenght - 1\n78 ac = 2 ^ (lenght)\n79 print \"(\"; ab; \"*\"; ac; \")\";\n80 if  lenght = 0 then goto 90 else print \" + \";\n84 n = n + 1\n86 goto 75\n87 rem * *-----------step 3---------- - **\n90 n = 1: i = 1\n100 lenght = len(bin$)\n110 print \"\"\n120 a$ = mid$(bin$,n,i)\n130 ab = fix(val(a$))\n140 lenght = lenght - 1\n150 ac = 2 ^ (lenght)\n151 ad = ab * ac\n152 a(lenght) = ad\n160 print ad;\n170 if  lenght = 0 then goto 200 else print \" + \";\n180 n = n + 1\n190 goto 120\n191 rem * *------------step 4-------------- - **\n200 i = 0\n201 lenght = len(bin$)\n202 print \"\"\n211 sum = 0\n212 sum = sum + a(i)\n230 i = i + 1\n220 if i = (lenght - 1) then 250\n240 goto 212\n250 ? sum;\n260 rem * *------------end-------------- * *\n400 END\n410 print \"Please Enter Correct Number\"\n420 goto 20 ";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Binary to decimal

        #region Next String
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 INPUT \"Enter a string: \",A$\n20 GOSUB 50\n30 PRINT B$\n40 END\n50 FOR I = 1 TO LEN(A$)\n60 N = ASC(MID$(A$, I, 1))\n70 E = 255\n80 IF N> 64 AND N< 91 THEN E = 90   ' uppercase\n90 IF N> 96 AND N< 123 THEN E = 122 ' lowercase\n100 IF E< 255 THEN N = N + 13\n110 IF N> E THEN N = N - 26\n120 B$= B$+CHR$(N)\n130 NEXT\n140 RETURN";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Next String

        #region Number Mountain
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 INPUT \"Number of rows: \",R\n20 FOR I = 0 TO R-1\n30 C = 1\n40 FOR K = 0 TO I\n50 PRINT USING \"####\"; C;\n60 C = C * (I - K) / (K + 1)\n70 NEXT\n80 PRINT\n90 NEXT";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Number Mountain

        #region Prime
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 INPUT \"Enter a Number\";Inpt\n20 ItratTo = cint(sqr(INPT)) + 1\n30 Dividing = 2\n40 while (dividing <> ItratTo)\n50 if (INPT / dividing)= cint(INPT / dividing) then print \"Composite\":End\n60 dividing = dividing + 1\n70 wend\n80 Print \"Prime\"\n90 End";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Prime

        #region Acey Ducey
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 PRINT TAB(26);\"ACEY DUCEY CARD GAME\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n21 PRINT\n22 PRINT\n30 PRINT\"ACEY-DUCEY IS PLAYED IN THE FOLLOWING MANNER \"\n40 PRINT\"THE DEALER (COMPUTER) DEALS TWO CARDS FACE UP\"\n50 PRINT\"YOU HAVE AN OPTION TO BET OR NOT BET DEPENDING\"\n60 PRINT\"ON WHETHER OR NOT YOU FEEL THE CARD WILL HAVE\"\n70 PRINT\"A VALUE BETWEEN THE FIRST TWO.\"\n80 PRINT\"IF YOU DO NOT WANT TO BET, INPUT A 0\"\n100 N=100\n110 Q=100\n120 PRINT \"YOU NOW HAVE\";Q;\"DOLLARS.\"\n130 PRINT\n140 GOTO 260\n210 Q=Q+M\n220 GOTO 120\n240 Q=Q-M\n250 GOTO 120\n260 PRINT\"HERE ARE YOUR NEXT TWO CARDS: \"\n270 A=INT(14*RND(1))+2\n280 IF A<2 THEN 270\n290 IF A>14 THEN 270\n300 B=INT(14*RND(1))+2\n310 IF B<2 THEN 300\n320 IF B>14 THEN 300\n330 IF A>=B THEN 270\n350 IF A<11 THEN 400\n360 IF A=11 THEN 420\n370 IF A=12 THEN 440\n380 IF A=13 THEN 460\n390 IF A=14 THEN 480\n400 PRINT A\n410 GOTO 500\n420 PRINT\"JACK\"\n430 GOTO 500\n440 PRINT\"QUEEN\"\n450 GOTO 500\n460 PRINT\"KING\"\n470 GOTO 500\n480 PRINT\"ACE\"\n500 IF B<11 THEN 550\n510 IF B=11 THEN 570\n520 IF B=12 THEN 590\n530 IF B=13 THEN 610\n540 IF B=14 THEN 630\n550 PRINT B\n560 GOTO 650\n570 PRINT\"JACK\"\n580 GOTO 650\n590 PRINT\"QUEEN\"\n600 GOTO 650\n610 PRINT\"KING\"\n620 GOTO 650\n630 PRINT\"ACE\"\n640 PRINT\n650 PRINT\n660 INPUT\"WHAT IS YOUR BET\";M\n670 IF M<>0 THEN 680\n675 PRINT\"CHICKEN!!\"\n676 PRINT\n677 GOTO 260\n680 IF M<=Q THEN 730\n690 PRINT\"SORRY, MY FRIEND, BUT YOU BET TOO MUCH.\"\n700 PRINT\"YOU HAVE ONLY \";Q;\" DOLLARS TO BET.\"\n710 GOTO 650\n730 C=INT(14*RND(1))+2\n740 IF C<2 THEN 730\n750 IF C>14 THEN 730\n760 IF C<11 THEN 810\n770 IF C=11 THEN 830\n780 IF C=12 THEN 850\n790 IF C=13 THEN 870\n800 IF C=14 THEN 890\n810 PRINT C\n820 GOTO 910\n830 PRINT\"JACK\"\n840 GOTO 910\n850 PRINT\"QUEEN\"\n860 GOTO 910\n870 PRINT\"KING\"\n880 GOTO 910\n890 PRINT \"ACE\"\n900 PRINT\n910 IF C>A THEN 930\n920 GOTO 970\n930 IF C>=B THEN 970\n950 PRINT\"YOU WIN!!!\"\n960 GOTO 210\n970 PRINT\"SORRY, YOU LOSE\"\n980 IF M<Q THEN 240\n990 PRINT\n1000 PRINT\n1010 PRINT\"SORRY, FRIEND, BUT YOU BLEW YOUR WAD.\"\n1015 PRINT:PRINT\n1020 INPUT\"TRY AGAIN (YES OR NO)\";A$\n1025 PRINT:PRINT\n1030 IF A$=\"YES\" THEN 110\n1040 PRINT\"O.K., HOPE YOU HAD FUN!\"\n1050 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion

        #region mathdice
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 PRINT TAB(31);\"MATH DICE\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT:PRINT:PRINT\n40 PRINT \"THIS PROGRAM GENERATES SUCCESIVE PICTURES OF TWO DICE.\"\n50 PRINT \"WHEN TWO DICE AND AN EQUAL SIGN FOLLOWED BY A QUESTION\"\n60 PRINT \"MARK HAVE BEEN PRINTED, TYPE YOUR ANSWER AND THE RETURN KEY.\"\n70 PRINT \"TO CONCLUDE THE LESSON, TYPE CONTROL-C AS YOUR ANSWER.\"\n80 PRINT\n90 PRINT\n100 N=N+1\n110 D=INT(6*RND(1)+1)\n120 PRINT\" ----- \"\n130 IF D=1 THEN 200\n140 IF D=2 THEN 180\n150 IF D=3 THEN 180\n160 PRINT \"I * * I\"\n170 GOTO 210\n180 PRINT \"I *   I\"\n190 GOTO 210\n200 PRINT \"I     I\"\n210 IF D=2 THEN 260\n220 IF D=4 THEN 260\n230 IF D=6 THEN 270\n240 PRINT \"I  *  I\"\n250 GOTO 280\n260 PRINT \"I     I\"\n265 GOTO 280\n270 PRINT \"I * * I\"\n280 IF D=1 THEN 350\n290 IF D=2 THEN 330\n300 IF D=3 THEN 330\n310 PRINT \"I * * I\"\n320 GOTO 360\n330 PRINT \"I   * I\"\n340 GOTO 360\n350 PRINT \"I     I\"\n360 PRINT \" ----- \"\n370 PRINT\n375 IF N=2 THEN 500\n380 PRINT \"   +\"\n381 PRINT\n400 A=D\n410 GOTO 100\n500 T=D+A\n510 PRINT \"      =\";\n520 INPUT T1\n530 IF T1=T THEN 590\n540 PRINT \"NO, COUNT THE SPOTS AND GIVE ANOTHER ANSWER.\"\n541 PRINT \"      =\";\n550 INPUT T2\n560 IF T2=T THEN 590\n570 PRINT \"NO, THE ANSWER IS\";T\n580 GOTO 600\n590 PRINT \"RIGHT!\"\n600 PRINT\n601 PRINT \"THE DICE ROLL AGAIN...\"\n610 PRINT\n615 N=0\n620 GOTO 100\n999 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.BackgroundImage = Properties.Resources.tile_frame;
        }

        #endregion mathdice

        #region Queen
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "1 PRINT TAB(33);\"QUEEN\"\n2 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n3 PRINT:PRINT:PRINT\n10 DIM S(64)\n11 FOR I=1 TO 64\n12 READ S(I)\n13 NEXT I\n14 DATA  81,  71,  61,  51,  41,  31,  21,  11\n15 DATA  92,  82,  72,  62,  52,  42,  32,  22\n16 DATA 103,  93,  83,  73,  63,  53,  43,  33\n17 DATA 114, 104,  94,  84,  74,  64,  54,  44\n18 DATA 125, 115, 105,  95,  85,  75,  65,  55\n19 DATA 136, 126, 116, 106,  96,  86,  76,  66\n20 DATA 147, 137, 127, 117, 107,  97,  87,  77\n21 DATA 158, 148, 138, 128, 118, 108,  98,  88\n22 INPUT \"DO YOU WANT INSTRUCTIONS\";W$\n23 IF W$=\"NO\" THEN 30\n24 IF W$=\"YES\" THEN 28\n25 PRINT \"PLEASE ANSWER 'YES' OR 'NO'.\"\n26 GOTO 22\n28 GOSUB 5000\n29 GOTO 100\n30 GOSUB 5160\n90 REM     ERROR CHECKS\n100 PRINT \"WHERE WOULD YOU LIKE TO START\";\n110 INPUT M1\n115 IF M1=0 THEN 232\n120 T1=INT(M1/10)\n130 U1=M1-10*T1\n140 IF U1=1 THEN 200\n150 IF U1=T1 THEN 200\n160 PRINT \"PLEASE READ THE DIRECTIONS AGAIN.\"\n170 PRINT \"YOU HAVE BEGUN ILLEGALLY.\"\n175 PRINT\n180 GOTO 100\n200 GOSUB 2000\n210 PRINT \"COMPUTER MOVES TO SQUARE\";M\n215 IF M=158 THEN 3400\n220 PRINT \"WHAT IS YOUR MOVE\";\n230 INPUT M1\n231 IF M1<>0 THEN 239\n232 PRINT\n233 PRINT \"IT LOOKS LIKE I HAVE WON BY FORFEIT.\"\n234 PRINT\n235 GOTO 4000\n239 IF M1<=M THEN 3200\n240 T1=INT(M1/10)\n250 U1=M1-10*T1\n260 P=U1-U\n270 IF P<>0 THEN 300\n280 L=T1-T\n290 IF L<=0 THEN 3200\n295 GOTO 200\n300 IF T1-T <>P THEN 320\n310 GOTO 200\n320 IF T1-T <>2*P THEN 3200\n330 GOTO 200\n1990 REM     LOCATE MOVE FOR COMPUTER\n2000 IF M1=41 THEN 2180\n2010 IF M1=44 THEN 2180\n2020 IF M1=73 THEN 2180\n2030 IF M1=75 THEN 2180\n2040 IF M1=126 THEN 2180\n2050 IF M1=127 THEN 2180\n2060 IF M1=158 THEN 3300\n2065 C=0\n2070 FOR K=7 TO 1 STEP -1\n2080 U=U1\n2090 T=T1+K\n2100 GOSUB 3500\n2105 IF C=1 THEN 2160\n2110 U=U+K\n2120 GOSUB 3500\n2125 IF C=1 THEN 2160\n2130 T=T+K\n2140 GOSUB 3500\n2145 IF C=1 THEN 2160\n2150 NEXT K\n2155 GOTO 2180\n2160 C=0\n2170 RETURN\n2180 GOSUB 3000\n2190 RETURN\n2990 REM     RANDOM MOVE\n3000 Z=RND(1)\n3010 IF Z>.6 THEN 3110\n3020 IF Z>.3 THEN 3070\n3030 U=U1\n3040 T=T1+1\n3050 M=10*T+U\n3060 RETURN\n3070 U=U1+1\n3080 T=T1+2\n3090 M=10*T+U\n3100 RETURN\n3110 U=U1+1\n3120 T=T1+1\n3130 M=10*T+U\n3140 RETURN\n3190 REM     ILLEGAL MOVE MESSAGE\n3200 PRINT\n3210 PRINT \"Y O U   C H E A T . . .  TRY AGAIN\";\n3220 GOTO 230\n3290 REM     PLAYER WINS\n3300 PRINT\n3310 PRINT \"C O N G R A T U L A T I O N S . . .\"\n3320 PRINT \n3330 PRINT \"YOU HAVE WON--VERY WELL PLAYED.\"\n3340 PRINT \"IT LOOKS LIKE I HAVE MET MY MATCH.\"\n3350 PRINT \"THANKS FOR PLAYING---I CAN'T WIN ALL THE TIME.\"\n3360 PRINT\n3370 GOTO 4000\n3390 REM     COMPUTER WINS\n3400 PRINT\n3410 PRINT \"NICE TRY, BUT IT LOOKS LIKE I HAVE WON.\"\n3420 PRINT \"THANKS FOR PLAYING.\"\n3430 PRINT\n3440 GOTO 4000\n3490 REM     TEST FOR COMPUTER MOVE\n3500 M=10*T+U\n3510 IF M=158 THEN 3570\n3520 IF M=127 THEN 3570\n3530 IF M=126 THEN 3570\n3540 IF M=75 THEN 3570\n3550 IF M=73 THEN 3570\n3560 RETURN\n3570 C=1\n3580 GOTO 3560\n3990 REM     ANOTHER GAME???\n4000 PRINT \"ANYONE ELSE CARE TO TRY\";\n4010 INPUT Q$\n4020 PRINT\n4030 IF Q$=\"YES\" THEN 30 \n4040 IF Q$=\"NO\" THEN 4050\n4042 PRINT \"PLEASE ANSWER 'YES' OR 'NO'.\"\n4045 GOTO 4000\n4050 PRINT:PRINT \"OK --- THANKS AGAIN.\"\n4060 STOP\n4990 REM     DIRECTIONS\n5000 PRINT \"WE ARE GOING TO PLAY A GAME BASED ON ONE OF THE CHESS\"\n5010 PRINT \"MOVES.  OUR QUEEN WILL BE ABLE TO MOVE ONLY TO THE LEFT,\"\n5020 PRINT \"DOWN, OR DIAGONALLY DOWN AND TO THE LEFT.\"\n5030 PRINT\n5040 PRINT \"THE OBJECT OF THE GAME IS TO PLACE THE QUEEN IN THE LOWER\"\n5050 PRINT \"LEFT HAND SQUARE BY ALTERNATING MOVES BETWEEN YOU AND THE\"\n5060 PRINT \"COMPUTER.  THE FIRST ONE TO PLACE THE QUEEN THERE WINS.\"\n5070 PRINT\n5080 PRINT \"YOU GO FIRST AND PLACE THE QUEEN IN ANY ONE OF THE SQUARES\"\n5090 PRINT \"ON THE TOP ROW OR RIGHT HAND COLUMN.\"\n5100 PRINT \"THAT WILL BE YOUR FIRST MOVE.\"\n5110 PRINT \"WE ALTERNATE MOVES.\"\n5120 PRINT \"YOU MAY FORFEIT BY TYPING '0' AS YOUR MOVE.\"\n5130 PRINT \"BE SURE TO PRESS THE RETURN KEY AFTER EACH RESPONSE.\"\n5140 PRINT\n5150 PRINT\n5160 PRINT\n5170 FOR A=0 TO 7\n5180 FOR B=1 TO 8\n5185 I=8*A+B\n5190 PRINT S(I);\n5200 NEXT B\n5210 PRINT\n5220 PRINT\n5230 PRINT\n5240 NEXT A\n5250 PRINT\n5260 RETURN\n9999 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.tile_frame;
        }

        #endregion Queen

        #region tic tac
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "2 PRINT TAB(30);\"TIC-TAC-TOE\"\n4 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n6 PRINT:PRINT:PRINT\n8 PRINT \"THE BOARD IS NUMBERED:\"\n10 PRINT \" 1  2  3\"\n12 PRINT \" 4  5  6\"\n14 PRINT \" 7  8  9\"\n16 PRINT:PRINT:PRINT\n20 DIM S(9)\n50 INPUT\"DO YOU WANT 'X' OR 'O'\";C$\n55 IF C$=\"X\"THEN 475\n60 P$=\"O\":Q$=\"X\"\n100 G=-1:H=1:IF S(5)<>0 THEN 103\n102 S(5)=-1:GOTO 195\n103 IF S(5)<>1 THEN 106\n104 IF S(1)<>0 THEN 110\n105 S(1)=-1:GOTO 195\n106 IF S(2)=1 AND S(1)=0 THEN 181\n107 IF S(4)=1 AND S(1)=0 THEN 181\n108 IF S(6)=1 AND S(9)=0 THEN 189\n109 IF S(8)=1 AND S(9)=0 THEN 189\n110 IF G=1 THEN 112\n111 GOTO 118\n112 J=3*INT((M-1)/3)+1\n113 IF 3*INT((M-1)/3)+1=M THEN K=1\n114 IF 3*INT((M-1)/3)+2=M THEN K=2\n115 IF 3*INT((M-1)/3)+3=M THEN K=3\n116 GOTO 120\n118 FOR J=1 TO 7 STEP 3:FOR K=1 TO 3\n120 IF S(J)<>G THEN 130\n122 IF S(J+2)<>G THEN 135\n126 IF S(J+1)<>0 THEN 150\n128 S(J+1)=-1:GOTO 195\n130 IF S(J)=H THEN 150\n131 IF S(J+2)<>G THEN 150\n132 IF S(J+1)<>G THEN 150\n133 S(J)=-1:GOTO 195\n135 IF S(J+2)<>0 THEN 150\n136 IF S(J+1)<>G THEN 150\n138 S(J+2)=-1:GOTO 195\n150 IF S(K)<>G THEN 160\n152 IF S(K+6)<>G THEN 165\n156 IF S(K+3)<>0 THEN 170\n158 S(K+3)=-1:GOTO 195\n160 IF S(K)=H THEN 170\n161 IF S(K+6)<>G THEN 170\n162 IF S(K+3)<>G THEN 170\n163 S(K)=-1:GOTO 195\n165 IF S(K+6)<>0 THEN 170\n166 IF S(K+3)<>G THEN 170\n168 S(K+6)=-1:GOTO 195\n170 GOTO 450\n171 IF S(3)=G AND S(7)=0 THEN 187\n172 IF S(9)=G AND S(1)=0 THEN 181\n173 IF S(7)=G AND S(3)=0 THEN 183\n174 IF S(9)=0 AND S(1)=G THEN 189\n175 IF G=-1 THEN G=1:H=-1:GOTO 110\n176 IF S(9)=1 AND S(3)=0 THEN 182\n177 FOR I=2 TO 9:IF S(I)<>0 THEN 179\n178 S(I)=-1:GOTO 195\n179 NEXT I\n181 S(1)=-1:GOTO 195\n182 IF S(1)=1 THEN 177\n183 S(3)=-1:GOTO 195\n187 S(7)=-1:GOTO 195\n189 S(9)=-1\n195 PRINT:PRINT\"THE COMPUTER MOVES TO...\"\n202 GOSUB 1000\n205 GOTO 500\n450 IF G=1 THEN 465\n455 IF J=7 AND K=3 THEN 465\n460 NEXT K,J\n465 IF S(5)=G THEN 171\n467 GOTO 175\n475 P$=\"X\":Q$=\"O\"\n500 PRINT:INPUT\"WHERE DO YOU MOVE\";M\n502 IF M=0 THEN PRINT\"THANKS FOR THE GAME.\":GOTO 2000\n503 IF M>9 THEN 506\n505 IF S(M)=0 THEN 510\n506 PRINT\"THAT SQUARE IS OCCUPIED.\":PRINT:PRINT:GOTO 500\n510 G=1:S(M)=1\n520 GOSUB 1000\n530 GOTO 100\n1000 PRINT:FOR I=1 TO 9:PRINT\" \";:IF S(I)<>-1 THEN 1014\n1012 PRINT Q$\" \";:GOTO 1020\n1014 IF S(I)<>0 THEN 1018\n1016 PRINT\"  \";:GOTO 1020\n1018 PRINT P$\" \";\n1020 IF I<>3 AND I<>6 THEN 1050\n1030 PRINT:PRINT\"---+---+---\"\n1040 GOTO 1080\n1050 IF I=9 THEN 1080\n1060 PRINT\"!\";\n1080 NEXT I:PRINT:PRINT:PRINT\n1095 FOR I=1 TO 7 STEP 3\n1100 IF S(I)<>S(I+1)THEN 1115\n1105 IF S(I)<>S(I+2)THEN 1115\n1110 IF S(I)=-1 THEN 1350\n1112 IF S(I)=1 THEN 1200\n1115 NEXT I:FOR I=1 TO 3:IF S(I)<>S(I+3)THEN 1150\n1130 IF S(I)<>S(I+6)THEN 1150\n1135 IF S(I)=-1 THEN 1350\n1137 IF S(I)=1 THEN 1200\n1150 NEXT I:FOR I=1 TO 9:IF S(I)=0 THEN 1155\n1152 NEXT I:GOTO 1400\n1155 IF S(5)<>G THEN 1170\n1160 IF S(1)=G AND S(9)=G THEN 1180\n1165 IF S(3)=G AND S(7)=G THEN 1180\n1170 RETURN\n1180 IF G=-1 THEN 1350\n1200 PRINT\"YOU BEAT ME!! GOOD GAME.\":GOTO 2000\n1350 PRINT\"I WIN, TURKEY!!!\":GOTO 2000\n1400 PRINT\"IT'S A DRAW. THANK YOU.\"\n2000 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "2 PRINT TAB(30);\"TIC-TAC-TOE\"\n4 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n6 PRINT:PRINT:PRINT\n8 PRINT \"THE BOARD IS NUMBERED:\"\n10 PRINT \" 1  2  3\"\n12 PRINT \" 4  5  6\"\n14 PRINT \" 7  8  9\"\n16 PRINT:PRINT:PRINT\n20 DIM S(9)\n50 INPUT\"DO YOU WANT 'X' OR 'O'\";C$\n55 IF C$=\"X\"THEN 475\n60 P$=\"O\":Q$=\"X\"\n100 G=-1:H=1:IF S(5)<>0 THEN 103\n102 S(5)=-1:GOTO 195\n103 IF S(5)<>1 THEN 106\n104 IF S(1)<>0 THEN 110\n105 S(1)=-1:GOTO 195\n106 IF S(2)=1 AND S(1)=0 THEN 181\n107 IF S(4)=1 AND S(1)=0 THEN 181\n108 IF S(6)=1 AND S(9)=0 THEN 189\n109 IF S(8)=1 AND S(9)=0 THEN 189\n110 IF G=1 THEN 112\n111 GOTO 118\n112 J=3*INT((M-1)/3)+1\n113 IF 3*INT((M-1)/3)+1=M THEN K=1\n114 IF 3*INT((M-1)/3)+2=M THEN K=2\n115 IF 3*INT((M-1)/3)+3=M THEN K=3\n116 GOTO 120\n118 FOR J=1 TO 7 STEP 3:FOR K=1 TO 3\n120 IF S(J)<>G THEN 130\n122 IF S(J+2)<>G THEN 135\n126 IF S(J+1)<>0 THEN 150\n128 S(J+1)=-1:GOTO 195\n130 IF S(J)=H THEN 150\n131 IF S(J+2)<>G THEN 150\n132 IF S(J+1)<>G THEN 150\n133 S(J)=-1:GOTO 195\n135 IF S(J+2)<>0 THEN 150\n136 IF S(J+1)<>G THEN 150\n138 S(J+2)=-1:GOTO 195\n150 IF S(K)<>G THEN 160\n152 IF S(K+6)<>G THEN 165\n156 IF S(K+3)<>0 THEN 170\n158 S(K+3)=-1:GOTO 195\n160 IF S(K)=H THEN 170\n161 IF S(K+6)<>G THEN 170\n162 IF S(K+3)<>G THEN 170\n163 S(K)=-1:GOTO 195\n165 IF S(K+6)<>0 THEN 170\n166 IF S(K+3)<>G THEN 170\n168 S(K+6)=-1:GOTO 195\n170 GOTO 450\n171 IF S(3)=G AND S(7)=0 THEN 187\n172 IF S(9)=G AND S(1)=0 THEN 181\n173 IF S(7)=G AND S(3)=0 THEN 183\n174 IF S(9)=0 AND S(1)=G THEN 189\n175 IF G=-1 THEN G=1:H=-1:GOTO 110\n176 IF S(9)=1 AND S(3)=0 THEN 182\n177 FOR I=2 TO 9:IF S(I)<>0 THEN 179\n178 S(I)=-1:GOTO 195\n179 NEXT I\n181 S(1)=-1:GOTO 195\n182 IF S(1)=1 THEN 177\n183 S(3)=-1:GOTO 195\n187 S(7)=-1:GOTO 195\n189 S(9)=-1\n195 PRINT:PRINT\"THE COMPUTER MOVES TO...\"\n202 GOSUB 1000\n205 GOTO 500\n450 IF G=1 THEN 465\n455 IF J=7 AND K=3 THEN 465\n460 NEXT K,J\n465 IF S(5)=G THEN 171\n467 GOTO 175\n475 P$=\"X\":Q$=\"O\"\n500 PRINT:INPUT\"WHERE DO YOU MOVE\";M\n502 IF M=0 THEN PRINT\"THANKS FOR THE GAME.\":GOTO 2000\n503 IF M>9 THEN 506\n505 IF S(M)=0 THEN 510\n506 PRINT\"THAT SQUARE IS OCCUPIED.\":PRINT:PRINT:GOTO 500\n510 G=1:S(M)=1\n520 GOSUB 1000\n530 GOTO 100\n1000 PRINT:FOR I=1 TO 9:PRINT\" \";:IF S(I)<>-1 THEN 1014\n1012 PRINT Q$\" \";:GOTO 1020\n1014 IF S(I)<>0 THEN 1018\n1016 PRINT\"  \";:GOTO 1020\n1018 PRINT P$\" \";\n1020 IF I<>3 AND I<>6 THEN 1050\n1030 PRINT:PRINT\"---+---+---\"\n1040 GOTO 1080\n1050 IF I=9 THEN 1080\n1060 PRINT\"!\";\n1080 NEXT I:PRINT:PRINT:PRINT\n1095 FOR I=1 TO 7 STEP 3\n1100 IF S(I)<>S(I+1)THEN 1115\n1105 IF S(I)<>S(I+2)THEN 1115\n1110 IF S(I)=-1 THEN 1350\n1112 IF S(I)=1 THEN 1200\n1115 NEXT I:FOR I=1 TO 3:IF S(I)<>S(I+3)THEN 1150\n1130 IF S(I)<>S(I+6)THEN 1150\n1135 IF S(I)=-1 THEN 1350\n1137 IF S(I)=1 THEN 1200\n1150 NEXT I:FOR I=1 TO 9:IF S(I)=0 THEN 1155\n1152 NEXT I:GOTO 1400\n1155 IF S(5)<>G THEN 1170\n1160 IF S(1)=G AND S(9)=G THEN 1180\n1165 IF S(3)=G AND S(7)=G THEN 1180\n1170 RETURN\n1180 IF G=-1 THEN 1350\n1200 PRINT\"YOU BEAT ME!! GOOD GAME.\":GOTO 2000\n1350 PRINT\"I WIN, TURKEY!!!\":GOTO 2000\n1400 PRINT\"IT'S A DRAW. THANK YOU.\"\n2000 END";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion tic tac

        #region high iq
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "1 PRINT TAB(33);\"H-I-Q\"\n2 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n3 PRINT:PRINT:PRINT\n4 DIM B(70),T(9,9)\n5 PRINT \"HERE IS THE BOARD:\": PRINT\n6 PRINT \"          !    !    !\"\n7 PRINT \"         13   14   15\": PRINT\n8 PRINT \"          !    !    !\"\n9 PRINT \"         22   23   24\": PRINT\n10 PRINT \"!    !    !    !    !    !    !\"\n11 PRINT \"29   30   31   32   33   34   35\": PRINT\n12 PRINT \"!    !    !    !    !    !    !\"\n13 PRINT \"38   39   40   41   42   43   44\": PRINT\n14 PRINT \"!    !    !    !    !    !    !\"\n15 PRINT \"47   48   49   50   51   52   53\": PRINT\n16 PRINT \"          !    !    !\"\n17 PRINT \"         58   59   60\": PRINT\n18 PRINT \"          !    !    !\"\n19 PRINT \"         67   68   69\": PRINT\n20 PRINT \"TO SAVE TYPING TIME, A COMPRESSED VERSION OF THE GAME BOARD\"\n22 PRINT \"WILL BE USED DURING PLAY.  REFER TO THE ABOVE ONE FOR PEG\"\n24 PRINT \"NUMBERS.  OK, LET'S BEGIN.\"\n28 REM *** SET UP BOARD\n29 FOR R=1 TO 9\n30 FOR C=1 TO 9\n31 IF (R-4)*(R-5)*(R-6)=0 THEN 40\n32 IF (C-4)*(C-5)*(C-6)=0 THEN 40\n35 T(R,C)=-5\n36 GOTO 50\n40 IF (R-1)*(C-1)*(R-9)*(C-9)=0 THEN 35\n42 T(R,C)=5\n50 NEXT C\n60 NEXT R\n65 T(5,5)=0: GOSUB 500\n70 REM *** INPUT MOVE AND CHECK ON LEGALITY\n75 FOR W=1 TO 33\n77 READ M\n79 DATA 13,14,15,22,23,24,29,30,31,32,33,34,35,38,39,40,41\n81 DATA 42,43,44,47,48,49,50,51,52,53,58,59,60,67,68,69\n83 B(M)=-7: NEXT W\n86 B(41)=-3\n100 INPUT \"MOVE WHICH PIECE\";Z\n110 IF B(Z)=-7 THEN 140\n120 PRINT \"ILLEGAL MOVE, TRY AGAIN...\": GOTO 100\n140 INPUT \"TO WHERE\";P\n150 IF B(P)=0 THEN 120\n153 IF B(P)=-7 THEN 120\n156 IF Z=P THEN 100\n160 IF ((Z+P)/2)=INT((Z+P)/2) THEN 180\n170 GOTO 120\n180 IF (ABS(Z-P)-2)*(ABS(Z-P)-18)<>0 THEN 120\n190 GOSUB 1000\n200 GOSUB 500\n210 GOSUB 1500\n220 GOTO 100\n500 REM *** PRINT BOARD\n510 FOR X=1 TO 9\n520 FOR Y=1 TO 9\n525 IF (X-1)*(X-9)*(Y-1)*(Y-9)=0 THEN 550\n530 IF (X-4)*(X-5)*(X-6)=0 THEN 570\n540 IF (Y-4)*(Y-5)*(Y-6)=0 THEN 570\n550 REM\n560 GOTO 610\n570 IF T(X,Y)<>5 THEN 600\n580 PRINT TAB(Y*2);\"!\";\n590 GOTO 610\n600 PRINT TAB(Y*2);\"O\";\n610 REM\n615 NEXT Y\n620 PRINT\n630 NEXT X\n640 RETURN\n1000 REM *** UPDATE BOARD\n1005 C=1: FOR X=1 TO 9\n1020 FOR Y=1 TO 9\n1030 IF C<>Z THEN 1220\n1040 IF C+2<>P THEN 1080\n1045 IF T(X,Y+1)=0 THEN 120\n1050 T(X,Y+2)=5\n1060 T(X,Y+1)=0: B(C+1)=-3\n1070 GOTO 1200\n1080 IF C+18<>P THEN 1130\n1085 IF T(X+1,Y)=0 THEN 120\n1090 T(X+2,Y)=5: T(X+1,Y)=0: B(C+9)=-3\n1120 GOTO 1200\n1130 IF C-2<>P THEN 1170\n1135 IF T(X,Y-1)=0 THEN 120\n1140 T(X,Y-2)=5: T(X,Y-1)=0: B(C-1)=-3\n1160 GOTO 1200\n1170 IF C-18<>P THEN 1220\n1175 IF T(X-1,Y)=0 THEN 120\n1180 T(X-2,Y)=5: T(X-1,Y)=0: B(C-9)=-3\n1200 B(Z)=-3: B(P)=-7\n1210 T(X,Y)=0: GOTO 1240\n1220 C=C+1\n1225 NEXT Y\n1230 NEXT X\n1240 RETURN\n1500 REM*** CHECK IF GAME IS OVER\n1505 F=0\n1510 FOR R=2 TO 8\n1520 FOR C=2 TO 8\n1530 IF T(R,C)<>5 THEN 1580\n1535 F=F+1\n1540 FOR A=R-1 TO R+1\n1545 T=0\n1550 FOR B=C-1 TO C+1\n1560 T=T+T(A,B)\n1561 NEXT B\n1564 IF T<>10 THEN 1567\n1565 IF T(A,C)<>0 THEN 1630\n1567 NEXT A\n1568 FOR X=C-1 TO C+1\n1569 T=0\n1570 FOR Y=R-1 TO R+1\n1571 T=T+T(Y,X)\n1572 NEXT Y\n1573 IF T<>10 THEN 1575\n1574 IF T(R,X)<>0 THEN 1630\n1575 NEXT X\n1580 NEXT C\n1590 NEXT R\n1600 REM *** GAME IS OVER\n1605 PRINT \"THE GAME IS OVER.\"\n1610 PRINT \"YOU HAD\";F;\"PIECES REMAINING.\"\n1611 IF F<>1 THEN 1615\n1612 PRINT \"BRAVO!  YOU MADE A PERFECT SCORE!\"\n1613 PRINT \"SAVE THIS PAPER AS A RECORD OF YOUR ACCOMPLISHMENT!\"\n1615 PRINT: INPUT \"PLAY AGAIN (YES OR NO)\";A$\n1617 IF A$=\"NO\" THEN 2000\n1618 RESTORE: GOTO 28\n1620 STOP\n1630 RETURN\n2000 PRINT: PRINT \"SO LONG FOR NOW.\": PRINT\n2010 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "1 PRINT TAB(33);\"H-I-Q\"\n2 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n3 PRINT:PRINT:PRINT\n4 DIM B(70),T(9,9)\n5 PRINT \"HERE IS THE BOARD:\": PRINT\n6 PRINT \"          !    !    !\"\n7 PRINT \"         13   14   15\": PRINT\n8 PRINT \"          !    !    !\"\n9 PRINT \"         22   23   24\": PRINT\n10 PRINT \"!    !    !    !    !    !    !\"\n11 PRINT \"29   30   31   32   33   34   35\": PRINT\n12 PRINT \"!    !    !    !    !    !    !\"\n13 PRINT \"38   39   40   41   42   43   44\": PRINT\n14 PRINT \"!    !    !    !    !    !    !\"\n15 PRINT \"47   48   49   50   51   52   53\": PRINT\n16 PRINT \"          !    !    !\"\n17 PRINT \"         58   59   60\": PRINT\n18 PRINT \"          !    !    !\"\n19 PRINT \"         67   68   69\": PRINT\n20 PRINT \"TO SAVE TYPING TIME, A COMPRESSED VERSION OF THE GAME BOARD\"\n22 PRINT \"WILL BE USED DURING PLAY.  REFER TO THE ABOVE ONE FOR PEG\"\n24 PRINT \"NUMBERS.  OK, LET'S BEGIN.\"\n28 REM *** SET UP BOARD\n29 FOR R=1 TO 9\n30 FOR C=1 TO 9\n31 IF (R-4)*(R-5)*(R-6)=0 THEN 40\n32 IF (C-4)*(C-5)*(C-6)=0 THEN 40\n35 T(R,C)=-5\n36 GOTO 50\n40 IF (R-1)*(C-1)*(R-9)*(C-9)=0 THEN 35\n42 T(R,C)=5\n50 NEXT C\n60 NEXT R\n65 T(5,5)=0: GOSUB 500\n70 REM *** INPUT MOVE AND CHECK ON LEGALITY\n75 FOR W=1 TO 33\n77 READ M\n79 DATA 13,14,15,22,23,24,29,30,31,32,33,34,35,38,39,40,41\n81 DATA 42,43,44,47,48,49,50,51,52,53,58,59,60,67,68,69\n83 B(M)=-7: NEXT W\n86 B(41)=-3\n100 INPUT \"MOVE WHICH PIECE\";Z\n110 IF B(Z)=-7 THEN 140\n120 PRINT \"ILLEGAL MOVE, TRY AGAIN...\": GOTO 100\n140 INPUT \"TO WHERE\";P\n150 IF B(P)=0 THEN 120\n153 IF B(P)=-7 THEN 120\n156 IF Z=P THEN 100\n160 IF ((Z+P)/2)=INT((Z+P)/2) THEN 180\n170 GOTO 120\n180 IF (ABS(Z-P)-2)*(ABS(Z-P)-18)<>0 THEN 120\n190 GOSUB 1000\n200 GOSUB 500\n210 GOSUB 1500\n220 GOTO 100\n500 REM *** PRINT BOARD\n510 FOR X=1 TO 9\n520 FOR Y=1 TO 9\n525 IF (X-1)*(X-9)*(Y-1)*(Y-9)=0 THEN 550\n530 IF (X-4)*(X-5)*(X-6)=0 THEN 570\n540 IF (Y-4)*(Y-5)*(Y-6)=0 THEN 570\n550 REM\n560 GOTO 610\n570 IF T(X,Y)<>5 THEN 600\n580 PRINT TAB(Y*2);\"!\";\n590 GOTO 610\n600 PRINT TAB(Y*2);\"O\";\n610 REM\n615 NEXT Y\n620 PRINT\n630 NEXT X\n640 RETURN\n1000 REM *** UPDATE BOARD\n1005 C=1: FOR X=1 TO 9\n1020 FOR Y=1 TO 9\n1030 IF C<>Z THEN 1220\n1040 IF C+2<>P THEN 1080\n1045 IF T(X,Y+1)=0 THEN 120\n1050 T(X,Y+2)=5\n1060 T(X,Y+1)=0: B(C+1)=-3\n1070 GOTO 1200\n1080 IF C+18<>P THEN 1130\n1085 IF T(X+1,Y)=0 THEN 120\n1090 T(X+2,Y)=5: T(X+1,Y)=0: B(C+9)=-3\n1120 GOTO 1200\n1130 IF C-2<>P THEN 1170\n1135 IF T(X,Y-1)=0 THEN 120\n1140 T(X,Y-2)=5: T(X,Y-1)=0: B(C-1)=-3\n1160 GOTO 1200\n1170 IF C-18<>P THEN 1220\n1175 IF T(X-1,Y)=0 THEN 120\n1180 T(X-2,Y)=5: T(X-1,Y)=0: B(C-9)=-3\n1200 B(Z)=-3: B(P)=-7\n1210 T(X,Y)=0: GOTO 1240\n1220 C=C+1\n1225 NEXT Y\n1230 NEXT X\n1240 RETURN\n1500 REM*** CHECK IF GAME IS OVER\n1505 F=0\n1510 FOR R=2 TO 8\n1520 FOR C=2 TO 8\n1530 IF T(R,C)<>5 THEN 1580\n1535 F=F+1\n1540 FOR A=R-1 TO R+1\n1545 T=0\n1550 FOR B=C-1 TO C+1\n1560 T=T+T(A,B)\n1561 NEXT B\n1564 IF T<>10 THEN 1567\n1565 IF T(A,C)<>0 THEN 1630\n1567 NEXT A\n1568 FOR X=C-1 TO C+1\n1569 T=0\n1570 FOR Y=R-1 TO R+1\n1571 T=T+T(Y,X)\n1572 NEXT Y\n1573 IF T<>10 THEN 1575\n1574 IF T(R,X)<>0 THEN 1630\n1575 NEXT X\n1580 NEXT C\n1590 NEXT R\n1600 REM *** GAME IS OVER\n1605 PRINT \"THE GAME IS OVER.\"\n1610 PRINT \"YOU HAD\";F;\"PIECES REMAINING.\"\n1611 IF F<>1 THEN 1615\n1612 PRINT \"BRAVO!  YOU MADE A PERFECT SCORE!\"\n1613 PRINT \"SAVE THIS PAPER AS A RECORD OF YOUR ACCOMPLISHMENT!\"\n1615 PRINT: INPUT \"PLAY AGAIN (YES OR NO)\";A$\n1617 IF A$=\"NO\" THEN 2000\n1618 RESTORE: GOTO 28\n1620 STOP\n1630 RETURN\n2000 PRINT: PRINT \"SO LONG FOR NOW.\": PRINT\n2010 END";
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion high iq

        #region digits
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 PRINT TAB(33);\"DIGITS\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT:PRINT:PRINT\n210 PRINT \"THIS IS A GAME OF GUESSING.\"\n220 PRINT \"FOR INSTRUCTIONS, TYPE '1', ELSE TYPE '0'\";\n230 INPUT E\n240 IF E=0 THEN 360\n250 PRINT\n260 PRINT \"PLEASE TAKE A PIECE OF PAPER AND WRITE DOWN\"\n270 PRINT \"THE DIGITS '0', '1', OR '2' THIRTY TIMES AT RANDOM.\"\n280 PRINT \"ARRANGE THEM IN THREE LINES OF TEN DIGITS EACH.\"\n290 PRINT \"I WILL ASK FOR THEN TEN AT A TIME.\"\n300 PRINT \"I WILL ALWAYS GUESS THEM FIRST AND THEN LOOK AT YOUR\"\n310 PRINT \"NEXT NUMBER TO SEE IF I WAS RIGHT. BY PURE LUCK,\"\n320 PRINT \"I OUGHT TO BE RIGHT TEN TIMES. BUT I HOPE TO DO BETTER\"\n330 PRINT \"THAN THAT *****\"\n340 PRINT:PRINT\n360 READ A,B,C\n370 DATA 0,1,3\n380 DIM M(26,2),K(2,2),L(8,2)\n400 FOR I=0 TO 26: FOR J=0 TO 2: M(I,J)=1: NEXT J: NEXT I\n410 FOR I=0 TO 2: FOR J=0 TO 2: K(I,J)=9: NEXT J: NEXT I\n420 FOR I=0 TO 8: FOR J=0 TO 2: L(I,J)=3: NEXT J: NEXT I\n450 L(0,0)=2: L(4,1)=2: L(8,2)=2\n480 Z=26: Z1=8: Z2=2\n510 X=0\n520 FOR T=1 TO 3\n530 PRINT\n540 PRINT \"TEN NUMBERS, PLEASE\";\n550 INPUT N(1),N(2),N(3),N(4),N(5),N(6),N(7),N(8),N(9),N(10)\n560 FOR I=1 TO 10\n570 W=N(I)-1\n580 IF W=SGN(W) THEN 620\n590 PRINT \"ONLY USE THE DIGITS '0', '1', OR '2'.\"\n600 PRINT \"LET'S TRY AGAIN.\":GOTO 530\n620 NEXT I\n630 PRINT: PRINT \"MY GUESS\",\"YOUR NO.\",\"RESULT\",\"NO. RIGHT\":PRINT\n660 FOR U=1 TO 10\n670 N=N(U): S=0\n690 FOR J=0 TO 2\n700 S1=A*K(Z2,J)+B*L(Z1,J)+C*M(Z,J)\n710 IF S>S1 THEN 760\n720 IF S<S1 THEN 740\n730 IF RND(1)<.5 THEN 760\n740 S=S1: G=J\n760 NEXT J\n770 PRINT \"  \";G,\"   \";N(U),\n780 IF G=N(U) THEN 810\n790 PRINT \" WRONG\",X\n800 GOTO 880\n810 X=X+1\n820 PRINT \" RIGHT\",X\n830 M(Z,N)=M(Z,N)+1\n840 L(Z1,N)=L(Z1,N)+1\n850 K(Z2,N)=K(Z2,N)+1\n860 Z=Z-INT(Z/9)*9\n870 Z=3*Z+N(U)\n880 Z1=Z-INT(Z/9)*9\n890 Z2=N(U)\n900 NEXT U\n910 NEXT T\n920 PRINT\n930 IF X>10 THEN 980\n940 IF X<10 THEN 1010\n950 PRINT \"I GUESSED EXACTLY 1/3 OF YOUR NUMBERS.\"\n960 PRINT \"IT'S A TIE GAME.\"\n970 GOTO 1030\n980 PRINT \"I GUESSED MORE THAN 1/3 OF YOUR NUMBERS.\"\n990 PRINT \"I WIN.\": FOR Q=1 TO 10: PRINT CHR$(7);: NEXT Q\n1000 GOTO 1030\n1010 PRINT \"I GUESSED LESS THAN 1/3 OF YOUR NUMBERS.\"\n1020 PRINT \"YOU BEAT ME.  CONGRATULATIONS *****\"\n1030 PRINT\n1040 PRINT \"DO YOU WANT TO TRY AGAIN (1 FOR YES, 0 FOR NO)\";\n1060 INPUT X\n1070 IF X=1 THEN 400\n1080 PRINT:PRINT \"THANKS FOR THE GAME.\"\n1090 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "10 PRINT TAB(33);\"DIGITS\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT:PRINT:PRINT\n210 PRINT \"THIS IS A GAME OF GUESSING.\"\n220 PRINT \"FOR INSTRUCTIONS, TYPE '1', ELSE TYPE '0'\";\n230 INPUT E\n240 IF E=0 THEN 360\n250 PRINT\n260 PRINT \"PLEASE TAKE A PIECE OF PAPER AND WRITE DOWN\"\n270 PRINT \"THE DIGITS '0', '1', OR '2' THIRTY TIMES AT RANDOM.\"\n280 PRINT \"ARRANGE THEM IN THREE LINES OF TEN DIGITS EACH.\"\n290 PRINT \"I WILL ASK FOR THEN TEN AT A TIME.\"\n300 PRINT \"I WILL ALWAYS GUESS THEM FIRST AND THEN LOOK AT YOUR\"\n310 PRINT \"NEXT NUMBER TO SEE IF I WAS RIGHT. BY PURE LUCK,\"\n320 PRINT \"I OUGHT TO BE RIGHT TEN TIMES. BUT I HOPE TO DO BETTER\"\n330 PRINT \"THAN THAT *****\"\n340 PRINT:PRINT\n360 READ A,B,C\n370 DATA 0,1,3\n380 DIM M(26,2),K(2,2),L(8,2)\n400 FOR I=0 TO 26: FOR J=0 TO 2: M(I,J)=1: NEXT J: NEXT I\n410 FOR I=0 TO 2: FOR J=0 TO 2: K(I,J)=9: NEXT J: NEXT I\n420 FOR I=0 TO 8: FOR J=0 TO 2: L(I,J)=3: NEXT J: NEXT I\n450 L(0,0)=2: L(4,1)=2: L(8,2)=2\n480 Z=26: Z1=8: Z2=2\n510 X=0\n520 FOR T=1 TO 3\n530 PRINT\n540 PRINT \"TEN NUMBERS, PLEASE\";\n550 INPUT N(1),N(2),N(3),N(4),N(5),N(6),N(7),N(8),N(9),N(10)\n560 FOR I=1 TO 10\n570 W=N(I)-1\n580 IF W=SGN(W) THEN 620\n590 PRINT \"ONLY USE THE DIGITS '0', '1', OR '2'.\"\n600 PRINT \"LET'S TRY AGAIN.\":GOTO 530\n620 NEXT I\n630 PRINT: PRINT \"MY GUESS\",\"YOUR NO.\",\"RESULT\",\"NO. RIGHT\":PRINT\n660 FOR U=1 TO 10\n670 N=N(U): S=0\n690 FOR J=0 TO 2\n700 S1=A*K(Z2,J)+B*L(Z1,J)+C*M(Z,J)\n710 IF S>S1 THEN 760\n720 IF S<S1 THEN 740\n730 IF RND(1)<.5 THEN 760\n740 S=S1: G=J\n760 NEXT J\n770 PRINT \"  \";G,\"   \";N(U),\n780 IF G=N(U) THEN 810\n790 PRINT \" WRONG\",X\n800 GOTO 880\n810 X=X+1\n820 PRINT \" RIGHT\",X\n830 M(Z,N)=M(Z,N)+1\n840 L(Z1,N)=L(Z1,N)+1\n850 K(Z2,N)=K(Z2,N)+1\n860 Z=Z-INT(Z/9)*9\n870 Z=3*Z+N(U)\n880 Z1=Z-INT(Z/9)*9\n890 Z2=N(U)\n900 NEXT U\n910 NEXT T\n920 PRINT\n930 IF X>10 THEN 980\n940 IF X<10 THEN 1010\n950 PRINT \"I GUESSED EXACTLY 1/3 OF YOUR NUMBERS.\"\n960 PRINT \"IT'S A TIE GAME.\"\n970 GOTO 1030\n980 PRINT \"I GUESSED MORE THAN 1/3 OF YOUR NUMBERS.\"\n990 PRINT \"I WIN.\": FOR Q=1 TO 10: PRINT CHR$(7);: NEXT Q\n1000 GOTO 1030\n1010 PRINT \"I GUESSED LESS THAN 1/3 OF YOUR NUMBERS.\"\n1020 PRINT \"YOU BEAT ME.  CONGRATULATIONS *****\"\n1030 PRINT\n1040 PRINT \"DO YOU WANT TO TRY AGAIN (1 FOR YES, 0 FOR NO)\";\n1060 INPUT X\n1070 IF X=1 THEN 400\n1080 PRINT:PRINT \"THANKS FOR THE GAME.\"\n1090 END";
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion digits

        #region diamond
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "1 PRINT TAB(33);\"DIAMOND\"\n2 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n3 PRINT:PRINT:PRINT\n4 PRINT \"FOR A PRETTY DIAMOND PATTERN,\"\n5 INPUT \"TYPE IN AN ODD NUMBER BETWEEN 5 AND 21\";R:PRINT\n6 Q=INT(60/R):A$=\"CC\"\n8 FOR L=1 TO Q\n10 X=1:Y=R:Z=2\n20 FOR N=X TO Y STEP Z\n25 PRINT TAB((R-N)/2);\n28 FOR M=1 TO Q\n29 C=1\n30 FOR A=1 TO N\n32 IF C>LEN(A$) THEN PRINT \"!\";:GOTO 50\n34 PRINT MID$(A$,C,1);\n36 C=C+1\n50 NEXT A\n53 IF M=Q THEN 60\n55 PRINT TAB(R*M+(R-N)/2);\n56 NEXT M\n60 PRINT\n70 NEXT N\n83 IF X<>1 THEN 95\n85 X=R-2:Y=1:Z=-2\n90 GOTO 20\n95 NEXT L\n99 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "1 PRINT TAB(33);\"DIAMOND\"\n2 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n3 PRINT:PRINT:PRINT\n4 PRINT \"FOR A PRETTY DIAMOND PATTERN,\"\n5 INPUT \"TYPE IN AN ODD NUMBER BETWEEN 5 AND 21\";R:PRINT\n6 Q=INT(60/R):A$=\"CC\"\n8 FOR L=1 TO Q\n10 X=1:Y=R:Z=2\n20 FOR N=X TO Y STEP Z\n25 PRINT TAB((R-N)/2);\n28 FOR M=1 TO Q\n29 C=1\n30 FOR A=1 TO N\n32 IF C>LEN(A$) THEN PRINT \"!\";:GOTO 50\n34 PRINT MID$(A$,C,1);\n36 C=C+1\n50 NEXT A\n53 IF M=Q THEN 60\n55 PRINT TAB(R*M+(R-N)/2);\n56 NEXT M\n60 PRINT\n70 NEXT N\n83 IF X<>1 THEN 95\n85 X=R-2:Y=1:Z=-2\n90 GOTO 20\n95 NEXT L\n99 END";
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion diamond

        #region Cube
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 PRINT TAB(34);\"CUBE\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT : PRINT : PRINT\n100 PRINT \"DO YOU WANT TO SEE THE INSTRUCTIONS? (YES--1,NO--0)\"\n110 INPUT B7\n120 IF B7=0 THEN 370\n130 PRINT\"THIS IS A GAME IN WHICH YOU WILL BE PLAYING AGAINST THE\"\n140 PRINT\"RANDOM DECISION OF THE COMPUTER. THE FIELD OF PLAY IS A\"\n150 PRINT\"CUBE OF SIDE 3. ANY OF THE 27 LOCATIONS CAN BE DESIGNATED\"\n160 PRINT\"BY INPUTING THREE NUMBERS SUCH AS 2,3,1. AT THE START,\"\n170 PRINT\"YOU ARE AUTOMATICALLY AT LOCATION 1,1,1. THE OBJECT OF\"\n180 PRINT\"THE GAME IS TO GET TO LOCATION 3,3,3. ONE MINOR DETAIL:\"\n190 PRINT\"THE COMPUTER WILL PICK, AT RANDOM, 5 LOCATIONS AT WHICH\"\n200 PRINT\"IT WILL PLANT LAND MINES. IF YOU HIT ONE OF THESE LOCATIONS\"\n210 PRINT\"YOU LOSE. ONE OTHER DETAIL: YOU MAY MOVE ONLY ONE SPACE \"\n220 PRINT\"IN ONE DIRECTION EACH MOVE. FOR  EXAMPLE: FROM 1,1,2 YOU\"\n230 PRINT\"MAY MOVE TO 2,1,2 OR 1,1,3. YOU MAY NOT CHANGE\"\n240 PRINT\"TWO OF THE NUMBERS ON THE SAME MOVE. IF YOU MAKE AN ILLEGAL\"\n250 PRINT\"MOVE, YOU LOSE AND THE COMPUTER TAKES THE MONEY YOU MAY\"\n260 PRINT\"HAVE BET ON THAT ROUND.\"\n270 PRINT\n280 PRINT\n290 PRINT\"ALL YES OR NO QUESTIONS WILL BE ANSWERED BY A 1 FOR YES\"\n300 PRINT\"OR A 0 (ZERO) FOR NO.\"\n310 PRINT\n320 PRINT\"WHEN STATING THE AMOUNT OF A WAGER, PRINT ONLY THE NUMBER\"\n330 PRINT\"OF DOLLARS (EXAMPLE: 250)  YOU ARE AUTOMATICALLY STARTED WITH\"\n340 PRINT\"500 DOLLARS IN YOUR ACCOUNT.\"\n350 PRINT\n360 PRINT \"GOOD LUCK!\"\n370 LET A1=500\n380 LET A=INT(3*(RND(X)))\n390 IF A<>0 THEN 410\n400 LET A=3\n410 LET B=INT(3*(RND(X)))\n420 IF B<>0 THEN 440\n430 LET B=2\n440 LET C=INT(3*(RND(X)))\n450 IF C<>0 THEN 470\n460 LET C=3\n470 LET D=INT(3*(RND(X)))\n480 IF D<>0 THEN 500\n490 LET D=1\n500 LET E=INT(3*(RND(X)))\n510 IF E<>0 THEN 530\n520 LET E=3\n530 LET F=INT(3*(RND(X)))\n540 IF F<>0 THEN 560\n550 LET F=3\n560 LET G=INT(3*(RND(X)))\n570 IF G<>0 THEN 590\n580 LET G=3\n590 LET H=INT(3*(RND(X)))\n600 IF H<>0 THEN 620\n610 LET H=3\n620 LET I=INT(3*(RND(X)))\n630 IF I<>0 THEN 650\n640 LET I=2\n650 LET J=INT(3*(RND(X)))\n660 IF J<>0 THEN 680\n670 LET J=3\n680 LET K=INT(3*(RND(X)))\n690 IF K<>0 THEN 710\n700 LET K=2\n710 LET L=INT(3*(RND(X)))\n720 IF L<>0 THEN 740\n730 LET L=3\n740 LET M=INT(3*(RND(X)))\n750 IF M<>0 THEN 770\n760 LET M=3\n770 LET N=INT(3*(RND(X)))\n780 IF N<>0 THEN 800\n790 LET N=1\n800 LET O=INT (3*(RND(X)))\n810 IF O <>0 THEN 830\n820 LET O=3\n830 PRINT \"WANT TO MAKE A WAGER?\"\n840 INPUT Z\n850 IF Z=0 THEN 920\n860 PRINT \"HOW MUCH \";\n870 INPUT Z1\n876 IF A1<Z1 THEN 1522\n880 LET W=1\n890 LET X=1\n900 LET Y=1\n910 PRINT\n920 PRINT \"IT'S YOUR MOVE:  \";\n930 INPUT P,Q,R\n940 IF P>W+1 THEN 1030\n950 IF P=W+1 THEN 1000\n960 IF Q>X+1 THEN 1030\n970 IF Q=(X+1) THEN 1010\n980 IF R >(Y+1)  THEN 1030\n990 GOTO 1050\n1000 IF Q>= X+1 THEN 1030\n1010 IF R>=Y+1 THEN 1030\n1020 GOTO 1050\n1030 PRINT:PRINT \"ILLEGAL MOVE. YOU LOSE.\"\n1040 GOTO 1440\n1050 LET W=P\n1060 LET X=Q\n1070 LET Y=R\n1080 IF P=3 THEN 1100\n1090 GOTO 1130\n1100 IF  Q=3 THEN 1120\n1110 GOTO 1130\n1120 IF R=3 THEN 1530\n1130 IF P=A THEN 1150\n1140 GOTO 1180\n1150 IF Q=B THEN 1170\n1160 GOTO 1180\n1170 IF R=C THEN 1400\n1180 IF P=D THEN 1200\n1190 GOTO 1230\n1200 IF Q=E THEN 1220\n1210 GOTO 1230\n1220 IF  R=F THEN 1400\n1230 IF P=G THEN 1250\n1240 GOTO 1280\n1250 IF Q=H THEN 1270\n1260 GOTO 1280\n1270 IF R=I THEN 1400\n1280 IF P=J THEN 1300\n1290 GOTO 1330\n1300 IF Q=K THEN 1320\n1310 GOTO 1330\n1320 IF R=L THEN 1440\n1330 IF P=M THEN 1350\n1340 GOTO 1380\n1350 IF Q=N THEN 1370\n1360 GOTO 1380\n1370 IF R=O THEN 1400\n1380 PRINT \"NEXT MOVE: \";\n1390 GOTO 930 \n1400 PRINT\"******BANG******\"\n1410 PRINT \"YOU LOSE!\"\n1420 PRINT\n1430 PRINT\n1440 IF   Z=0 THEN 1580\n1450 PRINT \n1460 LET Z2=A1-Z1\n1470 IF Z2>0 THEN 1500\n1480 PRINT \"YOU BUST.\"\n1490 GOTO 1610\n1500 PRINT \" YOU NOW HAVE\"; Z2; \"DOLLARS.\"\n1510 LET A1=Z2\n1520 GOTO 1580\n1522 PRINT\"TRIED TO FOOL ME; BET AGAIN\";\n1525 GOTO 870\n1530 PRINT\"CONGRATULATIONS!\"\n1540 IF Z=0 THEN 1580\n1550 LET Z2=A1+Z1\n1560 PRINT \"YOU NOW HAVE\"; Z2;\"DOLLARS.\"\n1570 LET A1=Z2\n1580 PRINT\"DO YOU WANT TO TRY AGAIN \";\n1590 INPUT S\n1600 IF S=1 THEN 380\n1610 PRINT \"TOUGH LUCK!\"\n1620 PRINT\n1630 PRINT \"GOODBYE.\"\n1640 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "10 PRINT TAB(34);\"CUBE\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT : PRINT : PRINT\n100 PRINT \"DO YOU WANT TO SEE THE INSTRUCTIONS? (YES--1,NO--0)\"\n110 INPUT B7\n120 IF B7=0 THEN 370\n130 PRINT\"THIS IS A GAME IN WHICH YOU WILL BE PLAYING AGAINST THE\"\n140 PRINT\"RANDOM DECISION OF THE COMPUTER. THE FIELD OF PLAY IS A\"\n150 PRINT\"CUBE OF SIDE 3. ANY OF THE 27 LOCATIONS CAN BE DESIGNATED\"\n160 PRINT\"BY INPUTING THREE NUMBERS SUCH AS 2,3,1. AT THE START,\"\n170 PRINT\"YOU ARE AUTOMATICALLY AT LOCATION 1,1,1. THE OBJECT OF\"\n180 PRINT\"THE GAME IS TO GET TO LOCATION 3,3,3. ONE MINOR DETAIL:\"\n190 PRINT\"THE COMPUTER WILL PICK, AT RANDOM, 5 LOCATIONS AT WHICH\"\n200 PRINT\"IT WILL PLANT LAND MINES. IF YOU HIT ONE OF THESE LOCATIONS\"\n210 PRINT\"YOU LOSE. ONE OTHER DETAIL: YOU MAY MOVE ONLY ONE SPACE \"\n220 PRINT\"IN ONE DIRECTION EACH MOVE. FOR  EXAMPLE: FROM 1,1,2 YOU\"\n230 PRINT\"MAY MOVE TO 2,1,2 OR 1,1,3. YOU MAY NOT CHANGE\"\n240 PRINT\"TWO OF THE NUMBERS ON THE SAME MOVE. IF YOU MAKE AN ILLEGAL\"\n250 PRINT\"MOVE, YOU LOSE AND THE COMPUTER TAKES THE MONEY YOU MAY\"\n260 PRINT\"HAVE BET ON THAT ROUND.\"\n270 PRINT\n280 PRINT\n290 PRINT\"ALL YES OR NO QUESTIONS WILL BE ANSWERED BY A 1 FOR YES\"\n300 PRINT\"OR A 0 (ZERO) FOR NO.\"\n310 PRINT\n320 PRINT\"WHEN STATING THE AMOUNT OF A WAGER, PRINT ONLY THE NUMBER\"\n330 PRINT\"OF DOLLARS (EXAMPLE: 250)  YOU ARE AUTOMATICALLY STARTED WITH\"\n340 PRINT\"500 DOLLARS IN YOUR ACCOUNT.\"\n350 PRINT\n360 PRINT \"GOOD LUCK!\"\n370 LET A1=500\n380 LET A=INT(3*(RND(X)))\n390 IF A<>0 THEN 410\n400 LET A=3\n410 LET B=INT(3*(RND(X)))\n420 IF B<>0 THEN 440\n430 LET B=2\n440 LET C=INT(3*(RND(X)))\n450 IF C<>0 THEN 470\n460 LET C=3\n470 LET D=INT(3*(RND(X)))\n480 IF D<>0 THEN 500\n490 LET D=1\n500 LET E=INT(3*(RND(X)))\n510 IF E<>0 THEN 530\n520 LET E=3\n530 LET F=INT(3*(RND(X)))\n540 IF F<>0 THEN 560\n550 LET F=3\n560 LET G=INT(3*(RND(X)))\n570 IF G<>0 THEN 590\n580 LET G=3\n590 LET H=INT(3*(RND(X)))\n600 IF H<>0 THEN 620\n610 LET H=3\n620 LET I=INT(3*(RND(X)))\n630 IF I<>0 THEN 650\n640 LET I=2\n650 LET J=INT(3*(RND(X)))\n660 IF J<>0 THEN 680\n670 LET J=3\n680 LET K=INT(3*(RND(X)))\n690 IF K<>0 THEN 710\n700 LET K=2\n710 LET L=INT(3*(RND(X)))\n720 IF L<>0 THEN 740\n730 LET L=3\n740 LET M=INT(3*(RND(X)))\n750 IF M<>0 THEN 770\n760 LET M=3\n770 LET N=INT(3*(RND(X)))\n780 IF N<>0 THEN 800\n790 LET N=1\n800 LET O=INT (3*(RND(X)))\n810 IF O <>0 THEN 830\n820 LET O=3\n830 PRINT \"WANT TO MAKE A WAGER?\"\n840 INPUT Z\n850 IF Z=0 THEN 920\n860 PRINT \"HOW MUCH \";\n870 INPUT Z1\n876 IF A1<Z1 THEN 1522\n880 LET W=1\n890 LET X=1\n900 LET Y=1\n910 PRINT\n920 PRINT \"IT'S YOUR MOVE:  \";\n930 INPUT P,Q,R\n940 IF P>W+1 THEN 1030\n950 IF P=W+1 THEN 1000\n960 IF Q>X+1 THEN 1030\n970 IF Q=(X+1) THEN 1010\n980 IF R >(Y+1)  THEN 1030\n990 GOTO 1050\n1000 IF Q>= X+1 THEN 1030\n1010 IF R>=Y+1 THEN 1030\n1020 GOTO 1050\n1030 PRINT:PRINT \"ILLEGAL MOVE. YOU LOSE.\"\n1040 GOTO 1440\n1050 LET W=P\n1060 LET X=Q\n1070 LET Y=R\n1080 IF P=3 THEN 1100\n1090 GOTO 1130\n1100 IF  Q=3 THEN 1120\n1110 GOTO 1130\n1120 IF R=3 THEN 1530\n1130 IF P=A THEN 1150\n1140 GOTO 1180\n1150 IF Q=B THEN 1170\n1160 GOTO 1180\n1170 IF R=C THEN 1400\n1180 IF P=D THEN 1200\n1190 GOTO 1230\n1200 IF Q=E THEN 1220\n1210 GOTO 1230\n1220 IF  R=F THEN 1400\n1230 IF P=G THEN 1250\n1240 GOTO 1280\n1250 IF Q=H THEN 1270\n1260 GOTO 1280\n1270 IF R=I THEN 1400\n1280 IF P=J THEN 1300\n1290 GOTO 1330\n1300 IF Q=K THEN 1320\n1310 GOTO 1330\n1320 IF R=L THEN 1440\n1330 IF P=M THEN 1350\n1340 GOTO 1380\n1350 IF Q=N THEN 1370\n1360 GOTO 1380\n1370 IF R=O THEN 1400\n1380 PRINT \"NEXT MOVE: \";\n1390 GOTO 930 \n1400 PRINT\"******BANG******\"\n1410 PRINT \"YOU LOSE!\"\n1420 PRINT\n1430 PRINT\n1440 IF   Z=0 THEN 1580\n1450 PRINT \n1460 LET Z2=A1-Z1\n1470 IF Z2>0 THEN 1500\n1480 PRINT \"YOU BUST.\"\n1490 GOTO 1610\n1500 PRINT \" YOU NOW HAVE\"; Z2; \"DOLLARS.\"\n1510 LET A1=Z2\n1520 GOTO 1580\n1522 PRINT\"TRIED TO FOOL ME; BET AGAIN\";\n1525 GOTO 870\n1530 PRINT\"CONGRATULATIONS!\"\n1540 IF Z=0 THEN 1580\n1550 LET Z2=A1+Z1\n1560 PRINT \"YOU NOW HAVE\"; Z2;\"DOLLARS.\"\n1570 LET A1=Z2\n1580 PRINT\"DO YOU WANT TO TRY AGAIN \";\n1590 INPUT S\n1600 IF S=1 THEN 380\n1610 PRINT \"TOUGH LUCK!\"\n1620 PRINT\n1630 PRINT \"GOODBYE.\"\n1640 END";
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion Cube

        #region chemist
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "3 PRINT TAB(33);\"CHEMIST\"\n6 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n8 PRINT:PRINT:PRINT\n10 PRINT \"THE FICTITIOUS CHECMICAL KRYPTOCYANIC ACID CAN ONLY BE\"\n20 PRINT \"DILUTED BY THE RATIO OF 7 PARTS WATER TO 3 PARTS ACID.\"\n30 PRINT \"IF ANY OTHER RATIO IS ATTEMPTED, THE ACID BECOMES UNSTABLE\"\n40 PRINT \"AND SOON EXPLODES.  GIVEN THE AMOUNT OF ACID, YOU MUST\"\n50 PRINT \"DECIDE WHO MUCH WATER TO ADD FOR DILUTION.  IF YOU MISS\"\n60 PRINT \"YOU FACE THE CONSEQUENCES.\"\n100 A=INT(RND(1)*50)\n110 W=7*A/3\n120 PRINT A;\"LITERS OF KRYPTOCYANIC ACID.  HOW MUCH WATER\";\n130 INPUT R\n140 D=ABS(W-R)\n150 IF D>W/20 THEN 200\n160 PRINT \" GOOD JOB! YOU MAY BREATHE NOW, BUT DON'T INHALE THE FUMES!\"\n170 PRINT\n180 GOTO 100\n200 PRINT \" SIZZLE!  YOU HAVE JUST BEEN DESALINATED INTO A BLOB\"\n210 PRINT \" OF QUIVERING PROTOPLASM!\"\n220 T=T+1\n230 IF T=9 THEN 260\n240 PRINT \" HOWEVER, YOU MAY TRY AGAIN WITH ANOTHER LIFE.\"\n250 GOTO 100\n260 PRINT \" YOUR 9 LIVES ARE USED, BUT YOU WILL BE LONG REMEMBERED FOR\"\n270 PRINT \" YOUR CONTRIBUTIONS TO THE FIELD OF COMIC BOOK CHEMISTRY.\"\n280 END";
            syntaxEditor.Show();
            Parent.Hide();
            //       f.synBox1.Text = "3 PRINT TAB(33);\"CHEMIST\"\n6 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n8 PRINT:PRINT:PRINT\n10 PRINT \"THE FICTITIOUS CHECMICAL KRYPTOCYANIC ACID CAN ONLY BE\"\n20 PRINT \"DILUTED BY THE RATIO OF 7 PARTS WATER TO 3 PARTS ACID.\"\n30 PRINT \"IF ANY OTHER RATIO IS ATTEMPTED, THE ACID BECOMES UNSTABLE\"\n40 PRINT \"AND SOON EXPLODES.  GIVEN THE AMOUNT OF ACID, YOU MUST\"\n50 PRINT \"DECIDE WHO MUCH WATER TO ADD FOR DILUTION.  IF YOU MISS\"\n60 PRINT \"YOU FACE THE CONSEQUENCES.\"\n100 A=INT(RND(1)*50)\n110 W=7*A/3\n120 PRINT A;\"LITERS OF KRYPTOCYANIC ACID.  HOW MUCH WATER\";\n130 INPUT R\n140 D=ABS(W-R)\n150 IF D>W/20 THEN 200\n160 PRINT \" GOOD JOB! YOU MAY BREATHE NOW, BUT DON'T INHALE THE FUMES!\"\n170 PRINT\n180 GOTO 100\n200 PRINT \" SIZZLE!  YOU HAVE JUST BEEN DESALINATED INTO A BLOB\"\n210 PRINT \" OF QUIVERING PROTOPLASM!\"\n220 T=T+1\n230 IF T=9 THEN 260\n240 PRINT \" HOWEVER, YOU MAY TRY AGAIN WITH ANOTHER LIFE.\"\n250 GOTO 100\n260 PRINT \" YOUR 9 LIVES ARE USED, BUT YOU WILL BE LONG REMEMBERED FOR\"\n270 PRINT \" YOUR CONTRIBUTIONS TO THE FIELD OF COMIC BOOK CHEMISTRY.\"\n280 END";
        }

        private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox25.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox25_MouseLeave(object sender, EventArgs e)
        {
            pictureBox25.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion chemist

        #region calender
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "3 PRINT TAB(33);\"CHEMIST\"\n6 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n8 PRINT:PRINT:PRINT\n10 PRINT \"THE FICTITIOUS CHECMICAL KRYPTOCYANIC ACID CAN ONLY BE\"\n20 PRINT \"DILUTED BY THE RATIO OF 7 PARTS WATER TO 3 PARTS ACID.\"\n30 PRINT \"IF ANY OTHER RATIO IS ATTEMPTED, THE ACID BECOMES UNSTABLE\"\n40 PRINT \"AND SOON EXPLODES.  GIVEN THE AMOUNT OF ACID, YOU MUST\"\n50 PRINT \"DECIDE WHO MUCH WATER TO ADD FOR DILUTION.  IF YOU MISS\"\n60 PRINT \"YOU FACE THE CONSEQUENCES.\"\n100 A=INT(RND(1)*50)\n110 W=7*A/3\n120 PRINT A;\"LITERS OF KRYPTOCYANIC ACID.  HOW MUCH WATER\";\n130 INPUT R\n140 D=ABS(W-R)\n150 IF D>W/20 THEN 200\n160 PRINT \" GOOD JOB! YOU MAY BREATHE NOW, BUT DON'T INHALE THE FUMES!\"\n170 PRINT\n180 GOTO 100\n200 PRINT \" SIZZLE!  YOU HAVE JUST BEEN DESALINATED INTO A BLOB\"\n210 PRINT \" OF QUIVERING PROTOPLASM!\"\n220 T=T+1\n230 IF T=9 THEN 260\n240 PRINT \" HOWEVER, YOU MAY TRY AGAIN WITH ANOTHER LIFE.\"\n250 GOTO 100\n260 PRINT \" YOUR 9 LIVES ARE USED, BUT YOU WILL BE LONG REMEMBERED FOR\"\n270 PRINT \" YOUR CONTRIBUTIONS TO THE FIELD OF COMIC BOOK CHEMISTRY.\"\n280 END";
            syntaxEditor.Show();
            Parent.Hide();
            //   f.synBox1.Text = "3 PRINT TAB(33);\"CHEMIST\"\n6 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n8 PRINT:PRINT:PRINT\n10 PRINT \"THE FICTITIOUS CHECMICAL KRYPTOCYANIC ACID CAN ONLY BE\"\n20 PRINT \"DILUTED BY THE RATIO OF 7 PARTS WATER TO 3 PARTS ACID.\"\n30 PRINT \"IF ANY OTHER RATIO IS ATTEMPTED, THE ACID BECOMES UNSTABLE\"\n40 PRINT \"AND SOON EXPLODES.  GIVEN THE AMOUNT OF ACID, YOU MUST\"\n50 PRINT \"DECIDE WHO MUCH WATER TO ADD FOR DILUTION.  IF YOU MISS\"\n60 PRINT \"YOU FACE THE CONSEQUENCES.\"\n100 A=INT(RND(1)*50)\n110 W=7*A/3\n120 PRINT A;\"LITERS OF KRYPTOCYANIC ACID.  HOW MUCH WATER\";\n130 INPUT R\n140 D=ABS(W-R)\n150 IF D>W/20 THEN 200\n160 PRINT \" GOOD JOB! YOU MAY BREATHE NOW, BUT DON'T INHALE THE FUMES!\"\n170 PRINT\n180 GOTO 100\n200 PRINT \" SIZZLE!  YOU HAVE JUST BEEN DESALINATED INTO A BLOB\"\n210 PRINT \" OF QUIVERING PROTOPLASM!\"\n220 T=T+1\n230 IF T=9 THEN 260\n240 PRINT \" HOWEVER, YOU MAY TRY AGAIN WITH ANOTHER LIFE.\"\n250 GOTO 100\n260 PRINT \" YOUR 9 LIVES ARE USED, BUT YOU WILL BE LONG REMEMBERED FOR\"\n270 PRINT \" YOUR CONTRIBUTIONS TO THE FIELD OF COMIC BOOK CHEMISTRY.\"\n280 END";
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox24.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion calender

        #region Black jack
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "2 PRINT TAB(31);\"BLACK JACK\"\n4 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n6 PRINT:PRINT:PRINT\n10 DEF FNA(Q)=Q+11*(Q>=22)\n20 DIM P(15,12),Q(15),C(52),D(52),T(8),S(7),B(15)\n30 DIM R(15)\n40 REM--P(I,J) IS THE JTH CARD IN HAND I, Q(I) IS TOTAL OF HAND I\n50 REM--C IS THE DECK BEING DEALT FROM, D IS THE DISCARD PILE,\n60 REM--T(I) IS THE TOTAL FOR PLAYER I, S(I) IS THE TOTAL THIS HAND FOR\n70 REM--PLAYER I, B(I) IS TH BET FOR HAND I\n80 REM--R(I) IS THE LENGTH OF P(I,*)\n90 GOTO 1500\n100 REM--SUBROUTINE TO GET A CARD.  RESULT IS PUT IN X.\n110 IF C<51 THEN 230\n120 PRINT \"RESHUFFLING\"\n130 FOR D=D TO 1 STEP -1\n140 C=C-1\n150 C(C)=D(D)\n160 NEXT D\n170 FOR C1=52 TO C STEP -1\n180 C2=INT(RND(1)*(C1-C+1))+C\n190 C3=C(C2)\n200 C(C2)=C(C1)\n210 C(C1)=C3\n220 NEXT C1\n230 X=C(C)\n240 C=C+1\n250 RETURN\n300 REM--SUBROUTINE TO EVALUATE HAND I.  TOTAL IS PUT INTO\n310 REM--Q(I). TOTALS HAVE THE FOLLOWING MEANING:\n320 REM--  2-10...HARD 2-10\n330 REM-- 11-21...SOFT 11-21\n340 REM-- 22-32...HARD 11-21\n350 REM--  33+....BUSTED\n360 Q=0\n370 FOR Q2=1 TO R(I)\n380 X=P(I,Q2)\n390 GOSUB 500\n400 NEXT Q2\n410 Q(I)=Q\n420 RETURN\n500 REM--SUBROUTINE TO ADD CARD X TO TOTAL Q.\n510 X1=X: IF X1>10 THEN X1=10:  REM  SAME AS X1=10 MIN X\n520 Q1=Q+X1\n530 IF Q>=11 THEN 590\n540 IF X>1 THEN 570\n550 Q=Q+11\n560 RETURN\n570 Q=Q1-11*(Q1>=11)\n580 RETURN\n590 Q=Q1-(Q<=21 AND Q1>21)\n600 IF Q<33 THEN 620\n610 Q=-1\n620 RETURN\n700 REM--CARD PRINTING SUBROUTINE\n710 REM  D$ DEFINED ELSEWHERE\n720 PRINT MID$(D$,3*X-2,3);\n730 PRINT \"  \";\n740 RETURN\n750 REM--ALTERNATIVE PRINTING ROUTINE\n760 PRINT \" \";MID$(D$,3*X-1,2);\n770 PRINT \"   \";\n780 RETURN\n800 REM--SUBROUTINE TO PLAY OUT A HAND.\n810 REM--NO SPLITTING OR BLACKJACKS ALLOWED\n820 H1=5\n830 GOSUB 1410\n840 H1=3\n850 ON H GOTO 950,930\n860 GOSUB 100\n870 B(I)=B(I)*2\n880 PRINT \"RECEIVED A\";\n890 GOSUB 700\n900 GOSUB 1100\n910 IF Q>0 THEN GOSUB 1300\n920 RETURN\n930 GOSUB 1320\n940 RETURN\n950 GOSUB 100\n960 PRINT \"RECEIVED A\";\n970 GOSUB 700\n980 GOSUB 1100\n990 IF Q<0 THEN 940\n1000 PRINT \"HIT\";\n1010 GOTO 830\n1100 REM--SUBROUTINE TO ADD A CARD TO ROW I\n1110 R(I)=R(I)+1\n1120 P(I,R(I))=X\n1130 Q=Q(I)\n1140 GOSUB 500\n1150 Q(I)=Q\n1160 IF Q>=0 THEN 1190\n1170 PRINT \"...BUSTED\"\n1180 GOSUB 1200\n1190 RETURN\n1200 REM--SUBROUTINE TO DISCARD ROW I\n1210 IF R(I)<>0 THEN 1230\n1220 RETURN\n1230 D=D+1\n1240 D(D)=P(I,R(I))\n1250 R(I)=R(I)-1\n1260 GOTO 1210\n1300 REM--PRINTS TOTAL OF HAND I\n1310 PRINT\n1320 AA=Q(I): GOSUB 3400\n1325 PRINT \"TOTAL IS\";AA\n1330 RETURN\n1400 REM--SUBROUTINE TO READ REPLY\n1410 REM  I$ DEFINED ELSEWHERE\n1420 INPUT H$: H$=LEFT$(H$,1)\n1430 FOR H=1 TO H1 STEP 2\n1440 IF H$=MID$(I$,H,1) THEN 1480\n1450 NEXT H\n1460 PRINT \"TYPE \";MID$(I$,1,H1-1);\" OR \";MID$(I$,H1,2);\" PLEASE\";\n1470 GOTO 1420\n1480 H=(H+1)/2\n1490 RETURN\n1500 REM--PROGRAM STARTS HERE\n1510 REM--INITIALIZE\n1520 D$=\"N A  2  3  4  5  6  7N 8  9 10  J  Q  K\"\n1530 I$=\"H,S,D,/,\"\n1540 FOR I=1 TO 13\n1550 FOR J=4*I-3 TO 4*I\n1560 D(J)=I\n1570 NEXT J\n1580 NEXT I\n1590 D=52\n1600 C=53\n1610 PRINT \"DO YOU WANT INSTRUCTIONS\";\n1620 INPUT H$\n1630 IF LEFT$(H$,1)=\"N\" OR LEFT$(H$,1)=\"n\" THEN 1760\n1640 PRINT \"THIS IS THE GAME OF 21. AS MANY AS 7 PLAYERS MAY PLAY THE\"\n1650 PRINT \"GAME. ON EACH DEAL, BETS WILL BE ASKED FOR, AND THE\"\n1660 PRINT \"PLAYERS' BETS SHOULD BE TYPED IN. THE CARDS WILL THEN BE\"\n1670 PRINT \"DEALT, AND EACH PLAYER IN TURN PLAYS HIS HAND. THE\"\n1680 PRINT \"FIRST RESPONSE SHOULD BE EITHER 'D', INDICATING THAT THE\"\n1690 PRINT \"PLAYER IS DOUBLING DOWN, 'S', INDICATING THAT HE IS\"\n1700 PRINT \"STANDING, 'H', INDICATING HE WANTS ANOTHER CARD, OR '/',\"\n1710 PRINT \"INDICATING THAT HE WANTS TO SPLIT HIS CARDS. AFTER THE\"\n1720 PRINT \"INITIAL RESPONSE, ALL FURTHER RESPONSES SHOULD BE 'S' OR\"\n1730 PRINT \"'H', UNLESS THE CARDS WERE SPLIT, IN WHICH CASE DOUBLING\"\n1740 PRINT \"DOWN IS AGAIN PERMITTED. IN ORDER TO COLLECT FOR\"\n1750 PRINT \"BLACKJACK, THE INITIAL RESPONSE SHOULD BE 'S'.\"\n1760 PRINT \"NUMBER OF PLAYERS\";\n1770 INPUT N\n1775 PRINT\n1780 IF N<1 OR N>7 OR N>INT(N) THEN 1760\n1790 FOR I=1 TO 8: T(I)=0: NEXT I\n1800 D1=N+1\n1810 IF 2*D1+C>=52 THEN GOSUB 120\n1820 IF C=2 THEN C=C-1\n1830 FOR I=1 TO N: Z(I)=0: NEXT I\n1840 FOR I=1 TO 15: B(I)=0: NEXT I\n1850 FOR I=1 TO 15: Q(I)=0: NEXT I\n1860 FOR I=1 TO 7: S(I)=0: NEXT I\n1870 FOR I=1 TO 15: R(I)=0: NEXT I\n1880 PRINT \"BETS:\"\n1890 FOR I=1 TO N: PRINT \"#\";I;: INPUT Z(I): NEXT I\n1900 FOR I=1 TO N\n1910 IF Z(I)<=0 OR Z(I)>500 THEN 1880\n1920 B(I)=Z(I)\n1930 NEXT I\n1940 PRINT \"PLAYER\";\n1950 FOR I=1 TO N\n1960 PRINT I;\"   \";\n1970 NEXT I\n1980 PRINT \"DEALER\"\n1990 FOR J=1 TO 2\n2000 PRINT TAB(5);\n2010 FOR I=1 TO D1\n2020 GOSUB 100\n2030 P(I,J)=X\n2040 IF J=1 OR I<=N THEN GOSUB 750\n2050 NEXT I\n2060 PRINT\n2070 NEXT J\n2080 FOR I=1 TO D1\n2090 R(I)=2\n2100 NEXT I\n2110 REM--TEST FOR INSURANCE\n2120 IF P(D1,1)>1 THEN 2240\n2130 PRINT \"ANY INSURANCE\";\n2140 INPUT H$\n2150 IF LEFT$(H$,1)<>\"Y\" THEN 2240\n2160 PRINT \"INSURANCE BETS\"\n2170 FOR I=1 TO N: PRINT \"#\";I;: INPUT Z(I): NEXT I\n2180 FOR I=1 TO N\n2190 IF Z(I)<0 OR Z(I)>B(I)/2 THEN 2160\n2200 NEXT I\n2210 FOR I=1 TO N\n2220 S(I)=Z(I)*(3*(-(P(D1,2)>=10))-1)\n2230 NEXT I\n2240 REM--TEST FOR DEALER BLACKJACK\n2250 L1=1: L2=1\n2252 IF P(D1,1)=1 AND P(D1,2)>9 THEN L1=0: L2=0\n2253 IF P(D1,2)=1 AND P(D1,1)>9 THEN L1=0: L2=0\n2254 IF L1<>0 OR L2<>0 THEN 2320\n2260 PRINT:PRINT \"DEALER HAS A\";MID$(D$,3*P(D1,2)-2,3);\" IN THE HOLE \";\n2270 PRINT \"FOR BLACKJACK\"\n2280 FOR I=1 TO D1\n2290 GOSUB 300\n2300 NEXT I\n2310 GOTO 3140\n2320 REM--NO DEALER BLACKJACK\n2330 IF P(D1,1)>1 AND P(D1,1)<10 THEN 2350\n2340 PRINT:PRINT \"NO DEALER BLACKJACK.\"\n2350 REM--NOW PLAY THE HANDS\n2360 FOR I=1 TO N\n2370 PRINT \"PLAYER\";I;\n2380 H1=7\n2390 GOSUB 1410\n2400 ON H GOTO 2550,2410,2510,2600\n2410 REM--PLAYER WANTS TO STAND\n2420 GOSUB 300\n2430 IF Q(I)<>21 THEN 2490\n2440 PRINT \"BLACKJACK\"\n2450 S(I)=S(I)+1.5*B(I)\n2460 B(I)=0\n2470 GOSUB 1200\n2480 GOTO 2900\n2490 GOSUB 1320\n2500 GOTO 2900\n2510 REM--PLAYER WANTS TO DOUBLE DOWN\n2520 GOSUB 300\n2530 GOSUB 860\n2540 GOTO 2900\n2550 REM--PLAYER WANTS TO BE HIT\n2560 GOSUB 300\n2570 H1=3\n2580 GOSUB 950\n2590 GOTO 2900\n2600 REM--PLAYER WANTS TO SPLIT\n2610 L1=P(I,1): IF P(I,1)>10 THEN L1=10\n2612 L2=P(I,2): IF P(I,2)>10 THEN L2=10\n2614 IF L1=L2 THEN 2640\n2620 PRINT \"SPLITTING NOT ALLOWED.\"\n2630 GOTO 2370\n2640 REM--PLAY OUT SPLIT\n2650 I1=I+D1\n2660 R(I1)=2\n2670 P(I1,1)=P(I,2)\n2680 B(I+D1)=B(I)\n2690 GOSUB 100\n2700 PRINT \"FIRST HAND RECEIVES A\";\n2710 GOSUB 700\n2720 P(I,2)=X\n2730 GOSUB 300\n2740 PRINT\n2750 GOSUB 100\n2760 PRINT \"SECOND HAND RECEIVES A\";\n2770 I=I1\n2780 GOSUB 700\n2790 P(I,2)=X\n2800 GOSUB 300\n2810 PRINT\n2820 I=I1-D1\n2830 IF P(I,1)=1 THEN 2900\n2840 REM--NOW PLAY THE TWO HANDS\n2850 PRINT \"HAND\";1-(I>D1);\n2860 GOSUB 800\n2870 I=I+D1\n2880 IF I=I1 THEN 2850\n2890 I=I1-D1\n2900 NEXT I\n2910 GOSUB 300\n2920 REM--TEST FOR PLAYING DEALER'S HAND\n2930 FOR I=1 TO N\n2940 IF R(I)>0 OR R(I+D1)>0 THEN 3010\n2950 NEXT I\n2960 PRINT \"DEALER HAD A\";\n2970 X=P(D1,2)\n2980 GOSUB 700\n2990 PRINT \" CONCEALED.\"\n3000 GOTO 3140\n3010 PRINT \"DEALER HAS A\";MID$(D$,3*P(D1,2)-2,3);\" CONCEALED \";\n3020 I=D1\n3030 AA=Q(I): GOSUB 3400\n3035 PRINT \"FOR A TOTAL OF\";AA\n3040 IF AA>16 THEN 3130\n3050 PRINT \"DRAWS\";\n3060 GOSUB 100\n3070 GOSUB 750\n3080 GOSUB 1100\n3090 AA=Q: GOSUB 3400\n3095 IF Q>0 AND AA<17 THEN 3060\n3100 Q(I)=Q-(Q<0)/2\n3110 IF Q<0 THEN 3140\n3120 AA=Q: GOSUB 3400\n3125 PRINT \"---TOTAL IS\";AA\n3130 PRINT\n3140 REM--TALLY THE RESULT\n3150 REM \n3160 Z$=\"LOSES PUSHES WINS \"\n3165 PRINT\n3170 FOR I=1 TO N\n3180 AA=Q(I): GOSUB 3400\n3182 AB=Q(I+D1): GOSUB 3410\n3184 AC=Q(D1): GOSUB 3420\n3186 S(I)=S(I)+B(I)*SGN(AA-AC)+B(I+D1)*SGN(AB-AC)\n3188 B(I+D1)=0\n3200 PRINT \"PLAYER\";I;\n3210 PRINT MID$(Z$,SGN(S(I))*6+7,6);\" \";\n3220 IF S(I)<>0 THEN 3250\n3230 PRINT \"      \";\n3240 GOTO 3260\n3250 PRINT ABS(S(I));\n3260 T(I)=T(I)+S(I)\n3270 PRINT \"TOTAL=\";T(I)\n3280 GOSUB 1200\n3290 T(D1)=T(D1)-S(I)\n3300 I=I+D1\n3310 GOSUB 1200\n3320 I=I-D1\n3330 NEXT I\n3340 PRINT \"DEALER'S TOTAL=\";T(D1)\n3345 PRINT\n3350 GOSUB 1200\n3360 GOTO 1810\n3400 AA=AA+11*(AA>=22): RETURN\n3410 AB=AB+11*(AB>=22): RETURN\n3420 AC=AC+11*(AC>=22): RETURN";
            syntaxEditor.Show();
            Parent.Hide();
            //   f.synBox1.Text = "2 PRINT TAB(31);\"BLACK JACK\"\n4 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n6 PRINT:PRINT:PRINT\n10 DEF FNA(Q)=Q+11*(Q>=22)\n20 DIM P(15,12),Q(15),C(52),D(52),T(8),S(7),B(15)\n30 DIM R(15)\n40 REM--P(I,J) IS THE JTH CARD IN HAND I, Q(I) IS TOTAL OF HAND I\n50 REM--C IS THE DECK BEING DEALT FROM, D IS THE DISCARD PILE,\n60 REM--T(I) IS THE TOTAL FOR PLAYER I, S(I) IS THE TOTAL THIS HAND FOR\n70 REM--PLAYER I, B(I) IS TH BET FOR HAND I\n80 REM--R(I) IS THE LENGTH OF P(I,*)\n90 GOTO 1500\n100 REM--SUBROUTINE TO GET A CARD.  RESULT IS PUT IN X.\n110 IF C<51 THEN 230\n120 PRINT \"RESHUFFLING\"\n130 FOR D=D TO 1 STEP -1\n140 C=C-1\n150 C(C)=D(D)\n160 NEXT D\n170 FOR C1=52 TO C STEP -1\n180 C2=INT(RND(1)*(C1-C+1))+C\n190 C3=C(C2)\n200 C(C2)=C(C1)\n210 C(C1)=C3\n220 NEXT C1\n230 X=C(C)\n240 C=C+1\n250 RETURN\n300 REM--SUBROUTINE TO EVALUATE HAND I.  TOTAL IS PUT INTO\n310 REM--Q(I). TOTALS HAVE THE FOLLOWING MEANING:\n320 REM--  2-10...HARD 2-10\n330 REM-- 11-21...SOFT 11-21\n340 REM-- 22-32...HARD 11-21\n350 REM--  33+....BUSTED\n360 Q=0\n370 FOR Q2=1 TO R(I)\n380 X=P(I,Q2)\n390 GOSUB 500\n400 NEXT Q2\n410 Q(I)=Q\n420 RETURN\n500 REM--SUBROUTINE TO ADD CARD X TO TOTAL Q.\n510 X1=X: IF X1>10 THEN X1=10:  REM  SAME AS X1=10 MIN X\n520 Q1=Q+X1\n530 IF Q>=11 THEN 590\n540 IF X>1 THEN 570\n550 Q=Q+11\n560 RETURN\n570 Q=Q1-11*(Q1>=11)\n580 RETURN\n590 Q=Q1-(Q<=21 AND Q1>21)\n600 IF Q<33 THEN 620\n610 Q=-1\n620 RETURN\n700 REM--CARD PRINTING SUBROUTINE\n710 REM  D$ DEFINED ELSEWHERE\n720 PRINT MID$(D$,3*X-2,3);\n730 PRINT \"  \";\n740 RETURN\n750 REM--ALTERNATIVE PRINTING ROUTINE\n760 PRINT \" \";MID$(D$,3*X-1,2);\n770 PRINT \"   \";\n780 RETURN\n800 REM--SUBROUTINE TO PLAY OUT A HAND.\n810 REM--NO SPLITTING OR BLACKJACKS ALLOWED\n820 H1=5\n830 GOSUB 1410\n840 H1=3\n850 ON H GOTO 950,930\n860 GOSUB 100\n870 B(I)=B(I)*2\n880 PRINT \"RECEIVED A\";\n890 GOSUB 700\n900 GOSUB 1100\n910 IF Q>0 THEN GOSUB 1300\n920 RETURN\n930 GOSUB 1320\n940 RETURN\n950 GOSUB 100\n960 PRINT \"RECEIVED A\";\n970 GOSUB 700\n980 GOSUB 1100\n990 IF Q<0 THEN 940\n1000 PRINT \"HIT\";\n1010 GOTO 830\n1100 REM--SUBROUTINE TO ADD A CARD TO ROW I\n1110 R(I)=R(I)+1\n1120 P(I,R(I))=X\n1130 Q=Q(I)\n1140 GOSUB 500\n1150 Q(I)=Q\n1160 IF Q>=0 THEN 1190\n1170 PRINT \"...BUSTED\"\n1180 GOSUB 1200\n1190 RETURN\n1200 REM--SUBROUTINE TO DISCARD ROW I\n1210 IF R(I)<>0 THEN 1230\n1220 RETURN\n1230 D=D+1\n1240 D(D)=P(I,R(I))\n1250 R(I)=R(I)-1\n1260 GOTO 1210\n1300 REM--PRINTS TOTAL OF HAND I\n1310 PRINT\n1320 AA=Q(I): GOSUB 3400\n1325 PRINT \"TOTAL IS\";AA\n1330 RETURN\n1400 REM--SUBROUTINE TO READ REPLY\n1410 REM  I$ DEFINED ELSEWHERE\n1420 INPUT H$: H$=LEFT$(H$,1)\n1430 FOR H=1 TO H1 STEP 2\n1440 IF H$=MID$(I$,H,1) THEN 1480\n1450 NEXT H\n1460 PRINT \"TYPE \";MID$(I$,1,H1-1);\" OR \";MID$(I$,H1,2);\" PLEASE\";\n1470 GOTO 1420\n1480 H=(H+1)/2\n1490 RETURN\n1500 REM--PROGRAM STARTS HERE\n1510 REM--INITIALIZE\n1520 D$=\"N A  2  3  4  5  6  7N 8  9 10  J  Q  K\"\n1530 I$=\"H,S,D,/,\"\n1540 FOR I=1 TO 13\n1550 FOR J=4*I-3 TO 4*I\n1560 D(J)=I\n1570 NEXT J\n1580 NEXT I\n1590 D=52\n1600 C=53\n1610 PRINT \"DO YOU WANT INSTRUCTIONS\";\n1620 INPUT H$\n1630 IF LEFT$(H$,1)=\"N\" OR LEFT$(H$,1)=\"n\" THEN 1760\n1640 PRINT \"THIS IS THE GAME OF 21. AS MANY AS 7 PLAYERS MAY PLAY THE\"\n1650 PRINT \"GAME. ON EACH DEAL, BETS WILL BE ASKED FOR, AND THE\"\n1660 PRINT \"PLAYERS' BETS SHOULD BE TYPED IN. THE CARDS WILL THEN BE\"\n1670 PRINT \"DEALT, AND EACH PLAYER IN TURN PLAYS HIS HAND. THE\"\n1680 PRINT \"FIRST RESPONSE SHOULD BE EITHER 'D', INDICATING THAT THE\"\n1690 PRINT \"PLAYER IS DOUBLING DOWN, 'S', INDICATING THAT HE IS\"\n1700 PRINT \"STANDING, 'H', INDICATING HE WANTS ANOTHER CARD, OR '/',\"\n1710 PRINT \"INDICATING THAT HE WANTS TO SPLIT HIS CARDS. AFTER THE\"\n1720 PRINT \"INITIAL RESPONSE, ALL FURTHER RESPONSES SHOULD BE 'S' OR\"\n1730 PRINT \"'H', UNLESS THE CARDS WERE SPLIT, IN WHICH CASE DOUBLING\"\n1740 PRINT \"DOWN IS AGAIN PERMITTED. IN ORDER TO COLLECT FOR\"\n1750 PRINT \"BLACKJACK, THE INITIAL RESPONSE SHOULD BE 'S'.\"\n1760 PRINT \"NUMBER OF PLAYERS\";\n1770 INPUT N\n1775 PRINT\n1780 IF N<1 OR N>7 OR N>INT(N) THEN 1760\n1790 FOR I=1 TO 8: T(I)=0: NEXT I\n1800 D1=N+1\n1810 IF 2*D1+C>=52 THEN GOSUB 120\n1820 IF C=2 THEN C=C-1\n1830 FOR I=1 TO N: Z(I)=0: NEXT I\n1840 FOR I=1 TO 15: B(I)=0: NEXT I\n1850 FOR I=1 TO 15: Q(I)=0: NEXT I\n1860 FOR I=1 TO 7: S(I)=0: NEXT I\n1870 FOR I=1 TO 15: R(I)=0: NEXT I\n1880 PRINT \"BETS:\"\n1890 FOR I=1 TO N: PRINT \"#\";I;: INPUT Z(I): NEXT I\n1900 FOR I=1 TO N\n1910 IF Z(I)<=0 OR Z(I)>500 THEN 1880\n1920 B(I)=Z(I)\n1930 NEXT I\n1940 PRINT \"PLAYER\";\n1950 FOR I=1 TO N\n1960 PRINT I;\"   \";\n1970 NEXT I\n1980 PRINT \"DEALER\"\n1990 FOR J=1 TO 2\n2000 PRINT TAB(5);\n2010 FOR I=1 TO D1\n2020 GOSUB 100\n2030 P(I,J)=X\n2040 IF J=1 OR I<=N THEN GOSUB 750\n2050 NEXT I\n2060 PRINT\n2070 NEXT J\n2080 FOR I=1 TO D1\n2090 R(I)=2\n2100 NEXT I\n2110 REM--TEST FOR INSURANCE\n2120 IF P(D1,1)>1 THEN 2240\n2130 PRINT \"ANY INSURANCE\";\n2140 INPUT H$\n2150 IF LEFT$(H$,1)<>\"Y\" THEN 2240\n2160 PRINT \"INSURANCE BETS\"\n2170 FOR I=1 TO N: PRINT \"#\";I;: INPUT Z(I): NEXT I\n2180 FOR I=1 TO N\n2190 IF Z(I)<0 OR Z(I)>B(I)/2 THEN 2160\n2200 NEXT I\n2210 FOR I=1 TO N\n2220 S(I)=Z(I)*(3*(-(P(D1,2)>=10))-1)\n2230 NEXT I\n2240 REM--TEST FOR DEALER BLACKJACK\n2250 L1=1: L2=1\n2252 IF P(D1,1)=1 AND P(D1,2)>9 THEN L1=0: L2=0\n2253 IF P(D1,2)=1 AND P(D1,1)>9 THEN L1=0: L2=0\n2254 IF L1<>0 OR L2<>0 THEN 2320\n2260 PRINT:PRINT \"DEALER HAS A\";MID$(D$,3*P(D1,2)-2,3);\" IN THE HOLE \";\n2270 PRINT \"FOR BLACKJACK\"\n2280 FOR I=1 TO D1\n2290 GOSUB 300\n2300 NEXT I\n2310 GOTO 3140\n2320 REM--NO DEALER BLACKJACK\n2330 IF P(D1,1)>1 AND P(D1,1)<10 THEN 2350\n2340 PRINT:PRINT \"NO DEALER BLACKJACK.\"\n2350 REM--NOW PLAY THE HANDS\n2360 FOR I=1 TO N\n2370 PRINT \"PLAYER\";I;\n2380 H1=7\n2390 GOSUB 1410\n2400 ON H GOTO 2550,2410,2510,2600\n2410 REM--PLAYER WANTS TO STAND\n2420 GOSUB 300\n2430 IF Q(I)<>21 THEN 2490\n2440 PRINT \"BLACKJACK\"\n2450 S(I)=S(I)+1.5*B(I)\n2460 B(I)=0\n2470 GOSUB 1200\n2480 GOTO 2900\n2490 GOSUB 1320\n2500 GOTO 2900\n2510 REM--PLAYER WANTS TO DOUBLE DOWN\n2520 GOSUB 300\n2530 GOSUB 860\n2540 GOTO 2900\n2550 REM--PLAYER WANTS TO BE HIT\n2560 GOSUB 300\n2570 H1=3\n2580 GOSUB 950\n2590 GOTO 2900\n2600 REM--PLAYER WANTS TO SPLIT\n2610 L1=P(I,1): IF P(I,1)>10 THEN L1=10\n2612 L2=P(I,2): IF P(I,2)>10 THEN L2=10\n2614 IF L1=L2 THEN 2640\n2620 PRINT \"SPLITTING NOT ALLOWED.\"\n2630 GOTO 2370\n2640 REM--PLAY OUT SPLIT\n2650 I1=I+D1\n2660 R(I1)=2\n2670 P(I1,1)=P(I,2)\n2680 B(I+D1)=B(I)\n2690 GOSUB 100\n2700 PRINT \"FIRST HAND RECEIVES A\";\n2710 GOSUB 700\n2720 P(I,2)=X\n2730 GOSUB 300\n2740 PRINT\n2750 GOSUB 100\n2760 PRINT \"SECOND HAND RECEIVES A\";\n2770 I=I1\n2780 GOSUB 700\n2790 P(I,2)=X\n2800 GOSUB 300\n2810 PRINT\n2820 I=I1-D1\n2830 IF P(I,1)=1 THEN 2900\n2840 REM--NOW PLAY THE TWO HANDS\n2850 PRINT \"HAND\";1-(I>D1);\n2860 GOSUB 800\n2870 I=I+D1\n2880 IF I=I1 THEN 2850\n2890 I=I1-D1\n2900 NEXT I\n2910 GOSUB 300\n2920 REM--TEST FOR PLAYING DEALER'S HAND\n2930 FOR I=1 TO N\n2940 IF R(I)>0 OR R(I+D1)>0 THEN 3010\n2950 NEXT I\n2960 PRINT \"DEALER HAD A\";\n2970 X=P(D1,2)\n2980 GOSUB 700\n2990 PRINT \" CONCEALED.\"\n3000 GOTO 3140\n3010 PRINT \"DEALER HAS A\";MID$(D$,3*P(D1,2)-2,3);\" CONCEALED \";\n3020 I=D1\n3030 AA=Q(I): GOSUB 3400\n3035 PRINT \"FOR A TOTAL OF\";AA\n3040 IF AA>16 THEN 3130\n3050 PRINT \"DRAWS\";\n3060 GOSUB 100\n3070 GOSUB 750\n3080 GOSUB 1100\n3090 AA=Q: GOSUB 3400\n3095 IF Q>0 AND AA<17 THEN 3060\n3100 Q(I)=Q-(Q<0)/2\n3110 IF Q<0 THEN 3140\n3120 AA=Q: GOSUB 3400\n3125 PRINT \"---TOTAL IS\";AA\n3130 PRINT\n3140 REM--TALLY THE RESULT\n3150 REM \n3160 Z$=\"LOSES PUSHES WINS \"\n3165 PRINT\n3170 FOR I=1 TO N\n3180 AA=Q(I): GOSUB 3400\n3182 AB=Q(I+D1): GOSUB 3410\n3184 AC=Q(D1): GOSUB 3420\n3186 S(I)=S(I)+B(I)*SGN(AA-AC)+B(I+D1)*SGN(AB-AC)\n3188 B(I+D1)=0\n3200 PRINT \"PLAYER\";I;\n3210 PRINT MID$(Z$,SGN(S(I))*6+7,6);\" \";\n3220 IF S(I)<>0 THEN 3250\n3230 PRINT \"      \";\n3240 GOTO 3260\n3250 PRINT ABS(S(I));\n3260 T(I)=T(I)+S(I)\n3270 PRINT \"TOTAL=\";T(I)\n3280 GOSUB 1200\n3290 T(D1)=T(D1)-S(I)\n3300 I=I+D1\n3310 GOSUB 1200\n3320 I=I-D1\n3330 NEXT I\n3340 PRINT \"DEALER'S TOTAL=\";T(D1)\n3345 PRINT\n3350 GOSUB 1200\n3360 GOTO 1810\n3400 AA=AA+11*(AA>=22): RETURN\n3410 AB=AB+11*(AB>=22): RETURN\n3420 AC=AC+11*(AC>=22): RETURN";
        }

        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox23.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion black jack

        #region bat num
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text = "10 PRINT TAB(33);\"BATNUM\"\n20 PRINT TAB(15);\"CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY\"\n30 PRINT:PRINT:PRINT\n110 PRINT \"THIS PROGRAM IS A 'BATTLE OF NUMBERS' GAME, WHERE THE\"\n120 PRINT \"COMPUTER IS YOUR OPPONENT.\"\n130 PRINT \n140 PRINT \"THE GAME STARTS WITH AN ASSUMED PILE OF OBJECTS. YOU\"\n150 PRINT \"AND YOUR OPPONENT ALTERNATELY REMOVE OBJECTS FROM THE PILE.\"\n160 PRINT \"WINNING IS DEFINED IN ADVANCE AS TAKING THE LAST OBJECT OR\"\n170 PRINT \"NOT. YOU CAN ALSO SPECIFY SOME OTHER BEGINNING CONDITIONS.\"\n180 PRINT \"DON'T USE ZERO, HOWEVER, IN PLAYING THE GAME.\"\n190 PRINT \"ENTER A NEGATIVE NUMBER FOR NEW PILE SIZE TO STOP PLAYING.\"\n200 PRINT\n210 GOTO 330\n220 FOR I=1 TO 10\n230 PRINT\n240 NEXT I\n330 INPUT \"ENTER PILE SIZE\";N\n350 IF N>=1 THEN 370\n360 GOTO 330\n370 IF N<>INT(N) THEN 220\n380 IF N<1 THEN 220\n390 INPUT \"ENTER WIN OPTION - 1 TO TAKE LAST, 2 TO AVOID LAST: \";M\n410 IF M=1 THEN 430\n420 IF M<>2 THEN 390\n430 INPUT \"ENTER MIN AND MAX \";A,B\n450 IF A>B THEN 430\n460 IF A<1 THEN 430\n470 IF A<>INT(A) THEN 430\n480 IF B<>INT(B) THEN 430\n490 INPUT \"ENTER START OPTION - 1 COMPUTER FIRST, 2 YOU FIRST \";S\n500 PRINT:PRINT\n510 IF S=1 THEN 530\n520 IF S<>2 THEN 490\n530 C=A+B\n540 IF S=2 THEN 570\n550 GOSUB 600\n560 IF W=1 THEN 220\n570 GOSUB 810\n580 IF W=1 THEN 220\n590 GOTO 550\n600 Q=N\n610 IF M=1 THEN 630\n620 Q=Q-1\n630 IF M=1 THEN 680\n640 IF N>A THEN 720\n650 W=1\n660 PRINT \"COMPUTER TAKES\";N;\"AND LOSES.\"\n670 RETURN\n680 IF N>B THEN 720\n690 W=1\n700 PRINT \"COMPUTER TAKES\";N;\"AND WINS.\"\n710 RETURN\n720 P=Q-C*INT(Q/C)\n730 IF P>=A THEN 750\n740 P=A\n750 IF P<=B THEN 770\n760 P=B\n770 N=N-P\n780 PRINT \"COMPUTER TAKES\";P;\"AND LEAVES\";N\n790 W=0\n800 RETURN\n810 PRINT:PRINT \"YOUR MOVE \";\n820 INPUT P\n830 IF P<>0 THEN 870\n840 PRINT \"I TOLD YOU NOT TO USE ZERO! COMPUTER WINS BY FORFEIT.\"\n850 W=1\n860 RETURN\n870 IF P<>INT(P) THEN 920\n880 IF P>=A THEN 910\n890 IF P=N THEN 960\n900 GOTO 920\n910 IF P<=B THEN 940\n920 PRINT \"ILLEGAL MOVE, REENTER IT \";\n930 GOTO 820\n940 N=N-P\n950 IF N<>0 THEN 1030\n960 IF M=1 THEN 1000\n970 PRINT \"TOUGH LUCK, YOU LOSE.\"\n980 W=1\n990 RETURN\n1000 PRINT \"CONGRATULATIONS, YOU WIN.\"\n1010 W=1\n1020 RETURN\n1030 IF N>=0 THEN 1060\n1040 N=N+P\n1050 GOTO 920\n1060 W=0\n1070 RETURN\n1080 END";
            syntaxEditor.Show();
            Parent.Hide();
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.BackgroundImage = Properties.Resources.tile_frame_h;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.BackgroundImage = Properties.Resources.tile_frame;
        }
        #endregion bat num
    }
}
