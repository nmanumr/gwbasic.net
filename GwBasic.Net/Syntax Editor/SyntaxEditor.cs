using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace GwBasic.Net
{
    public partial class SyntaxEditor : Form
    {
        public bool InfoShown = false;
        private string _path = "";
        private About about = new About();
        private bool _isFullScreen = true;

        private readonly string[] Keywords = new[]
        {
            "Beep", "call", "CHAIN", "CIRCLE", "CLOSE", "CLS", "COLOR",
            "COMMON", "COM", "DATA", "DEF FN", "DEFDBL", "DEFSTR", "DEFINT",
            "DEFSNG", "DEF SEG", "DEF USR", "DIM", "DRAW", "SCREEN", "END",
            "ENVIRON", "ERASE", "ERROR", "FIELD", "FOR", "NEXT", "GET", "GOSUB",
            "RETURN", "GOTO", "IF", "THEN", "ELSE", "INPUT", "INPUT\\#", "IOCTL",
            "KEY", "LET", "LINE", "LINE INPUT", "LINE INPUT\\#", "LOCATE", "LOCK",
            "LPRINT USING", "LPRINT", "RSET", "LSET", "ON TIMER", "ON STRIG",
            "ON PLAY", "ON PEN", "ON KEY", "ON COM", "ON ERROR GOTO", "ON",
            "OPEN", "OPTION BASE", "OUT", "PAINT", "PALETTE", "PALETTE USING",
            "PEN", "PLAY", "POKE", "PRESET", "PSET", "PRINT", "PRINT\\#", "PRINT\\#",
            "PRINT", "PUT", "RANDOMIZE", "READ", "REM", "RESTORE", "RESUME","USING",
            "RETURN", "SHELL", "SOUND", "STRIG", "SWAP", "TIME\\$", "WHILE", "WEND"
        };

        private readonly string[] Functions = new[]
        {
            "ABS", "ASC", "ANT", "CDBL", "CHR\\$", "CINT", "CIRCLE", "COM", "COS",
            "CSNG", "CVI", "DATE\\$", "ENVIRON\\$", "EOF", "EXP", "EXTERR", "FIX",
            "FRE", "HEX\\$", "INKEY\\$", "INP", "INPUT\\$", "INSTR", "INT", "LEFT$",
            "LEN", "LOC", "LOF", "LOG", "LPOS", "MID\\$", "MKI\\$", "MKS\\$", "MKD\\$",
            "OCT\\$", "PEEK", "PEN", "PLAY", "PMAP", "POINT", "POS", "RIGHT", "RND",
            "SGN", "SIN", "SPACE\\$", "SPC", "SQR", "STICK", "STRIG", "STRING\\$", "STR\\$",
            "TAB", "TAN", "TIMER", "USR", "VAL", "VARPTR", "VARPTR\\$"
        };

        private readonly string[] Commands = new[]
        {
            "CLEAR", "CONT", "CHDIR", "BLOAD", "AUTO", "DELETE", "FILES", "KILL", "LIST",
            "LLIST", "LOAD", "MERGE", "MKDIR", "NAME", "NEW", "PCOPY", "RENUM", "RESET",
            "RMDIR", "RUN", "SAVE", "SYSTEM", "TRON", "TROFF"
        };

        private readonly string[] Variables = new[]
        {
            "CSRLIN", "DATE$", "ERDEV", "ERDEV$", "ERL", "ERR", "INKEY$", "TIME$"
        };

        private static string CreateKeywordRegex(string[] keywords)
        {
            return "(" + string.Join(")|(", keywords) + ")";
        }

        public SyntaxEditor()
        {
            InitializeComponent();

            synBox1.CurrentLineColor = currentLineColor;
            toolStripButton5.ToolTipText = "";
            btInvisibleChars.ToolTipText = "";
            btInvisibleChars_Click(synBox1, null);
            synBox1.Refresh();

            //create autocomplete popup menu
            popupMenu = new AutocompleteMenu(synBox1);
            popupMenu.Items.ImageList = imageList1;
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
            popupMenu.AllowTabKey = true;

            BuildAutocompleteMenu();
        }

        public SyntaxEditor(string text, string path)
        {
            InitializeComponent();
            synBox1.CurrentLineColor = currentLineColor;
            toolStripButton5.ToolTipText = "";
            btInvisibleChars.ToolTipText = "";
            btInvisibleChars_Click(synBox1, null);
            synBox1.Refresh();

            //create autocomplete popup menu
            popupMenu = new AutocompleteMenu(synBox1);
            popupMenu.Items.ImageList = imageList1;
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
            popupMenu.AllowTabKey = true;
            //
            BuildAutocompleteMenu();
            synBox1.Text = text;
            _path = path;
        }

        private void SyntaxEditor_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenFile(string sFile)
        {
            try
            {
                StreamReader StreamReader1 = new StreamReader(sFile);
                synBox1.Text = StreamReader1.ReadToEnd();
                StreamReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error loading from file");
            }

        }

        private void synBox1_SelectionChanged(object sender, EventArgs e)
        {
            var currentColNum = synBox1.Selection.Start.iChar + 1;
            var currentLineNum = synBox1.Selection.Start.iLine + 1;

            currentCol.Text = @"Col: " + currentColNum;
            CurrentLine.Text = @"Line: " + currentLineNum;
        }

        private void fctb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            HighlightVisibleRange();
            const string startMarker = "FOR";
            const string endMarker = "NEXT";
            var currentSelection = synBox1.Selection.Clone();
            currentSelection.Normalize();

            if (currentSelection.Start.iLine != currentSelection.End.iLine)
            {
                synBox1[currentSelection.Start.iLine].FoldingStartMarker = startMarker;
                synBox1[currentSelection.End.iLine].FoldingEndMarker = endMarker;
                synBox1.Invalidate();
            }
        }
        private void synBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                var currentLineNum = synBox1.Selection.Start.iLine;
                var currentLine = synBox1.GetLineText(currentLineNum - 1);

                var crntLineNum = Regex.Matches(currentLine, "[| ]*[0-9]*");
                try
                {
                    var nextLineNum = int.Parse(crntLineNum[0].ToString()) + 10;
                    synBox1.SelectedText = nextLineNum + @" ";
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Unable to find line Number.", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        #region DragDrop

        private void synBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    this.Activate();
                    OpenFile(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DragDrop function: " + ex.Message);
            }
        }

        private void synBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion Drag


        #region scrollbar

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            synBox1.OnScroll(e, e.Type != ScrollEventType.ThumbTrack && e.Type != ScrollEventType.ThumbPosition);
        }

        private void hMyScrollBar_MouseLeave(object sender, EventArgs e)
        {
            hMyScrollBar.ThumbColor = Color.LightGray;
        }

        private void hMyScrollBar_MouseMove(object sender, MouseEventArgs e)
        {
            hMyScrollBar.ThumbColor = Color.Gray;
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (hMyScrollBar.Visible)
            {
                hMyScrollBar.Value = hMyScrollBar.Value - 20;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (hMyScrollBar.Visible)
            {
                hMyScrollBar.Value = hMyScrollBar.Value + 20;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (vMyScrollBar.Visible)
            {
                vMyScrollBar.Value = vMyScrollBar.Value - 20;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (vMyScrollBar.Visible)
            {
                vMyScrollBar.Value = vMyScrollBar.Value + 20;
            }
        }

        #endregion scrollbar


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Gw-Basic File (*.BAS)|*.BAS";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, synBox1.Text);
                    _path = sfd.FileName;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_path == "")
            {
                saveAsToolStripMenuItem_Click(saveAsToolStripMenuItem, e);
            }
            else
            {
                if (!File.Exists(_path))
                {
                    using (StreamWriter sw = File.CreateText(_path))
                    {
                        sw.Write(synBox1.Text);
                    }
                }
                else
                {
                    File.WriteAllText(_path, synBox1.Text);
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Do you want to save changes?", @"Gw-Basic Syntax Highlighter",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(New, e);
                synBox1.Text = "";
                synBox1.SelectedText = "10 ";
            }
            else if (result == DialogResult.No)
            {
                synBox1.Text = "";
                synBox1.SelectedText = "10 ";
            }
        }

        public void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = @"Gw-Basic File (*.BAS)|*.BAS|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                synBox1.OpenBindingFile(openFileDialog1.FileName, Encoding.UTF8);
                synBox1.IsChanged = false;
                synBox1.ClearUndo();
                GC.Collect();
                GC.GetTotalMemory(true);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(Save, e);
        }

        private void Print_Click(object sender, EventArgs e)
        {
            var settings = new PrintDialogSettings();
            settings.Header = "&b&w&b";
            settings.Footer = "&b&p";
            synBox1.Print(settings);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            var text = synBox1.SelectedText;
            Clipboard.SetText(text);
            synBox1.SelectedText = "";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            var text = synBox1.SelectedText;
            Clipboard.SetText(text);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            synBox1.SelectedText = Clipboard.GetText();
        }

        private void btInvisibleChars_Click(object sender, EventArgs e)
        {
            HighlightInvisibleChars(synBox1.Range);

        }

        private void HighlightInvisibleChars(Range range)
        {
            range.ClearStyle(invisibleCharsStyle);
            if (btInvisibleChars.Checked)
                range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
        }

        private void btHighlightCurrentLine_Click(object sender, EventArgs e)
        {
            if (btHighlightCurrentLine.Checked)
            {
                synBox1.CurrentLineColor = currentLineColor;
            }
            else
            {
                synBox1.CurrentLineColor = Color.Transparent;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(synBox1, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(synBox1, e);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_Click(synBox1, e);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.ShowReplaceDialog();
        }

        private void commentCurrentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.CommentPrefix = "REM ";
            synBox1.InsertLinePrefix(synBox1.CommentPrefix);
        }

        private void uncommentCurrentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.CommentPrefix = "REM";
            synBox1.RemoveLinePrefix(synBox1.CommentPrefix);
        }

        private void exportToHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string html = "";

                if (sfd.FilterIndex == 1)
                {
                    html = synBox1.Html;
                }
                if (sfd.FilterIndex == 2)
                {

                    ExportToHTML exporter = new ExportToHTML();
                    exporter.UseBr = true;
                    exporter.UseNbsp = false;
                    exporter.UseForwardNbsp = true;
                    exporter.UseStyleTag = true;
                    html = exporter.GetHtml(synBox1);
                }
                File.WriteAllText(sfd.FileName, html);
            }
        }

        private void exportToRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rtf = synBox1.Rtf;
                File.WriteAllText(sfd.FileName, rtf);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            commentCurrentLineToolStripMenuItem_Click(sender, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.Undo();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            synBox1.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            synBox1.Redo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = synBox1.SelectedText;
            Clipboard.SetText(text);
            synBox1.SelectedText = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy_Click(synBox1, e);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste_Click(synBox1, e);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.SelectAll();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            findToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            replaceToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            uncommentCurrentLineToolStripMenuItem_Click(sender, e);
        }

        private void shortKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HotkeysEditorForm(synBox1.HotkeysMapping);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                synBox1.HotkeysMapping = form.GetHotkeys();
        }

        private void startStopMacroRecordingCtrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.MacrosManager.IsRecording = !synBox1.MacrosManager.IsRecording;
        }

        private void executeMacroCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.MacrosManager.ExecuteMacros();
        }

        private void setSelectedAsReadOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.Selection.ReadOnly = true;
        }

        private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synBox1.Selection.ReadOnly = false;
        }

        #region Highlight

        Style WavyStyle = new WavyLineStyle(255, Color.Red);
        Style KeywordsStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        Style FunctionNameStyle = new TextStyle(Brushes.SeaGreen, null, FontStyle.Regular);
        Style StringNameStyle = new TextStyle(Brushes.IndianRed, null, FontStyle.Italic);
        Style CommandStyle = new TextStyle(Brushes.CornflowerBlue, null, FontStyle.Regular);
        Style VariableNameStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
        Style CommentNameStyle = new TextStyle(Brushes.Gray, null, FontStyle.Italic);
        Style LineNumStyle = new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular);
        Style NumStyle = new TextStyle(Brushes.SteelBlue, null, FontStyle.Regular);
        Style invisibleCharsStyle = new SyntaxEditor.InvisibleCharsRenderer(Pens.Gray);
        Style operatorNameStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        Color currentLineColor = Color.FromArgb(100, 210, 210, 255);
        //private Style ReadOnlyText = new TextStyle(null, Brushes., FontStyle.Regular);

        public void HighlightVisibleRange()
        {
            synBox1.Range.ClearStyle(KeywordsStyle, FunctionNameStyle, CommandStyle, VariableNameStyle, StringNameStyle,
                LineNumStyle, NumStyle, CommentNameStyle, operatorNameStyle);

            synBox1.Range.SetStyle(LineNumStyle, @"^[0-9]*[|\s]*",
                RegexOptions.Multiline);

            synBox1.Range.SetStyle(CommentNameStyle, "('|(REM\\s+)).*",
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(StringNameStyle, "(\"[^\"]+\"?)|(\"\")",
                RegexOptions.Singleline);

            synBox1.Range.SetStyle(NumStyle, "[0-9]*",
                RegexOptions.Multiline);

            synBox1.Range.SetStyle(NumStyle, "(auto)|(run)|(list)",
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(KeywordsStyle,
                CreateKeywordRegex(Keywords),
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(FunctionNameStyle,
                CreateKeywordRegex(Functions),
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(CommandStyle,
               CreateKeywordRegex(Commands),
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(operatorNameStyle, @"(\*)|-|/|=|(<=)|(>=)|<|>|(<>)|(and)|(or)",
                RegexOptions.IgnoreCase);

            synBox1.Range.SetStyle(VariableNameStyle,
                CreateKeywordRegex(Variables),
                RegexOptions.IgnoreCase);

        }
        #endregion Highlight




        #region InvisibleCharsRenderer

        public class InvisibleCharsRenderer : Style
        {
            Pen pen;

            public InvisibleCharsRenderer(Pen pen)
            {
                this.pen = pen;
            }

            public override void Draw(Graphics gr, Point position, Range range)
            {
                var tb = range.tb;
                using (Brush brush = new SolidBrush(pen.Color))
                    foreach (var place in range)
                    {
                        switch (tb[place].c)
                        {
                            case ' ':
                                var point = tb.PlaceToPoint(place);
                                point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
                                gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                                break;
                        }

                        if (tb[place.iLine].Count - 1 == place.iChar)
                        {
                            var point = tb.PlaceToPoint(place);
                            point.Offset(tb.CharWidth, 0);
                            gr.DrawString("¶", tb.Font, brush, point);
                        }
                    }
            }
        }

        #endregion InvisibleCharsRenderer


        #region For_Loop

        //20 FOR I = 1 TO 5
        //30 FOR J = 1 TO I
        //40 PRINT "*"
        //50 NEXT J
        //60 PRINT "\"
        //70 NEXT I
        //80 END

        #endregion For_Loop




        #region close

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            close.Image = Properties.Resources.clsh;
            status.ForeColor = Color.FromArgb(255, 255, 100, 100);
            status.Text = "Close";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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


        #region ZoomIn

        private void ZoomIn_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Zoom In";
            ZoomIn.BackColor = Color.LightGray;
        }

        private void ZoomIn_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
            ZoomIn.BackColor = Color.Transparent;
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            synBox1.Zoom = synBox1.Zoom + 10;
        }

        #endregion ZoomIn


        #region ZoomOut

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            synBox1.Zoom = synBox1.Zoom - 10;
        }

        private void ZoomOut_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Zoom Out";
            ZoomOut.BackColor = Color.LightGray;
        }

        private void ZoomOut_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
            ZoomOut.BackColor = Color.Transparent;
        }

        #endregion ZoomOut

        #region new

        private void New_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Create New Document";
        }

        private void New_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        #endregion new


        #region Open
        private void Open_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Open New Document";
        }

        private void Open_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion Open


        #region Save
        private void Save_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Save Current Document";
        }

        private void Save_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion Save


        #region Print
        private void Print_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void Print_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Print Current Document";
        }
        #endregion print


        #region cut
        private void Cut_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Delete the Selected Text and Copy it to Clipboard";
        }

        private void Cut_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion cut


        #region copy
        private void Copy_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Copy Select Text Clipboard";
        }

        private void Copy_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion copy


        #region Paste
        private void Paste_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void Paste_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Paste the Copied Text";
        }
        #endregion Paste


        #region invisible char
        private void btInvisibleChars_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void btInvisibleChars_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = @"Show Invisible Characters";
        }
        #endregion invisible char


        #region HighlightCurrentLine
        private void btHighlightCurrentLine_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Highlight Current Line";
        }

        private void btHighlightCurrentLine_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion HighlightCurrentLine


        #region undo
        private void Undo_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Undo Recent Change";
        }

        private void Undo_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion undo


        #region redo
        private void Redo_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void Redo_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Redo Recent Undo";
        }
        #endregion redo


        #region comment
        private void toolStripButton1_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Comment Out Current Line";
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion comment


        #region uncomment
        private void toolStripButton2_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Uncomment Current Line";
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion uncomment


        #region find

        private void toolStripButton3_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Show Find Dialog";
        }

        private void toolStripButton3_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion find


        #region replace
        private void toolStripButton4_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Show Replace Dialog";
        }

        private void toolStripButton4_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion replace

        #region Execute
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var temp = Path.GetTempPath();
            File.WriteAllText(temp + "\\Run.bas", synBox1.Text);
            Process.Start("Execute.bat");
        }
        private void toolStripButton5_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Execute the Program";
        }

        private void toolStripButton5_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }
        #endregion 


        private void aboutSyntaxEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Image = Properties.Resources.info_h;
            status.Text = "Info";
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.info;
            status.Text = "";
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Home_h;
            status.Text = "Goto Home Page";
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Home;
            status.Text = "";
        }

        private void SyntaxEditor_Activated(object sender, EventArgs e)
        {
            if (InfoShown)
            {
                about.Activate();
            }
        }

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

        private void synBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_isFullScreen)
            {
                var height = this.Size.Height - (6 + 17);
                var widht = this.Size.Width - (6 + 17);

                synBox1.Size = new Size(widht, height);
                synBox1.Location = new Point(3, 3);
                synBox1.BringToFront();

                pictureBox1.BringToFront();
                pictureBox1.Location = new Point(3, Size.Height - 20);

                pictureBox2.BringToFront();
                pictureBox2.Height = Size.Height - (6 + 17);
                pictureBox2.Location = new Point(Size.Width - 20, 3);

                pictureBox3.BringToFront();
                pictureBox3.Location = new Point(Size.Width - 18, 3);

                pictureBox4.BringToFront();
                pictureBox4.Location = new Point(Size.Width - 18, Size.Height - (16 + 17));

                pictureBox5.BringToFront();
                pictureBox5.Location = new Point(pictureBox5.Location.X, Size.Height - 18);

                pictureBox6.BringToFront();
                pictureBox6.Location = new Point(pictureBox6.Location.X, Size.Height - 18);

                vMyScrollBar.BringToFront();
                vMyScrollBar.Height = Size.Height - (6 + 17 + 13 * 2);
                vMyScrollBar.Location = new Point(Size.Width - 18, 16);

                hMyScrollBar.BringToFront();
                hMyScrollBar.Location = new Point(hMyScrollBar.Location.X, Size.Height - 17);

                currentCol.BringToFront();
                currentCol.Location = new Point(currentCol.Location.X, Size.Height - 18);

                CurrentLine.BringToFront();
                CurrentLine.Location = new Point(CurrentLine.Location.X, Size.Height - 18);

                ZoomIn.BringToFront();
                ZoomIn.Location = new Point(ZoomIn.Location.X, Size.Height - 18);

                ZoomOut.BringToFront();
                ZoomOut.Location = new Point(ZoomOut.Location.X, Size.Height - 18);

                _isFullScreen = false;
            }
            else
            {
                synBox1.Location = new Point(4, 89);
                synBox1.Size = new Size(Size.Width - 27, Size.Height - 153);
                synBox1.SendToBack();

                pictureBox1.Location = new Point(3, Size.Height - 63);

                pictureBox2.Height = Size.Height - (63 + 89);
                pictureBox2.Location = new Point(Size.Width - 20, 89);

                pictureBox3.Location = new Point(Size.Width - 18, 89);
                pictureBox4.Location = new Point(Size.Width - 18, Size.Height - (17 + 63));

                pictureBox5.Location = new Point(pictureBox5.Location.X, Size.Height - 61);
                pictureBox6.Location = new Point(pictureBox6.Location.X, Size.Height - 61);

                vMyScrollBar.Height = Size.Height - (6 + 17 + 13 * 2);
                vMyScrollBar.Location = new Point(Size.Width - 18, 16);
                hMyScrollBar.Location = new Point(hMyScrollBar.Location.X, Size.Height - 60);

                currentCol.Location = new Point(currentCol.Location.X, Size.Height - 61);
                CurrentLine.Location = new Point(CurrentLine.Location.X, Size.Height - 61);

                ZoomIn.Location = new Point(ZoomIn.Location.X, Size.Height - 61);
                ZoomOut.Location = new Point(ZoomOut.Location.X, Size.Height - 61);

                vScrollBar.SendToBack();
                hScrollBar.SendToBack();
                _isFullScreen = true;
            }
        }

        private void SyntaxEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                Save_Click(synBox1, null);

            else if (e.KeyCode == Keys.O && Control.ModifierKeys == Keys.Control)
                openToolStripMenuItem_Click(synBox1, null);

            else if (e.KeyCode == Keys.N && Control.ModifierKeys == Keys.Control)
                newToolStripMenuItem_Click(synBox1, null);

            else if (e.KeyCode == Keys.P && Control.ModifierKeys == Keys.Control)
                printToolStripMenuItem_Click(synBox1, null);

            else if (e.KeyCode == Keys.R && Control.ModifierKeys == Keys.Control)
                toolStripButton5_Click(synBox1, null);

            else if (e.KeyCode == Keys.F5)
                toolStripButton5_Click(synBox1, null);

        }

        private void synBox1_ToolTipNeeded(object sender, ToolTipNeededEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.HoveredWord))
            {
                //e.ToolTipIcon = ;
                e.ToolTipTitle = e.HoveredWord;
                e.ToolTipText = ":( ToolTip function is not implemented yet!";
            }
        }

        private void miniTimer_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAbout();
        }

        #region Save as
        private void toolStripButton6_MouseMove(object sender, MouseEventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "Save Document As";
        }

        private void toolStripButton6_MouseLeave(object sender, EventArgs e)
        {
            status.ForeColor = Color.FromArgb(255, 136, 136, 136);
            status.Text = "";
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Gw-Basic File (*.BAS)|*.BAS";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, synBox1.Text);
                    _path = sfd.FileName;
                }
            }
        }
        #endregion Save as

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string html = "";

                if (sfd.FilterIndex == 1)
                {
                    html = synBox1.Html;
                }
                if (sfd.FilterIndex == 2)
                {

                    ExportToHTML exporter = new ExportToHTML();
                    exporter.UseBr = true;
                    exporter.UseNbsp = false;
                    exporter.UseForwardNbsp = true;
                    exporter.UseStyleTag = true;
                    html = exporter.GetHtml(synBox1);
                }
                File.WriteAllText(sfd.FileName, html);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rtf = synBox1.Rtf;
                File.WriteAllText(sfd.FileName, rtf);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            synBox1.Selection.ReadOnly = true;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            synBox1.Selection.ReadOnly = false;
        }

        private void toolStripButton7_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Export to RTF";
        }

        private void toolStripButton7_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void toolStripButton8_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Export to HTML";
        }

        private void toolStripButton8_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void toolStripButton9_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Set the selected text as readonly";
        }

        private void toolStripButton9_MouseLeave(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Set the selected text as Writeable";
        }

        private void toolStripButton10_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            synBox1.MacrosManager.IsRecording = !synBox1.MacrosManager.IsRecording;
            if (synBox1.MacrosManager.IsRecording)
                toolStripButton11.Image = Properties.Resources.media_controls_stop_small;
            else
                toolStripButton11.Image = Properties.Resources.record;

            
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            synBox1.MacrosManager.ExecuteMacros();
        }

        private void toolStripButton11_MouseMove(object sender, MouseEventArgs e)
        {
            if (synBox1.MacrosManager.IsRecording)
                status.Text = "Stop Macro Recording";
            else
                status.Text = "Start Macro Recording";
            
        }

        private void toolStripButton11_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void toolStripButton12_MouseMove(object sender, MouseEventArgs e)
        {
            status.Text = "Execute Macro";
        }
    }

}
