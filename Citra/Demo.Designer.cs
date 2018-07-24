namespace Citra
{
    partial class Demo
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
            this.pBoxA = new System.Windows.Forms.PictureBox();
            this.pBoxB = new System.Windows.Forms.PictureBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxA
            // 
            this.pBoxA.Location = new System.Drawing.Point(12, 99);
            this.pBoxA.Name = "pBoxA";
            this.pBoxA.Size = new System.Drawing.Size(250, 250);
            this.pBoxA.TabIndex = 0;
            this.pBoxA.TabStop = false;
            // 
            // pBoxB
            // 
            this.pBoxB.Location = new System.Drawing.Point(268, 99);
            this.pBoxB.Name = "pBoxB";
            this.pBoxB.Size = new System.Drawing.Size(250, 250);
            this.pBoxB.TabIndex = 1;
            this.pBoxB.TabStop = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(250, 81);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(268, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(250, 81);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "";
            // 
            // btnEmbed
            // 
            this.btnEmbed.Location = new System.Drawing.Point(187, 99);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(75, 23);
            this.btnEmbed.TabIndex = 4;
            this.btnEmbed.Text = "Embed";
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(268, 99);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 5;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 99);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnEmbed);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.pBoxB);
            this.Controls.Add(this.pBoxA);
            this.Name = "Demo";
            this.Text = "Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxA;
        private System.Windows.Forms.PictureBox pBoxB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.Button btnEmbed;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
    }
}