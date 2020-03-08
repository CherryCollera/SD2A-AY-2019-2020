namespace LabActivity5_Form
{
    partial class Form3
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
            this.BtnInteger = new System.Windows.Forms.Button();
            this.BtnFloat = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnComputeSum = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteger
            // 
            this.BtnInteger.Location = new System.Drawing.Point(54, 70);
            this.BtnInteger.Name = "BtnInteger";
            this.BtnInteger.Size = new System.Drawing.Size(167, 24);
            this.BtnInteger.TabIndex = 0;
            this.BtnInteger.Text = "Integer";
            this.BtnInteger.UseVisualStyleBackColor = true;
            this.BtnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // BtnFloat
            // 
            this.BtnFloat.Location = new System.Drawing.Point(246, 70);
            this.BtnFloat.Name = "BtnFloat";
            this.BtnFloat.Size = new System.Drawing.Size(167, 24);
            this.BtnFloat.TabIndex = 1;
            this.BtnFloat.Text = "Float";
            this.BtnFloat.UseVisualStyleBackColor = true;
            this.BtnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(439, 70);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(167, 24);
            this.BtnDouble.TabIndex = 2;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.Location = new System.Drawing.Point(168, 168);
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(133, 20);
            this.TxtDisplay1.TabIndex = 3;
            this.TxtDisplay1.TextChanged += new System.EventHandler(this.TxtDisplay1_TextChanged);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.Location = new System.Drawing.Point(438, 168);
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(133, 20);
            this.TxtDisplay2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter first number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter second number:";
            // 
            // BtnComputeSum
            // 
            this.BtnComputeSum.Location = new System.Drawing.Point(235, 236);
            this.BtnComputeSum.Name = "BtnComputeSum";
            this.BtnComputeSum.Size = new System.Drawing.Size(167, 24);
            this.BtnComputeSum.TabIndex = 7;
            this.BtnComputeSum.Text = "Compute Sum";
            this.BtnComputeSum.UseVisualStyleBackColor = true;
            this.BtnComputeSum.Click += new System.EventHandler(this.BtnComputeSum_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(552, 236);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(54, 24);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(667, 301);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnComputeSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnFloat);
            this.Controls.Add(this.BtnInteger);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInteger;
        private System.Windows.Forms.Button BtnFloat;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnComputeSum;
        private System.Windows.Forms.Button BtnExit;
    }
}