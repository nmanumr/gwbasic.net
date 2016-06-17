using System.Windows.Forms;
using System;
using System.Drawing;
using FastColoredTextBoxNS;
using MiniTimer_Theme;

namespace GwBasic.Net
{
    partial class SyntaxEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyntaxEditor));
            this.synBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btInvisibleChars = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.setSelectedAsReadOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSelectedAsWritableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uncommentCurrentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.startStopMacroRecordingCtrlMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeMacroCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutSyntaxEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.currentCol = new System.Windows.Forms.Label();
            this.CurrentLine = new System.Windows.Forms.Label();
            this.ZoomIn = new System.Windows.Forms.Label();
            this.ZoomOut = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.miniTimer_LinkLabel1 = new MiniTimer_Theme.MiniTimer_LinkLabel();
            this.status = new MiniTimer_Theme.MiniTimer_Label();
            this.vMyScrollBar = new GwBasic.Net.MyScrollBar();
            this.hMyScrollBar = new GwBasic.Net.MyScrollBar();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentCurrentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.max = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.Print = new System.Windows.Forms.ToolStripButton();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.btHighlightCurrentLine = new System.Windows.Forms.ToolStripButton();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.synBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // synBox1
            // 
            this.synBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.synBox1.AutoCompleteBrackets = true;
            this.synBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"'};
            this.synBox1.AutoIndent = false;
            this.synBox1.AutoIndentChars = false;
            this.synBox1.AutoIndentCharsPatterns = "";
            this.synBox1.AutoScrollMinSize = new System.Drawing.Size(2, 15);
            this.synBox1.BackBrush = null;
            this.synBox1.CharHeight = 15;
            this.synBox1.CharWidth = 7;
            this.synBox1.CommentPrefix = "REM";
            this.synBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.synBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.synBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.synBox1.IsReplaceMode = false;
            this.synBox1.LeftBracket = '(';
            this.synBox1.LeftBracket2 = '[';
            this.synBox1.Location = new System.Drawing.Point(4, 89);
            this.synBox1.Name = "synBox1";
            this.synBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.synBox1.RightBracket = ')';
            this.synBox1.RightBracket2 = ']';
            this.synBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.synBox1.ServiceColors = null;
            this.synBox1.ShowLineNumbers = false;
            this.synBox1.ShowScrollBars = false;
            this.synBox1.Size = new System.Drawing.Size(840, 398);
            this.synBox1.TabIndex = 0;
            this.synBox1.Zoom = 100;
            this.synBox1.ToolTipNeeded += new System.EventHandler<FastColoredTextBoxNS.ToolTipNeededEventArgs>(this.synBox1_ToolTipNeeded);
            this.synBox1.SelectionChanged += new System.EventHandler(this.synBox1_SelectionChanged);
            this.synBox1.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChangedDelayed);
            this.synBox1.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.synBox1_KeyPressed);
            this.synBox1.ScrollbarsUpdated += new System.EventHandler(this.synBox1_ScrollbarsUpdated);
            this.synBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.synBox1_DragDrop);
            this.synBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.synBox1_DragEnter);
            this.synBox1.DoubleClick += new System.EventHandler(this.synBox1_DoubleClick);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar.Location = new System.Drawing.Point(591, 107);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 294);
            this.vScrollBar.TabIndex = 8;
            this.vScrollBar.Visible = false;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar.Location = new System.Drawing.Point(41, 443);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(457, 17);
            this.hScrollBar.TabIndex = 9;
            this.hScrollBar.Visible = false;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.toolStripButton6,
            this.Print,
            this.toolStripSeparator4,
            this.Cut,
            this.Copy,
            this.Paste,
            this.toolStripSeparator5,
            this.btInvisibleChars,
            this.btHighlightCurrentLine,
            this.toolStripSeparator6,
            this.Undo,
            this.Redo,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator9,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator16,
            this.toolStripButton5,
            this.toolStripSeparator15,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator17,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator18,
            this.toolStripButton11,
            this.toolStripButton12});
            this.toolStrip1.Location = new System.Drawing.Point(9, 62);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btInvisibleChars
            // 
            this.btInvisibleChars.AutoToolTip = false;
            this.btInvisibleChars.CheckOnClick = true;
            this.btInvisibleChars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btInvisibleChars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInvisibleChars.Name = "btInvisibleChars";
            this.btInvisibleChars.Size = new System.Drawing.Size(23, 22);
            this.btInvisibleChars.Text = "¶";
            this.btInvisibleChars.Click += new System.EventHandler(this.btInvisibleChars_Click);
            this.btInvisibleChars.MouseLeave += new System.EventHandler(this.btInvisibleChars_MouseLeave);
            this.btInvisibleChars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btInvisibleChars_MouseMove);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(522, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(175, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator11,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator12,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator14,
            this.setSelectedAsReadOnlyToolStripMenuItem,
            this.setSelectedAsWritableToolStripMenuItem,
            this.toolStripSeparator10,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator2,
            this.commentCurrentLineToolStripMenuItem,
            this.uncommentCurrentLineToolStripMenuItem,
            this.toolStripSeparator13,
            this.startStopMacroRecordingCtrlMToolStripMenuItem,
            this.executeMacroCtrlEToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(264, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.cutToolStripMenuItem.Text = "Cut [Ctrl+X]";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(264, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.selectAllToolStripMenuItem.Text = "Select All [Ctrl+A]";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(264, 6);
            // 
            // setSelectedAsReadOnlyToolStripMenuItem
            // 
            this.setSelectedAsReadOnlyToolStripMenuItem.Name = "setSelectedAsReadOnlyToolStripMenuItem";
            this.setSelectedAsReadOnlyToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.setSelectedAsReadOnlyToolStripMenuItem.Text = "Set Selected as Read Only";
            this.setSelectedAsReadOnlyToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsReadOnlyToolStripMenuItem_Click);
            // 
            // setSelectedAsWritableToolStripMenuItem
            // 
            this.setSelectedAsWritableToolStripMenuItem.Name = "setSelectedAsWritableToolStripMenuItem";
            this.setSelectedAsWritableToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.setSelectedAsWritableToolStripMenuItem.Text = "Set selected as writable";
            this.setSelectedAsWritableToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsWritableToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(264, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // uncommentCurrentLineToolStripMenuItem
            // 
            this.uncommentCurrentLineToolStripMenuItem.Name = "uncommentCurrentLineToolStripMenuItem";
            this.uncommentCurrentLineToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.uncommentCurrentLineToolStripMenuItem.Text = "Uncomment Current Line";
            this.uncommentCurrentLineToolStripMenuItem.Click += new System.EventHandler(this.uncommentCurrentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(264, 6);
            // 
            // startStopMacroRecordingCtrlMToolStripMenuItem
            // 
            this.startStopMacroRecordingCtrlMToolStripMenuItem.Name = "startStopMacroRecordingCtrlMToolStripMenuItem";
            this.startStopMacroRecordingCtrlMToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.startStopMacroRecordingCtrlMToolStripMenuItem.Text = "Start/Stop macro recording [Ctrl+M]";
            this.startStopMacroRecordingCtrlMToolStripMenuItem.Click += new System.EventHandler(this.startStopMacroRecordingCtrlMToolStripMenuItem_Click);
            // 
            // executeMacroCtrlEToolStripMenuItem
            // 
            this.executeMacroCtrlEToolStripMenuItem.Name = "executeMacroCtrlEToolStripMenuItem";
            this.executeMacroCtrlEToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.executeMacroCtrlEToolStripMenuItem.Text = "Execute macro [Ctrl+E]";
            this.executeMacroCtrlEToolStripMenuItem.Click += new System.EventHandler(this.executeMacroCtrlEToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToHTMLToolStripMenuItem,
            this.exportToRTFToolStripMenuItem,
            this.toolStripSeparator3});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // exportToHTMLToolStripMenuItem
            // 
            this.exportToHTMLToolStripMenuItem.Name = "exportToHTMLToolStripMenuItem";
            this.exportToHTMLToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToHTMLToolStripMenuItem.Text = "Export to HTML";
            this.exportToHTMLToolStripMenuItem.Click += new System.EventHandler(this.exportToHTMLToolStripMenuItem_Click);
            // 
            // exportToRTFToolStripMenuItem
            // 
            this.exportToRTFToolStripMenuItem.Name = "exportToRTFToolStripMenuItem";
            this.exportToRTFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToRTFToolStripMenuItem.Text = "Export to RTF";
            this.exportToRTFToolStripMenuItem.Click += new System.EventHandler(this.exportToRTFToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortKeysToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutSyntaxEditorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // shortKeysToolStripMenuItem
            // 
            this.shortKeysToolStripMenuItem.Name = "shortKeysToolStripMenuItem";
            this.shortKeysToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.shortKeysToolStripMenuItem.Text = "Shortcut Keys";
            this.shortKeysToolStripMenuItem.Click += new System.EventHandler(this.shortKeysToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(175, 6);
            // 
            // aboutSyntaxEditorToolStripMenuItem
            // 
            this.aboutSyntaxEditorToolStripMenuItem.Name = "aboutSyntaxEditorToolStripMenuItem";
            this.aboutSyntaxEditorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutSyntaxEditorToolStripMenuItem.Text = "About Syntax Editor";
            this.aboutSyntaxEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutSyntaxEditorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // currentCol
            // 
            this.currentCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentCol.AutoSize = true;
            this.currentCol.BackColor = System.Drawing.Color.White;
            this.currentCol.Location = new System.Drawing.Point(64, 490);
            this.currentCol.Name = "currentCol";
            this.currentCol.Size = new System.Drawing.Size(46, 13);
            this.currentCol.TabIndex = 22;
            this.currentCol.Text = "Col: 000";
            // 
            // CurrentLine
            // 
            this.CurrentLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentLine.AutoSize = true;
            this.CurrentLine.BackColor = System.Drawing.Color.White;
            this.CurrentLine.Location = new System.Drawing.Point(6, 490);
            this.CurrentLine.Name = "CurrentLine";
            this.CurrentLine.Size = new System.Drawing.Size(51, 13);
            this.CurrentLine.TabIndex = 23;
            this.CurrentLine.Text = "Line: 000";
            // 
            // ZoomIn
            // 
            this.ZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomIn.AutoSize = true;
            this.ZoomIn.BackColor = System.Drawing.Color.White;
            this.ZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomIn.Location = new System.Drawing.Point(813, 490);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(13, 13);
            this.ZoomIn.TabIndex = 24;
            this.ZoomIn.Text = "+";
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            this.ZoomIn.MouseLeave += new System.EventHandler(this.ZoomIn_MouseLeave);
            this.ZoomIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZoomIn_MouseMove);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomOut.AutoSize = true;
            this.ZoomOut.BackColor = System.Drawing.Color.White;
            this.ZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomOut.Location = new System.Drawing.Point(832, 490);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(10, 13);
            this.ZoomOut.TabIndex = 25;
            this.ZoomOut.Text = "-";
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            this.ZoomOut.MouseLeave += new System.EventHandler(this.ZoomOut_MouseLeave);
            this.ZoomOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZoomOut_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "function.png");
            this.imageList1.Images.SetKeyName(1, "Staement.png");
            this.imageList1.Images.SetKeyName(2, "Variable.png");
            this.imageList1.Images.SetKeyName(3, "Command.png");
            this.imageList1.Images.SetKeyName(4, "Action.png");
            // 
            // miniTimer_LinkLabel1
            // 
            this.miniTimer_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(134)))), ((int)(((byte)(158)))));
            this.miniTimer_LinkLabel1.AutoSize = true;
            this.miniTimer_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.miniTimer_LinkLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.miniTimer_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.miniTimer_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(172)))));
            this.miniTimer_LinkLabel1.Location = new System.Drawing.Point(18, 20);
            this.miniTimer_LinkLabel1.Name = "miniTimer_LinkLabel1";
            this.miniTimer_LinkLabel1.Size = new System.Drawing.Size(196, 16);
            this.miniTimer_LinkLabel1.TabIndex = 18;
            this.miniTimer_LinkLabel1.TabStop = true;
            this.miniTimer_LinkLabel1.Text = "GwBasic.Net Syntax Editor (Beta)";
            this.miniTimer_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(172)))));
            this.miniTimer_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.miniTimer_LinkLabel1_LinkClicked);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.Control;
            this.status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.status.Location = new System.Drawing.Point(17, 517);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 16);
            this.status.TabIndex = 2;
            // 
            // vMyScrollBar
            // 
            this.vMyScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vMyScrollBar.BackColor = System.Drawing.Color.White;
            this.vMyScrollBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vMyScrollBar.BorderColor = System.Drawing.Color.Transparent;
            this.vMyScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vMyScrollBar.Location = new System.Drawing.Point(849, 107);
            this.vMyScrollBar.Maximum = 90;
            this.vMyScrollBar.Name = "vMyScrollBar";
            this.vMyScrollBar.Orientation = System.Windows.Forms.ScrollOrientation.VerticalScroll;
            this.vMyScrollBar.Size = new System.Drawing.Size(12, 364);
            this.vMyScrollBar.TabIndex = 6;
            this.vMyScrollBar.Text = "myScrollBar1";
            this.vMyScrollBar.ThumbColor = System.Drawing.Color.LightGray;
            this.vMyScrollBar.ThumbSize = 20;
            this.vMyScrollBar.Value = 0;
            this.vMyScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // hMyScrollBar
            // 
            this.hMyScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hMyScrollBar.BackColor = System.Drawing.Color.White;
            this.hMyScrollBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hMyScrollBar.BorderColor = System.Drawing.Color.Transparent;
            this.hMyScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hMyScrollBar.Location = new System.Drawing.Point(127, 491);
            this.hMyScrollBar.Maximum = 100;
            this.hMyScrollBar.Name = "hMyScrollBar";
            this.hMyScrollBar.Orientation = System.Windows.Forms.ScrollOrientation.HorizontalScroll;
            this.hMyScrollBar.Size = new System.Drawing.Size(662, 12);
            this.hMyScrollBar.TabIndex = 7;
            this.hMyScrollBar.Text = "myScrollBar2";
            this.hMyScrollBar.ThumbColor = System.Drawing.Color.LightGray;
            this.hMyScrollBar.ThumbSize = 20;
            this.hMyScrollBar.Value = 0;
            this.hMyScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            this.hMyScrollBar.MouseLeave += new System.EventHandler(this.hMyScrollBar_MouseLeave);
            this.hMyScrollBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hMyScrollBar_MouseMove);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.layer__plus;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New [Ctrl+N]";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Untitled;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.fileprint;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.printToolStripMenuItem.Text = "Print..";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.undo_16x16;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.undoToolStripMenuItem.Text = "Undo [Ctrl+Z]";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.redo_16x16;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.redoToolStripMenuItem.Text = "Redo [Ctrl+R]";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Untitled_3;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.copyToolStripMenuItem.Text = "Copy [Ctrl+C]";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Untitled_4;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.pasteToolStripMenuItem.Text = "Paste [Ctrl+V]";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.search_icon;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.findToolStripMenuItem.Text = "Find [Ctrl+F]...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Untitled_8;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.replaceToolStripMenuItem.Text = "Replace [Ctrl+H]...";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // commentCurrentLineToolStripMenuItem
            // 
            this.commentCurrentLineToolStripMenuItem.Image = global::GwBasic.Net.Properties.Resources.Untitled_2;
            this.commentCurrentLineToolStripMenuItem.Name = "commentCurrentLineToolStripMenuItem";
            this.commentCurrentLineToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.commentCurrentLineToolStripMenuItem.Text = "Comment Current Line";
            this.commentCurrentLineToolStripMenuItem.Click += new System.EventHandler(this.commentCurrentLineToolStripMenuItem_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::GwBasic.Net.Properties.Resources.Home;
            this.pictureBox9.Location = new System.Drawing.Point(788, 516);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox9_MouseLeave);
            this.pictureBox9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox9_MouseMove);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Gainsboro;
            this.close.Image = global::GwBasic.Net.Properties.Resources.CtrlBtn;
            this.close.Location = new System.Drawing.Point(832, 22);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 14);
            this.close.TabIndex = 21;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.Image = global::GwBasic.Net.Properties.Resources.CtrlBtn;
            this.max.Location = new System.Drawing.Point(812, 22);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(14, 14);
            this.max.TabIndex = 20;
            this.max.TabStop = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            this.max.MouseLeave += new System.EventHandler(this.max_MouseLeave);
            this.max.MouseMove += new System.Windows.Forms.MouseEventHandler(this.max_MouseMove);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Image = global::GwBasic.Net.Properties.Resources.CtrlBtn;
            this.min.Location = new System.Drawing.Point(791, 22);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(14, 14);
            this.min.TabIndex = 19;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            this.min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.min_MouseMove);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox8.Location = new System.Drawing.Point(1, 56);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(879, 1);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::GwBasic.Net.Properties.Resources.LT;
            this.pictureBox6.Location = new System.Drawing.Point(112, 490);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(13, 13);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::GwBasic.Net.Properties.Resources.RG;
            this.pictureBox5.Location = new System.Drawing.Point(795, 490);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 13);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::GwBasic.Net.Properties.Resources.DN;
            this.pictureBox4.Location = new System.Drawing.Point(849, 474);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 13);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::GwBasic.Net.Properties.Resources.UP;
            this.pictureBox3.Location = new System.Drawing.Point(849, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 13);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // New
            // 
            this.New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New.Image = global::GwBasic.Net.Properties.Resources.doc;
            this.New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(23, 22);
            this.New.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.New.MouseLeave += new System.EventHandler(this.New_MouseLeave);
            this.New.MouseMove += new System.Windows.Forms.MouseEventHandler(this.New_MouseMove);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = global::GwBasic.Net.Properties.Resources.Open1;
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.Open.MouseLeave += new System.EventHandler(this.Open_MouseLeave);
            this.Open.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Open_MouseMove);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = global::GwBasic.Net.Properties.Resources.save___Copy;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.MouseLeave += new System.EventHandler(this.Save_MouseLeave);
            this.Save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Save_MouseMove);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::GwBasic.Net.Properties.Resources.save_as;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            this.toolStripButton6.MouseLeave += new System.EventHandler(this.toolStripButton6_MouseLeave);
            this.toolStripButton6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton6_MouseMove);
            // 
            // Print
            // 
            this.Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Print.Image = global::GwBasic.Net.Properties.Resources.fileprint;
            this.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(23, 22);
            this.Print.Click += new System.EventHandler(this.Print_Click);
            this.Print.MouseLeave += new System.EventHandler(this.Print_MouseLeave);
            this.Print.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Print_MouseMove);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Image = global::GwBasic.Net.Properties.Resources.cut1;
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(23, 22);
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            this.Cut.MouseLeave += new System.EventHandler(this.Cut_MouseLeave);
            this.Cut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cut_MouseMove);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = global::GwBasic.Net.Properties.Resources.Copy1;
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(23, 22);
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            this.Copy.MouseLeave += new System.EventHandler(this.Copy_MouseLeave);
            this.Copy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Copy_MouseMove);
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = global::GwBasic.Net.Properties.Resources.Paste1;
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            this.Paste.MouseLeave += new System.EventHandler(this.Paste_MouseLeave);
            this.Paste.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paste_MouseMove);
            // 
            // btHighlightCurrentLine
            // 
            this.btHighlightCurrentLine.Checked = true;
            this.btHighlightCurrentLine.CheckOnClick = true;
            this.btHighlightCurrentLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btHighlightCurrentLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btHighlightCurrentLine.Image = global::GwBasic.Net.Properties.Resources.edit_padding_top;
            this.btHighlightCurrentLine.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btHighlightCurrentLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHighlightCurrentLine.Name = "btHighlightCurrentLine";
            this.btHighlightCurrentLine.Size = new System.Drawing.Size(23, 22);
            this.btHighlightCurrentLine.Click += new System.EventHandler(this.btHighlightCurrentLine_Click);
            this.btHighlightCurrentLine.MouseLeave += new System.EventHandler(this.btHighlightCurrentLine_MouseLeave);
            this.btHighlightCurrentLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btHighlightCurrentLine_MouseMove);
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = global::GwBasic.Net.Properties.Resources.Undo5;
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(23, 22);
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            this.Undo.MouseLeave += new System.EventHandler(this.Undo_MouseLeave);
            this.Undo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Undo_MouseMove);
            // 
            // Redo
            // 
            this.Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Redo.Image = global::GwBasic.Net.Properties.Resources.redo3;
            this.Redo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(23, 22);
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            this.Redo.MouseLeave += new System.EventHandler(this.Redo_MouseLeave);
            this.Redo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Redo_MouseMove);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GwBasic.Net.Properties.Resources.Untitled_2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            this.toolStripButton1.MouseLeave += new System.EventHandler(this.toolStripButton1_MouseLeave);
            this.toolStripButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseMove);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::GwBasic.Net.Properties.Resources.Untitled_6;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);
            this.toolStripButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton2_MouseMove);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::GwBasic.Net.Properties.Resources.Untitled_7;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            this.toolStripButton3.MouseLeave += new System.EventHandler(this.toolStripButton3_MouseLeave);
            this.toolStripButton3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton3_MouseMove);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::GwBasic.Net.Properties.Resources.Untitled_8;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            this.toolStripButton4.MouseLeave += new System.EventHandler(this.toolStripButton4_MouseLeave);
            this.toolStripButton4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton4_MouseMove);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoToolTip = false;
            this.toolStripButton5.Image = global::GwBasic.Net.Properties.Resources.run___Copy;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(116, 22);
            this.toolStripButton5.Text = "Execute Program";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            this.toolStripButton5.MouseLeave += new System.EventHandler(this.toolStripButton5_MouseLeave);
            this.toolStripButton5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton5_MouseMove);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::GwBasic.Net.Properties.Resources.rtf;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            this.toolStripButton7.MouseLeave += new System.EventHandler(this.toolStripButton7_MouseLeave);
            this.toolStripButton7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton7_MouseMove);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::GwBasic.Net.Properties.Resources.html;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            this.toolStripButton8.MouseLeave += new System.EventHandler(this.toolStripButton8_MouseLeave);
            this.toolStripButton8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton8_MouseMove);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::GwBasic.Net.Properties.Resources.text_field_read_only;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            this.toolStripButton9.MouseLeave += new System.EventHandler(this.toolStripButton9_MouseLeave);
            this.toolStripButton9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton9_MouseMove);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = global::GwBasic.Net.Properties.Resources.edit;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            this.toolStripButton10.MouseLeave += new System.EventHandler(this.toolStripButton10_MouseLeave);
            this.toolStripButton10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton10_MouseMove);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.DoubleClickEnabled = true;
            this.toolStripButton11.Image = global::GwBasic.Net.Properties.Resources.record;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "toolStripButton11";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            this.toolStripButton11.MouseLeave += new System.EventHandler(this.toolStripButton11_MouseLeave);
            this.toolStripButton11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton11_MouseMove);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = global::GwBasic.Net.Properties.Resources.application_run_icon_1004203643;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "toolStripButton12";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            this.toolStripButton12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton12_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::GwBasic.Net.Properties.Resources.sweet_slim_scrollbar_ui_set_psd_54_112091;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::GwBasic.Net.Properties.Resources.sweet_slim_scrollbar_ui_set_psd_54_112091;
            this.pictureBox2.Location = new System.Drawing.Point(847, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 398);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GwBasic.Net.Properties.Resources.sweet_slim_scrollbar_ui_set_psd_54_112092;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GwBasic.Net.Properties.Resources.sweet_slim_scrollbar_ui_set_psd_54_112092;
            this.pictureBox1.Location = new System.Drawing.Point(3, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 17);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::GwBasic.Net.Properties.Resources.info;
            this.pictureBox10.Location = new System.Drawing.Point(817, 516);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave);
            this.pictureBox10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox10_MouseMove);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::GwBasic.Net.Properties.Resources.footer;
            this.pictureBox7.Location = new System.Drawing.Point(3, 505);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(861, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // SyntaxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 551);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.CurrentLine);
            this.Controls.Add(this.close);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.miniTimer_LinkLabel1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.vMyScrollBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hMyScrollBar);
            this.Controls.Add(this.currentCol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.synBox1);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "SyntaxEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GwBasic.Net Syntax Editor";
            this.Activated += new System.EventHandler(this.SyntaxEditor_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SyntaxEditor_FormClosed_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SyntaxEditor_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.synBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VScrollBar vScrollBar;
        private HScrollBar hScrollBar;
        public FastColoredTextBox synBox1;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem commentCurrentLineToolStripMenuItem;
        private ToolStripMenuItem uncommentCurrentLineToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton New;
        private ToolStripButton Open;
        private ToolStripButton Save;
        private ToolStripButton Print;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Cut;
        private ToolStripButton Copy;
        private ToolStripButton Paste;
        private ToolStripButton btHighlightCurrentLine;
        private ToolStripButton btInvisibleChars;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton Undo;
        private ToolStripButton Redo;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem aboutSyntaxEditorToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem exportToHTMLToolStripMenuItem;
        private ToolStripMenuItem exportToRTFToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private MyScrollBar vMyScrollBar;
        private MyScrollBar hMyScrollBar;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem shortKeysToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem startStopMacroRecordingCtrlMToolStripMenuItem;
        private ToolStripMenuItem executeMacroCtrlEToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem setSelectedAsReadOnlyToolStripMenuItem;
        private ToolStripMenuItem setSelectedAsWritableToolStripMenuItem;
        private PictureBox pictureBox1;
        public MiniTimer_Label status;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private MiniTimer_LinkLabel miniTimer_LinkLabel1;
        private PictureBox min;
        private PictureBox max;
        private PictureBox close;
        private Label currentCol;
        private Label CurrentLine;
        private Label ZoomIn;
        private Label ZoomOut;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator15;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        //private Info info1;
    }
}

