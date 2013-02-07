using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharpEditor
{
    public partial class CSharpEditorForm : Form
    {
        private ListBox listBoxAutoComplete;
        private ToolStripStatusLabel toolStripStatusLabel = new ToolStripStatusLabel();
        private Point caretPos;
        private static int _counter;
 
 
        public CSharpEditorForm()
        {
            InitializeComponent();
            // Instantiate listBoxAutoComplete object
            listBoxAutoComplete = new ListBox();
            // Add the ListBox to the form. 
            this.Controls.Add(listBoxAutoComplete);
            // Add status bar
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
        }

        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        private void CSharpEditorForm_Load(object sender, EventArgs e)
        {
            if (!AllocConsole())
                MessageBox.Show("Failed to alloc console");
        }
        
        private void editorPane_KeyDown(object sender, KeyEventArgs e)
        {
            Clear();
            StatusLine();

            // Detecting the dot key
            if (e.KeyData == Keys.OemPeriod)
            {
                // Get current line
                int currentLineIndex = editorPane.GetLineFromCharIndex(editorPane.SelectionStart);
                string currentLine = this.editorPane.Lines[currentLineIndex];
                
                Console.WriteLine("Current line numb.: {0}, {1}", currentLineIndex+1 , currentLine);

                if (!this.listBoxAutoComplete.Visible)
                {
                    this.listBoxAutoComplete.Items.Clear();
                    // Populate the Auto Complete list box
                    this.listBoxAutoComplete.Items.Add("Olá " + ++_counter);
                    

                    // Display the Auto Complete list box
                    DisplayAutoCompleteList();
                }
            }
        }


        // Display the Auto Complete list box
        private void DisplayAutoCompleteList()
        {
            // Find the position of the caret
            Point caretLoc = this.editorPane.GetPositionFromCharIndex(editorPane.SelectionStart);
            caretLoc.Y += (int)Math.Ceiling(this.editorPane.Font.GetHeight()) * 2 + 13;
            caretLoc.X += 20;
            this.listBoxAutoComplete.Location = caretLoc;
            this.listBoxAutoComplete.Height = 100;
            this.listBoxAutoComplete.Width = 140;
            this.listBoxAutoComplete.BringToFront();
            this.listBoxAutoComplete.Show();
        }
        private void StatusLine()
        {
            int ln = this.editorPane.GetLineFromCharIndex(editorPane.SelectionStart);
            int cn = (editorPane.SelectionStart) - (editorPane.GetFirstCharIndexFromLine(ln)) + 1;
            ln = ln + 1;
            caretPos.X = cn;
            caretPos.Y = ln;
            string lnColString = "Ln: " + ln.ToString() + " Col: " + cn.ToString();
            statusStrip.Items[0].Text = lnColString;
        }
        private void Clear()
        {
            this.listBoxAutoComplete.Hide();
        }
        private void editorPane_MouseClick(object sender, MouseEventArgs e)
        {
            StatusLine();
        }

        private void editorPane_MouseUp(object sender, MouseEventArgs e)
        {
            StatusLine();
        }

        private void editorPane_TextChanged(object sender, EventArgs e)
        {
            StatusLine();
        }
    }
}
