namespace bartershop
{
    partial class form_elemen
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
            this.txt_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_0
            // 
            this.txt_0.Location = new System.Drawing.Point(106, 33);
            this.txt_0.Name = "txt_0";
            this.txt_0.Size = new System.Drawing.Size(100, 20);
            this.txt_0.TabIndex = 1;
            this.txt_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_0_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Earth element";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sea element";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(106, 59);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 2;
            this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_0_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Storm element";
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(106, 111);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(100, 20);
            this.txt_3.TabIndex = 6;
            this.txt_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Flame element";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(106, 85);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 4;
            this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_0_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Earth essense";
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(106, 137);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(100, 20);
            this.txt_4.TabIndex = 8;
            this.txt_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_0_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(131, 163);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // form_elemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 227);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_elemen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit harga element";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_elemen_FormClosed);
            this.Shown += new System.EventHandler(this.form_elemen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.Button btn_save;
    }
}