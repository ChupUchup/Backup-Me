namespace bartershop
{
    partial class form_main
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
            this.combo_item = new System.Windows.Forms.ComboBox();
            this.combo_elemen = new System.Windows.Forms.ComboBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_elemen = new System.Windows.Forms.TextBox();
            this.txt_harga_elemen = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_need = new System.Windows.Forms.Label();
            this.lbl_elemen = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_harga_elemen = new System.Windows.Forms.Label();
            this.lbl_harga_item = new System.Windows.Forms.Label();
            this.txt_harga_item = new System.Windows.Forms.TextBox();
            this.lbl_pajak = new System.Windows.Forms.Label();
            this.txt_pajak = new System.Windows.Forms.TextBox();
            this.btn_edit_elemen = new System.Windows.Forms.Button();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_element = new System.Windows.Forms.Label();
            this.txt_need = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // combo_item
            // 
            this.combo_item.FormattingEnabled = true;
            this.combo_item.Location = new System.Drawing.Point(94, 11);
            this.combo_item.Name = "combo_item";
            this.combo_item.Size = new System.Drawing.Size(121, 21);
            this.combo_item.TabIndex = 0;
            this.combo_item.Text = "Pilih item";
            this.combo_item.SelectedIndexChanged += new System.EventHandler(this.combo_item_SelectedIndexChanged);
            // 
            // combo_elemen
            // 
            this.combo_elemen.FormattingEnabled = true;
            this.combo_elemen.Location = new System.Drawing.Point(94, 64);
            this.combo_elemen.Name = "combo_elemen";
            this.combo_elemen.Size = new System.Drawing.Size(121, 21);
            this.combo_elemen.TabIndex = 1;
            this.combo_elemen.Text = "Pilih element";
            this.combo_elemen.SelectedIndexChanged += new System.EventHandler(this.combo_elemen_SelectedIndexChanged);
            // 
            // txt_item
            // 
            this.txt_item.Enabled = false;
            this.txt_item.Location = new System.Drawing.Point(135, 38);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(80, 20);
            this.txt_item.TabIndex = 2;
            // 
            // txt_elemen
            // 
            this.txt_elemen.Enabled = false;
            this.txt_elemen.Location = new System.Drawing.Point(94, 91);
            this.txt_elemen.Name = "txt_elemen";
            this.txt_elemen.Size = new System.Drawing.Size(121, 20);
            this.txt_elemen.TabIndex = 3;
            // 
            // txt_harga_elemen
            // 
            this.txt_harga_elemen.Enabled = false;
            this.txt_harga_elemen.Location = new System.Drawing.Point(94, 143);
            this.txt_harga_elemen.Name = "txt_harga_elemen";
            this.txt_harga_elemen.Size = new System.Drawing.Size(98, 20);
            this.txt_harga_elemen.TabIndex = 4;
            this.txt_harga_elemen.TextChanged += new System.EventHandler(this.txt_harga_TextChanged);
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(94, 117);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(121, 20);
            this.txt_total.TabIndex = 5;
            // 
            // lbl_need
            // 
            this.lbl_need.AutoSize = true;
            this.lbl_need.Location = new System.Drawing.Point(55, 41);
            this.lbl_need.Name = "lbl_need";
            this.lbl_need.Size = new System.Drawing.Size(33, 13);
            this.lbl_need.TabIndex = 6;
            this.lbl_need.Text = "Need";
            // 
            // lbl_elemen
            // 
            this.lbl_elemen.AutoSize = true;
            this.lbl_elemen.Location = new System.Drawing.Point(54, 94);
            this.lbl_elemen.Name = "lbl_elemen";
            this.lbl_elemen.Size = new System.Drawing.Size(34, 13);
            this.lbl_elemen.TabIndex = 7;
            this.lbl_elemen.Text = "Value";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(59, 120);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Total";
            // 
            // lbl_harga_elemen
            // 
            this.lbl_harga_elemen.AutoSize = true;
            this.lbl_harga_elemen.Location = new System.Drawing.Point(12, 146);
            this.lbl_harga_elemen.Name = "lbl_harga_elemen";
            this.lbl_harga_elemen.Size = new System.Drawing.Size(76, 13);
            this.lbl_harga_elemen.TabIndex = 9;
            this.lbl_harga_elemen.Text = "Harga element";
            // 
            // lbl_harga_item
            // 
            this.lbl_harga_item.AutoSize = true;
            this.lbl_harga_item.Location = new System.Drawing.Point(30, 198);
            this.lbl_harga_item.Name = "lbl_harga_item";
            this.lbl_harga_item.Size = new System.Drawing.Size(58, 13);
            this.lbl_harga_item.TabIndex = 11;
            this.lbl_harga_item.Text = "Harga item";
            // 
            // txt_harga_item
            // 
            this.txt_harga_item.Enabled = false;
            this.txt_harga_item.Location = new System.Drawing.Point(94, 195);
            this.txt_harga_item.Name = "txt_harga_item";
            this.txt_harga_item.Size = new System.Drawing.Size(121, 20);
            this.txt_harga_item.TabIndex = 10;
            // 
            // lbl_pajak
            // 
            this.lbl_pajak.AutoSize = true;
            this.lbl_pajak.Location = new System.Drawing.Point(54, 172);
            this.lbl_pajak.Name = "lbl_pajak";
            this.lbl_pajak.Size = new System.Drawing.Size(34, 13);
            this.lbl_pajak.TabIndex = 13;
            this.lbl_pajak.Text = "Pajak";
            // 
            // txt_pajak
            // 
            this.txt_pajak.Enabled = false;
            this.txt_pajak.Location = new System.Drawing.Point(94, 169);
            this.txt_pajak.Name = "txt_pajak";
            this.txt_pajak.Size = new System.Drawing.Size(121, 20);
            this.txt_pajak.TabIndex = 12;
            // 
            // btn_edit_elemen
            // 
            this.btn_edit_elemen.Image = global::bartershop.Properties.Resources.setting;
            this.btn_edit_elemen.Location = new System.Drawing.Point(193, 142);
            this.btn_edit_elemen.Name = "btn_edit_elemen";
            this.btn_edit_elemen.Size = new System.Drawing.Size(22, 22);
            this.btn_edit_elemen.TabIndex = 14;
            this.btn_edit_elemen.UseVisualStyleBackColor = true;
            this.btn_edit_elemen.Click += new System.EventHandler(this.btn_edit_elemen_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(61, 14);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 15;
            this.lbl_item.Text = "Item";
            // 
            // lbl_element
            // 
            this.lbl_element.AutoSize = true;
            this.lbl_element.Location = new System.Drawing.Point(43, 67);
            this.lbl_element.Name = "lbl_element";
            this.lbl_element.Size = new System.Drawing.Size(45, 13);
            this.lbl_element.TabIndex = 16;
            this.lbl_element.Text = "Element";
            // 
            // txt_need
            // 
            this.txt_need.Location = new System.Drawing.Point(94, 38);
            this.txt_need.Name = "txt_need";
            this.txt_need.Size = new System.Drawing.Size(39, 20);
            this.txt_need.TabIndex = 17;
            this.txt_need.Text = "1";
            this.txt_need.TextChanged += new System.EventHandler(this.txt_need_TextChanged);
            this.txt_need.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_need_KeyPress);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 227);
            this.Controls.Add(this.txt_need);
            this.Controls.Add(this.lbl_element);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.btn_edit_elemen);
            this.Controls.Add(this.lbl_pajak);
            this.Controls.Add(this.txt_pajak);
            this.Controls.Add(this.lbl_harga_item);
            this.Controls.Add(this.txt_harga_item);
            this.Controls.Add(this.lbl_harga_elemen);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_elemen);
            this.Controls.Add(this.lbl_need);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_harga_elemen);
            this.Controls.Add(this.txt_elemen);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.combo_elemen);
            this.Controls.Add(this.combo_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "barter shop";
            this.Shown += new System.EventHandler(this.form_main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_item;
        private System.Windows.Forms.ComboBox combo_elemen;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_elemen;
        private System.Windows.Forms.TextBox txt_harga_elemen;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_need;
        private System.Windows.Forms.Label lbl_elemen;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_harga_elemen;
        private System.Windows.Forms.Label lbl_harga_item;
        private System.Windows.Forms.TextBox txt_harga_item;
        private System.Windows.Forms.Label lbl_pajak;
        private System.Windows.Forms.TextBox txt_pajak;
        private System.Windows.Forms.Button btn_edit_elemen;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_element;
        private System.Windows.Forms.TextBox txt_need;
    }
}