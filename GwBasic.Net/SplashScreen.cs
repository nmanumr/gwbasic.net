using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GwBasic.Net.Properties;
using Timer = System.Windows.Forms.Timer;

namespace GwBasic.Net
{
    public partial class SplashScreen : Form
    {
        Timer tmr;
        
        public SplashScreen()
        {

            InitializeComponent();

            int duration = 900;//in milliseconds
            int steps = 100;
            Timer timer = new Timer();
            timer.Interval = duration / steps;
            
            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
            
            PictureBox spashPictureBox = new PictureBox();
            spashPictureBox.Image = Resources.splash2;
            spashPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            spashPictureBox.Dock = DockStyle.Fill;
            this.Controls.Add(spashPictureBox);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 2550;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            Form1 mf = new Form1();
            mf.Show();

            this.Hide();
        }

        
        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
