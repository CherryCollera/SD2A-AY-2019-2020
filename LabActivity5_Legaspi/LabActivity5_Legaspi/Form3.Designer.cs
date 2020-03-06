namespace LabActivity5_Legaspi
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
            this.BtnDouble = new System.Windows.Forms.Button();
            this.BtnFloat = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtBox_Num1 = new System.Windows.Forms.TextBox();
            this.BtnSum = new System.Windows.Forms.Button();
            this.txtBox_Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteger
            // 
            this.BtnInteger.Location = new System.Drawing.Point(12, 45);
            this.BtnInteger.Name = "BtnInteger";
            this.BtnInteger.Size = new System.Drawing.Size(221, 37);
            this.BtnInteger.TabIndex = 0;
            this.BtnInteger.Text = "Integer";
            this.BtnInteger.UseVisualStyleBackColor = true;
            this.BtnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(483, 45);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(221, 37);
            this.BtnDouble.TabIndex = 1;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // BtnFloat
            // 
            this.BtnFloat.Location = new System.Drawing.Point(248, 45);
            this.BtnFloat.Name = "BtnFloat";
            this.BtnFloat.Size = new System.Drawing.Size(221, 37);
            this.BtnFloat.TabIndex = 2;
            this.BtnFloat.Text = "Float";
            this.BtnFloat.UseVisualStyleBackColor = true;
            this.BtnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNum1.Location = new System.Drawing.Point(85, 141);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(140, 20);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Enter first number:";
            // 
            // txtBox_Num1
            // 
            this.txtBox_Num1.Location = new System.Drawing.Point(231, 142);
            this.txtBox_Num1.Name = "txtBox_Num1";
            this.txtBox_Num1.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Num1.TabIndex = 4;
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(128, 186);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(221, 37);
            this.BtnSum.TabIndex = 7;
            this.BtnSum.Text = "Compute Sum";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // txtBox_Num2
            // 
            this.txtBox_Num2.Location = new System.Drawing.Point(540, 141);
            this.txtBox_Num2.Name = "txtBox_Num2";
            this.txtBox_Num2.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Num2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(368, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter second number:";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(355, 186);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(221, 37);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 235);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.txtBox_Num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.txtBox_Num1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.BtnFloat);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnInteger);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInteger;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Button BtnFloat;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtBox_Num1;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.TextBox txtBox_Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
    }
}