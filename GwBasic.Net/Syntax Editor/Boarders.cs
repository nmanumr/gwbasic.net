using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace GwBasic.Net
{
    partial class SyntaxEditor
    {
        private const int CS_DROPSHADOW = 0x00020000;

        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private int VIRTUALBORDER = 3;
        private bool SHOWVIRTUALBORDERS = true;

        // Declare the limits for the form size
        private int MINHEIGHT = 10;
        private int MINWIDTH = 200;


        private Point RESIZESTART;
        private Point RESIZEDESTINATION;
        private Point MOUSEPOS;

        // Define Rectangles & Booleans for all 9 + 1 areas of the Form.
        private Rectangle R0;
        private Rectangle R1;
        private Rectangle R2;
        private Rectangle R3;
        private Rectangle R4;
        private Rectangle R5;
        private Rectangle R6;
        private Rectangle R7;
        private Rectangle R8;
        private Rectangle R9;


        // Bool to determine if the form is being moved (True when the form is clicked in the center area (R5))
        private bool ISMOVING;

        // Bool to determine if the form is being rezised (True when the form is clicked in all areas except the center (R5))
        private bool ISREZISING;

        // Bool's to determine in which direction the form is moving
        private bool ISRESIZINGLEFT;
        private bool ISRESIZINGRIGHT;

        private bool ISRESIZINGTOP;
        private bool ISRESIZINGBOTTOM;

        private bool ISRESIZINGTOPRIGHT;
        private bool ISRESIZINGTOPLEFT;

        private bool ISRESIZINGBOTTOMRIGHT;
        private bool ISRESIZINGBOTTOMLEFT;


        /*
        
          
          
                Y
          
                |
                |
                |
                |     
                |                                                                           
   X   ---------|------------------------------------------------------------------------   X
                |                                                                          
                |    <-------------------------- R0 ----------------------------->
                |
                |
                |    |-----------------------------------------------------------|  
                |    | R1 |                      R2                         | R3 |
                |    |-----------------------------------------------------------|
                |    |    |                                                 |    |
                |    |    |                                                 |    |
                |    | R4 |                      R5                         | R6 |
                |    |    |                                                 |    |
                |    |    |                                                 |    |
                |    |-----------------------------------------------------------|  
                |    | R7 |                      R8                         | R9 |
                |    |-----------------------------------------------------------|
                |
                |
                |
                |
          
                Y                                                                                                                           */

        #region Default Instance

        private static Form1 defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Form1 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Form1();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Every time the form paints, set the location and size of the form areas...
            #region DIVIDE THE FORM INTO 9 SUB AREAS
            R1 = new Rectangle(new Point(ClientRectangle.X, ClientRectangle.Y), new Size(VIRTUALBORDER, VIRTUALBORDER));
            R2 = new Rectangle(new Point(ClientRectangle.X + R1.Width, ClientRectangle.Y), new Size(ClientRectangle.Width - (R1.Width * 2), R1.Height));
            R3 = new Rectangle(new Point(ClientRectangle.X + R1.Width + R2.Width, ClientRectangle.Y), new Size(VIRTUALBORDER, VIRTUALBORDER));

            R4 = new Rectangle(new Point(ClientRectangle.X, ClientRectangle.Y + R1.Height), new Size(R1.Width, ClientRectangle.Height - (R1.Width * 2)));
            R5 = new Rectangle(new Point(ClientRectangle.X + R4.Width, ClientRectangle.Y + R1.Height), new Size(R2.Width, R4.Height));
            R6 = new Rectangle(new Point(ClientRectangle.X + R4.Width + R5.Width, ClientRectangle.Y + R1.Height), new Size(R3.Width, R4.Height));

            R7 = new Rectangle(new Point(ClientRectangle.X, ClientRectangle.Y + R1.Height + R4.Height), new Size(VIRTUALBORDER, VIRTUALBORDER));
            R8 = new Rectangle(new Point(ClientRectangle.X + R7.Width, ClientRectangle.Y + R1.Height + R4.Height), new Size(ClientRectangle.Width - (R7.Width * 2), R7.Height));
            R9 = new Rectangle(new Point(ClientRectangle.X + R7.Width + R8.Width, ClientRectangle.Y + R1.Height + R4.Height), new Size(VIRTUALBORDER, VIRTUALBORDER));
            #endregion


            #region SET FILL COLORS FOR THE VIRTUAL BORDER
            if (SHOWVIRTUALBORDERS)
            {
                Graphics GFX = e.Graphics;
                GFX.FillRectangle(Brushes.White, R5);

                GFX.FillRectangle(Brushes.LightGray, R1);
                GFX.FillRectangle(Brushes.LightGray, R3);
                GFX.FillRectangle(Brushes.LightGray, R7);
                GFX.FillRectangle(Brushes.LightGray, R9);

                GFX.FillRectangle(Brushes.LightGray, R2);
                GFX.FillRectangle(Brushes.LightGray, R8);
                GFX.FillRectangle(Brushes.LightGray, R4);
                GFX.FillRectangle(Brushes.LightGray, R6);
            }
            #endregion
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (R1.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGTOPLEFT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R2.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGTOP = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R3.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGTOPRIGHT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R4.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGLEFT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R5.Contains(MOUSEPOS))
                    {
                        // If the center area of the form is pressed (R5), then we should be able to move the form.
                        ISMOVING = true;
                        ISREZISING = false;
                        MOUSEPOS = new Point(e.X, e.Y);
                        Cursor = Cursors.SizeAll;
                    }
                    if (R6.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGRIGHT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R7.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGBOTTOMLEFT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R8.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGBOTTOM = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    if (R9.Contains(MOUSEPOS))
                    {
                        ISREZISING = true;
                        ISRESIZINGBOTTOMRIGHT = true;
                        RESIZESTART = PointToScreen(new Point(e.X, e.Y));
                    }
                    break;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            RESIZEDESTINATION = PointToScreen(new Point(e.X, e.Y));
            R0 = Bounds;

            // If the form has captured the mouse...
            if (Capture)
            {
                if (ISMOVING)
                {
                    ISREZISING = false;
                    // ISMOVING is true if the R5 rectangle is pressed. Allow the form to be moved around the screen.
                    Location = new Point(MousePosition.X - MOUSEPOS.X, MousePosition.Y - MOUSEPOS.Y);
                }
                if (ISREZISING)
                {
                    ISMOVING = false;

                    if (ISRESIZINGTOPLEFT)
                    { Bounds = new Rectangle(R0.X + RESIZEDESTINATION.X - RESIZESTART.X, R0.Y + RESIZEDESTINATION.Y - RESIZESTART.Y, R0.Width - RESIZEDESTINATION.X + RESIZESTART.X, R0.Height - RESIZEDESTINATION.Y + RESIZESTART.Y); }
                    if (ISRESIZINGTOP)
                    { Bounds = new Rectangle(R0.X, R0.Y + RESIZEDESTINATION.Y - RESIZESTART.Y, R0.Width, R0.Height - RESIZEDESTINATION.Y + RESIZESTART.Y); }
                    if (ISRESIZINGTOPRIGHT)
                    { Bounds = new Rectangle(R0.X, R0.Y + RESIZEDESTINATION.Y - RESIZESTART.Y, R0.Width + RESIZEDESTINATION.X - RESIZESTART.X, R0.Height - RESIZEDESTINATION.Y + RESIZESTART.Y); }
                    if (ISRESIZINGLEFT)
                    { Bounds = new Rectangle(R0.X + RESIZEDESTINATION.X - RESIZESTART.X, R0.Y, R0.Width - RESIZEDESTINATION.X + RESIZESTART.X, R0.Height); }
                    if (ISRESIZINGRIGHT)
                    { Bounds = new Rectangle(R0.X, R0.Y, R0.Width + RESIZEDESTINATION.X - RESIZESTART.X, R0.Height); }
                    if (ISRESIZINGBOTTOMLEFT)
                    { Bounds = new Rectangle(R0.X + RESIZEDESTINATION.X - RESIZESTART.X, R0.Y, R0.Width - RESIZEDESTINATION.X + RESIZESTART.X, R0.Height + RESIZEDESTINATION.Y - RESIZESTART.Y); }
                    if (ISRESIZINGBOTTOM)
                    { Bounds = new Rectangle(R0.X, R0.Y, R0.Width, R0.Height + RESIZEDESTINATION.Y - RESIZESTART.Y); }
                    if (ISRESIZINGBOTTOMRIGHT)
                    { Bounds = new Rectangle(R0.X, R0.Y, R0.Width + RESIZEDESTINATION.X - RESIZESTART.X, R0.Height + RESIZEDESTINATION.Y - RESIZESTART.Y); }

                    RESIZESTART = RESIZEDESTINATION;
                    Invalidate();
                }
            }

            // If the form has not captured the mouse; the mouse is just hovering the form...
            else
            {
                MOUSEPOS = new Point(e.X, e.Y);

                // Changes Cursor depending where the mousepointer is at the form...
                if (R1.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNWSE; }
                if (R2.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNS; }
                if (R3.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNESW; }
                if (R4.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeWE; }
                if (R5.Contains(MOUSEPOS))
                { Cursor = Cursors.Default; }
                if (R6.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeWE; }
                if (R7.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNESW; }
                if (R8.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNS; }
                if (R9.Contains(MOUSEPOS))
                { Cursor = Cursors.SizeNWSE; }
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //CODE TO LIMIT THE SIZE OF THE FORM
            if (Height < MINHEIGHT)
            {
                Capture = false;
                Height = MINHEIGHT;
            }
            if (Width < MINWIDTH)
            {
                Capture = false;
                Width = MINWIDTH;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ISMOVING = false;
            ISREZISING = false;

            ISRESIZINGLEFT = false;
            ISRESIZINGRIGHT = false;

            ISRESIZINGTOP = false;
            ISRESIZINGBOTTOM = false;

            ISRESIZINGTOPRIGHT = false;
            ISRESIZINGTOPLEFT = false;

            ISRESIZINGBOTTOMRIGHT = false;
            ISRESIZINGBOTTOMLEFT = false;

            Invalidate();
        }
    }
}
