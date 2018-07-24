namespace aplikasi_penjualan
{
    partial class form_karyawan
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
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_karyawan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.RichTextBox();
            this.txt_memo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel_editKaryawan = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_passA = new System.Windows.Forms.TextBox();
            this.txt_passB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.panel_umum = new System.Windows.Forms.Panel();
            this.btn_img = new System.Windows.Forms.Button();
            this.img_box = new System.Windows.Forms.PictureBox();
            this.list_jabatan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).BeginInit();
            this.panel_password.SuspendLayout();
            this.panel_editKaryawan.SuspendLayout();
            this.panel_umum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_box)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nik
            // 
            this.txt_nik.Location = new System.Drawing.Point(260, 9);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.Size = new System.Drawing.Size(200, 20);
            this.txt_nik.TabIndex = 0;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(260, 35);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(200, 20);
            this.txt_nama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jabatan";
            // 
            // dgv_karyawan
            // 
            this.dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_karyawan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_karyawan.Location = new System.Drawing.Point(0, 268);
            this.dgv_karyawan.Name = "dgv_karyawan";
            this.dgv_karyawan.Size = new System.Drawing.Size(784, 293);
            this.dgv_karyawan.TabIndex = 9;
            this.dgv_karyawan.SelectionChanged += new System.EventHandler(this.dgv_karyawan_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alamat";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(260, 87);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(200, 75);
            this.txt_alamat.TabIndex = 3;
            this.txt_alamat.Text = "";
            // 
            // txt_memo
            // 
            this.txt_memo.Location = new System.Drawing.Point(260, 169);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(200, 75);
            this.txt_memo.TabIndex = 4;
            this.txt_memo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Memo";
            // 
            // panel_password
            // 
            this.panel_password.Controls.Add(this.btn_delete);
            this.panel_password.Controls.Add(this.btn_cancel);
            this.panel_password.Controls.Add(this.btn_save);
            this.panel_password.Controls.Add(this.panel_editKaryawan);
            this.panel_password.Controls.Add(this.label6);
            this.panel_password.Controls.Add(this.txt_pass);
            this.panel_password.Location = new System.Drawing.Point(480, 96);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(298, 167);
            this.panel_password.TabIndex = 15;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(120, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(201, 130);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(39, 130);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel_editKaryawan
            // 
            this.panel_editKaryawan.Controls.Add(this.label9);
            this.panel_editKaryawan.Controls.Add(this.label8);
            this.panel_editKaryawan.Controls.Add(this.label7);
            this.panel_editKaryawan.Controls.Add(this.txt_passA);
            this.panel_editKaryawan.Controls.Add(this.txt_passB);
            this.panel_editKaryawan.Location = new System.Drawing.Point(5, 36);
            this.panel_editKaryawan.Name = "panel_editKaryawan";
            this.panel_editKaryawan.Size = new System.Drawing.Size(288, 80);
            this.panel_editKaryawan.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Isi hanya jika mengedit password lama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Baru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password";
            // 
            // txt_passA
            // 
            this.txt_passA.Location = new System.Drawing.Point(71, 25);
            this.txt_passA.Name = "txt_passA";
            this.txt_passA.Size = new System.Drawing.Size(156, 20);
            this.txt_passA.TabIndex = 6;
            // 
            // txt_passB
            // 
            this.txt_passB.Location = new System.Drawing.Point(71, 51);
            this.txt_passB.Name = "txt_passB";
            this.txt_passB.Size = new System.Drawing.Size(156, 20);
            this.txt_passB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(76, 10);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(156, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(556, 14);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 75);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit Data";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(637, 14);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 75);
            this.btn_tambah.TabIndex = 9;
            this.btn_tambah.Text = "Tambah Data";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // panel_umum
            // 
            this.panel_umum.Controls.Add(this.btn_img);
            this.panel_umum.Controls.Add(this.img_box);
            this.panel_umum.Controls.Add(this.list_jabatan);
            this.panel_umum.Controls.Add(this.label1);
            this.panel_umum.Controls.Add(this.txt_nik);
            this.panel_umum.Controls.Add(this.txt_nama);
            this.panel_umum.Controls.Add(this.label2);
            this.panel_umum.Controls.Add(this.label5);
            this.panel_umum.Controls.Add(this.txt_memo);
            this.panel_umum.Controls.Add(this.label3);
            this.panel_umum.Controls.Add(this.txt_alamat);
            this.panel_umum.Controls.Add(this.label4);
            this.panel_umum.Location = new System.Drawing.Point(6, 5);
            this.panel_umum.Name = "panel_umum";
            this.panel_umum.Size = new System.Drawing.Size(468, 259);
            this.panel_umum.TabIndex = 18;
            // 
            // btn_img
            // 
            this.btn_img.Location = new System.Drawing.Point(154, 5);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(50, 23);
            this.btn_img.TabIndex = 21;
            this.btn_img.Text = "Browse";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click_1);
            // 
            // img_box
            // 
            this.img_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_box.Location = new System.Drawing.Point(5, 4);
            this.img_box.Name = "img_box";
            this.img_box.Size = new System.Drawing.Size(200, 250);
            this.img_box.TabIndex = 20;
            this.img_box.TabStop = false;
            // 
            // list_jabatan
            // 
            this.list_jabatan.FormattingEnabled = true;
            this.list_jabatan.Location = new System.Drawing.Point(260, 60);
            this.list_jabatan.Name = "list_jabatan";
            this.list_jabatan.Size = new System.Drawing.Size(200, 21);
            this.list_jabatan.TabIndex = 2;
            // 
            // form_karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_umum);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.dgv_karyawan);
            this.Name = "form_karyawan";
            this.Text = "Data Karyawan";
            this.Load += new System.EventHandler(this.form_karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).EndInit();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_editKaryawan.ResumeLayout(false);
            this.panel_editKaryawan.PerformLayout();
            this.panel_umum.ResumeLayout(false);
            this.panel_umum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_karyawan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_alamat;
        private System.Windows.Forms.RichTextBox txt_memo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Panel panel_umum;
        private System.Windows.Forms.ComboBox list_jabatan;
        private System.Windows.Forms.Panel panel_editKaryawan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_passA;
        private System.Windows.Forms.TextBox txt_passB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.PictureBox img_box;
        private System.Windows.Forms.Button btn_delete;


    }
}