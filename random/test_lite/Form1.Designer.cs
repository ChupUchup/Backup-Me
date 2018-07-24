namespace test_lite
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.list_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list_jabatan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.RichTextBox();
            this.txt_memo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_karyawan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(210, 144);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Simpan";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(70, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(170, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(70, 38);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(170, 20);
            this.txt_nama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(70, 64);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(170, 20);
            this.txt_password.TabIndex = 5;
            // 
            // list_gender
            // 
            this.list_gender.FormattingEnabled = true;
            this.list_gender.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.list_gender.Location = new System.Drawing.Point(70, 90);
            this.list_gender.Name = "list_gender";
            this.list_gender.Size = new System.Drawing.Size(170, 21);
            this.list_gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jabatan";
            // 
            // list_jabatan
            // 
            this.list_jabatan.FormattingEnabled = true;
            this.list_jabatan.Items.AddRange(new object[] {
            "CEO",
            "Direktur",
            "Wakil Direktur",
            "Manager",
            "Wakil Manager",
            "Kepala Staff",
            "Staff"});
            this.list_jabatan.Location = new System.Drawing.Point(70, 117);
            this.list_jabatan.Name = "list_jabatan";
            this.list_jabatan.Size = new System.Drawing.Size(170, 21);
            this.list_jabatan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alamat";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(246, 25);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(226, 46);
            this.txt_alamat.TabIndex = 12;
            this.txt_alamat.Text = "";
            // 
            // txt_memo
            // 
            this.txt_memo.Location = new System.Drawing.Point(246, 90);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(226, 48);
            this.txt_memo.TabIndex = 14;
            this.txt_memo.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Memo";
            // 
            // dgv_karyawan
            // 
            this.dgv_karyawan.AllowUserToAddRows = false;
            this.dgv_karyawan.AllowUserToDeleteRows = false;
            this.dgv_karyawan.AllowUserToResizeColumns = false;
            this.dgv_karyawan.AllowUserToResizeRows = false;
            this.dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_karyawan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_karyawan.Location = new System.Drawing.Point(0, 183);
            this.dgv_karyawan.MultiSelect = false;
            this.dgv_karyawan.Name = "dgv_karyawan";
            this.dgv_karyawan.Size = new System.Drawing.Size(484, 278);
            this.dgv_karyawan.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dgv_karyawan);
            this.Controls.Add(this.txt_memo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_jabatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox list_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox list_jabatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_alamat;
        private System.Windows.Forms.RichTextBox txt_memo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_karyawan;
    }
}

