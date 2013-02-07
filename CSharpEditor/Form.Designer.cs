namespace CSharpEditor
{
    partial class CSharpEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSharpEditorForm));
            this.editorPane = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorsList = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.assemblyRefsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addAssemblyRefButton = new System.Windows.Forms.ToolStripButton();
            this.removeAssemblyRefButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.compileButton = new System.Windows.Forms.ToolStripButton();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.newFileButton = new System.Windows.Forms.ToolStripButton();
            this.loadFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorPane
            // 
            this.editorPane.AcceptsTab = true;
            this.editorPane.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorPane.Location = new System.Drawing.Point(12, 3);
            this.editorPane.Name = "editorPane";
            this.editorPane.Size = new System.Drawing.Size(1116, 462);
            this.editorPane.TabIndex = 0;
            this.editorPane.Text = "";
            this.editorPane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.editorPane_MouseClick);
            this.editorPane.TextChanged += new System.EventHandler(this.editorPane_TextChanged);
            this.editorPane.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorPane_KeyDown);
            this.editorPane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editorPane_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editorPane);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 660);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorsList);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errors";
            // 
            // errorsList
            // 
            this.errorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsList.Location = new System.Drawing.Point(9, 19);
            this.errorsList.Name = "errorsList";
            this.errorsList.ReadOnly = true;
            this.errorsList.Size = new System.Drawing.Size(1116, 146);
            this.errorsList.TabIndex = 0;
            this.errorsList.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 701);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1140, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.assemblyRefsComboBox,
            this.addAssemblyRefButton,
            this.removeAssemblyRefButton,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.compileButton,
            this.runButton,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.newFileButton,
            this.loadFileButton,
            this.saveFileButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1140, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel1.Text = "Assembly References:";
            // 
            // assemblyRefsComboBox
            // 
            this.assemblyRefsComboBox.Name = "assemblyRefsComboBox";
            this.assemblyRefsComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // addAssemblyRefButton
            // 
            this.addAssemblyRefButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addAssemblyRefButton.Image = ((System.Drawing.Image)(resources.GetObject("addAssemblyRefButton.Image")));
            this.addAssemblyRefButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAssemblyRefButton.Name = "addAssemblyRefButton";
            this.addAssemblyRefButton.Size = new System.Drawing.Size(23, 22);
            this.addAssemblyRefButton.Text = "+";
            // 
            // removeAssemblyRefButton
            // 
            this.removeAssemblyRefButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeAssemblyRefButton.Image = ((System.Drawing.Image)(resources.GetObject("removeAssemblyRefButton.Image")));
            this.removeAssemblyRefButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeAssemblyRefButton.Name = "removeAssemblyRefButton";
            this.removeAssemblyRefButton.Size = new System.Drawing.Size(23, 22);
            this.removeAssemblyRefButton.Text = "-";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel3.Text = "Build: ";
            // 
            // compileButton
            // 
            this.compileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.compileButton.Image = ((System.Drawing.Image)(resources.GetObject("compileButton.Image")));
            this.compileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(65, 22);
            this.compileButton.Text = "Compile...";
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runButton.Image = ((System.Drawing.Image)(resources.GetObject("runButton.Image")));
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(41, 22);
            this.runButton.Text = "Run...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel2.Text = "File:";
            // 
            // newFileButton
            // 
            this.newFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFileButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileButton.Image")));
            this.newFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(44, 22);
            this.newFileButton.Text = "New...";
            // 
            // loadFileButton
            // 
            this.loadFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadFileButton.Image = ((System.Drawing.Image)(resources.GetObject("loadFileButton.Image")));
            this.loadFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(46, 22);
            this.loadFileButton.Text = "Load...";
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(44, 22);
            this.saveFileButton.Text = "Save...";
            // 
            // CSharpEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 723);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSharpEditorForm";
            this.Text = "Yet another C# editor";
            this.Load += new System.EventHandler(this.CSharpEditorForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox editorPane;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox errorsList;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox assemblyRefsComboBox;
        private System.Windows.Forms.ToolStripButton addAssemblyRefButton;
        private System.Windows.Forms.ToolStripButton removeAssemblyRefButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton compileButton;
        private System.Windows.Forms.ToolStripButton runButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton newFileButton;
        private System.Windows.Forms.ToolStripButton loadFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
    }
}

