namespace LabActivity5_Legaspi
{
    partial class Calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnForm1 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnPeriod = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(274, 26);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnZero
            // 
            this.BtnZero.Location = new System.Drawing.Point(11, 248);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(64, 57);
            this.BtnZero.TabIndex = 1;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnForm1
            // 
            this.BtnForm1.Location = new System.Drawing.Point(11, 311);
            this.BtnForm1.Name = "BtnForm1";
            this.BtnForm1.Size = new System.Drawing.Size(204, 57);
            this.BtnForm1.TabIndex = 2;
            this.BtnForm1.Text = "Back to Form 1";
            this.BtnForm1.UseVisualStyleBackColor = true;
            this.BtnForm1.Click += new System.EventHandler(this.BtnForm1_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Location = new System.Drawing.Point(221, 311);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(64, 120);
            this.BtnEquals.TabIndex = 3;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnPeriod
            // 
            this.BtnPeriod.Location = new System.Drawing.Point(81, 248);
            this.BtnPeriod.Name = "BtnPeriod";
            this.BtnPeriod.Size = new System.Drawing.Size(64, 57);
            this.BtnPeriod.TabIndex = 4;
            this.BtnPeriod.Text = ".";
            this.BtnPeriod.UseVisualStyleBackColor = true;
            this.BtnPeriod.Click += new System.EventHandler(this.BtnPeriod_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(151, 248);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(64, 57);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(221, 248);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(64, 57);
            this.BtnDivide.TabIndex = 6;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Location = new System.Drawing.Point(11, 185);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(64, 57);
            this.BtnSeven.TabIndex = 7;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Location = new System.Drawing.Point(81, 185);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(64, 57);
            this.BtnEight.TabIndex = 8;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Location = new System.Drawing.Point(151, 185);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(64, 57);
            this.BtnNine.TabIndex = 9;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(221, 185);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(64, 57);
            this.BtnMultiply.TabIndex = 10;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Location = new System.Drawing.Point(11, 122);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(64, 57);
            this.BtnFour.TabIndex = 11;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Location = new System.Drawing.Point(81, 122);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(64, 57);
            this.BtnFive.TabIndex = 12;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Location = new System.Drawing.Point(151, 122);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(64, 57);
            this.BtnSix.TabIndex = 13;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Location = new System.Drawing.Point(220, 122);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(64, 57);
            this.BtnSubtract.TabIndex = 14;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnOne.FlatAppearance.BorderSize = 10;
            this.BtnOne.Location = new System.Drawing.Point(11, 59);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(64, 57);
            this.BtnOne.TabIndex = 15;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(81, 59);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(64, 57);
            this.BtnTwo.TabIndex = 16;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Location = new System.Drawing.Point(151, 59);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(64, 57);
            this.BtnThree.TabIndex = 17;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(221, 59);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(64, 57);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnForm3
            // 
            this.BtnForm3.Location = new System.Drawing.Point(11, 374);
            this.BtnForm3.Name = "BtnForm3";
            this.BtnForm3.Size = new System.Drawing.Size(204, 57);
            this.BtnForm3.TabIndex = 19;
            this.BtnForm3.Text = "Go to Form 3";
            this.BtnForm3.UseVisualStyleBackColor = true;
            this.BtnForm3.Click += new System.EventHandler(this.BtnForm3_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(297, 435);
            this.Controls.Add(this.BtnForm3);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnPeriod);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnForm1);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnForm1;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnPeriod;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnForm3;
    }
}

