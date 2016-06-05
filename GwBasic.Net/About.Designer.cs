namespace GwBasic.Net
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniTimer_LinkLabel1 = new MiniTimer_Theme.MiniTimer_LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::GwBasic.Net.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 551);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // miniTimer_LinkLabel1
            // 
            this.miniTimer_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(134)))), ((int)(((byte)(158)))));
            this.miniTimer_LinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniTimer_LinkLabel1.AutoSize = true;
            this.miniTimer_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.miniTimer_LinkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.miniTimer_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.miniTimer_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(172)))));
            this.miniTimer_LinkLabel1.Location = new System.Drawing.Point(799, 23);
            this.miniTimer_LinkLabel1.Name = "miniTimer_LinkLabel1";
            this.miniTimer_LinkLabel1.Size = new System.Drawing.Size(39, 16);
            this.miniTimer_LinkLabel1.TabIndex = 1;
            this.miniTimer_LinkLabel1.TabStop = true;
            this.miniTimer_LinkLabel1.Text = "Close";
            this.miniTimer_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(172)))));
            this.miniTimer_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.miniTimer_LinkLabel1_LinkClicked);
            // 
            // About
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GwBasic.Net.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(867, 551);
            this.Controls.Add(this.miniTimer_LinkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MiniTimer_Theme.MiniTimer_LinkLabel miniTimer_LinkLabel1;
    }
}