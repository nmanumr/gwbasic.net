using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;


namespace GwBasic.Net
{

    public partial class Form1 : Form
    {
        private About about = new About();
        private bool InfoShown;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #region close
        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            close.Image = Properties.Resources.clsh;
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Close";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.CtrlBtn;
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "";
        }
        #endregion close

        #region max
        private void max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
                this.Refresh();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Refresh();
            }
        }

        private void max_MouseMove(object sender, MouseEventArgs e)
        {
            max.Image = Properties.Resources.minmaxh;
            if (this.WindowState == FormWindowState.Normal)
            {
                status.ForeColor = Color.FromArgb(255, 136, 136, 136);
                status.Text = "Maximize";
            }
            else
            {
                status.ForeColor = Color.FromArgb(255, 136, 136, 136);
                status.Text = "Restore";
            }
        }

        private void max_MouseLeave(object sender, EventArgs e)
        {
            max.Image = Properties.Resources.CtrlBtn;
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "";
        }
        #endregion max

        #region min
        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void min_MouseMove(object sender, MouseEventArgs e)
        {
            min.Image = Properties.Resources.minmaxh;
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Minimize";
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.Image = Properties.Resources.CtrlBtn;
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "";
        }
        #endregion min

        #region write new
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tile_frame_h;
            status.Text = "Write New Program";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tile_frame;
            status.Text = "";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SyntaxEditor syntaxEditor = new SyntaxEditor();
            syntaxEditor.synBox1.Text= "10 REM Start Writing your GW-Basic Code Here: \n20 ";
            syntaxEditor.Show();
            this.Hide();
        }
        #endregion write new

        #region open existing
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.tile_frame_h;
            status.Text = "Open Existing Program";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.tile_frame;
            status.Text = "";
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Documentation not available yet.");
        }
        #endregion  open existing

        #region Console
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start("Console.bat");
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.tile_frame;
            status.Text = "";
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.tile_frame_h;
            status.Text = "Open PcBasic Console";
        }








        #endregion Console

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region About
        private void ShowAbout()
        {
            var pstate = this.WindowState;
            this.Size = new Size(867, 551);
            var xposition = (Screen.PrimaryScreen.WorkingArea.Width - Size.Width) / 2;
            var yposition = (Screen.PrimaryScreen.WorkingArea.Height - Size.Height) / 2;
            this.Location = new Point(xposition, yposition);
            this.Refresh();

            about.Size = this.Size;
            about.StartPosition = FormStartPosition.CenterScreen;
            about.WindowState = pstate;

            about.Show();
            InfoShown = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = Properties.Resources.info_h;
            status.Text = "Info";
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.info;
            status.Text = "";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (InfoShown)
            {
                about.Activate();
            }
        }
        #endregion About

        private void miniTimer_LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(miniTimer_LinkLabel2.Text);
        }
    }
}
