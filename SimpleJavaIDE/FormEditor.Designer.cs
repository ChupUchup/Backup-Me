namespace SimpleJavaIDE
{
    partial class FormEditor
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabError = new System.Windows.Forms.TabPage();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.labelBuildRun = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabError.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.Control;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(5, 24);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(99, 24);
            this.MenuBar.TabIndex = 10;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.runToolStripMenuItem,
            this.buildRunToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "&Debug";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.buildToolStripMenuItem.Text = "&Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // buildRunToolStripMenuItem
            // 
            this.buildRunToolStripMenuItem.Name = "buildRunToolStripMenuItem";
            this.buildRunToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.buildRunToolStripMenuItem.Text = "B&uild && Run";
            this.buildRunToolStripMenuItem.Click += new System.EventHandler(this.buildRunToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabError);
            this.tabControl1.Controls.Add(this.tabOutput);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 438);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 123);
            this.tabControl1.TabIndex = 10;
            // 
            // tabError
            // 
            this.tabError.BackColor = System.Drawing.Color.Maroon;
            this.tabError.Controls.Add(this.txtError);
            this.tabError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabError.Location = new System.Drawing.Point(4, 4);
            this.tabError.Margin = new System.Windows.Forms.Padding(0);
            this.tabError.Name = "tabError";
            this.tabError.Size = new System.Drawing.Size(776, 97);
            this.tabError.TabIndex = 0;
            this.tabError.Text = "Error List";
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.Control;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtError.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(0, 0);
            this.txtError.Margin = new System.Windows.Forms.Padding(0);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(776, 97);
            this.txtError.TabIndex = 10;
            this.txtError.Text = "";
            this.txtError.WordWrap = false;
            // 
            // tabOutput
            // 
            this.tabOutput.BackColor = System.Drawing.Color.Maroon;
            this.tabOutput.Controls.Add(this.txtOutput);
            this.tabOutput.Location = new System.Drawing.Point(4, 4);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(0);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(776, 97);
            this.tabOutput.TabIndex = 1;
            this.tabOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(776, 97);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.Black;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.ForeColor = System.Drawing.Color.White;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(784, 358);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "";
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.SystemColors.Control;
            this.panel_2.Controls.Add(this.labelFileName);
            this.panel_2.Controls.Add(this.labelBuildRun);
            this.panel_2.Controls.Add(this.labelNew);
            this.panel_2.Controls.Add(this.labelSave);
            this.panel_2.Controls.Add(this.labelOpen);
            this.panel_2.Controls.Add(this.labelExit);
            this.panel_2.Controls.Add(this.MenuBar);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_2.Location = new System.Drawing.Point(0, 0);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(784, 80);
            this.panel_2.TabIndex = 11;
            // 
            // labelBuildRun
            // 
            this.labelBuildRun.AutoSize = true;
            this.labelBuildRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuildRun.Image = global::SimpleJavaIDE.Properties.Resources.run_small;
            this.labelBuildRun.Location = new System.Drawing.Point(94, 51);
            this.labelBuildRun.Name = "labelBuildRun";
            this.labelBuildRun.Size = new System.Drawing.Size(19, 20);
            this.labelBuildRun.TabIndex = 15;
            this.labelBuildRun.Text = "  ";
            this.labelBuildRun.Click += new System.EventHandler(this.labelBuildRun_Click);
            this.labelBuildRun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.labelBuildRun.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelBuildRun.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.labelBuildRun.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Image = global::SimpleJavaIDE.Properties.Resources.new_small;
            this.labelNew.Location = new System.Drawing.Point(19, 51);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(19, 20);
            this.labelNew.TabIndex = 14;
            this.labelNew.Text = "  ";
            this.labelNew.Click += new System.EventHandler(this.labelNew_Click);
            this.labelNew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.labelNew.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelNew.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.labelNew.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Image = global::SimpleJavaIDE.Properties.Resources.save_small;
            this.labelSave.Location = new System.Drawing.Point(44, 51);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(19, 20);
            this.labelSave.TabIndex = 13;
            this.labelSave.Text = "  ";
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
            this.labelSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.labelSave.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelSave.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.labelSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpen.Image = global::SimpleJavaIDE.Properties.Resources.open_small;
            this.labelOpen.Location = new System.Drawing.Point(69, 51);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(19, 20);
            this.labelOpen.TabIndex = 12;
            this.labelOpen.Text = "  ";
            this.labelOpen.Click += new System.EventHandler(this.labelOpen_Click);
            this.labelOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.labelOpen.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelOpen.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.labelOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(763, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(17, 16);
            this.labelExit.TabIndex = 11;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.labelExit.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.labelExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // panel_3
            // 
            this.panel_3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_3.Controls.Add(this.txtEditor);
            this.panel_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3.Location = new System.Drawing.Point(0, 80);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(784, 358);
            this.panel_3.TabIndex = 12;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(16, 6);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(108, 16);
            this.labelFileName.TabIndex = 16;
            this.labelFileName.Text = "Simple Java IDE";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "FormEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Java IDE";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormEditor_KeyUp);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabError.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildRunToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelBuildRun;
        private System.Windows.Forms.Label labelFileName;
    }
}