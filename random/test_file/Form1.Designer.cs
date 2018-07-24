namespace test_file
{
    partial class Form1
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
            this.list_db = new System.Windows.Forms.ComboBox();
            this.list_tbl = new System.Windows.Forms.ComboBox();
            this.dgv_tbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // list_db
            // 
            this.list_db.FormattingEnabled = true;
            this.list_db.Location = new System.Drawing.Point(89, 12);
            this.list_db.Name = "list_db";
            this.list_db.Size = new System.Drawing.Size(183, 21);
            this.list_db.TabIndex = 0;
            this.list_db.SelectedIndexChanged += new System.EventHandler(this.list_db_SelectedIndexChanged);
            // 
            // list_tbl
            // 
            this.list_tbl.FormattingEnabled = true;
            this.list_tbl.Location = new System.Drawing.Point(89, 39);
            this.list_tbl.Name = "list_tbl";
            this.list_tbl.Size = new System.Drawing.Size(183, 21);
            this.list_tbl.TabIndex = 1;
            this.list_tbl.SelectedIndexChanged += new System.EventHandler(this.list_tbl_SelectedIndexChanged);
            // 
            // dgv_tbl
            // 
            this.dgv_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_tbl.Location = new System.Drawing.Point(0, 87);
            this.dgv_tbl.Name = "dgv_tbl";
            this.dgv_tbl.Size = new System.Drawing.Size(284, 174);
            this.dgv_tbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgv_tbl);
            this.Controls.Add(this.list_tbl);
            this.Controls.Add(this.list_db);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox list_db;
        private System.Windows.Forms.ComboBox list_tbl;
        private System.Windows.Forms.DataGridView dgv_tbl;
    }
}

