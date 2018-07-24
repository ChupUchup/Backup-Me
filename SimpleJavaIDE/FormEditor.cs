//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleJavaIDE
{
    public partial class FormEditor : Form
    {
        bool _currentFileIsSaved = false;
        string _currentCode = "", _currentFileName = "", _currentFilepath = "", _currentFileDirectory = "", _errorMsg = "", _outputMsg = "";
        enum Debug { Build, Run, BuildRun };

        public FormEditor()
        {
            InitializeComponent();
            this.KeyPreview = true;
            tabControl1.Size = new Size(tabControl1.Width, 20);
            txtEditor.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtEditor.AcceptsTab = true;
        }

        private void FormEditor_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == (int)Keys.Escape) exitToolStripMenuItem_Click(null, null);
            if (e.KeyValue == (int)Keys.F5) buildRunToolStripMenuItem_Click(null, null);
            else if (e.KeyValue == (int)Keys.F6) buildToolStripMenuItem_Click(null, null);
            else if (e.KeyValue == (int)Keys.F4) runToolStripMenuItem_Click(null, null);
            else if (e.KeyCode == Keys.O && e.Control) { openToolStripMenuItem_Click(null, null); }
            else if (e.KeyCode == Keys.S && e.Control) { saveToolStripMenuItem_Click(null, null); }
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDebug(Debug.Build);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDebug(Debug.Run);
        }

        private void buildRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDebug(Debug.BuildRun);
        }

        private void doDebug(Debug debugType)
        {
            if (_currentFileIsSaved)
            {
                if (_currentCode != txtEditor.Text)
                {
                    using (var fs = new StreamWriter(_currentFilepath))
                    {
                        fs.Write(txtEditor.Text);
                        _currentCode = txtEditor.Text;
                    }
                }
                string fileName = _currentFileName.Replace(".java", "");
                if (debugType == Debug.Build)
                {
                    doCMD("cd /D " + _currentFileDirectory + " && javac " + _currentFileName);
                }
                else if (debugType == Debug.Run)
                {
                    doCMD("cd /D " + _currentFileDirectory + " && java " + fileName);
                }
                else if (debugType == Debug.BuildRun)
                {
                    doCMD("cd /D " + _currentFileDirectory + " && javac " + _currentFileName + " && java " + fileName);
                }
                if (_errorMsg != "") { txtError.Text = _errorMsg; tabControl1.SelectedIndex = 0; }
                if (_outputMsg != "") { txtOutput.Text = _outputMsg; tabControl1.SelectedIndex = 1; }
                tabControl1.Size = new Size(tabControl1.Width, 123);
                txtEditor.Focus();
            }
            else
            {
                if (txtEditor.Text != "")
                {
                    doSaveFile();
                    if (_currentFileIsSaved) doDebug(debugType);
                }
            }
        }

        private void doCMD(object command)
        {
            try
            {
                txtError.Text = "";
                txtOutput.Text = "";
                ProcessStartInfo procInfo = new ProcessStartInfo("cmd", "/c " + command);
                procInfo.RedirectStandardOutput = true;
                procInfo.RedirectStandardError = true;
                procInfo.UseShellExecute = false;
                procInfo.CreateNoWindow = true;
                Process proc = new Process();
                proc.StartInfo = procInfo;
                proc.Start();
                _outputMsg = proc.StandardOutput.ReadToEnd();
                _errorMsg = proc.StandardError.ReadToEnd();
            }
            catch (Exception ex) { _errorMsg += "Exception : \n" + ex.Message; }
        }

        private void doSaveFile()
        {
            if (_currentFilepath == "") _currentFileIsSaved = false;
            tabControl1.Size = new Size(tabControl1.Width, 20);
            using (var sfd = new SaveFileDialog())
            {
                sfd.AddExtension = true;
                sfd.Filter = "Java File (*.java)|*.java";
                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "")
                {
                    using (var fs = new StreamWriter(sfd.FileName))
                    {
                        fs.Write(txtEditor.Text);
                        _currentCode = txtEditor.Text;
                    }
                    FileInfo f = new FileInfo(sfd.FileName);
                    _currentFilepath = sfd.FileName;
                    _currentFileName = f.Name;
                    _currentFileDirectory = f.DirectoryName;
                    _currentFileIsSaved = true;
                    labelFileName.Text = _currentFileName;
                }
            }
        }

        private void doOpenFile()
        {
            if (_currentFilepath == "") _currentFileIsSaved = false;
            tabControl1.Size = new Size(tabControl1.Width, 20);
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Java File (*.java)|*.java";
                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
                {
                    using (var fs = new StreamReader(ofd.FileName))
                    {
                        _currentCode = fs.ReadToEnd();
                        txtEditor.Text = _currentCode;
                    }
                    FileInfo f = new FileInfo(ofd.FileName);
                    _currentFilepath = ofd.FileName;
                    _currentFileName = f.Name;
                    _currentFileDirectory = f.DirectoryName;
                    _currentFileIsSaved = true;
                    labelFileName.Text = _currentFileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doOpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doSaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentCode != txtEditor.Text)
            {
                if (MessageBox.Show("Simpan Perubahan ?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    doSaveFile();
                    if (_currentCode == txtEditor.Text) Application.Exit();
                }
                else Application.Exit();
            }
            else Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(null, null);
        }
        
        private void labelNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }

        private void labelSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(null, null);
        }

        private void labelOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(null, null);
        }

        private void labelBuildRun_Click(object sender, EventArgs e)
        {
            buildRunToolStripMenuItem_Click(null, null);
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label x = (Label)sender;
            x.BackColor = Color.Black;
            x.ForeColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label x = (Label)sender;
            x.BackColor = Color.FromKnownColor(KnownColor.Control);
            x.ForeColor = Color.Black;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label x = (Label)sender;
            x.BackColor = Color.Red;
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            Label x = (Label)sender;
            x.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

    }
}
