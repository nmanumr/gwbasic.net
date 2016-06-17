using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GwBasic.Net
{
    public partial class About : Form
    {
        public About()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (pictureBox1.Width / 2),
                             pictureBox1.Location.Y);
            pictureBox1.Refresh();
        }

        
        private void About_Load(object sender, EventArgs e)
        {
            Opacity = .9;
        }

        private void miniTimer_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

        }
    }
}
