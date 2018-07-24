namespace test_sctDraw
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
            this.button1 = new System.Windows.Forms.Button();
            this.scalaY = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSin = new System.Windows.Forms.CheckBox();
            this.checkBoxCos = new System.Windows.Forms.CheckBox();
            this.checkBoxTan = new System.Windows.Forms.CheckBox();
            this.initAngle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTheta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPow = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHideLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scalaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scalaY
            // 
            this.scalaY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scalaY.Location = new System.Drawing.Point(446, 10);
            this.scalaY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.scalaY.Name = "scalaY";
            this.scalaY.Size = new System.Drawing.Size(55, 20);
            this.scalaY.TabIndex = 1;
            this.scalaY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkBoxSin
            // 
            this.checkBoxSin.AutoSize = true;
            this.checkBoxSin.BackColor = System.Drawing.Color.Salmon;
            this.checkBoxSin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSin.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSin.Name = "checkBoxSin";
            this.checkBoxSin.Size = new System.Drawing.Size(41, 17);
            this.checkBoxSin.TabIndex = 2;
            this.checkBoxSin.Text = "Sin";
            this.checkBoxSin.UseVisualStyleBackColor = false;
            // 
            // checkBoxCos
            // 
            this.checkBoxCos.AutoSize = true;
            this.checkBoxCos.BackColor = System.Drawing.Color.Chartreuse;
            this.checkBoxCos.Location = new System.Drawing.Point(59, 12);
            this.checkBoxCos.Name = "checkBoxCos";
            this.checkBoxCos.Size = new System.Drawing.Size(44, 17);
            this.checkBoxCos.TabIndex = 3;
            this.checkBoxCos.Text = "Cos";
            this.checkBoxCos.UseVisualStyleBackColor = false;
            // 
            // checkBoxTan
            // 
            this.checkBoxTan.AutoSize = true;
            this.checkBoxTan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBoxTan.Location = new System.Drawing.Point(109, 12);
            this.checkBoxTan.Name = "checkBoxTan";
            this.checkBoxTan.Size = new System.Drawing.Size(45, 17);
            this.checkBoxTan.TabIndex = 4;
            this.checkBoxTan.Text = "Tan";
            this.checkBoxTan.UseVisualStyleBackColor = false;
            // 
            // initAngle
            // 
            this.initAngle.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.initAngle.Location = new System.Drawing.Point(341, 11);
            this.initAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.initAngle.Name = "initAngle";
            this.initAngle.Size = new System.Drawing.Size(55, 20);
            this.initAngle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Initial Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scala Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line Angle";
            // 
            // lineAngle
            // 
            this.lineAngle.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lineAngle.Location = new System.Drawing.Point(567, 10);
            this.lineAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.lineAngle.Name = "lineAngle";
            this.lineAngle.Size = new System.Drawing.Size(55, 20);
            this.lineAngle.TabIndex = 8;
            this.lineAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(193, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "θ";
            // 
            // numTheta
            // 
            this.numTheta.Location = new System.Drawing.Point(160, 10);
            this.numTheta.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTheta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTheta.Name = "numTheta";
            this.numTheta.Size = new System.Drawing.Size(31, 20);
            this.numTheta.TabIndex = 10;
            this.numTheta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "^";
            // 
            // numPow
            // 
            this.numPow.Location = new System.Drawing.Point(233, 10);
            this.numPow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPow.Name = "numPow";
            this.numPow.Size = new System.Drawing.Size(31, 20);
            this.numPow.TabIndex = 12;
            this.numPow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxHideLine
            // 
            this.checkBoxHideLine.AutoSize = true;
            this.checkBoxHideLine.BackColor = System.Drawing.Color.Black;
            this.checkBoxHideLine.ForeColor = System.Drawing.Color.White;
            this.checkBoxHideLine.Location = new System.Drawing.Point(567, 37);
            this.checkBoxHideLine.Name = "checkBoxHideLine";
            this.checkBoxHideLine.Size = new System.Drawing.Size(71, 17);
            this.checkBoxHideLine.TabIndex = 14;
            this.checkBoxHideLine.Text = "Hide Line";
            this.checkBoxHideLine.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.checkBoxHideLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTheta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initAngle);
            this.Controls.Add(this.checkBoxTan);
            this.Controls.Add(this.checkBoxCos);
            this.Controls.Add(this.checkBoxSin);
            this.Controls.Add(this.scalaY);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sin Cos Tan";
            ((System.ComponentModel.ISupportInitialize)(this.scalaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown scalaY;
        private System.Windows.Forms.CheckBox checkBoxSin;
        private System.Windows.Forms.CheckBox checkBoxCos;
        private System.Windows.Forms.CheckBox checkBoxTan;
        private System.Windows.Forms.NumericUpDown initAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lineAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTheta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPow;
        private System.Windows.Forms.CheckBox checkBoxHideLine;
    }
}

