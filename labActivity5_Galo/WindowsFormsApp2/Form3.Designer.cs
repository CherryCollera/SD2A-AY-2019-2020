namespace WindowsFormsApp2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnInteger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter second number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter first number: ";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(338, 177);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(117, 20);
            this.txtSecond.TabIndex = 13;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(120, 177);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(117, 20);
            this.txtFirst.TabIndex = 12;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(199, 225);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(175, 30);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute Sum";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.White;
            this.btnDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.ForeColor = System.Drawing.Color.Black;
            this.btnDouble.Location = new System.Drawing.Point(371, 69);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(129, 30);
            this.btnDouble.TabIndex = 10;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.White;
            this.btnFloat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloat.ForeColor = System.Drawing.Color.Black;
            this.btnFloat.Location = new System.Drawing.Point(216, 69);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(129, 30);
            this.btnFloat.TabIndex = 9;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = false;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnInteger
            // 
            this.btnInteger.BackColor = System.Drawing.Color.White;
            this.btnInteger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteger.ForeColor = System.Drawing.Color.Black;
            this.btnInteger.Location = new System.Drawing.Point(61, 69);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(129, 30);
            this.btnInteger.TabIndex = 8;
            this.btnInteger.Text = "Integer";
            this.btnInteger.UseVisualStyleBackColor = false;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnInteger);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button button1;
    }
}